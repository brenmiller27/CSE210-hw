using System;

public class EternalGoal : Goal
{
    private string _goaltype = "Eternal";

    private int _goalPoints;

    private _timescomplete = 0;

    private bool _goalcomplete = false;

    public class Goal()

    {

    }

    public EternalGoal(string goalName, string goalDescription, string int goalPoints, int _timescomplete, bool _goalcomplete) : base(goalName, goalDescription)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalcomplete = _goalcomplete;
    }


    public int GetRunningTime()
    {
        return _timescomplete
    }

    public override void DisplayGoalPoints()
    {
        Console.Write("How Many points is the goal worth when you complete it?");
        goalPoints = int.Parse(Console.WriteLine());
        return;
    }

    public override int GetgoalPoints() 
    {
       return _goalPoints;
    }

      public override bool GetGoalStatus()
    {
        return _goalComplete;
    }

    public override string ToCSVRecord()
    {
        return $"{_goalType}|{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}|{GetRunningTotal()}|{_goalComplete}";
    }

    public override string ToString()
    {
        return $"[ ] {GetGoalName()} ({GetGoalDescription()}) - Completed {GetRunningTotal()} times";
    }

    public override void RecordEvent()
    {
        _timesCompleted += 1;
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
    }


}