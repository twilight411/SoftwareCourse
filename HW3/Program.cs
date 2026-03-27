using System.Text;
using System.Timers;

Console.OutputEncoding = Encoding.UTF8;

DateTime targetTime = ReadAlarmTimeFromUser();

var myClock = new AlarmClock(targetTime);
myClock.Tick += MyClock_Tick;
myClock.Alarm += MyClock_Alarm;

myClock.Start();
Console.WriteLine($"闹钟已启动，响铃时间：{targetTime:yyyy-MM-dd HH:mm:ss}");
Console.WriteLine("响铃前会持续嘀嗒；响铃后按任意键退出…");
Console.ReadKey();

static DateTime ReadAlarmTimeFromUser()
{
    while (true)
    {
        Console.WriteLine("请输入闹钟响铃时间（格式 HH:mm:ss，而且是英文冒号， 例如 14:30:00）：");
        string? line = Console.ReadLine();

        // 用户才是最大的问题：空输入、乱格式、乱字符都要挡在外面，否则后面全乱套。
        if (string.IsNullOrWhiteSpace(line))
        {
            Console.WriteLine("输入不能为空，请重新输入。");
            continue;
        }

        if (!TimeSpan.TryParse(line.Trim(), out TimeSpan timeOfDay))
        {
            Console.WriteLine("格式不对，请按 HH:mm:ss 输入（如 09:05:00）。");
            continue;
        }

        DateTime target = DateTime.Today.Add(timeOfDay);
        if (target <= DateTime.Now)
        {
            target = target.AddDays(1);
        }

        return target;
    }
}

static void MyClock_Tick(object? sender, ClockEventArgs e)
{
    Console.WriteLine($"[嘀嗒] {e.NowTime:HH:mm:ss}");
}

static void MyClock_Alarm(object? sender, ClockEventArgs e)
{
    Console.WriteLine();
    Console.WriteLine($"【响铃！】{e.NowTime:HH:mm:ss} 时间到！");
}

public class ClockEventArgs : EventArgs
{
    public DateTime NowTime { get; }

    public ClockEventArgs(DateTime time)
    {
        NowTime = time;
    }
}

public delegate void TickEventHandler(object sender, ClockEventArgs e);

public delegate void AlarmEventHandler(object sender, ClockEventArgs e);

public class AlarmClock
{
    public event TickEventHandler? Tick;
    public event AlarmEventHandler? Alarm;

    private readonly System.Timers.Timer _timer;
    private readonly DateTime _targetTime;

    public AlarmClock(DateTime targetTime)
    {
        _targetTime = targetTime;
        _timer = new System.Timers.Timer(1000);
        _timer.Elapsed += Timer_Elapsed;
    }

    private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
    {
        DateTime now = DateTime.Now;
        OnTick(new ClockEventArgs(now));

        if (now >= _targetTime)
        {
            OnAlarm(new ClockEventArgs(now));
            _timer.Stop();
        }
    }

    protected virtual void OnTick(ClockEventArgs e)
    {
        Tick?.Invoke(this, e);
    }

    protected virtual void OnAlarm(ClockEventArgs e)
    {
        Alarm?.Invoke(this, e);
    }

    public void Start()
    {
        _timer.Start();
    }
}
