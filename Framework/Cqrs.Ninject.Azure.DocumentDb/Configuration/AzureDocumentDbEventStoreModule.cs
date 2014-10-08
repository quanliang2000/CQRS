﻿#region Copyright
// // -----------------------------------------------------------------------
// // <copyright company="cdmdotnet Limited">
// // 	Copyright cdmdotnet Limited. All rights reserved.
// // </copyright>
// // -----------------------------------------------------------------------
#endregion

using Cqrs.Azure.DocumentDb.Events;
using Cqrs.Events;
using Ninject.Modules;

namespace Cqrs.Ninject.Azure.DocumentDb.Configuration
{
	/// <summary>
	/// The <see cref="INinjectModule"/> for use with the Cqrs package.
	/// </summary>
	public class AzureDocumentDbEventStoreModule<TAuthenticationToken> : NinjectModule
	{
		#region Overrides of NinjectModule

		/// <summary>
		/// Loads the module into the kernel.
		/// </summary>
		public override void Load()
		{
			RegisterFactories();
			RegisterServices();
			RegisterCqrsRequirements();
		}

		#endregion

		/// <summary>
		/// Register the all factories
		/// </summary>
		public virtual void RegisterFactories()
		{
			Bind<IEventBuilder<TAuthenticationToken>>()
				.To<AzureDocumentDbEventBuilder<TAuthenticationToken>>()
				.InSingletonScope();
			Bind<IEventDeserialiser<TAuthenticationToken>>()
				.To<AzureDocumentDbEventDeserialiser<TAuthenticationToken>>()
				.InSingletonScope();
		}

		/// <summary>
		/// Register the all services
		/// </summary>
		public virtual void RegisterServices()
		{
		}

		/// <summary>
		/// Register the all Cqrs command handlers
		/// </summary>
		public virtual void RegisterCqrsRequirements()
		{
			Bind<IAzureDocumentDbEventStoreConnectionHelper>()
				.To<AzureDocumentDbEventStoreConnectionHelper>()
				.InSingletonScope();

			Bind<IEventStore<TAuthenticationToken>>()
				.To<AzureDocumentDbEventStore<TAuthenticationToken>>()
				.InSingletonScope();
		}
	}
}