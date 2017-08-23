using System;


namespace LiveDemo
{
    class DynamicArray
    {
        private int [] arr;
        private int elementCount = 0;
        private int capacity = 0;

        public DynamicArray(int cap)
        {
            capacity = cap;
            arr = new int[capacity];
        }

        public void Add(int element)
        {
            if(elementCount == capacity)
            {
                int [] newarr = new int[capacity + 10];
                for(int i = 0; i < capacity; i++)
                {
                    newarr[i] = arr[i];
                }
                capacity = capacity + 10;
            }
            else
            {
                arr[elementCount] = element;
            }
            
            elementCount++;
        }

        /// <summary>
        /// Get an element from the array specified by index
        /// </summary>
        /// <param name="index">The index of the element needed</param>
        /// <returns>The number stored at index or null if it doesn't exist</returns>
        public int GetElement(int index)
        {
            if (index > elementCount)
                throw new IndexOutOfRangeException();
            else
                return arr[index];
        }
    }
}