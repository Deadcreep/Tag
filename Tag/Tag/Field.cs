using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag
{
    class Field
    {
        int[,] coordinates;
        int value;

        public Field(int size)
        {
            coordinates[size, size] = 0;
            for (int x = 1; x < size; x++)
                for (int y = 1; y < size; y++)
                    coordinates[x, y] = x;
        }

        public int this[int x, int y]
        {
            get 
            {
                return coordinates[x,y];
            }
            set
            {
                coordinates[x, y] = value;
            }

    }

}
