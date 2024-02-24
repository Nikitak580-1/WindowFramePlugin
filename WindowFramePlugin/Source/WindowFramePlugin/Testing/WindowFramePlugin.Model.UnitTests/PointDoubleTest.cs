namespace WindowFramePlugin.UnitTests
{
    using NUnit.Framework;
    using WindowFramePlugin.Model;
    using System.Reflection;
    using NUnit.Framework.Legacy;

    [TestFixture]
    public class PointDoubleTest
    {
        [Test(Description = "Positive test Get X.")]
        public void X_GetCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var pointDouble = new PointDouble(0, 0);

            //Act
            var value = 20d;
            pointDouble.X = value;

            //Assert
            ClassicAssert.IsTrue(
                pointDouble.X == value,
                "Геттер вернул неверное значение");
        }

        [Test(Description = "Positive test Get Y.")]
        public void Y_GetCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var pointDouble = new PointDouble(0, 0);

            //Act
            var value = 30d;
            pointDouble.Y = value;

            //Assert
            ClassicAssert.IsTrue(
                pointDouble.Y == value,
                "Геттер вернул неверное значение");
        }

        [Test(Description = "Positive test Set X.")]
        public void X_SetCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var pointDouble = new PointDouble(0, 0);
            var correctX = 20d;
            var expected = correctX;

            //Act
            pointDouble.X = correctX;
            var actual = pointDouble.X;

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Positive test Set Y.")]
        public void Y_SetCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var pointDouble = new PointDouble(0, 0);
            var correctY = 30d;
            var expected = correctY;

            //Act
            pointDouble.Y = correctY;
            var actual = pointDouble.Y;

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }
    }
}
