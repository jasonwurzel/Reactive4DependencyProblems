using FluentAssertions;
using ReactiveUI;
using Xunit;

namespace UnitTestProject2
{
	public class UnitTest1
	{
		[Fact]
		public void TestMethod1()
		{
			true.Should().BeTrue();
			var reactiveList = new ReactiveList<string>();
			var mainThreadScheduler = RxApp.MainThreadScheduler;
		}
	}
}
