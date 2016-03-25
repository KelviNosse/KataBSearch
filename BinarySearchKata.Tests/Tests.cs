using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearchKata.Logic;

namespace BinarySearchKata.Tests
{
    [TestClass]
    public class Tests
    {
        
        [TestMethod]
        public void Check_Chop_Sequential()
        {
            
           int[] numbers = new[] {10, 23, 4, 3, 5, 9, 80};  
           var bsearch = new BinarySearch();
           var result = bsearch.Chop_Sequential(5, numbers);
           Assert.AreEqual(2, result, "Expected index 2 when bsearch for 5 lol");
        }
    }
}
