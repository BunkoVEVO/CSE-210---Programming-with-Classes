class Program
{
    static void Main(string[] args)
    {
        // Create different types of goals
        Goal marathonGoal = new SimpleGoal("Run a Marathon", 1000);
        Goal scriptureGoal = new EternalGoal("Read Scriptures", 100);
        Goal templeGoal = new ChecklistGoal("Attend the Temple", 50, 10, 500);

        // Record events
        marathonGoal.RecordEvent();
        scriptureGoal.RecordEvent();
        templeGoal.RecordEvent();
        templeGoal.RecordEvent();
        
        // Display status of goals
        Console.WriteLine(marathonGoal.GetStatus());
        Console.WriteLine(scriptureGoal.GetStatus());
        Console.WriteLine(templeGoal.GetStatus());
    }
}
