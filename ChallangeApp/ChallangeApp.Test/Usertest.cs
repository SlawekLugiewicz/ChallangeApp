

namespace ChallangeApp.Test
{
    public class Tests
    {

        [Test]
        public void WhenUserColllectTwoScore_ShouldReturngCorretSumAsResult()
        {
            // arange 
            var user = new User("Slawek", "iubcdkdz");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-3);
            user.AddScore(1);
            //act
            var result = user.Result;

            // assert
            Assert.AreEqual(9, result);

        }


        [Test]
        public void WhenUserColllectTwoScore_ShouldReturngCorretSumAsResult1()
        {
            // arange 
            var user = new User("Juanusz", "iubcdkdz");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(6);
            user.AddScore(12);
            //actw
            var result = user.Result;

            // assert
            Assert.AreEqual(29, result);

        }

        [Test]
        public void WhenUserColllectTwoScore_ShouldReturngCorretSumAsResult12()
        {
            // arange 
            var user = new User("Jacek", "ghkkjljj");
            user.AddScore(-25);
            user.AddScore(-5);
            user.AddScore(-16);
            user.AddScore(-8);
            //act
            var result = user.Result;

            // assert
            Assert.AreEqual(-54, result);


        }
    }
}