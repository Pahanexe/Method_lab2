namespace Method_lab2.tests
{
    [TestClass]
    public class Listlabtest
    {
        [TestMethod]
        public void Lenght_Test()
        {
            ListLab list = new ListLab();
            list.Append('a');
            list.Append('b');
            list.Append('c');

            int x= list.lenght();
            Assert.AreEqual(3, x);
        }
    }
}