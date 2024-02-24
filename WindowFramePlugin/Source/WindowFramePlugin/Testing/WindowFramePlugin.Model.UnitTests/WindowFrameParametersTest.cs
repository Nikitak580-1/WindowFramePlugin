namespace WindowFramePlugin.UnitTests
{
    using WindowFramePlugin.Model;
    using NUnit.Framework;
    using System;
    using System.Security.Cryptography;
    using NUnit.Framework.Legacy;

    [TestFixture]
    public class WindowFrameParametersTest
    {
        [Test(Description = "Positive Set Parameter Value test.")]
        public void SetParameterValue_GetCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var windowFrameParameters = new WindowFrameParameters();

            //Act
            var expectedWindowFrameLenghtW1 =
                windowFrameParameters.GetParameterValue(
                    ParameterType.WindowFrameLenghtW1);
            var expectedWindowFrameHeightH2 =
                windowFrameParameters.GetParameterValue(
                    ParameterType.WindowFrameHeightH2);
            var expectedTotalWidthWindowFrameTh =
                windowFrameParameters.GetParameterValue(
                    ParameterType.TotalWidthWindowFrameTh);
            var expectedTotalWidthWindowSashesTm =
                windowFrameParameters.GetParameterValue(
                    ParameterType.TotalWidthWindowSashesTm);
            var expectedTotalHeightWindowSashG2 =
                windowFrameParameters.GetParameterValue(
                    ParameterType.TotalHeightWindowSashG2);
            var expectedLengthPartitionWindowFrameL3 =
                windowFrameParameters.GetParameterValue(
                    ParameterType.LengthPartitionWindowFrameL3);

            windowFrameParameters.SetParameterValue(
                ParameterType.WindowFrameLenghtW1, expectedWindowFrameLenghtW1);
            windowFrameParameters.SetParameterValue(
                ParameterType.WindowFrameHeightH2, expectedWindowFrameHeightH2);
            windowFrameParameters.SetParameterValue(
                ParameterType.TotalWidthWindowFrameTh, expectedTotalWidthWindowFrameTh);
            windowFrameParameters.SetParameterValue(
                ParameterType.TotalWidthWindowSashesTm, expectedTotalWidthWindowSashesTm);
            windowFrameParameters.SetParameterValue(
                ParameterType.TotalHeightWindowSashG2, expectedTotalHeightWindowSashG2);
            windowFrameParameters.SetParameterValue(
                ParameterType.LengthPartitionWindowFrameL3, expectedLengthPartitionWindowFrameL3);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(
                    windowFrameParameters.GetParameterValue(
                        ParameterType.WindowFrameLenghtW1),
                    Is.EqualTo(expectedWindowFrameLenghtW1));
                Assert.That(
                    windowFrameParameters.GetParameterValue(
                        ParameterType.WindowFrameHeightH2),
                    Is.EqualTo(expectedWindowFrameHeightH2));
                Assert.That(
                    windowFrameParameters.GetParameterValue(
                        ParameterType.TotalWidthWindowFrameTh),
                    Is.EqualTo(expectedTotalWidthWindowFrameTh));
                Assert.That(
                    windowFrameParameters.GetParameterValue(
                        ParameterType.TotalWidthWindowSashesTm),
                    Is.EqualTo(expectedTotalWidthWindowSashesTm));
                Assert.That(
                    windowFrameParameters.GetParameterValue(
                        ParameterType.TotalHeightWindowSashG2),
                    Is.EqualTo(expectedTotalHeightWindowSashG2));
                Assert.That(
                    windowFrameParameters.GetParameterValue(
                        ParameterType.LengthPartitionWindowFrameL3),
                    Is.EqualTo(expectedLengthPartitionWindowFrameL3));
            });
        }

        [Test(Description = "Negative Set Parameter Value test.")]
        public void SetParameterValue_GetInCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var windowFrameParameters = new WindowFrameParameters();
            var message =
                "Это исключение выбрасывается,"
                + " если значение выходит из диапазона допустимых значений";
            var wrongdValue = 0;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.Throws<ArgumentException>(() =>
                {
                    windowFrameParameters.SetParameterValue(
                        ParameterType.WindowFrameLenghtW1,
                        wrongdValue);
                },
                message);
                Assert.Throws<ArgumentException>(() =>
                {
                    windowFrameParameters.SetParameterValue(
                        ParameterType.WindowFrameHeightH2,
                        wrongdValue);
                },
                message);
                Assert.Throws<ArgumentException>(() =>
                {
                    windowFrameParameters.SetParameterValue(
                        ParameterType.TotalWidthWindowFrameTh,
                        wrongdValue);
                },
                message);
                Assert.Throws<ArgumentException>(() =>
                {
                    windowFrameParameters.SetParameterValue(
                        ParameterType.TotalWidthWindowFrameTh,
                        10);

                    windowFrameParameters.SetParameterValue(
                        ParameterType.TotalWidthWindowSashesTm,
                        6);

                    windowFrameParameters.SetParameterValue(
                        ParameterType.TotalWidthWindowFrameTh,
                        5);
                },
                message);
                Assert.Throws<ArgumentException>(() =>
                {
                    windowFrameParameters.SetParameterValue(
                        ParameterType.TotalWidthWindowSashesTm,
                        4);

                    windowFrameParameters.SetParameterValue(
                        ParameterType.TotalWidthWindowFrameTh,
                        5);

                    windowFrameParameters.SetParameterValue(
                        ParameterType.TotalWidthWindowSashesTm,
                        6);
                },
                message);
                Assert.Throws<ArgumentException>(() =>
                {
                    windowFrameParameters.SetParameterValue(
                        ParameterType.TotalWidthWindowSashesTm,
                        wrongdValue);
                },
                message);
                Assert.Throws<ArgumentException>(() =>
                {
                    windowFrameParameters.SetParameterValue(
                        ParameterType.TotalHeightWindowSashG2,
                        wrongdValue);
                },
                message);
                Assert.Throws<ArgumentException>(() =>
                {
                    windowFrameParameters.SetParameterValue(
                        ParameterType.LengthPartitionWindowFrameL3,
                        wrongdValue);
                },
                message);
            });
        }

        [Test(Description = "Positive Get Parameter Value test.")]
        public void GetParameterValue_GetCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var windowFrameParameters = new WindowFrameParameters();
            var correctValue = 50d;
            var expected = correctValue;

            //Act
            windowFrameParameters.SetParameterValue(
                ParameterType.WindowFrameLenghtW1, correctValue);
            var actual =
                windowFrameParameters.GetParameterValue(ParameterType.WindowFrameLenghtW1);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Positive Get Parameter MinValue test.")]
        public void GetParameterMinValue_GetCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var windowFrameParameters = new WindowFrameParameters();
            var correctValue = 5d;
            var expected = correctValue;

            //Act
            windowFrameParameters.SetParameterValue(
                ParameterType.WindowFrameLenghtW1, 50d);
            var actual =
                windowFrameParameters.GetParameterMinValue(
                    ParameterType.TotalHeightWindowSashG2);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Positive Get Parameter MaxValue test.")]
        public void GetParameterMaxValue_GetCorrectValue_ReturnsSameValue()
        {
            //Arrange
            var windowFrameParameters = new WindowFrameParameters();
            var correctValue = 7.69d;
            var expected = correctValue;

            //Act
            windowFrameParameters.SetParameterValue(
                ParameterType.WindowFrameLenghtW1, 50d);
            var actual =
                windowFrameParameters.GetParameterMaxValue(
                    ParameterType.TotalHeightWindowSashG2);

            //Assert
            ClassicAssert.AreEqual(expected, actual);
        }
    }
}