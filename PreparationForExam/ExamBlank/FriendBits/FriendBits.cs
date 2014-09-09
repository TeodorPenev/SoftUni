using System;

namespace FriendBits
{
    class FriendBits
    {
        static void Main()
        {
            uint num = uint.Parse(Console.ReadLine());
            uint friendsBits =0U;
            uint aloneBits = 0U;
            uint one = 1U;

            for (int i = 31; i >=0; i--)
            {
                uint mask0 = one << i + 1;
                uint mask1 = one << i;
                uint mask2 = one << i - 1;
                uint mask3 = one << i - 2;
                if (((num & mask1)>>i)==((num & mask2)>>i-1))
                {
                    friendsBits = friendsBits << 1;
                    friendsBits = friendsBits | ((num & mask1) >> i);
                }
                else
                {
                    if (((num & mask1)>>i)==((num & mask0)>>i+1))
                    {
                        friendsBits = friendsBits << 1;
                        friendsBits = friendsBits | ((num & mask1) >> i);
                        
                    }
                    if (i==1)
                    {
                    aloneBits = aloneBits << 1;
                    aloneBits = aloneBits | ((num & mask2) >> i - 1);
                    break;
                    }

                    if (((num & mask2) >> i-1) == ((num & mask3) >> i - 2))
                    {
                        continue;
                    }
                    aloneBits = aloneBits << 1;
                    aloneBits = aloneBits | ((num & mask2) >> i - 1);
                    
                }
            }
            Console.WriteLine(friendsBits);
            Console.WriteLine(aloneBits);
        }
    }
}
