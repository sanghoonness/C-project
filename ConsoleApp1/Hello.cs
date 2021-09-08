using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Helloworld
{
	class Helloworld
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			/*if (args.Length == 0)
			{
				Console.WriteLine("사용법: Helloworld.exe<이름>");
				return;
			}*/		

			//WriteLine("Hello,{0}!", args[0]);
			Console.WriteLine("==================================");
			Console.WriteLine("구구단 시작");
			Console.WriteLine("yo what's up 이재영선임님!!!");
			//var i = 0;
			//var j = 0;
			//var k = 1;
			/**for (k = 1; k <= 9; k=k+3)
			{				
				for (i = 1; i <= 9; i++)
				{
					for (j = k; j <= k + 2; j++)
					{
						Console.Write(j + "*" + i + "={0} ", j * i);
					}
					Console.WriteLine("");
				}
			}
			Console.WriteLine("==================================");**/
			/**while (k <= 9)
			{
				for (i = 1; i <= 9; i++)
				{
					for (j = k; j <= k + 2; j++)
					{
						Console.Write(j + "*" + i + "={0} ", j * i);
					}
					Console.WriteLine("");
				}
				k = k + 3;
			}**/


			for (int i = 1; i <= 9; i++)
			{
				for (int j = 1; j <= 9; j++)
				{
					var front = i; 
					//Console.Write(j + "*" + i + "={0} ", j * i);
					Console.Write($"{front} x {j} = {front++ * j}\t{front} x {j} = {front++ * j}\t{front} x {j} = {front++ * j}");
					//Console.Write($"{i} x {j} = {i++ * j}\t{i} x {j} = {i++ * j}\t{i} x {j} = {i++ * j}");
					Console.Write("\r\n"); //개행
				}
				i += 2;
				Console.WriteLine(); //개행
			}		

		}
	}
}
