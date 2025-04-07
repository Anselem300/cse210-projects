public class CheckListGoal : Goals {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string shortName, string description, int points, int target, int bonus) : 
    base(shortName, description, points) {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent(GoalManager manager)
    {
        if (_amountCompleted < _target) {
            _amountCompleted++;
            manager.AddPoints(_points);
            if (_amountCompleted == _target) {
                manager.AddPoints(_bonus);
            }
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailedString() {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}