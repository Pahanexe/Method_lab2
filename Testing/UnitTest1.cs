using Microsoft.VisualStudio.TestTools.UnitTesting;
using Method_lab2;
namespace Method_lab2.Testing
{
    [TestClass]
    public class ListTest
    {

        [TestMethod]
        public void Append_test()
        {
            List list = new List();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            Assert.AreEqual(4, list.lenght());
        }
        [TestMethod]
        public void lenght_test()
        {
            List list = new List();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');
            Assert.AreEqual(4, list.lenght());
        }
    }
}