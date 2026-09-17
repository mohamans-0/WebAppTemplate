namespace WebAppTemplate.Extensions
{
    public static class DateTimeExtension
    {
        public static int ToAge(this DateTime DOB)
        {
            return DateTime.Now.Year - DOB.Year;
        }
    }
}
