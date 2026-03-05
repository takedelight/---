using System;
using System.Collections.Generic;
using cp.data_structures; 
namespace cp.sort
{
    public class HeapSort
    {
        public static List<double> sort(List<double> arr)
        {
            MinHeap heap = new MinHeap();
            heap.build(arr.ToArray());

            List<double> result = new List<double>();

            while (heap.heap.Count > 0)
            {
                result.Add(heap.heap[0]);
                heap.removemin();
            }

            return result;
        }
    }
}