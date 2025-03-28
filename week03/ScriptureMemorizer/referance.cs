using System;

public class Reference
{
        private string _book;
    private string _chapter;
    private string _verse;

    private string _verse2;

   
    public Reference(){
        //Default values
        _book = "Unknown";
        _chapter = "Undefined";
        _verse = "Undefined";
        _verse2 = "n";
    }

        public Reference(string bookToInput)
    {
        
        //ex Fraction(Juan) is the same like "Juan 1-1"
        _book = bookToInput;
        _chapter = "1"; 
        _verse = "1"; 
        _verse2 = "n";
    }

   
    public Reference(string bookToInput,string chapterToInput)
    {
        
        //ex Fraction(Juan, 1) is the same like "Juan 1-1"
        _book = bookToInput;
        _chapter = chapterToInput;
        _verse = "1"; //Authomatic assigment
        _verse2 = "n";
    }
    
    
    public Reference(string bookToInput, string chapterToInput, string verseToInput){
        
       
        _book = bookToInput;
        _chapter = chapterToInput;
        _verse = verseToInput;
        _verse2 = "n";

    }
    
    public Reference(string bookToInput, string chapterToInput, string verseToInput, string verseToEnd){
        
    
        _book = bookToInput;
        _chapter = chapterToInput;
        _verse = verseToInput;
        _verse2 = verseToEnd;

    }
       public string GetBook(){
     
        return _book;
    }
    public void SetBook(string bookSetted){
        
        _book = bookSetted; 
    }
    public string GetChapter(){
       
        return _chapter;
    }
    public void SetChapter(string chapterSetted){
       
        _chapter = chapterSetted; 
    }    public string GetVerse(){
       
        return _verse;
    }
    public void SetVerse(string verseSetted){
        
        _verse = verseSetted; 
    }
public string GetVerseToEnd(){
        
        return _verse2;
    }
    public void SetVerseToEnd(string verseToEndSetted){
        
        _verse = verseToEndSetted; 
    }    //--------------------- Getter & Setter section - end ----------------

    //--------------------- Methods (functions) --------------------------
    public string GetCompleteReference()
    {
        if (_verse2 == "n")
        {
        //Print the string (ex. return "Juan 1:1")
        string completeReference = $"{_book} {_chapter}:{_verse}";
        return completeReference;
        }
        else{
        //Print the string (ex. return "Juan 1:1-5")
        string completeReference = $"{_book} {_chapter}:{_verse}-{_verse2}";
        return completeReference;

        }
        
    }
}