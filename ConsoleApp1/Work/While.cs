using System;
using System.Collections.Generic;
using System.Text;

namespace Work
{
    public class While
    {
        public bool While4(float N)
        {
            while (N>1)
            {
                N /= 3;
            }
            return N == 1 ? true : false;
        }
        public int While8(int N)
        {
            int k = 1;
            while (Math.Pow(k + 1, 2) <= N)
            {
                k++;
            }
            return k;
        }
        public int While12(int N)
        {
            int sum = 0;
            int k = 0;
            while (sum <= N)
            {
                sum += k;
                if (sum + k + 1 <= N)
                    k++;
                else
                    sum += (k + 1);
            }
            return k;
        }
        public float While16(float distance)
        {
            float sum = 0;
            float procent = 1.1f;
            while(sum <= 200f)
            {
                sum += distance;
                distance *= procent;
            }
            return (float)Math.Round(sum,2);
        }
        public bool While20(int N)
        {
            int num = 0;
            while (num != 2 && N > 2)
            {
                num = N % 10;
                N = N / 10;
            }
            return num == 2 ? true : false;
        }
        public bool While24(int num)
        {
            int f1 = 1;
            int f2 = 1;
            int f3 = 0;
            while (num != f3 && f2 + f1 > 0)
            {
                f3 = f2 + f1;
                f1 = f2;
                f2 = f3;
            }
            return num == f3 ? true : false;
        }
        public int While28(int N)
        {
            int f1 = 0;
            int f2 = 1;
            int f3 = 0;
            int num = 1;
            while (N != f3 && f2 + f1 > 0)
            {
                f3 = f2 + f1;
                f1 = f2;
                f2 = f3;
                num++;
            }
            return num;
        }
    }
}
