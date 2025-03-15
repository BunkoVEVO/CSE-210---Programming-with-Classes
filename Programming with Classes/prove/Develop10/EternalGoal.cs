class EternalGoal : Goal
{
    private int count = 0;

    public EternalGoal(string name, int points) : base(name, points) {}

    public override void RecordEvent()
    {
        count++;
        Console.WriteLine($"Recorded {name} {count} time(s). Earned {points} points.");
    }

    public override string GetStatus()
    {
        return $"[ ] {name} - Completed {count} times";
    }
}
