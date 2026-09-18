namespace dsBackup
{
    public static class ScheduleHelper
    {
        public static string SecToHrs(int seconds)
        {
            int s = seconds % 60;
            int min = seconds / 60;
            int m = min % 60;
            int h = min / 60;
            return $"{h:00}:{m:00}:{s:00}";
        }

        public static int ToSeconds(decimal value, string unit)
        {
            return unit == "Hrs"
                ? Convert.ToInt32(value * 60 * 60)
                : Convert.ToInt32(value * 60);
        }
    }
}
