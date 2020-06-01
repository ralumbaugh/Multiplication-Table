using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Table = new int[10,10];
            for(int column=0; column<10; column++)
            {
                Table[column,0] = column+1;
                for(int row=1; row<10; row++)
                {
                    Table[column,row] = (row+1)*(column+1);
                }
            }

            for(int i=0; i<10; i++)
            {
                string line = "[";
                for(int j=0; j<10; j++)
                {
                    line = $"{line}{Table[i,j]},\t";
                }
                line = line + "]";
                Console.WriteLine(line);
            }
        }

    }
}
