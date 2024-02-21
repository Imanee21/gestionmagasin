using System.Collections.Generic;



public class ApiResponse
{
    public bool error { get; set; }
    public string msg { get; set; }
    public List<Country> data { get; set; }
}



public class Country
{
    public string iso2 { get; set; }
    public string iso3 { get; set; }
    public string country { get; set; }
    public List<string> cities { get; set; }
}