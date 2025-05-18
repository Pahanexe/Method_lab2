using Microsoft.VisualStudio.TestTools.UnitTesting;
using Method_lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Unit test for ListLab class

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