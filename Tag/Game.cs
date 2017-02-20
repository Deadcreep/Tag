using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag
{
    
    struct Coordinate
    {
        public int x; //get set
        public int y;

        public Coordinate(int a, int b)
        {
            x = a;
            y = b;
        }
    }

    class Game
    {
        int[,] coordinates;        
        int size;

        public Game(int size)
        {
            this.size = size;
            FillField(size);
        }

        private void FillField(int size)
        {
            
            coordinates = new int[size, size];
            int val = 1;  
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                {
                    coordinates[x, y] = val == 16 ? 0 : val;
                    val++;
                }
        }
               

        public int this[int x, int y]
        {
            get
            {
                if(x >= size || y >= size)
                {
                    throw new IndexOutOfRangeException();
                }
                return coordinates[x, y];
            }
            set
            {
                coordinates[x, y] = value;
            }
        }

        public Coordinate  GetLocation(int value)
        {
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    if(value == coordinates[x, y]) 
                    {
                        return  new Coordinate(x, y);                        
                    }
            throw new ArgumentException ("Value does not exist");
        }
        
        public void Shift(int value)
        {
            if (value == 0)
            {
                throw new ArgumentException("Incorrect value");
            }
            var source = GetLocation(value);
            var dest = GetLocation(0);
            if (Math.Abs(source.x + source.y-dest.x-dest.y)!=1)
                throw new Exception("Can't move " + value);
                coordinates[source.x, source.y] = 0;
                coordinates[dest.x, dest.y] = value;
        }
    }
}

