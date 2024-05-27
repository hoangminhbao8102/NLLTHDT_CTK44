using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_D_Bai05
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, -5, 3, 7, -2, 3, 7, -9, 3 };

            // a. Xóa phần tử x đầu tiên trong danh sách (ví dụ xóa phần tử 3)
            array = RemoveFirstOccurrence(array, 3);
            Console.WriteLine("Array after modifications: " + string.Join(", ", array));

            // b. Xóa phần tử theo vị trí trong danh sách (ví dụ vị trí 1)
            array = RemoveAtPosition(array, 1);
            Console.WriteLine("Array after modifications: " + string.Join(", ", array));

            // c. Xóa tất cả phần tử x trong danh sách (ví dụ xóa tất cả số 3)
            array = RemoveAllOccurrences(array, 7);
            Console.WriteLine("Array after modifications: " + string.Join(", ", array));

            // d. Xóa tất cả số âm trong danh sách
            array = RemoveAllNegatives(array);
            Console.WriteLine("Array after modifications: " + string.Join(", ", array));

            // e. Tìm phần tử lớn nhất trong mảng
            Console.WriteLine("Max Element: " + FindMaxElement(array));

            // f. Tìm vị trí đầu tiên của phần tử lớn nhất trong mảng
            Console.WriteLine("First Max Position: " + FindFirstMaxPosition(array));

            // g. Xóa tất cả phần tử lớn nhất trong mảng
            array = RemoveAllMaxElements(array);

            // h. Tìm tất cả vị trí của phần tử lớn nhất trong mảng
            int[] maxPositions = FindAllMaxPositions(array);
            Console.WriteLine("Maximum element found at positions:");
            foreach (int position in maxPositions)
            {
                Console.WriteLine(position);
            }

            // i. Thay thế phần tử x bằng phần tử y trong danh sách (ví dụ thay thế 3 bằng 5)
            array = ReplaceElement(array, -2, 100);

            // j. Chèn một phần tử vào trong danh sách tại vị trí bất kì (ví dụ chèn 10 tại vị trí 2)
            array = InsertElement(array, 0, 200);

            // k. Chèn một phần tử x vào trước phần tử y trong danh sách (ví dụ chèn 4 trước 7)
            array = InsertBefore(array, 100, 200);

            // l. Chèn một phần tử x vào sau phần tử y trong danh sách (ví dụ chèn 4 sau 7)
            array = InsertAfter(array, 200, 100);

            // m. Đảo ngược danh sách
            array = ReverseArray(array);
            Console.WriteLine("Reversed Array: " + string.Join(", ", array));

            // n. Đếm số phần tử (không tính trùng nhau) trong dánh sách
            Console.WriteLine("Unique Elements Count: " + CountUniqueElements(array));

            // o. Xóa tất cả phần tử trùng nhau trong danh sách
            array = RemoveAllDuplicates(array);
            Console.WriteLine("Array after removing duplicates: " + string.Join(", ", array));

            // p. Tính trung bình cộng các phần tử trong mảng
            Console.WriteLine("Average: " + CalculateAverage(array));

            // q. Tính tổng các phần tử chỉ xuất hiện một lần trong mảng
            Console.WriteLine("Sum of Unique Elements: " + SumUniqueElements(array));

            Console.ReadKey();
        }

        static int[] RemoveFirstOccurrence(int[] array, int x)
        {
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1) return array; // x not found

            int[] newArray = new int[array.Length - 1];
            int newIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i != index)
                {
                    newArray[newIndex++] = array[i];
                }
            }
            return newArray;
        }

        static int[] RemoveAtPosition(int[] array, int position)
        {
            if (position < 0 || position >= array.Length) return array; // Invalid position

            int[] newArray = new int[array.Length - 1];
            int newIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i != position)
                {
                    newArray[newIndex++] = array[i];
                }
            }
            return newArray;
        }

        static int[] RemoveAllOccurrences(int[] array, int x)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x) count++;
            }
            if (count == 0) return array;

            int[] newArray = new int[array.Length - count];
            int newIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != x)
                {
                    newArray[newIndex++] = array[i];
                }
            }
            return newArray;
        }

        static int[] RemoveAllNegatives(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) count++;
            }
            if (count == 0) return array;

            int[] newArray = new int[array.Length - count];
            int newIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    newArray[newIndex++] = array[i];
                }
            }
            return newArray;
        }

        static int FindMaxElement(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static int FindFirstMaxPosition(int[] array)
        {
            int max = FindMaxElement(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max) return i;
            }
            return -1; // Should never happen
        }

        static int[] FindAllMaxPositions(int[] array)
        {
            if (array.Length == 0)
            {
                return new int[0]; // Return an empty array if the array is empty
            }

            int max = array[0]; // Assume the first element is the max initially
            int maxCount = 0;

            // First, find the maximum element in the array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxCount = 1; // Reset count as we found a new max
                }
                else if (array[i] == max)
                {
                    maxCount++; // Increment count for each occurrence of max
                }
            }

            // Allocate array to hold positions
            int[] positions = new int[maxCount];
            int index = 0;

            // Second, find all the positions of the maximum element
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    positions[index++] = i; // Store position and increment index
                }
            }

            return positions;
        }

        static int[] RemoveAllMaxElements(int[] array)
        {
            int max = FindMaxElement(array);
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max) count++;
            }
            if (count == 0) return array;

            int[] newArray = new int[array.Length - count];
            int newIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != max)
                {
                    newArray[newIndex++] = array[i];
                }
            }
            return newArray;
        }

        static int[] ReplaceElement(int[] array, int oldItem, int newItem)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = (array[i] == oldItem) ? newItem : array[i];
            }
            return newArray;
        }

        static int[] InsertElement(int[] array, int position, int newItem)
        {
            if (position < 0 || position > array.Length) position = array.Length; // Clamp position

            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < position; i++)
            {
                newArray[i] = array[i];
            }
            newArray[position] = newItem;
            for (int i = position; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            return newArray;
        }

        static int[] InsertBefore(int[] array, int newItem, int beforeItem)
        {
            int position = Array.IndexOf(array, beforeItem);
            if (position == -1) return array; // beforeItem not found

            return InsertElement(array, position, newItem);
        }

        static int[] InsertAfter(int[] array, int newItem, int afterItem)
        {
            int position = Array.IndexOf(array, afterItem);
            if (position == -1) return array; // afterItem not found

            return InsertElement(array, position + 1, newItem);
        }

        static int[] ReverseArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[array.Length - 1 - i] = array[i];
            }
            return newArray;
        }

        static int CountUniqueElements(int[] array)
        {
            int[] uniqueElements = RemoveAllDuplicates(array);
            return uniqueElements.Length;
        }

        static int[] RemoveAllDuplicates(int[] array)
        {
            int[] tempArray = new int[array.Length];
            int tempIndex = 0;
            bool isDuplicate;

            for (int i = 0; i < array.Length; i++)
            {
                isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    tempArray[tempIndex++] = array[i];
                }
            }

            int[] uniqueArray = new int[tempIndex];
            Array.Copy(tempArray, uniqueArray, tempIndex);
            return uniqueArray;
        }

        static double CalculateAverage(int[] array)
        {
            if (array.Length == 0) return 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        static int SumUniqueElements(int[] array)
        {
            int[] uniqueElements = RemoveAllDuplicates(array);
            int sum = 0;
            for (int i = 0; i < uniqueElements.Length; i++)
            {
                sum += uniqueElements[i];
            }
            return sum;
        }
    }
}
