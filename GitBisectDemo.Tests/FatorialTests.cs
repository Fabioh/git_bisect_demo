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

		[Fact]
		public void Fat3()
		{
			var v = Fatorial.CalculaFatorial(3);
			v.ShouldBe(3 * 2);
		}

		[Fact]
		public void Fat4()
		{
			var v = Fatorial.CalculaFatorial(4);
			v.ShouldBe(4 * 3 * 2);
		}

		[Fact]
		public void Fat5()
		{
			var v = Fatorial.CalculaFatorial(5);
			v.ShouldBe(5 * 4 * 3 * 2);
		}

		[Fact]
		public void Fat8()
		{
			var v = Fatorial.CalculaFatorial(8);
			v.ShouldBe(1 * 2 * 3 * 4 * 5 * 6 * 7 * 8);
		}

		[Fact]
		public void Fat10()
		{
			var v = Fatorial.CalculaFatorial(10);
			v.ShouldBe(1 * 2 * 3 * 4 * 5 * 6 * 7 * 8 * 9 * 10);
		}

		[Fact]
		public void Fat13()
		{
			var v = Fatorial.CalculaFatorial(12);
			v.ShouldBe(1 * 2 * 3 * 4 * 5 * 6 * 7 * 8 * 9 * 10 * 11 * 12);
		}
	}
}
