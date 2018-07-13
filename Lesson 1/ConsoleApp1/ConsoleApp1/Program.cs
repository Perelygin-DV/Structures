using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp1

{
/// <summary>
/// Выполнил Перелыгин Д.В. Язык C#
/// </summary>

	class Program
	{
		//1. Ввести вес и рост человека. Рассчитать и вывести индекс массы 
		//тела по формуле I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах.
		static void Task1()
		{
			Console.Write("введите массу в кг:  ");
			int m = Convert.ToInt32(  Console.ReadLine());
			Console.Write("введите рост в м:  ");
			double h = Convert.ToDouble(Console.ReadLine());
			double I = m / (h * h);
			Console.WriteLine($"Ваша Индекс Массы Тела: {I:0.00}");
		}
		//2.Найти максимальное из четырех чисел.Массивы не использовать.
		static int Task2(int a, int b, int c, int d)
		{
			if (a > b & a > c & a > d) return a;
			if (b > c & b > d) return b;
			if (c > d) return c;
			return d;
		}
		// 3. Написать программу обмена значениями двух целочисленных переменных:
		//b. * без использования третьей переменной.
		static void Task3 (int a, int b)
		{
			Console.WriteLine($"Было: a={a}, b={b}");
			a =a+ b;
			b = a - b;
			a = a - b;
			Console.WriteLine($"Стало: a={a}, b={b}");
		}

		//4. Написать программу нахождения корней заданного квадратного уравнения.

		static int Task4 (int a, int b, int c, out double x1, out double x2)
		{
			int D = b * b - 4 * a * c;
			if (a == 0) { x1 = -c / b; x2 = x1; return 0; }
			if (D > 0)
			{
				x1 = (-b + Math.Sqrt(D));
				x2 = (-b - Math.Sqrt(D));
				return 1;
			};
			if (D == 0)
			{
				x1 = -b / (2 * a);
				x2 = x1;
				return 0;
			}
			else { x1 = 0; x2 = 0; return -1; }

		}
		//5. С клавиатуры вводится номер месяца. Требуется определить, к какому времени года он относится.
		static string Task5()
		{
			int month =0;
			bool flag;
			do
			{
				Console.WriteLine("Введите номер месяца");
				flag = int.TryParse(Console.ReadLine(), out month);
			}
			while (!flag&&month<1&&month>12);

			if (month < 3|| month ==12) return "Зима";
			if (month > 2 && month < 6) return "Весна";
			if (month > 5 && month < 9) return "Лето";
			else return "Осень";
			
		}

		//6. Ввести возраст человека(от 1 до 150 лет) и вывести его вместе с последующим словом «год», «года» или «лет».

		static void Task6 ()
		{
			Console.Write("Введите возраст человека: ");
			
			int age = Convert.ToInt32(Console.ReadLine());
			int j = age;
			if(age>21) age %= 10;
			if (age == 1||age==21) Console.Write($"{j}-год");
			if (age > 1 && age < 5) Console.Write($"{j}-года");
			if (age >= 5 && age < 9|| age==0||age>9&& age <= 20) Console.WriteLine($"{j}-лет");
			
			
		}
		//7. С клавиатуры вводятся числовые координаты двух полей шахматной доски(x1, y1, x2, y2). 
		//Требуется определить, относятся ли к поля к одному цвету или нет.
		static string Task7(int x1, int x2, int y1, int y2)
		{
			if ((x1 + y1) % 2 == (x2 + y2) % 2) return "";
			return "не";
		}
		//8. Ввести a и b и вывести квадраты и кубы чисел от a до b.
		static void Task8(int min, int max)
		{
			for (int i = min; i < max + 1; i++)
			{
				Console.WriteLine($"Квадрат числа {i} равен: {Math.Pow(i,2)}, куб равен {Math.Pow(i,3)}");
			}
		}
		//9. Даны целые положительные числа N и K. Используя только операции сложения и вычитания,
		//найти частное от деления нацело N на K, а также остаток от этого деления.

		static void Task9 (int N, int K)
			{int ost=N, chast=0;
			
			while(ost > K){ ost -= K; chast++; };
			Console.WriteLine($"Частное от деления {N} на {K} = {chast}, остаток - {ost}");
			Console.WriteLine();
			
			}

	//10. Дано целое число N(> 0). С помощью операций деления нацело и взятия остатка от деления 
	//	определить, имеются ли в записи числа N нечетные цифры.Если имеются, то вывести True, если нет — вывести False.
	    static bool Celye_chisla(int a)
		{
			while (a != 0) { if ((a % 10) % 2 !=0) return true;a/=10; }
			return false;
			
		}

		//11.
		static int Sredneearifm()
		{
			int sum = 0;
			int j = 0;
			int s = 0;
			Console.WriteLine("вводите числа, 0 - окончание подсчета");
			do
			{
				j = Convert.ToInt32(Console.ReadLine());
				s = j;
				while (s > 10) { s %= 10; };
				if (s != 8) sum += j;
			}
			while (j != 0);
			return sum;
		}
		//12. Написать функцию нахождения максимального из трех чисел.
		static int Maxof3(int a, int b, int c)
		{
			if (a > c && a > c) return a;
			if (b > c) return b;
			else return c;
		
		}
		//14
		static void Automorph(int m)
		{

			int k = 0;
			int j = 0;
			
			for (int i = 11; i < m; i++)
			{
				k = i * i;				
				int count ;
				while (k > i)
				{
					j = k;
					count = 1;
					do
					{
						j /= 10;
						count *= 10;
					}
					while (j > 10);
					k = k - (k / count) * count;
					if (k == i) { Console.WriteLine($"анаморфное число {i}, его квадрат {i*i}") ; };

				}
				
			}
		}
		static Random rnd = new Random();
		static void Main(string[] args)
		{
			//1
			Console.WriteLine("Задача 1");
			Task1();
			Console.WriteLine();
			//2
			Console.WriteLine("Задача 2");
			Console.WriteLine("Самое большое число"+Task2(2, 3, 4, 5)	); 
			Console.WriteLine();
			//3
			Console.WriteLine("Задача 3: решение задачи со звездочкой");
			Task3(2, 3);
			Console.WriteLine();

			//4
			Console.WriteLine("Задача 4");
			Console.WriteLine("Введите a,b,c");
			int a4 = Convert.ToInt32(Console.ReadLine());
			int b4 = Convert.ToInt32(Console.ReadLine());
			int c4 = Convert.ToInt32(Console.ReadLine());
			double x41, x42;
			int result = Task4 (a4, b4, c4, out x41, out x42);
			switch (result)
			{
				case 1: Console.WriteLine($"Корни: x1= {x41:0.00}, x2= {x42:0.00}");  break;
				case 0: Console.WriteLine($"Корень: {x41:0.00}"); break;
				default:
					Console.WriteLine("Нет корней"); break ; 
			}
			Console.WriteLine();

			//5
			Console.WriteLine("Задача 5");
			Console.WriteLine("Время года:"+Task5()); 
			Console.WriteLine();

			//6
			Console.WriteLine("Задача 6");
			Task6();
			Console.WriteLine();

			//7

			Console.WriteLine("Задача 7");
			Console.WriteLine(	$" Поля {Task7(1, 7, 2, 8)}относятся к одному цвету");
			Console.WriteLine();

			//8
			Console.WriteLine("Задача 8");
			Task8(1, 20);
			Console.WriteLine();
			//9
			Console.WriteLine("Задача 9");
			Task9(16, 5);
			Console.WriteLine();
			//10
			Console.WriteLine("Задача 10");
			Console.WriteLine($"В числе 241818 имеются нечетные числа: {Celye_chisla(241818)}");

			//11.
			Console.WriteLine("Задача 11");
			Console.WriteLine($"Сумма равна {Sredneearifm()}");
			Console.WriteLine();

			//12.

			Console.WriteLine("Задача 12");
			Console.WriteLine(Maxof3(4, 7, 9));
			Console.WriteLine();

			//13
			Console.WriteLine("Задача 13");
			Console.WriteLine($"Случайное число с функцией Random: {rnd.Next(1,100)}");

			Console.WriteLine();

			//Task 14

			Console.WriteLine("Введите до какого числа показать автоморфные числа");
			int m = Convert.ToInt32(Console.ReadLine());
			Automorph(m);
			Console.ReadKey();
		}
	}
}
