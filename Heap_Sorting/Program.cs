using System;

class Program
{


    static void Main()
    {
        int[] arr = { 20, 40, 10, 55, 80, 35 };
        Console.WriteLine("Unsorted array:");
        PrintArray(arr);

        HeapSort(arr);

        Console.WriteLine("Sorted array:");
        PrintArray(arr);
    }

    public static void HeapSort(int[] arr)
    {
        int n = arr.Length;

        // Build a max heap
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }

       
        for (int i = n - 1; i >= 0; i--)
        {
          
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

    
            Heapify(arr, i, 0);
        }
    }

  
    private static void Heapify(int[] arr, int n, int i)
    {
        int max = i; 
        int left = 2 * i + 1;  
        int right = 2 * i + 2; 

      
        if (left < n && arr[left] > arr[max])
        {
            max = left;
        }

        if (right < n && arr[right] > arr[max])
        {
            max = right;
        }

  
        if (max != i)
        {
          
            int swap = arr[i];
            arr[i] = arr[max];
            arr[max] = swap;

         
            Heapify(arr, n, max);
        }
    }

    
    public static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

  
   
}
