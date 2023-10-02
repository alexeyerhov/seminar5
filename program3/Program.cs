using System;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 38: Задайте массив вещественных чисел. 
            //Найдите разницу между максимальным и минимальным элементов массива.
            //[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


            double[] FillArray(double[] array){
                for (int i = 0; i < array.Length; i++){
                    array[i] = Math.Round((new Random().Next(1,24) + new Random().NextDouble()),2);
                }
                return array;
            }

            void ShowArray(double[] array){              
                for (int i = 0; i < array.Length; i++){
                    Console.Write($"{array[i]}, ");
                }
            }

            void DiffMinMaxOnArray(double[] array){
                double diff = 0;
                double min = array[0];
                double max = array[0];
                for (int i = 1; i < array.Length; i++){
                    if (array[i]>max){
                        max=array[i];
                    }
                    if (array[i]<min){
                        min=array[i];
                    }
                }
                diff = Math.Round(max-min,2);
                Console.WriteLine("");
                Console.WriteLine($"Difference of MAX and MIN numbers in array is {diff}");
            }


            Console.WriteLine("Enter size of your array :");
            int sizeOfArr = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[sizeOfArr];
            FillArray(arr);
            ShowArray(arr);
            DiffMinMaxOnArray(arr);
        }
    }
}
