using System;
class WineGlass
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int asteriksCount = n - 2;
        for (int i = 0; i < n / 2; i++)
        {
            string firstSlash = new string('\\', 1);
            string secondSlash = new string('/', 1);
            string asteriks = new string('*', asteriksCount);
            string dot = new string('.', i);
            Console.WriteLine("{0}{1}{2}{3}{0}", dot, firstSlash, asteriks, secondSlash);
            asteriksCount = asteriksCount - 2;
        }

        if (n >= 12)
        {
            for (int i = 0; i < (n / 2) - 2; i++)
            {
                string dot = new string('.', (n - 2) / 2);
                string lines = new string('|', 2);
                Console.WriteLine(dot + lines + dot);
            }
            string floor = new string('-', n);
            Console.WriteLine(floor);
            Console.WriteLine(floor);

        }

        if (n < 12)
        {
            for (int i = 0; i < (n / 2) - 1; i++)
            {
                string dot = new string('.', (n - 2) / 2);
                string lines = new string('|', 2);
                Console.WriteLine(dot + lines + dot);
            }
            string floor = new string('-', n);
            Console.WriteLine(floor);
        }


    }
}

