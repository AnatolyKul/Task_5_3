using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Отсортировать элементы массива по возрастанию*/
			int n, i, s, t;
			Console.WriteLine("Введите кол-во элементов массива");
			n = Convert.ToInt32(Console.ReadLine());
			Random rand = new Random();
			int[] arr = new int[n];
			Console.WriteLine(" ");
			for (i = 0; i < n; i++)
			{
				arr[i] = rand.Next(-5, 5);
				Console.WriteLine(arr[i]);
			}
			s = 1;
			while (s == 1)
			{
				s = 0;
				for (i = 1; i < n; i++)
					if (arr[i] < arr[i - 1])
					{
						t = arr[i];
						arr[i] = arr[i - 1];
						arr[i - 1] = t;
						s = 1;
					}
			}
			Console.WriteLine(" ");
			for (i = 0; i < n; i++)
				Console.WriteLine(arr[i]);
			Console.ReadKey();
		}
	}
}
