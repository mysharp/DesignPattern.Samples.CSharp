namespace EDC.DesignPattern.Adapter
{
    /// <summary>
    ///     适配器：成绩操作适配器类
    /// </summary>
    public class OperationAdapter : IScoreOperation
    {
        private readonly BinarySearchHelper searchTarget;
        private readonly QuickSortHelper sortTarget;

        public OperationAdapter()
        {
            sortTarget = new QuickSortHelper();
            searchTarget = new BinarySearchHelper();
        }

        public int Search(int[] array, int key)
        {
            return searchTarget.BinarySearch(array, key);
        }

        public int[] Sort(int[] array)
        {
            return sortTarget.QuickSort(array);
        }
    }
}