﻿using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using System;
using System.Transactions;

namespace Core.Utilities.Aspects.AutoFac.Transaction
{
	public class TransactionScopeAspect : MethodInterception
	{
		public override void Intercept(IInvocation invocation)
		{
			using (TransactionScope transactionScope = new TransactionScope())
			{
				try
				{
					invocation.Proceed();
					transactionScope.Complete();
				}
				catch (Exception)
				{
					transactionScope.Dispose();
					throw;
				}
			}
		}
	}
}
