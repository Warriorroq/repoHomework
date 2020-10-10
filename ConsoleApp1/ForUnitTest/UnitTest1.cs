using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestFor8()
        {
            Work.For f = new Work.For();
            int result = f.For8(3);
            Assert.AreEqual(result,6);
        }

        [Test]
        public void TestFor20()
        {
            Work.For f = new Work.For();
            int result = f.For20(3);
            Assert.AreEqual(result, 9);
        }
        [Test]
        public void TestWhile20()
        {
            Work.While w = new Work.While();
            bool result = w.While20(120);
            Assert.AreEqual(true,result);
        }
        [Test]
        public void TestWhile4()
        {
            Work.While w = new Work.While();
            bool result = w.While4(81);
            Assert.AreEqual(true, result);
        }
    }
}