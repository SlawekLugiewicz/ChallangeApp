
namespace ChallangeApp.Test
{
       
    public class TypeTest
    {
        [Test]
        public void WhenNameAewNotTheSame()
        {
            // arange 
            string user1 = ("Slawek");
            string user2 = ("Janusz");
           
            //act

            // assert
            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void WhenNumnerAreNotTheSame1()
        {
            // arange 
            int number1 = 2;
            int number2 = 4;
            //act

            // assert
            Assert.AreNotEqual(number1, number2);

        }

        [Test]
        public void WhenNumberAreNotTheSmae2()
        {
            // arange 
            float number3 = 2.5F;
            float number4 = 4.5F;
            //act

            // assert
            Assert.AreNotEqual(number3, number4);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }
        

        
    }
}