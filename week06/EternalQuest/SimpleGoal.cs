public class SimpleGoal : Goals {
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
       _isComplete = false;
    }
    public override void RecordEvent(GoalManager manager) {
        if (!_isComplete) {
            _isComplete = true;
           manager.AddPoints(_points);
        }
    }

    public override bool IsComplete()
    {
       return _isComplete;
    }

    public void SetIsComplete(bool value) {
        _isComplete = value;
    }


    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}