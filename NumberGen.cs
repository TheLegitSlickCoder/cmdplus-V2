using System;

namespace cmd_V2
{
    class NumberGen
    {
        Random rnd = new Random();

        public int getNum()
        {
            int num = rnd.Next(0, 100000);
            return num;
        }
    }
}