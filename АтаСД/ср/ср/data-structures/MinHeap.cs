using System;
using System.Collections.Generic;
using System.Linq;

namespace cp.data_structures
{
    public class MinHeap
    {
        public List<double> heap = new List<double>();

        private void heapifydown(int index)
        {
            while (true)
            {
                int small = index;
                int leftchild = 2 * index + 1;
                int rightchild = 2 * index + 2;

                if (leftchild < heap.Count && heap[leftchild] < heap[small])
                    small = leftchild;

                if (rightchild < heap.Count && heap[rightchild] < heap[small])
                    small = rightchild;

                if (small == index) break;

                swap(index, small);
                index = small;
            }
        }

        private void heapifyup(int index)
        {
            while (index > 0)
            {
                int parentindex = (index - 1) / 2;
                if (heap[parentindex] <= heap[index]) break;

                swap(parentindex, index);
                index = parentindex;
            }
        }

        private void swap(int i, int j)
        {
            double temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        public void build(double[] array)
        {
            heap = array.ToList();
            if (heap.Count == 0) return;

            for (int i = heap.Count / 2 - 1; i >= 0; i--)
            {
                heapifydown(i);
            }
        }

        public void insert(double value)
        {
            heap.Add(value);
            heapifyup(heap.Count - 1);
        }

        public void removemin()
        {
            if (heap.Count == 0) return;

            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            if (heap.Count > 0)
                heapifydown(0);
        }
    }
}