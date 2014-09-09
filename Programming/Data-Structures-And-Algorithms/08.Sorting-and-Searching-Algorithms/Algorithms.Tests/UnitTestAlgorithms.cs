namespace Algorithms.Tests
{
    using Algorithms;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestAlgorithms
    {
        [TestMethod]
        public void SelectionSort()
        {
            var collection = new SortableCollection<int>(new[] { 5, 1, 2, 4, 0, 6, 9, 8, 7 });
            collection.Sort(new SelectionSorter<int>());
            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] < collection.Items[i + 1]);
            }
        }

        [TestMethod]
        public void QuickSort()
        {
            var collection = new SortableCollection<int>(new[] { 5, 1, 2, 4, 0, 6, 9, 8, 7 });
            collection.Sort(new QuickSorter<int>());
            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] < collection.Items[i + 1]);
            }
        }

        [TestMethod]
        public void MergeSort()
        {
            var collection = new SortableCollection<int>(new[] { 5, 1, 2, 4, 0, 6, 9, 8, 7 });
            collection.Sort(new MergeSorter<int>());
            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] < collection.Items[i + 1]);
            }
        }

        [TestMethod]
        public void LinearSearchLast()
        {
            var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });
            int expected = 9;
            int actual = collection.LinearSearch(0);
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void BinarySearch()
        {
            var collection = new SortableCollection<int>(new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });
            collection.Sort(new QuickSorter<int>());
            int expected = 0;
            int actual = collection.BinarySearch(0);
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void Shuffle()
        {
            var collection = new SortableCollection<int>(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            collection.Shuffle();
            bool shuffled = false;
            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                if (collection.Items[i] > collection.Items[i + 1])
                {
                    shuffled = true;
                    break;
                }
            }

            Assert.IsTrue(shuffled);
        }
    }
}