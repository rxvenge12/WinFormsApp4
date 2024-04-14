using System;
using System.Linq;

namespace OneDimensionalArrayApp
{
    public class OneDimensionalArray
    {
        private int[] array;

        public int Length => array.Length;

        public int this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }

        public OneDimensionalArray(int size)
        {
            array = new int[size];
        }

        public OneDimensionalArray(params int[] elements)
        {
            array = elements;
        }

        public static OneDimensionalArray operator *(OneDimensionalArray arr1, OneDimensionalArray arr2)
        {
            if (arr1.Length != arr2.Length)
                throw new ArgumentException("Arrays must have the same length");

            var result = new OneDimensionalArray(arr1.Length);
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i] * arr2[i];
            }
            return result;
        }

        public static bool operator true(OneDimensionalArray arr)
        {
            return !arr.ContainsNegatives();
        }

        public static bool operator false(OneDimensionalArray arr)
        {
            return arr.ContainsNegatives();
        }

        public static int operator !(OneDimensionalArray arr)
        {
            return arr.Length;
        }

        public static bool operator ==(OneDimensionalArray arr1, OneDimensionalArray arr2)
        {
            return arr1.array.SequenceEqual(arr2.array);
        }

        public static bool operator !=(OneDimensionalArray arr1, OneDimensionalArray arr2)
        {
            return !arr1.array.SequenceEqual(arr2.array);
        }

        public static bool operator <(OneDimensionalArray arr1, OneDimensionalArray arr2)
        {
            return arr1.Length < arr2.Length;
        }

        public static bool operator >(OneDimensionalArray arr1, OneDimensionalArray arr2)
        {
            return arr1.Length > arr2.Length;
        }

        public bool ContainsNegatives()
        {
            return array.Any(x => x < 0);
        }

        public OneDimensionalArray RemoveNegatives()
        {
            var newArray = array.Where(x => x >= 0).ToArray();
            return new OneDimensionalArray(newArray);
        }

        public int[] GetArray()
        {
            return array;
        }

        public class Owner
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Organization { get; set; }

            public Owner(int id, string name, string organization)
            {
                Id = id;
                Name = name;
                Organization = organization;
            }
        }

        public class Date
        {
            public DateTime CreationDate { get; set; }

            public Date(DateTime creationDate)
            {
                CreationDate = creationDate;
            }
        }
    }

    public static class StatisticOperation
    {
        public static int Sum(OneDimensionalArray arr)
        {
            return arr.Length == 0 ? 0 : arr.GetArray().Sum();
        }

        public static int Difference(OneDimensionalArray arr)
        {
            return arr.Length == 0 ? 0 : arr.GetArray().Max() - arr.GetArray().Min();
        }

        public static int Count(OneDimensionalArray arr)
        {
            return arr.Length;
        }
    }

    public static class Extensions
    {
        public static bool ContainsChar(this string str, char c)
        {
            return str.Contains(c);
        }
    }
}
