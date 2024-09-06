using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Laba_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Типы ---

            // 1

            // Ввод bool
            Console.Write("Введите значение (true/false) для bool: ");
            bool a = bool.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели bool: " + a);

            // Ввод byte
            Console.Write("Введите значение (0-255) для byte: ");
            byte b = byte.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели byte: " + b);

            // Ввод sbyte
            Console.Write("Введите значение (-128 до 127) для sbyte: ");
            sbyte c = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели sbyte: " + c);

            // Ввод char
            Console.Write("Введите символ для char: ");
            char d = char.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели char: " + d);

            // Ввод decimal
            Console.Write("Введите десятичное число для decimal: ");
            decimal e = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели decimal: " + e);

            // Ввод double
            Console.Write("Введите значение с плавающей точкой для double: ");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели double: " + f);

            // Ввод float
            Console.Write("Введите значение с плавающей точкой для float: ");
            float g = float.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели float: " + g);

            // Ввод int
            Console.Write("Введите целое число для int: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели int: " + h);

            // Ввод uint
            Console.Write("Введите положительное целое число для uint: ");
            uint i = uint.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели uint: " + i);

            // Ввод nint
            //Console.Write("Введите значение для nint: ");
            //nint j = nint.Parse(Console.ReadLine());
            //Console.WriteLine("Вы ввели nint: " + j);

            // Ввод nuint
            //Console.Write("Введите значение для nuint: ");
            //nuint k = nuint.Parse(Console.ReadLine());
            //Console.WriteLine("Вы ввели nuint: " + k);

            // Ввод long
            Console.Write("Введите целое число для long: ");
            long l = long.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели long: " + l);

            // Ввод ulong
            Console.Write("Введите положительное целое число для ulong: ");
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели ulong: " + n);

            // Ввод short
            Console.Write("Введите целое число для short: ");
            short s = short.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели short: " + s);

            // Ввод ushort
            Console.Write("Введите положительное целое число для ushort: ");
            ushort u = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели ushort: " + u);

            // 2

            // неявное преобразование

            int number = 100;
            char letter = 'A';
            int letterInt = letter;
            float letterFloat = letter;
            long numberLong = number;
            float numberFloat = number;
            double numberDouble = number;

            // явноe преобразование

            float dottedFloat = 123.123f;
            int dottedInt = (int)dottedFloat;
            long dottedLong = (long)dottedFloat;
            short dottedShort = (short)dottedFloat;
            byte dottedByte = (byte)dottedFloat;
            sbyte dottedSbyte = (sbyte)dottedFloat;

            string intString = "123";
            string doubleString = "123,45";
            string decimalString = "123,456";

            int intValue = Convert.ToInt32(intString);
            double doubleValue = Convert.ToDouble(doubleString);
            decimal decimalValue = Convert.ToDecimal(decimalString);

            // 3

            int someNum = 120;
            object objSomeNum = someNum;
            int unpNumInt = (int)objSomeNum;

            float someNumFloat = 23.23f;
            object objsomeNumFloat = someNumFloat;
            float unpNumFloat = (float)objsomeNumFloat;



            // 4
            var varNumber = 100;
            var varString = "hello";
            var varBool = true;
            var varDouble = 1.1;

            Console.WriteLine(varNumber);
            Console.WriteLine(varString);
            Console.WriteLine(varBool);
            Console.WriteLine(varDouble);

            for (var z = 0; z < 10; z++)
            {
                Console.WriteLine(z);
            }

            // 5

            int? nullInt = null;
            double? nullDouble = null;
            bool? nullBool = null;

            Console.WriteLine(nullInt);
            Console.WriteLine(nullDouble);
            Console.WriteLine(nullBool);

            nullInt = 32;
            nullDouble = 12.2;
            nullBool = false;

            Console.WriteLine(nullInt);
            Console.WriteLine(nullDouble);
            Console.WriteLine(nullBool);

            // 6

            //var qwe = 120;
            //qwe = "hello";

            // --- Строки ---

            // 1

            string text = "Hello, world !"; // Обычные строки
            string text1 = @"/\/\/\/C:/\";  // Вербатим строки
            string text2 = @"
                            sdfsdf
                            gsgds /\/\
                            ";

            string str = "Hello";
            string str1 = "Hello";

            Console.WriteLine(str == str1);

            // 2 

            string somestr4 = "Hello, Hello, Hello, Hello, Hello, Hello, Hello";
            string somestr = "Hello";
            string somestr1 = "World";
            string somestr2 = "!";

            string concaten = somestr + somestr1 + somestr2;
            Console.WriteLine(concaten);

            string copy = string.Copy(somestr1);
            Console.WriteLine(copy);

            string substr = concaten.Substring(4, 3);
            Console.WriteLine(substr);

            string[] words = somestr4.Split(' ');
            Console.WriteLine(words[1]);

            string wordInsert = somestr.Insert(2, "game");
            Console.WriteLine(wordInsert);

            string remSome = somestr.Remove(1, 2);
            Console.WriteLine(remSome);

            int strNumber = 100;
            Console.WriteLine($" Text : {somestr}, Text : {strNumber}");

            // 3

            string strEmpty = string.Empty;
            string strEmpty1 = string.Empty;
            string nullString = null;

            Console.WriteLine(string.IsNullOrEmpty(strEmpty));
            Console.WriteLine(string.IsNullOrEmpty(nullString));

            Console.WriteLine(strEmpty.Insert(0, "hello"));
            Console.WriteLine(strEmpty1 + "hello");
            Console.WriteLine(strEmpty1.Contains("hello"));

            // 4
            StringBuilder stringBuilder = new StringBuilder("Hello, world !");

            Console.WriteLine(stringBuilder);

            stringBuilder.Remove(1, 2);
            stringBuilder.Insert(0, "Start - ");
            stringBuilder.Append(" - End");

            Console.WriteLine(stringBuilder);

            // --- Массивы ---

            // 1

            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int x1 = 0; x1 < 3; x1++)
            {
                for (int y1 = 0; y1 < 3; y1++)
                {
                    Console.Write(matrix[x1, y1] + " ");
                };
                Console.WriteLine();
            };

            // 2

            string[] textWords = { "hello", "world", "my", "dear", "friends" };

            for (int x1 = 0; x1 < textWords.Length; x1++)
            {
                Console.Write(textWords[x1]);
            }

            int textWordslength = textWords.Length;
            Console.WriteLine(textWordslength);

            Console.Write("Input position word: ");
            int positionWord = int.Parse(Console.ReadLine());

            Console.Write("Input new word: ");
            string userTextInput = Console.ReadLine();

            textWords[positionWord - 1] = userTextInput;

            // 3

            double[][] array = {
                new double[] { 12.2, 12.5 },
                new double[] { 11.2, 44.2, 42.1 },
                new double[] { 90.122, 403.21331, 342.3454, 4355.5354 }
            };

            for (int x1 = 0; x1 < array.Length; x1++)
            {
                for (int y1 = 0; y1 < array[x1].Length; y1++)
                {
                    Console.Write("Введите число в массив: ");
                    array[x1][y1] = double.Parse(Console.ReadLine());
                }
            }

            // 4

            var somethingNumbers = new[] { 1234, 2134, 345, 324, 90 };

            var somethingString = "Hello, world !";

            var somethingWords = new[] { "hello", "world", "lomal", "steklo" };

            // --- Кортежи ---

            // 1

            var textAndNumber = (123, "asdsad", "A", "qweqwe", 123456789UL);

            // 2

            var wordsAndNumbers = (111, 222, 333, 444, 555, "aaa", "bbb", "ccc", "ddd", "eee", 23.123, 43.24, 543.23);

            Console.WriteLine(wordsAndNumbers.Item1);
            Console.WriteLine(wordsAndNumbers.Item6);
            Console.WriteLine(wordsAndNumbers.Item11);

            // 3 

            var textAndNumber1 = (123, "asdsad", 'A', "qweqwe", 123456789UL);
            (int tnumber, string tstring1, char tchar, string tstring2, ulong tulong) = textAndNumber1;

            Console.WriteLine(tnumber);
            Console.WriteLine(tstring1);


            var textAndNumber2 = (12123, "asdsqwead", 'A', "qqweweqwe", 36789UL);
            (int tnnumber, _, _, _, ulong tullong) = textAndNumber2;

            Console.WriteLine(tnnumber);
            Console.WriteLine(tullong);

            var textAndNumber3 = (1211223, "asdsqwerwead", 'A', "qqweweqwewer", 3678339UL);
            var (ttnnumber, _, symbolA, _, ttullong) = textAndNumber3;

            Console.WriteLine(ttnnumber);
            Console.WriteLine(symbolA);

            // 4

            var ARRAY1 = ("42mm", 12321, "sdfdsf");
            var ARRAY2 = ("42mm", 12321, "sdfdsf");
            var ARRAY3 = ("42mm", 121, "sdfdasdsf");

            Console.WriteLine(ARRAY1 == ARRAY2);
            Console.WriteLine(ARRAY2 == ARRAY3);


            // --- Функции ---

            int[] numbersArray = { 1, 2, 3, 4, 5 };
            string textsString = "Hello, world!";

            (int min, int max, int sumNumbers, char firstLetterString) getInformation(int[] ar, string str)
            {
                int bufferMin = int.MaxValue;
                int bufferMax = int.MinValue;
                int sumNumbersArray = 0;

                foreach (int xy in ar)
                {
                    if (bufferMin > xy) { bufferMin = xy; }
                    if (bufferMax < xy) { bufferMax = xy; }
                    sumNumbersArray += xy;
                }

                char oneLetter = str[0];

                return (bufferMin, bufferMax, sumNumbersArray, oneLetter);
            }

            var someKart = getInformation(numbersArray, textsString);

            Console.WriteLine($"{someKart.min}, {someKart.max}, {someKart.sumNumbers}, {someKart.firstLetterString}");

            // --- checked and unchecked

            void getCheck()
            {
                try
                {
                    checked
                    {
                        int maxValueNumber = int.MaxValue;
                        Console.WriteLine(++maxValueNumber);
                    }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Ошибка вызвана переполнением");
                }
            }

            void getUnchecked() {
                unchecked
                {
                    int maxValueNumber = int.MaxValue;
                    Console.WriteLine(++maxValueNumber);
                }
            }
            getCheck();
            getUnchecked();
        }
    }
}
