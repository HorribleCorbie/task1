using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void EqualTest1()
        {
            int a = 1, b = 2, c = 3;
            string message = Logic.Task(a, b, c);
            Assert.AreEqual("Самое большое третье число:3. Самое минимальное первое число:1. Среднее число:2", message);
        }
        [TestMethod()]
        public void ErrorTest1()
        {
            int a = 3, b = 2, c = 3;
            string message = Logic.Task(a, b, c);
            Assert.Fail("Числа не разные.", message);
        }
        [TestMethod()]
        public void EqualTest2()
        {
            int a = 3, b = 2, c = 1;
            string message = Logic.Task(a, b, c);
            Assert.AreEqual("Самое большое первое число:3. Самое минимальное третье число:1. Среднее число:2", message);
        }

        [TestMethod()]
        public void EqualTest3()
        {
            int a = 1, b = 3, c = 2;
            string message = Logic.Task(a, b, c);
            Assert.AreEqual("Самое большое второе число:3. Самое минимальное первое число:1. Среднее число:2", message);
        }
    }
}