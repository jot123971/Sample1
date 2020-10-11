using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample1
{
    [TestClass]
    public class JKTest1
    {
        public int YesNo { get; private set; }

        [TestMethod]


        public void ShootHead_RotateGun_ReturnsTrue()

        {

            // Arrange - 

            Quit myGame = new Quit();

            myGame.Quit = 5;



            // Act - 

            var result = myGame.Yes();



            // Assert

            Assert.IsTrue((bool)result);
        }

        public void ShootAway_RotateGun_ReturnsTrue()

        {

            // Arrange - 

            Quit myGame = new Quit();

            myGame.Quit = 5;



            // Act - 

            var result = myGame.Yes();



            // Assert

            Assert.IsTrue((bool)result);
        }

        public void OuitGame_RotateGun_ReturnsYes()

        {

            // Arrange - 

           Quit myGame = new Quit();

            myGame.Quit = YesNo;



            // Act -

            var result = myGame.Yes();



            // Assert

            Assert.IsTrue((bool)result);
        }
    }
}
