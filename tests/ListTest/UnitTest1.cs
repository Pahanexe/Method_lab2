namespace Method_lab2.tests
{
    [TestClass]
    public class Listlabtest
    {
        [TestMethod]
        public void Lenght_Test()
        {
            var list = new ListLab();
            

            int x = list.lenght();
            Assert.AreEqual(0, x);
        }

        [TestMethod]
        public void Append_Test()
        {
            var list = new ListLab();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');

            int x = list.lenght();
            Assert.AreEqual(4, x);
        }

        [TestMethod]
        public void insert_test()
        {
            var list = new ListLab();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');

            list.insert('e',3);
            int x = list.lenght();
            Assert.AreEqual(5, x);
        }

        [TestMethod]
        public void delete_test()
        {
            var list = new ListLab();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');

            list.delete(2);
            int x = list.lenght();
            Assert.AreEqual(3, x);
        }

        [TestMethod]
        public void deleteall_test()
        {
            var list = new ListLab();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('c');

            list.deleteall('c');
            int x = list.lenght();
            Assert.AreEqual(2, x);
        }

        [TestMethod]
        public void reverse_test()
        {
            var list = new ListLab();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');

            list.reverse();
            string x= list.display();
            Assert.AreEqual("d c b a ", x);
        }

        [TestMethod]
        public void findfirst_test()
        {
            var list = new ListLab();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');

            int x = list.findfirst('c');
            Assert.AreEqual(2, x);
        }

        [TestMethod]
        public void findlast_test()
        {
            var list = new ListLab();
            list.Append('a');
            list.Append('c');
            list.Append('c');
            list.Append('d');

            int x = list.findlast('c');
            Assert.AreEqual(2, x);
        }

        [TestMethod]
        public void clone_test()
        {
            var list = new ListLab();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');

            var x = list.clone();
            Assert.AreEqual(list, x);
        }

        [TestMethod]
        public void display_test()
        {
            var list = new ListLab();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');

            string x = list.display();
            Assert.AreEqual("a b c d ", x);
        }

        [TestMethod]
        public void clear_test()
        {
            var list = new ListLab();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            list.Append('d');

            list.clear();
            int x = list.lenght();
            Assert.AreEqual(0, x);
        }

        [TestMethod]
        public void extend_test()
        {
            var list = new ListLab();
            list.Append('a');
            list.Append('b');
            list.Append('c');
            var list2 = list.clone();
            list.extend(list2);

            int x = list.lenght();
            Assert.AreEqual(6, x);
        }


    }
}