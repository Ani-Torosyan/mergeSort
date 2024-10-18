using System;

class MergeSort
{
    static void Merge(int[] array, int[] tempArray, int left, int mid, int right)
    {
        int i = left;     
        int j = mid + 1;  
        int k = left;     

        while (i <= mid && j <= right)
        {
            if (array[i] <= array[j])
            {
                tempArray[k++] = array[i++];
            }
            else
            {
                tempArray[k++] = array[j++];
            }
        }

        while (i <= mid)
        {
            tempArray[k++] = array[i++];
        }

        while (j <= right)
        {
            tempArray[k++] = array[j++];
        }

        for (i = left; i <= right; i++)
        {
            array[i] = tempArray[i];
        }
    }

    static void MergeSortRecursive(int[] array, int[] tempArray, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            MergeSortRecursive(array, tempArray, left, mid);
            MergeSortRecursive(array, tempArray, mid + 1, right);

            Merge(array, tempArray, left, mid, right);
        }
    }

    public static void mergeSort(int[] array)
    {
        int n = array.Length;
        int[] tempArray = new int[n];
        MergeSortRecursive(array, tempArray, 0, n - 1);
    }

    public static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
        Console.WriteLine("Original Array:");
        PrintArray(arr);

        mergeSort(arr);

        Console.WriteLine("Sorted Array:");
        PrintArray(arr);
    }
}


