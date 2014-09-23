using System;
class ChangeEvenBits
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        bool startCount = false;
        int[] countArr = new int[N];
        int startCountLen = 0;
        int count = 0;
        int countL = 0;
        int arrayCount = 0;
       
        for (int i = 0; i < N; i++)
        {
            int inputInteger = int.Parse(Console.ReadLine());
            for (int c = 31; c >= 0; c--)
            {
                int mask = 1 << c;
                if (((inputInteger & mask) >> c) > 0)
                {
                    startCount = true;
                }
                if (startCount == true)
                {
                    count++;
                }
            }
            countArr[arrayCount] = count;
            arrayCount++;
            count = 0;
            startCount = false;
        }
        int L = int.Parse(Console.ReadLine());

        for (int c = 31; c >= 0; c--)
        {
            int mask = 1 << c;
            if (((L & mask) >> c) > 0)
            {
                startCountLen++;
            }
        }
        for (int i = 0; i < countArr.Length; i++)
        {
            for (int e = 0, n = 0; e < countArr[i]; e++, n = n + 2)
            {
                int mask = 1 << n;
                L = L | 1 << n;
            }
        }
        for (int c = 31; c >= 0; c--)
        {
            int mask = 1 << c;
            if (((L & mask) >> c) > 0)
            {
                countL++;
            }
           
        }
        Console.WriteLine(L);
        Console.WriteLine(countL-startCountLen);
    }
}

