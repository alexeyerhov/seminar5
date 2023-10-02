using System;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 36: Задайте одномерный массив, заполненный случайными числами. 
            //Найдите сумму элементов, стоящих на нечётных позициях.
            //[3, 7, 23, 12] -> 19
            //[-4, -6, 89, 6] -> 0



            // !!!
            // В примере не учитывается нулевой элемент массива, сделал по аналогии. 
            // !!!
            
            int[] FillArray(int[] array){
                for (int i = 0; i < array.Length; i++){
                    array[i] = new Random().Next(1,24);
                }
                return array;
            }

            void ShowArray(int[] array){              
                for (int i = 0; i < array.Length; i++){
                    Console.Write($"{array[i]}, ");
                }
            }

            void SumOfNonOddNumbers(int[] array){
                int sum = 0;
                for (int i = 1; i < array.Length; i=i+2){
                    sum+=array[i];
                }
                Console.WriteLine("");
                Console.WriteLine($"Sum of numbers on non-odd position in array is {sum}");
            }


            Console.WriteLine("Enter size of your array :");
            int sizeOfArr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[sizeOfArr];
            FillArray(arr);
            ShowArray(arr);
            SumOfNonOddNumbers(arr);
        }
    }
}
