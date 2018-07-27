using System;
using Xunit;
using Shouldly;
using Shouldly.ShouldlyExtensionMethods;

namespace GitBisectDemo.Tests
{
	public class FatorialTest
	{
		[Fact]
		public void Fat1()
		{
			Fatorial.CalculaFatorial(1).ShouldBe(1);
		}

		[Fact]
		public void Fat2()
		{
			Fatorial.CalculaFatorial(2).ShouldBe(2);
		}

	}
}