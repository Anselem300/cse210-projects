public class EternalGoal : Goals {

    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        
    }
    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}