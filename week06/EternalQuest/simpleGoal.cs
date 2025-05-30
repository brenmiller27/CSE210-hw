using System;

public class SimpleGoal : Goal 

{
    private string _goalType = "Simple";

    private bool _goalcomplete;

    private int _goalPoints;

    public simpleGoal()
    {
        
    }

    public simpleGoal(string goalName, string goalDescription, int goalPoints, bool goalComplete) : base(goalName, goalDescription)
    
    {
    _goalComplete = goalComplete;
    _goalPoints = goalPoints;
    }


    public override void DisplayGoalPoints()
    {
        Console.Write("How many points is this goal worth? ");
        _goalPoints = int.Parse(Console.ReadLine());
        return;
    }
    public override int GetGoalPoints()
    {
        return _goalPoints;
    }
    
    public override bool GetGoalStatus()
    {
        return _goalComplete;
    }

    public override string ToCSVRecord()
    {
        return $"{_goalType}|{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}|{_goalComplete}";
    }

    public override string ToString()
    {
        return $"[{((_goalComplete == false) ? " " : "x")}] {GetGoalName()} ({GetGoalDescription()})";
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
        _goalComplete = true;
    }


}