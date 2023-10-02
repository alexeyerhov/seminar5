using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
            //Напишите программу, которая покажет количество чётных чисел в массиве.
            //[345, 897, 568, 234] -> 2


            int[] FillArray(int[] array){
                for (int i = 0; i < array.Length; i++){
                    array[i] = new Random().Next(100,1000);
                }
                return array;
            }

            void ShowArray(int[] array){              
                for (int i = 0; i < array.Length; i++){
                    Console.Write($"{array[i]}, ");
                }
            }

            void CheckForOddInArray(int[] array){
                int count = 0;
                for (int i = 0; i < array.Length; i++){
                    if (array[i]%2==0) {
                        count++;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine($"Count of odd numbers in array is {count}");
            }

            Console.WriteLine("Enter size of your array :");
            int sizeOfArr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[sizeOfArr];
            FillArray(arr);
            ShowArray(arr);
            CheckForOddInArray(arr);
        }
    }
}
