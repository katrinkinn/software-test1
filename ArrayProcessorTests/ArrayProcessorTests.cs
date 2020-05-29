using NUnit.Framework;
using ArrayProcessorApp;

namespace Tests
{
    public class ArrayProcessorTests
    {
        [Test]
        public void ReplacingNegativeNumbersTest()
        {
            double[] a = { -76, -3, -1 };
            double[] expected = { 76, 3, 1 };
            ArrayProcessor arr = new ArrayProcessor();
            double[] actual = arr.SortAndFilter(a);
            CollectionAssert.AreEqual(expected, actual);
        }
        [Test]
        public void SortTest()
        {
            double[] a = { 0, 3, 7, 1 };
            double[] expected = { 7, 3, 1, 0 };
            ArrayProcessor arr = new ArrayProcessor();
            double[] actual = arr.SortAndFilter(a);
            CollectionAssert.AreEqual(expected, actual);
        }
        [Test]
        public void RemoveTest()
        {
            double[] a = { 1, 1, 2, 3, 2, 3, 6, 2 };
            double[] expected = { 6, 3, 2, 1 };
            ArrayProcessor arr = new ArrayProcessor();
            double[] actual = arr.SortAndFilter(a);
            CollectionAssert.AreEqual(expected, actual);
        }
        [Test]
        public void AllConditionsTest()
        {
            double[] a = { 1, -1, 2, 3, 2, 73, 6, 2 };
            double[] expected = { 73, 6, 3, 2, 1 };
            ArrayProcessor arr = new ArrayProcessor();
            double[] actual = arr.SortAndFilter(a);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}