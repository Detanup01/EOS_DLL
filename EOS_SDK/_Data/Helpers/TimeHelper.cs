namespace EOS_SDK._Data
{
    public class TimeHelper
    {
        public static int GetEpochTime(DateTime time)
        {
            TimeSpan t = time - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            int secondsSinceEpoch = (int)t.TotalSeconds;
            return secondsSinceEpoch;
        }

        public static long ConvertTimeFrom(DateTimeOffset? from)
        {
            long to = -1;

            if (from.HasValue)
            {
                DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                long unixTimestampTicks = (from.Value.UtcDateTime - unixStart).Ticks;
                long unixTimestampSeconds = unixTimestampTicks / TimeSpan.TicksPerSecond;
                to = unixTimestampSeconds;
            }
            return to;
        }

        public static DateTimeOffset? ConvertTimeTo(long from)
        {
            DateTimeOffset? to = null;

            if (from >= 0)
            {
                DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                long unixTimeStampTicks = from * TimeSpan.TicksPerSecond;
                to = new DateTimeOffset(unixStart.Ticks + unixTimeStampTicks, TimeSpan.Zero);
            }
            return to;
        }
    }
}
