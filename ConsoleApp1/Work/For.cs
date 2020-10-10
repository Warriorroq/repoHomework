using System;

namespace Work
{
    public class For
    {
        public void For4(int price)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.Write((i * price) + " ");
            }
        }
        public int For8(int b)
        {
            int result = 1;
            for (int a = 1; a <= b; a++)
            {
                result *= a;
            }
            return result;
        }
        public void For12(float b)
        {
            float result = 1f;
            for (float a = 1.1f; Math.Abs(a) <= b; a += 0.1f)
            {
                result *= a;
            }
            Console.WriteLine(Math.Round(result, 2));
        }
        public void For16(int n,int num)
        {
            for (int i = 1; i <= n; i++)
            {
                int result = (int)Math.Pow(num, i);
                Console.Write(result + " ");
            }
        }
        public int For20(int a)
        {
            int b = 1;
            int result = 0;
            for (int i = 1; i <= a; i++)
            {
                b *= i;
                result += b;
            }
            return result;
        }
        public void For24(int a)
        {
            int b = 1;
            float x = 2f;
            float result = 1f;
            int k = 1;
            for (int i = 1; i <= a; i++)
            {
                b *= k;
                k++;
                b *= k;
                result -= (float)Math.Pow(x, i * 2) * -1f / b;
            }
            Console.WriteLine(Math.Round(result, 3));
        }
        public void For28(int a)
        {
            float down = 1;
            float up = 1;
            float upNum = 1;
            float x = 0.6f;
            float result = 1f;
            for (int i = 1; i <= a; i++)
            {
                down *= i * 2;
                float currentX = (float)Math.Pow(x, i);
                result -= (up * currentX * -1f) / down;
                upNum += 2;
                up *= upNum;
            }
            Console.WriteLine(result);
        }
        public void For32(int a)
        {
            float Num = 1f;
            float k = 3f;
            for (int i = 0; i < a; i++)
            {
                Num = (Num + 1) / k;
                Console.Write(Num + " ");
            }
        }
        public void For36(int a)
        {
            int k = 6;
            int sum = 0;
            for (int i = 1; i < a; i++)
            {
                sum += (int)Math.Pow(i, k);
            }
            Console.WriteLine("\n" + sum);
        }
        public void For40(int a)
        {
            int b = a + 3;
            for (int num = 0; num <= b - a; num++)
                for (int i = 0; i <= num; i++)
                {
                    Console.Write(" " + (a + num));
                }
        }
    }
}
