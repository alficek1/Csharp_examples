namespace S1.Api
{
    public class DateTimeInfoProvider : IMessageProvider
    {
        public string GetMessage()
        {
            return $"The current date and time is: {DateTime.Now}";
        }

        public int GetLuckyNumber()
        {
            return new Random().Next(1, 101); // Returns a random number between 1 and 100
        }
    }
}
