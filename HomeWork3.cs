using System;

namespace HomeWork3Lib
{
    public class HomeWork3
    {
        public static double GetAToPowerB(int a, int b)
        {
            int result = 1;
            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }

            return result;
        }
        public static int DividedbyA(int a)
        {
            int count = 0;
            const int maxNumber = 1000;
            for (int i = 1; i <= maxNumber; i++)
            {
                if (i % a == 0)
                {
                    count++;
                }
            }

            return count;
        }
        public static int GetSquareLessA(int a)
        {
            int count = 0;
            for (int i = 1; i <= a; i++)
            {
                if ((i * i < a))
                {
                    count++;
                }
            }

            return count;
        }

        public static int GetGreatestDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
        public static int GetSumAtoBdivide7(int a, int b)
        {
            int sum = 0;
            const int divider = 7;
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            for (; a <= b; a++)
            {
                if (a % divider == 0)
                {
                    sum += a;
                }
            }

            return sum;
        }

        public static int GetNumberFibonachi(int n)
        {
            int prev = 1;
            int next = 1;
            int sum = 0;
            for (int i = 2; i < n; i++)
            {
                sum = prev + next;
                prev = next;
                next = sum;
            }

            return sum;
        }

        public static int EuclidAlgoritm(int a, int b)
        {
                while ((a != 0) && (b != 0))
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }

                return Math.Max(a, b);
        }

        //public static double GetDihotomy(int cube)
        //{

        //}

        public static int GetOddCount(int a)
        {
            int check, count = 0;
            const int divider = 10;
            while (true)
            {
                check = a % divider;
                a /= divider;
                if (check % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int GetNumberMirror(int a)
        {
            int b = 0;
            const int divider = 10;
            while (a != 0)
            {
                int c = a % divider;
                b = b * divider + c;
                a /= divider;
            }

            return b;
        }

        public static bool OddLessEven(int n)
        {
            double even = 0, odd = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            if (even > odd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool GetSameNumbers(int a, int b)
        {
            int count = 0;
            const int divider = 10;
            while (a != 0)
            {
                int tempA = a % divider;
                while (b != 0)
                {
                    int tempB = b % divider;
                    if (tempA == tempB)
                    {
                        count++;
                    }

                    b = b / divider;
                }

                a = a / divider;
            }

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
