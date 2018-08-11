namespace ZbW.Testing.Isolation.Lib.Fakes
{
    using System;

    public class DateTimeGeneratorMock : IDateTimeGenerator
    {
        public bool CurrentDateTimeCalled { get; set; }

        public DateTime CurrentDateTime()
        {
            CurrentDateTimeCalled = true;
            return default(DateTime);
        }
    }
}