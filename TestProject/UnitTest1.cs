
using ConsoleAppMojProjekt;
 
namespace TestProject
{
    public class Tests
    {
        [Test]
        public void TestVerificationToGetStatisticsMin()
        {
            //Arange
            var user = new UserInMemmory("Piotr", "Warcho³");
            user.AddNumber(10);
            user.AddNumber(30);
            user.AddNumber(40);

            //Act
            var statistics = user.GetStatistics();
            //Assert
            Assert.AreEqual(10, statistics.Min);
        }
        [Test]
        public void TestVerificationToGetStatisticsMax()
        {
            //Arange
            var user = new UserInMemmory("Piotr", "Warcho³");
            user.AddNumber(20);
            user.AddNumber(13);
            user.AddNumber(67);

            //Act
            var statistics = user.GetStatistics();
            //Assert
            Assert.AreEqual(67.0f, statistics.Max);
        }
        [Test]
        public void TestVerificationToGetStatisticsAverage()
        {
            //Arange
            var user = new UserInMemmory("Piotr", "Warcho³");
            user.AddNumber(20);
            user.AddNumber(20);
            user.AddNumber(20);

            //Act
            var statistics = user.GetStatistics();
            //Assert
            Assert.AreEqual(20.0f, statistics.Average);
        }
    }
}