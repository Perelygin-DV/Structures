using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5

//Выполнил Перелыгин Д.В.

{ class Check
	{
		public int check(char a3, char b)
		{
			int t = 0;
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
					  };
			for (int i3 = 0; i3 < 41; i3++)
			{
				if (a3 == sym1[i3, 0] && b == sym1[i3, 1]) { t = i3+1; break; }
				
			}
			if (t < 19) return 1;
			if (t > 18 && t < 39) return 2;
			if (t == 39) return 3;
			if (t == 40) return 4;
			if (t == 41) return 5;
			else return 0;


		}
	}

	
	class Program
	{
		
		static void Main(string[] args)
		{

			//Задача 2
			Console.WriteLine("Задача 2, результат:");

			string a = "]]]()([,])(){}()([{ }])";
			char[] ac = a.ToCharArray();
			Stack<char> mm = new Stack<char>();
			int i = 0;
			int count1 = 0;
			for (i = 0; i < ac.Length - 1; i++)
			{

				if (ac[i] == '(' || ac[i] == '[' || ac[i] == '{')// 1.получили открытую скобку - добавили в стек
				{
					mm.Push(ac[i]);

				};
				if (ac[i] == ')' || ac[i] == ']' || ac[i] == '}')//2.условие-инкремент на внезапную закрытую лишнюю скобку (на открытую скобку не нужен т.к. будем считать кол-во элементов  в стеке) 
				{
					count1++;
				};
				if(mm.Count == 0) continue;//3.следующая операция, если стек пуст, приведет к ошибке, поэтому при пустом стеке идем на следующую итерацию
				i++;
				if //3.ловим открытые/закрытые скобки, декремент закртых скобок
					(ac[i] == ')' && mm.Peek() == '(' || ac[i] == ']' && mm.Peek() == '[' || ac[i] == '}' && mm.Peek() == '{')
				{ mm.Pop(); count1--; };
				i--;

			}
			if (ac[ac.Length - 1] == ')' || ac[i] == ']' || ac[i] == '}') count1++;//4.дополнительное условие для проверки последней ячейки массива на закрытую скобку (итерация отсутствовала)
			if (mm.Count() == 0 && count1 == 0) Console.WriteLine("Все нормально"); else Console.WriteLine("Что-то не так");


			//Задача 4.Инфиксная запись в постфиксную
			Console.WriteLine("Задача 4");
		   Check sym2 = new Check();

			
			string b = "(1+2)*3-4*(5-6)^";  //^ - символы первого и последнего вагона. Первый вагон добавил до итераций, последний - в самом выражении
			char[] bc = b.ToCharArray();//исходный массив
			char[] br = new char[bc.Length];//здесь результат
			int t = 0;
			int j1 = 0;
			Stack<char> z2 = new Stack<char>();
			int i1 = 0;
			z2.Push('^');
			int res = 0;
			for (i1 = 0; i1 < bc.Length; i1++)//алгоритм из методички
			{
				if (char.IsDigit(bc[i1])) { br[j1] = bc[i1]; j1++; continue; };// 1.вагон с цифрой всегда направляется в Калифорнию
				res = sym2.check(bc[i1], z2.Peek());
				if (res == 1) { z2.Push(bc[i1]); continue; };
				if (res == 2) { br[j1] = z2.Pop(); j1++; i1--; continue; };
				if (res == 3) { z2.Pop();  continue; };
				if (res == 4) { Console.WriteLine("Получили обратную польскую запись:"); break; }; //символ первого и последнего вагона
				if (res == 5) { Console.WriteLine("изначальная формула некорректно сбалансирована"); break; }; //символ первого и последнего вагона
			}
			foreach (char el in br) { Console.Write(el); };
			Console.WriteLine();
			Console.WriteLine("В стеке у нас:");
			foreach (char el in z2) { Console.Write(el); };
			




			Console.ReadKey();
		}
	}
}
