using System;

namespace CollectionsStuff
{
    class DynamicArray
    {
        private int[] arr;
        private int elementCount = 0;
        private int capacity = 0;

        /// <summary>
        /// Get current maximum capacity of the array
        /// </summary>
        /// <returns>Current Capacity</returns>
        public int GetArrayCapacity()
        {
            return capacity;
        }

        /// <summary>
        /// Get count of the number of elements added to the array
        /// </summary>
        /// <returns>The count of the elements</returns>
        public int GetArrayCount()
        {
            return elementCount;
        }

        /// <summary>
        /// Create a dynamic array with a capacity of 10 by default.
        /// </summary>
        public DynamicArray()
        {
            arr = new int[10];
            capacity = 10;
        }

        /// <summary>
        /// Create array with capacity n
        /// </summary>
        /// <param name="n">capacity of the array</param>
        public DynamicArray(int n)
        {
            arr = new int[n];
            capacity = n;
        }

        /// <summary>
        /// Add integer to the dymanic array
        /// </summary>
        /// <param name="elem">element to add</param>
        public void AddElement(int elem)
        {
            int count = capacity;
            try
            {
                arr[capacity - 1] = elem;
            }

            catch(IndexOutOfRangeException)
            {
                capacity += 10;
                arr = new int[capacity];
                arr[capacity - 1] = elem;
            }
            finally
            {
                elementCount++;
            }
        }

        public void Execute()
        {
            Console.WriteLine(GetArrayCount());
        }
    }

    class SomeClass
    {
        int x;
    }
    class DynamicArrayWithParamter<T>
    {
        private T[] arr;
        private int elementCount = 0;
        private int capacity = 0;

        /// <summary>
        /// Get current maximum capacity of the array
        /// </summary>
        /// <returns>Current Capacity</returns>
        public int GetArrayCapacity()
        {
            return capacity;
        }

        /// <summary>
        /// Get count of the number of elements added to the array
        /// </summary>
        /// <returns>The count of the elements</returns>
        public int GetArrayCount()
        {
            return elementCount;
        }

        /// <summary>
        /// Create a dynamic array with a capacity of 10 by default.
        /// </summary>
        public DynamicArrayWithParamter()
        {
            arr = new T[10];
            capacity = 10;
        }

        /// <summary>
        /// Create array with capacity n
        /// </summary>
        /// <param name="n">capacity of the array</param>
        public DynamicArrayWithParamter(int n)
        {
            arr = new T[n];
            capacity = n;
        }

        /// <summary>
        /// Add integer to the dymanic array
        /// </summary>
        /// <param name="elem">element to add</param>
        public void AddElement(T elem)
        {
            int count = capacity;
            try
            {
                arr[capacity - 1] = elem;
            }

            catch(IndexOutOfRangeException)
            {
                capacity += 10;
                arr = new T[capacity];
                arr[capacity - 1] = elem;
            }
            finally
            {
                elementCount++;
            }
        }

        public void Execute()
        {
            Console.WriteLine(GetArrayCount());
        }

    }

    public class LinkedList
    {
        private int element;

        LinkedList next;

        public LinkedList()
        {
            next = null;
        }

        public int GetElement()
        {
            return element;
        }

        public void SetElement(int n)
        {
            this.element = n;
        }

        public LinkedList GetNext()
        {
            return next;
        }

        public void SetNext(LinkedList obj)
        {
            this.next = obj;
        }
    }

    public class LinkedListManager
    {
        

        private LinkedList list = new LinkedList();

        private LinkedList currentElement = new LinkedList();
        private LinkedList root;

        public LinkedListManager()
        {
            root = list;
            currentElement = root;
        }

        public void AddElement(int n)
        {
            currentElement.SetElement(n);
            LinkedList newNode = new LinkedList();
            currentElement.SetNext(newNode);
            currentElement = newNode;
        }

        public LinkedList GetNext()
        {
            return currentElement.GetNext();
        }

        public LinkedList GetRoot()
        {
            return root;
        }
    }
}