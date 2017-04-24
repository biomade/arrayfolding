using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFolding
{
    class Program
    {
        static void Main(string[] args)
        {
            int numfolds = 3;
            int lenOfArray = (int)Math.Pow(2, (double)numfolds);
            string[] folddirections = new string[numfolds];
            folddirections[0] = "L";
            folddirections[1] = "L";
            folddirections[2] = "L";

            int[,] manipulateMe = new int[lenOfArray,1];
            int columns = lenOfArray;
            int rows = 1;
            //initialize the array
            for (int col = 0; col<columns; col++)
            {
                for (int row = 0; row<rows; row++)
                {
                    manipulateMe[col, row] = col+1;
                }
            }
            Console.Write("Base Array");
            WriteOutArray(manipulateMe);
            
            for(int foldNum = 0; foldNum< numfolds; foldNum++)
            {
                columns = manipulateMe.GetLength(0);
                rows = manipulateMe.GetLength(1);
                int newColCount = manipulateMe.GetLength(0) / 2;
                int newRowCount = manipulateMe.GetLength(1) * 2;
                
                //create new tempArray 
                int[,] tempArray = new int[newColCount, newRowCount];

                if (folddirections[foldNum] == "L")
                {
                    //fold left half over onto the right half
                    //get the bottom right half since it stays on the bottom                    
                    for (int row = newRowCount ; row >= 0; row++)
                    {
                        //start in the first row and only do half the columns moving downward and bring them to the top
                        for (int col = (columns/2) - 1; col >= 0; col--)
                        {
                            
                        }
                        
                    }
                   
                }
                else
                {
                    //fold righ half over onto the left half
                }

                //push temp into manipulateme, this is a deep copy            
                manipulateMe = (int[,])tempArray.Clone();
           

                Console.Write("# {0} Fold to the {1}:\r\n", foldNum, folddirections[foldNum]);
                WriteOutArray(manipulateMe);
            }

            Console.ReadKey();            
        }

        private static void WriteOutArray(int[,] array)
        {
            for (int row = 0; row < array.GetLength(1); row++)
            {
                for (int col = 0; col < array.GetLength(0); col++)
                {
                    Console.Write(array[col, row]);
                    if(col < array.GetLength(0) - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("  ");
            }
            Console.WriteLine("  ");
        }
    }
}
