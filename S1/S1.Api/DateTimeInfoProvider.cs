namespace S1.Api
{
    public class DateTimeInfoProvider : IMessageProvider
    {
        public string GetMessage()
        {
            return $"The current date and time is: {DateTime.Now}";
        }
    }
}
