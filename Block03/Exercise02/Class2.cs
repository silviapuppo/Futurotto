using System;


namespace Exercise02
{
    public class Class2
    {
        public static int[] SumLongInt(int[] firstNumber, int[] secondNumber)
        {
            int minLength = (firstNumber.Length < secondNumber.Length ? firstNumber.Length : secondNumber.Length);
            int maxLength = (firstNumber.Length > secondNumber.Length ? firstNumber.Length : secondNumber.Length);
            int[] longest = GetLongest(firstNumber, secondNumber);
            int[] shortest = GetShortest(firstNumber, secondNumber);
            int[] sum = new int[maxLength + 1];

            sum[0] = (longest[0] + shortest[0]) % 10;

            int i;

            for (i = 1; i < maxLength; i++)
            {
                sum[i] = ((longest[i] + shortest[i]) % 10 + (longest[i - 1] + shortest[i - 1]) / 10);
            }

            sum[i] = (longest[i - 1] + shortest[i - 1]) / 10;

            return sum;
        }

        private static int[] GetShortest(int[] array1, int[] array2)
        {
            int minLength = (array1.Length < array2.Length ? array1.Length : array2.Length);
            int maxLength = (array1.Length > array2.Length ? array1.Length : array2.Length);

            int[] shortest = new int[maxLength];
            int i;

            for (i = 0; i < minLength; i++)
            {
                shortest[i] = (array1.Length < array2.Length ? array1[i] : array2[i]);
            }

            while (i < maxLength)
            {
                shortest[i] = 0;
                i++;
            }

            return shortest;
        }

        private static int[] GetLongest(int[] array1, int[] array2)
        {
            int maxLength = (array1.Length >= array2.Length ? array1.Length : array2.Length);

            int[] longest = new int[maxLength];
            int i;

            for (i = 0; i < maxLength; i++)
            {
                longest[i] = (array1.Length >= array2.Length ? array1[i] : array2[i]);
            }

            return longest;
        }

    }

}
