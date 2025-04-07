public class EternalGoal : Goals {

    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        
    }
    public override void RecordEvent(GoalManager manager)
    {
        manager.AddPoints(_points);
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}