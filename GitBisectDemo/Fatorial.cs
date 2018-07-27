using System;

namespace GitBisectDemo
{
	public static class Fatorial
	{
		public static int CalculaFatorial(int i)
		{
			if (i == 1)
			{
				return 1;
			}

			if (i == 2)
			{
				return 2;
			}

			return i;

		}
	}
}
