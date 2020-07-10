using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
	public static class Messages
	{
		public static string ProductAdded = "The product has been added successfully";
		public static string ProductDeleted = "The product has been deleted successfully";
		public static string ProductUpdated = "The product has been updated successfully";

		public static string CategoryAdded = "The category has been added successfully";
		public static string CategoryDeleted = "The category has been deleted successfully";
		public static string CategoryUpdated = "The category has been updated successfully";

		public static string UserNotFound = "User not found";
		public static string PasswordError = "Incorrect password";
		public static string SuccessfulLogin = "Login successful";
		public static string UserAlreadyExists = "User already exist";
		public static string UserRegistrationSuccessful = "User registration succeeded";
		public static string AccessTokenCreated = "Access token has been created successfully";

		public static string AuthorizationDenied = "Do not have authorization claim";

	}
}
