using System;

public static class Heap<T> where T : IComparable<T>
{
    public static void Sort(T[] arr)
    {
        for (int i = arr.Length / 2 - 1; i >= 0; i--)
            heapify(arr, arr.Length, i);
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            T temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;
            heapify(arr, i, 0);
        }
    }
    static void heapify(T[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        if (left < n && IsGreater(arr[left],arr[largest]))
            largest = left;
        if (right < n && IsGreater(arr[left], arr[largest]))
            largest = right;
        if (largest != i)
        {
            T swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;
            heapify(arr, n, largest);
        }
    }

    private static bool IsGreater(T t1, T t2)
    {
        return t1.CompareTo(t2) > 0;
    }
}
