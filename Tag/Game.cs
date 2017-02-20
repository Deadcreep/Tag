using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag
{
    
    struct Coordinate
    {
        int x;
        int y;

        public Coordinate(int a, int b)
        {
            x = a;
            y = b;
        }
    }

    class Game
    {
        int[,] coordinates;
        int value;
        int size;

        public Game(int size)
        {
         FillField(size);   
        }

        private void FillField(int size)
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
                return coordinates[x, y];
            }
            set
            {
                coordinates[x, y] = value;
            }
        }

        public Coordinate  GetLocation(int value)
        {
            Coordinate requisiteCoordinates = new Coordinate(0,0);
            for (int x = 1; x < size; x++)
                for (int y = 1; y < size; y++)
                    if(value == coordinates[x, y]) 
                    {
                        requisiteCoordinates = new Coordinate(x, y);                        
                    }
                    else continue;
            return requisiteCoordinates;
        }

        
        public void Shift()
        {
            throw new System.NotImplementedException();
        }
    }
}
}
