using Topic;

namespace TestTopic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Topic_189()
        {
            Topic_189_轮转数组 topic_189 = new Topic_189_轮转数组();

            //var case1 = new int[7] {1,2,3,4,5,6,7};
            //topic_189.Rotate(case1, 3);

            var case2 = new int[4] { -1, -100, 3, 99 };
            topic_189.Rotate(case2, 2);

        }
    }
}