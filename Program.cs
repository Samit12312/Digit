using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace project_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter a number then enter the size and x and y");

            int digit = 0;
            //int num = int.Parse(Console.ReadLine());
            //int size = int.Parse(Console.ReadLine());
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            int num = 213;
            int size = 15;
            int x = 10;
            int y = 10;
            num = SwitchSide(num);
            while (num > 0)
            {
                

                digit = num % 10;
                if (digit == 0) Digit0(size, x, y);
                if (digit == 1) Digit1(size, x, y);
                if (digit == 2) Digit2(size, x, y);
                if (digit == 3) Digit3(size, x, y);
                if (digit == 4) Digit4(size, x, y);
                if (digit == 5) Digit5(size, x, y);
                if (digit == 6) Digit6(size, x, y);
                if (digit == 7) Digit7(size, x, y);
                if (digit == 8) Digit8(size, x, y);
                if (digit == 9) Digit9(size, x, y);
                x = x + 20;
                
                num = num / 10;

                
            }



            Console.ReadLine();
        }

        static void HorizntalLine(int size, int x, int y)
        {
            for (int i = 0; i <= size - 1; i++)
            {
                Console.SetCursorPosition(x + i, y);
                Console.Write("█");
            }

        }
        static void HalfColumn(int size, int x, int y)
        {
            for (int i = 0; i <= size / 2; i++) {
                Console.SetCursorPosition(x, y + i);
                Console.Write("█");
            }
        }
        static void Digit2(int size, int x, int y) {
            HorizntalLine(size, x, y);
            HalfColumn(size, x + size - 1, y);
            HorizntalLine(size, x, y + size/2);
            HalfColumn(size, x, y + size/2 );
            HorizntalLine(size, x, y + size);
        }
        static void Digit3(int size, int x, int y) {
            HorizntalLine(size, x, y);
            HalfColumn(size, x + size - 1, y);
            HorizntalLine(size, x, y + size / 2);
            HalfColumn(size - 1, x + size - 1, y + size / 2);
            HorizntalLine(size, x, y + size - 1);
        }
        static void Digit5(int size, int x, int y)
        {
            HorizntalLine(size, x, y);
            HalfColumn(size, x, y);
            HorizntalLine(size, x, y + size / 2);
            HalfColumn(size, x + size - 1, y + size / 2);
            HorizntalLine(size, x, y + size - 1);
        }
        static void Digit1(int size, int x, int y)
        {
            HalfColumn(size + size,x + size/2,y);
        }
        static void Digit4(int size, int x,int y)
        {
            HalfColumn(size,x,y);
            HorizntalLine(size, x, y + size / 2);
            HalfColumn(size + size, x + size, y);           
        }
        static void Digit6(int size, int x, int y)
        {
            HorizntalLine(size, x, y);
            HalfColumn(size + size -1, x, y);
            HorizntalLine(size,x,y + size / 2);
            HalfColumn(size, x + size - 1, y + size /2);
            HorizntalLine(size, x, y + size);
        }
        static void Digit7(int size, int x, int y)
        {
            HorizntalLine(size, x, y);
            HalfColumn(size + size/2, x + size - 1, y);
        }
        static void Digit8(int size, int x, int y)
        {
            HorizntalLine(size, x, y);
            HalfColumn(size + size, x, y);
            HalfColumn(size + size, x + size - 1, y);
            HorizntalLine(size, x, y + size);
            HorizntalLine(size, x, y + size/2);
        }
        static void Digit9(int size, int x, int y) 
        {
            HorizntalLine(size, x, y);
            HalfColumn(size , x, y);            
            HorizntalLine(size, x, y + size /2);
            HalfColumn(size + size, x + size - 1, y);
            HorizntalLine(size, x, y + size);
        }
        static void Digit0(int size, int x, int y)
        {
            HorizntalLine(size , x, y);
            HalfColumn(size + size , x, y);
            HalfColumn(size + size, x + size - 1, y);
            HorizntalLine(size, x, y + size);
        }
        static int SwitchSide(int num)
        {
            int n = 0;
            while (num > 0) 
            {
                n = n * 10 + num % 10;
                num = num / 10;
            }
            return n;
        }

        
    

    }
}
