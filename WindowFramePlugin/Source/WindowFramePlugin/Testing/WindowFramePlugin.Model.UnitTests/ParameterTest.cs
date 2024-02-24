namespace WindowFramePlugin.UnitTests
{
    using WindowFramePlugin.Model;
    using NUnit.Framework;
    using System;
    using NUnit.Framework.Legacy;

    [TestFixture]
    public class ParameterTest
    {
        [Test(Description = "Positive Get Value test.")]
        public void Value_GetCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var parameter =
                new Parameter(1, 1, 5);

            //Act
            var value = 3d;
            parameter.Value = value;

            //Assert
            ClassicAssert.IsTrue(
                parameter.Value == value,
                "Геттер вернул неверное значение");
        }

        [Test(Description = "Positive Get MinValue test.")]
        public void MinValue_GetCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var parameter =
                new Parameter(1, 1, 5);

            //Act
            var value = 3d;
            parameter.MinValue = value;

            //Assert
            ClassicAssert.IsTrue(
                parameter.MinValue == value,
                "Геттер вернул неверное значение");
        }

        [Test(Description = "Positive Get MaxValue test.")]
        public void MaxValue_GetCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var parameter =
                new Parameter(1, 1, 5);

            //Act
            var value = 3d;
            parameter.MaxValue = value;

            //Assert
            ClassicAssert.IsTrue(
                parameter.MaxValue == value,
                "Геттер вернул неверное значение");
        }

        [Test(Description = "Positive Set Value test.")]
        public void Value_SetCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var parameter =
                new Parameter(1, 1, 5);
            var correctValue = 3d;
            var expected = correctValue;

            //Act
            parameter.Value = correctValue;
            var actual = parameter.Value;

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative Set Value test.")]
        public void Value_SetInCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var parameter =
                new Parameter(1, 1, 5);
            var message =
                "Это исключение выбрасывается, "
                + "если значение выходит из диапазона допустимых значений";
            var valueMoreMax = 6d;
            var valueMoreMin = 0d;

            //Assert
            Assert.Multiple(() =>
            {
                // Act
                Assert.Throws<ArgumentException>(() =>
                {
                    parameter.Value = valueMoreMax;
                },
                message);
                Assert.Throws<ArgumentException>(() =>
                {
                    parameter.Value = valueMoreMin;
                },
                message);
            });
        }

        [Test(Description = "Positive Set MinValue test.")]
        public void MinValue_SetCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var parameter =
                new Parameter(1, 1, 5);
            var correctValue = 3d;
            var expected = correctValue;

            //Act
            parameter.MinValue = correctValue;
            var actual = parameter.MinValue;

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative Set MinValue test.")]
        public void MinValue_SetInCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var parameter =
                new Parameter(1, 1, 5);
            var message =
                "Это исключение выбрасывается, "
                + "если значение выходит из диапазона допустимых значений";
            var equalValue = 5d;

            //Assert
            Assert.Multiple(() =>
            {
                // Act
                Assert.Throws<ArgumentException>(() =>
                {
                    parameter.MaxValue = equalValue;
                    parameter.MinValue = equalValue;
                },
                message);
            });
        }

        [Test(Description = "Positive Set MaxValue test.")]
        public void MaxValue_SetCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var parameter =
                new Parameter(1, 1, 5);
            var correctValue = 3d;
            var expected = correctValue;

            //Act
            parameter.MaxValue = correctValue;
            var actual = parameter.MaxValue;

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative Set MaxValue test.")]
        public void MaxValue_SetInCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var parameter =
                new Parameter(1, 1, 5);
            var message =
                "Это исключение выбрасывается, "
                + "если значение выходит из диапазона допустимых значений";
            var equalValue = 5d;

            //Assert
            Assert.Multiple(() =>
            {
                // Act
                Assert.Throws<ArgumentException>(() =>
                {
                    parameter.MinValue = equalValue;
                    parameter.MaxValue = equalValue;
                },
                message);
            });
        }
    }

}
