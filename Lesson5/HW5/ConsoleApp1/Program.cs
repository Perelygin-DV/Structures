﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			char[,] sym1 = { { '+', '^' }, { '-', '^' }, { '*', '^' }, { '/', '^' }, { '(', '^' },
					   { '*', '+' }, { '/', '+' }, { '(', '+' }, { '*', '-' }, { '/', '-' },
					   { '(', '-' }, { '(', '*' }, { '(', '/' }, { '+', '(' }, { '-', '(' },
					   { '*', '(' }, { '/', '(' }, { '(', '(' },
					   //2
					   { '^', '+' }, { '+', '+' }, { '-', '+' }, { ')', '+' }, { '^', '-' },
					   { '+', '-' }, { '-', '-' }, { ')', '-' }, { '^', '*' }, { '+', '*' },
					   { '-', '*' }, { '*', '*' }, { '/', '*' }, { ')', '*' }, { '^', '/' },
					   { '+', '/' }, { '-', '/' }, { '*', '/' }, { '/', '/' }, { ')', '/' }, 
					   //3
					   { ')', '(' },
					   //4
					   { '^', '^' }, 
					   //
					   { '^', '(' }
					  };int t = 0;
			for(int i = 0; i < 41; i++)
			{
				Console.WriteLine(sym1[i,0]+"   "+sym1[i,1]+"   "+t);
				t++;
				
			}
			Console.ReadKey();
		}
	}
}
