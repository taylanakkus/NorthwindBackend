using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : Controller
	{
		private IAuthService _authservice;

		public AuthController(IAuthService authService)
		{
			_authservice = authService;
		}
		[HttpPost("login")]
		public ActionResult Login(UserForLoginDto userForLoginDto)
		{
			var userToLogin = _authservice.Login(userForLoginDto);
			if (!userToLogin.Success)
			{
				return BadRequest(userToLogin);
			}
			var result = _authservice.CreateAccessToken(userToLogin.Data);
			if (!result.Success)
			{
				return BadRequest(result.Message);
			}

			return Ok(result.Data);

		}
		[HttpPost("register")]
		public ActionResult Register(UserForRegisterDto userForRegisterDto)
		{
			var userExists = _authservice.UserExists(userForRegisterDto.Email);
			if (!userExists.Success)
			{
				return BadRequest(userExists.Message);
			}

			var registerResult = _authservice.Register(userForRegisterDto);
			var result = _authservice.CreateAccessToken(registerResult.Data);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result.Message);
		}
	}
}
