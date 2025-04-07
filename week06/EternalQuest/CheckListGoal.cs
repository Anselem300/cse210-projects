public class CheckListGoal : Goals {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string shortName, string description, int points, int target, int bonus) : 
    base(shortName, description, points) {

    }
    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetDetailedString() {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}