using System;

public class Scripture {
    private string _phase;


    public Scripture(){

      _phase = "unknown";

    }

    public Scripture (string phasetoinput) 
    
    {
      _phase = phasetoinput;
    }
        public void setphase(string phasetoSet){
        
        _phase = phasetoSet;
    }

     public string GetCompleteScripture()
    {
       
        string phaseToReturn = _phase;
        
        return phaseToReturn;

    }
}