using System;

namespace Spark.Cores
{
    public interface ITimeExpressions
    {

    }

    /// <summary>Returns cron expression that fires every minute.</summary>
    public class Minutely : ITimeExpressions
    {
        public Minutely(int minute = 0)
        {

        }
        public override string ToString()
        {
            return "* * * * *";
        }
    }

    /// <summary>
    /// Returns cron expression that fires every hour at the minute, 0 is first.
    /// </summary>
    public class Hourly : ITimeExpressions
    {
        public int Minute { get; set; }
        public Hourly(int minute = 0)
        {
            Minute = minute < 0 ? 0 : (minute > 59 ? 59 : minute);
        }
        public override string ToString()
        {
            return string.Format("{0} * * * *", Minute);
        }
    }


    /// <summary>
    /// Returns cron expression that fires every day at 00:00 UTC.
    /// </summary>
    /// /// <summary>
    /// Returns cron expression that fires every day at the first minute of
    /// the specified hour in UTC.
    /// </summary>
    /// <param name="hour">The hour in which the schedule will be activated (0-23).</param>
    ///    /// <summary>
    /// Returns cron expression that fires every day at the specified hour and minute
    /// in UTC.
    /// </summary>
    /// <param name="hour">The hour in which the schedule will be activated (0-23).</param>
    /// <param name="minute">The minute in which the schedule will be activated (0-59).</param>
    public class Daily : ITimeExpressions
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

        public Daily(int hour = 0, int minute = 0)
        {
            Hour = hour < 0 ? 0 : (hour > 23 ? 23 : hour);
            Minute = minute < 0 ? 0 : (minute > 59 ? 59 : minute);
        }
        public override string ToString()
        {
            return string.Format("{0} {1} * * *", Minute, Hour);
        }
    }

    /// <summary>
    /// Returns cron expression that fires every week at Monday, 00:00 UTC.
    /// </summary>
    /// <summary>
    /// Returns cron expression that fires every week at 00:00 UTC of the specified
    /// day of the week.
    /// </summary>
    /// <param name="dayOfWeek">The day of week in which the schedule will be activated.</param>
    /// <summary>
    /// Returns cron expression that fires every week at the first minute
    /// of the specified day of week and hour in UTC.
    /// </summary>
    /// <param name="dayOfWeek">The day of week in which the schedule will be activated.</param>
    /// <param name="hour">The hour in which the schedule will be activated (0-23).</param>
    /// <summary>
    /// Returns cron expression that fires every week at the specified day
    /// of week, hour and minute in UTC.
    /// </summary>
    /// <param name="dayOfWeek">The day of week in which the schedule will be activated.</param>
    /// <param name="hour">The hour in which the schedule will be activated (0-23).</param>
    /// <param name="minute">The minute in which the schedule will be activated (0-59).</param>
    public class Weekly : ITimeExpressions
    {
        public DayOfWeek DayOfWeek { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }

        public Weekly(DayOfWeek dayOfWeek = DayOfWeek.Monday, int hour = 0, int minute = 0)
        {
            DayOfWeek = dayOfWeek;
            Hour = hour < 0 ? 0 : (hour > 23 ? 23 : hour);
            Minute = minute < 0 ? 0 : (minute > 59 ? 59 : minute);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} * * {2}", Minute, Hour, (int)DayOfWeek);
        }
    }

    /// <summary>
    /// Returns cron expression that fires every month at 00:00 UTC of the first
    /// day of month.
    /// </summary>
    /// <summary>
    /// Returns cron expression that fires every month at 00:00 UTC of the specified
    /// day of month.
    /// </summary>
    /// <param name="day">The day of month in which the schedule will be activated (1-31).</param>
    /// <summary>
    /// Returns cron expression that fires every month at the first minute of the
    /// specified day of month and hour in UTC.
    /// </summary>
    /// <param name="day">The day of month in which the schedule will be activated (1-31).</param>
    /// <param name="hour">The hour in which the schedule will be activated (0-23).</param>
    /// <summary>
    /// Returns cron expression that fires every month at the specified day of month,
    /// hour and minute in UTC.
    /// </summary>
    /// <param name="day">The day of month in which the schedule will be activated (1-31).</param>
    /// <param name="hour">The hour in which the schedule will be activated (0-23).</param>
    /// <param name="minute">The minute in which the schedule will be activated (0-59).</param>
    public class Monthly : ITimeExpressions
    {
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }

        public Monthly(int day = 1, int hour = 0, int minute = 0)
        {
            Day = day < 1 ? 1 : (day > 31 ? 31 : day);
            Hour = hour < 0 ? 0 : (hour > 23 ? 23 : hour);
            Minute = minute < 0 ? 0 : (minute > 59 ? 59 : minute);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} * *", Minute, Hour, Day);
        }
    }


    /// <summary>
    /// Returns cron expression that fires every year on Jan, 1st at 00:00 UTC.
    /// </summary>
    /// <summary>
    /// Returns cron expression that fires every year in the first day at 00:00 UTC
    /// of the specified month.
    /// </summary>
    /// <param name="month">The month in which the schedule will be activated (1-12).</param>
    /// <summary>
    /// Returns cron expression that fires every year at 00:00 UTC of the specified
    /// month and day of month.
    /// </summary>
    /// <param name="month">The month in which the schedule will be activated (1-12).</param>
    /// <param name="day">The day of month in which the schedule will be activated (1-31).</param>
    /// <summary>
    /// Returns cron expression that fires every year at the first minute of the
    /// specified month, day and hour in UTC.
    /// </summary>
    /// <param name="month">The month in which the schedule will be activated (1-12).</param>
    /// <param name="day">The day of month in which the schedule will be activated (1-31).</param>
    /// <param name="hour">The hour in which the schedule will be activated (0-23).</param>
    /// <summary>
    /// Returns cron expression that fires every year at the specified month, day,
    /// hour and minute in UTC.
    /// </summary>
    /// <param name="month">The month in which the schedule will be activated (1-12).</param>
    /// <param name="day">The day of month in which the schedule will be activated (1-31).</param>
    /// <param name="hour">The hour in which the schedule will be activated (0-23).</param>
    /// <param name="minute">The minute in which the schedule will be activated (0-59).</param>

    public class Yearly : ITimeExpressions
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }

        public Yearly(int month = 1, int day = 0, int hour = 0, int minute = 0)
        {
            Month = month < 1 ? 1 : (month > 12 ? 12 : month);
            Day = day < 1 ? 1 : (day > 31 ? 31 : day);
            Hour = hour < 0 ? 0 : (hour > 23 ? 23 : hour);
            Minute = minute < 0 ? 0 : (minute > 59 ? 59 : minute);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} *", Minute, Hour, Day, Month);
        }
    }

    /// <summary>
    /// Returns cron expression that never fires. Specifically 31st of February
    /// </summary>
    /// <returns></returns>
    public class Never : ITimeExpressions
    {
        public Never(int never = 0)
        {

        }
        public override string ToString()
        {
            return new Yearly(2, 31).ToString();
        }
    }

    /// <summary>
    /// Returns cron expression that fires every &lt;<paramref name="interval"></paramref>&gt; minutes.
    /// </summary>
    /// <param name="interval">The number of minutes to wait between every activation.</param>

    public class MinuteInterval : ITimeExpressions
    {
        public int Interval { get; set; }
        public MinuteInterval(int interval = 1)
        {
            if (Interval < 1) Interval = 1;
            Interval = interval;
        }
        public override string ToString()
        {
            return string.Format("*/{0} * * * *", Interval);
        }
    }

    /// <summary>
    /// Returns cron expression that fires every &lt;<paramref name="interval"></paramref>&gt; hours.
    /// </summary>
    /// <param name="interval">The number of hours to wait between every activation.</param>

    public class HourInterval : ITimeExpressions
    {
        public int Interval { get; set; }

        public HourInterval(int interval = 1)
        {
            if (Interval < 1) Interval = 1;
            Interval = interval;
        }
        public override string ToString()
        {
            return string.Format("0 */{0} * * *", Interval);
        }
    }

    /// <summary>
    /// Returns cron expression that fires every &lt;<paramref name="interval"></paramref>&gt; days.
    /// </summary>
    /// <param name="interval">The number of days to wait between every activation.</param>

    public class DayInterval : ITimeExpressions
    {
        public int Interval { get; set; }
        public DayInterval(int interval = 1)
        {
            if (Interval < 1) Interval = 1;
            Interval = interval;
        }
        public override string ToString()
        {
            return string.Format("0 0 */{0} * *", Interval);
        }
    }

    /// <summary>
    /// Returns cron expression that fires every &lt;<paramref name="interval"></paramref>&gt; months.
    /// </summary>
    /// <param name="interval">The number of months to wait between every activation.</param>

    public class MonthInterval : ITimeExpressions
    {
        public int Interval { get; set; }

        public MonthInterval(int interval = 1)
        {
            if (Interval < 1) Interval = 1;
            Interval = interval;
        }
        public override string ToString()
        {
            return string.Format("0 0 1 */{0} *", Interval);
        }
    }
}
