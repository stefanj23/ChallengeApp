using System.Reflection.Metadata;
using System.Text.Json.Serialization;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoSccores_ShouldCorrectSumAsResult()
        {
            // arrange
            var emp2 = new Employee("Przemek", "S", 30);
            emp2.AddScore(5);
            emp2.AddScore(6);
            emp2.AddScore(9);

            // act 
            var result1 = emp2.Result;

            //assert 
            Assert.AreEqual(20, result1);
        }

        [Test]
        public void WhenUserCollectPositiveAndNegativSccoresShouldCorrectSumAsResult()
        {
            // arrange
            var emp1 = new Employee("Norbert", "S", 36);
            emp1.AddScore(-5);
            emp1.AddScore(-1);
            emp1.AddScore(10);
            emp1.AddScore(-8);
            emp1.AddScore(3);

            // act 
            var result2 = emp1.Result;

            // assert
            Assert.AreEqual(-1, result2);
        }






        }




}