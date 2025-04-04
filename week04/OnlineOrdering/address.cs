using System;


public class Address {

    private string _streetaddress {get ; set ;}
    private string _city {get ; set ;}
    private string _state {get ; set ;}

    private string _country {get ; set ;}


    public Address (string streetaddress, string city, string state, string country)

    {
        _streetaddress = streetaddress;

        _city = city;

        _state = state;

        _country = country;


    }


    public void SetCountry(string country)

    {
         _country = country;

    }

    public string GetCountry()

    {
        return _country;
    }


    public string GetAddress()

    {
        return $"{_streetaddress} {_city} , {_state} , {_country}";
    }

    


}