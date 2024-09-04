using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace jobayer_alam_24_Abstraction_Implementation.models
{
    public class TwoD_Array
    {
        private int[,] DataSets = new int[4, 4];
        
        /* ==========Visual Representation============
        * [
        !       [1, 2, 3, 4]
        !       [5, 6, 7, 8]
        !       [9, 10, 11, 12]
        !       [13, 14, 15, 16]
        * ]
        */
        private void OperationSettingValuesByUser()
        {
            //Row
            for(int row = 0; row < 4; row++)
            {
                Console.WriteLine($"=========Row {row + 1}============");
                //Column
                for(int col = 0; col < 4; col++)
                {
                    Console.Write($"Enter an Integer [{row + 1}][{col + 1}]: ");
                    
                    DataSets[row, col] = int.Parse(Console.ReadLine());
                }
            }
        }
        private void OperationPrintingValuesByUser()
        {
            Console.WriteLine($"[");
            for(int row = 0; row < 4; row++)
            {
                if(row == 0)
                {
                    Console.Write($" [");
                }
                else
                {
                    Console.Write($"[");
                }
                for(int col = 0; col < 4; col++)
                {
                    Console.Write($"{DataSets[row, col]}");
                    if(col < 3)
                    {
                        Console.Write($", ");
                    }
                }
                Console.Write($"]");

                if(row < 3)
                {
                    Console.Write($", ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"]");
        }

        public void ArrayOperations()
        {
            Console.WriteLine($"===========Taking Input=========");
            Console.WriteLine($"----------------------");
            OperationSettingValuesByUser();
            Console.WriteLine($"=========Printing 2D Arrays===========");
            OperationPrintingValuesByUser();
        }
    }
}