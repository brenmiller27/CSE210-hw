using System;

public class Domain {
    private string _reference;
    private string _scripture;

    public Domain()

    {
        _reference = "Unknown";
        _scripture = "Unknown";
    }

    public Domain(string referencetoinput) 
    {
       _reference = referencetoinput;
       _scripture = "";

    }

     public Domain(string referencetoinput, string scripturetoinput) 
    {
       _reference = referencetoinput;
       _scripture = scripturetoinput;

    }


    public string CompletePhase()
    {
        string phrase = _reference + " " + _scripture;
        return phrase;

    }



}