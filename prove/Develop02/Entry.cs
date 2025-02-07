using System;

public class Entry
{
    public string _prompt;
    public string _response;
    public DateTime _date;
    public override string ToString()
    {
        return $"Date: {_date} - Prompt: {_prompt} \n{_response}";
    }
}