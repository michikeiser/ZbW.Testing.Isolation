namespace ZbW.Testing.Isolation.Lib.UnitTests
{
    using System;

    using NUnit.Framework;

    using ZbW.Testing.Isolation.Lib.Fakes;

    [TestFixture]
    public class FileNameGeneratorTests
    {
        private const string SAMPLE_FILENAME = "Testdatei";

        private const string SAMPLE_EXTENSION = "zbw";

        [Test]
        public void Generate_CheckConcatination_ReturnCorrectFileName()
        {
            // arrange
            var fileNameGenerator = new FileNameGenerator();
            var sampleDate = new DateTime(1990, 12, 31, 23, 59, 59);

            var dateTimeGeneratorStub = new DateTimeGeneratorStub(sampleDate);

            // act
            var result = fileNameGenerator.Generate(dateTimeGeneratorStub, SAMPLE_FILENAME, SAMPLE_EXTENSION);

            // assert
            var expectedResult = "Testdatei19901231235959.zbw";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Generate_CheckDependency_CurrentDateTimeCalled()
        {
            // arrange
            var fileNameGenerator = new FileNameGenerator();
            var dateTimeGeneratorMock = new DateTimeGeneratorMock();

            // act
            fileNameGenerator.Generate(dateTimeGeneratorMock, SAMPLE_FILENAME, SAMPLE_EXTENSION);

            // assert
            Assert.That(dateTimeGeneratorMock.CurrentDateTimeCalled, Is.True);
        }
    }
}