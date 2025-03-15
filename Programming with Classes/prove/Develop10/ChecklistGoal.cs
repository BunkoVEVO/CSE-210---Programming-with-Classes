class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
        : base(name, points)
    {
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        this.currentCount = 0;
    }

    public override void RecordEvent()
    {
        currentCount++;
        int earnedPoints = points;
        
        if (currentCount == targetCount)
        {
            earnedPoints += bonusPoints;
            Console.WriteLine($"Bonus achieved! You earned an additional {bonusPoints} points!");
        }

        Console.WriteLine($"Completed {name} {currentCount}/{targetCount} times. Earned {earnedPoints} points.");
    }

    public override string GetStatus()
    {
        return $"[ ] {name} - Completed {currentCount}/{targetCount} times";
    }
}
