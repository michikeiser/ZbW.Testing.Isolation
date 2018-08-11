namespace ZbW.Testing.Isolation.Lib
{
    public class FileNameGenerator
    {
        private const string DATE_FORMAT = "yyyyMMddHHmmss";

        public string Generate(IDateTimeGenerator dateTimeGenerator, string name, string extension)
        {
            var currentDateTime = dateTimeGenerator.CurrentDateTime();
            var suffixString = currentDateTime.ToString(DATE_FORMAT);

            return $"{name}{suffixString}.{extension}";
        }
    }
}