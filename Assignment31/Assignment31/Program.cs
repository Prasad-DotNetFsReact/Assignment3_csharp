using System;

namespace Assignment
{
    class Question5
    {
        public static void Main(string[] args) {
            int[] array = { 2, 2, 7, 8, 8, 6, 9, 9, 9, 1, 5 };

            int duplicateCount = CountDuplicateElements(array);

            Console.WriteLine($"total number of duplicate:{duplicateCount}");
        }
     
        static int CountDuplicateElements(int[] array)
        { Array.Sort(array);
            int duplicateCount = 0;

            for (int i = 0; i < array.Length; i++) {
                if (array[i] == array[i + 1])
                {
                    duplicateCount++;

                    while (i < array.Length - 1 && array[i] == array[i + 1])
                    {
                        i++;
                    }
                }
                
            }

            return duplicateCount;
        }
     
}
}