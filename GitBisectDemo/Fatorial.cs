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

			int acumulado = 1;
			for (int count = 1; count <= i; ++count)
			{
				acumulado += count;
			}

			return acumulado;
		}
	}
}
