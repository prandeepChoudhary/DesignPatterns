using System;
namespace DesignPattern.Array
{
	public class ArrayClass
	{
        public int[] SortArray(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = 1; j < arr.Length - i; j++)
                {
                    if (arr[j] < arr[j-1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}

