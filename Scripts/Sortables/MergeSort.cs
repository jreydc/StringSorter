
namespace StringSorter.Scripts.Sortables;

public class MergeSort : ISortable
{
    public string SortBy(string input)
    {
        char[] chars = input.ToCharArray();
        MergeSorted(chars, 0, chars.Length - 1);
        return new string(chars);
    }

    private void MergeSorted(char[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            MergeSorted(array, left, middle);
            MergeSorted(array, middle + 1, right);
            Merge(array, left, middle, right);
        }
    }

    private void Merge(char[] array, int left, int middle, int right)
    {
        int leftArrayLength = middle - left + 1;
        int rightArrayLength = right - middle;

        char[] leftArray = new char[leftArrayLength];
        char[] rightArray = new char[rightArrayLength];

        Array.Copy(array, left, leftArray, 0, leftArrayLength);
        Array.Copy(array, middle + 1, rightArray, 0, rightArrayLength);

        int i = 0, j = 0, k = left;

        while (i < leftArrayLength && j < rightArrayLength)
        {
            if (leftArray[i] <= rightArray[j])
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }

        while (i < leftArrayLength)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }

        while (j < rightArrayLength)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }
}
