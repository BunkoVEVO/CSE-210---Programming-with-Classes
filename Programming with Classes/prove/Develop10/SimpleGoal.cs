class SimpleGoal : Goal
{
    private bool isCompleted = false;

    public SimpleGoal(string name, int points) : base(name, points) {}

    public override void RecordEvent()
    {
        if (!isCompleted)
        {
            isCompleted = true;
            Console.WriteLine($"{name} completed! You earned {points} points.");
        }
        else
        {
            Console.WriteLine($"{name} has already been completed.");
        }
    }

    public override string GetStatus()
    {
        return isCompleted ? $"[X] {name} - Completed" : $"[ ] {name}";
    }
}
