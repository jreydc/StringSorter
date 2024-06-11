namespace StringSorter.Scripts.Sortables
{
    public class QuickSort : ISortable
    {
        public string SortBy(string input)
        {
            char[] chars = input.ToCharArray();

            QuickSorted(chars, 0, chars.Length - 1);
            return new string(chars);
        }

        private void QuickSorted(char[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                QuickSorted(array, low, pi - 1);
                QuickSorted(array, pi + 1, high);
            }
        }

        private int Partition(char[] array, int low, int high)
        {
            char pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    char temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            char swap = array[i + 1];
            array[i + 1] = array[high];
            array[high] = swap;
            return i + 1;
        }
    }
}
