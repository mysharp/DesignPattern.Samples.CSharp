namespace EDC.DesignPattern.Adapter
{
    /// <summary>
    ///     适配者A：快速排序类
    /// </summary>
    public class QuickSortHelper
    {
        public int[] QuickSort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
            return array;
        }

        public void Sort(int[] array, int p, int r)
        {
            var q = 0;
            if (p < r)
            {
                q = Partition(array, p, r);
                Sort(array, p, q - 1);
                Sort(array, q + 1, r);
            }
        }

        public int Partition(int[] array, int p, int r)
        {
            var x = array[r];
            var j = p - 1;

            for (var i = p; i <= r - 1; i++)
                if (array[i] <= x)
                {
                    j++;
                    Swap(array, j, i);
                }

            Swap(array, j + 1, r);
            return j + 1;
        }

        public void Swap(int[] array, int i, int j)
        {
            var t = array[i];
            array[i] = array[j];
            array[j] = t;
        }
    }
}