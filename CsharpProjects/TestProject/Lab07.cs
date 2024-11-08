using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Lab07
{
    class Lab7
    {
        public void Start()
        {
            int[] numbers = { 1, 4, -5, 7, 0, 4, 6, 8 };
        }

        public int GetSum(int[] numbers)
        {
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            return sum;
        }

        public float FindAverage(int[] numbers)
        {
            int sum = GetSum(numbers);

            float average = sum / numbers.Length;

            return average;
        }

        public int FindMin(int[] numbers)
        {   
            int min = numbers[0];

            for(int i = 0; i < numbers.Length; i ++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        public int FindMax(int[] numbers)
        {
            int max = numbers[1];

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                   max = numbers[i];  
                }
            }

            return max;
        }

        public int[] Sort(int[] numbers)
        {
            int len = numbers.Length;
            int[] sortedArray;

            for (int i = 0; i < len - 1; i++)
            {
                bool swapped = false;

                for (int j= 0; j <  len - i - 1; j++)
                {

                }

            }

            return [];
        }
    }
}