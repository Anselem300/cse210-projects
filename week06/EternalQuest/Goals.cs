public abstract class Goals {
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goals(string shortName, string description, int points) {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string ShortName(){
        return _shortName;
    }
    public abstract void RecordEvent(GoalManager manager);

    public abstract bool IsComplete();

    public virtual string GetDetailedString() {
        return $"[{(IsComplete() ? "X": " ")}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}