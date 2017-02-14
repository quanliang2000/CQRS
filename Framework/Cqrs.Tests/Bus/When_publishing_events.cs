using cdmdotnet.Logging;
using cdmdotnet.Logging.Configuration;
using cdmdotnet.StateManagement.Threaded;
using Cqrs.Bus;
using Cqrs.Authentication;
using Cqrs.Configuration;
using Cqrs.Tests.Substitutes;
using NUnit.Framework;

namespace Cqrs.Tests.Bus
{
	[TestFixture]
	public class When_publishing_events
	{
		private InProcessBus<ISingleSignOnToken> _bus;

		[SetUp]
		public void Setup()
		{
			_bus = new InProcessBus<ISingleSignOnToken>(new AuthenticationTokenHelper(new ThreadedContextItemCollectionFactory()), new NullCorrelationIdHelper(), new TestDependencyResolver(null), new ConsoleLogger(new LoggerSettingsConfigurationSection(), new NullCorrelationIdHelper()), new ConfigurationManager(), new BusHelper(new ConfigurationManager()));
		}

		[Test]
		public void Should_publish_to_all_handlers()
		{
			var handler = new TestAggregateDidSomethingHandler();
			_bus.RegisterHandler<TestAggregateDidSomething>(handler.Handle, handler.GetType());
			_bus.RegisterHandler<TestAggregateDidSomething>(handler.Handle, handler.GetType());
			_bus.Publish(new TestAggregateDidSomething());
			Assert.AreEqual(2, handler.TimesRun);
		}

		[Test]
		public void Should_work_with_no_handlers()
		{
			_bus.Publish(new TestAggregateDidSomething());
		}
	}
}