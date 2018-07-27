using System;

namespace GitBisectDemo
{
	public static class Fatorial
	{
		public static int CalculaFatorial(int i)
		{
			if (i == 1 || i == 2)
			{
				return i;
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
