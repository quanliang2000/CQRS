﻿










//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Copyright
// -----------------------------------------------------------------------
// <copyright company="cdmdotnet Limited">
//     Copyright cdmdotnet Limited. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion
using Cqrs.Domain;
using Northwind.Domain.Orders;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Cqrs.Services;

namespace Northwind.Domain.Orders.Services.ServiceHost.Ninject.ServiceChannelFactories
{
	/// <summary>
	/// A <see cref="ServiceChannelFactory{TService}"/> for using  <see cref="IOrderService"/> via WCF
	/// </summary>
	[GeneratedCode("CQRS UML Code Generator", "1.601.881")]
	public partial class HttpOrderServiceChannelFactory : ServiceChannelFactory<IOrderService>
	{

		partial void RegisterServiceDataContracts()
		{

			OrderServiceGetAllOrdersResolver.RegisterDataContracts();

		}
	}
}
