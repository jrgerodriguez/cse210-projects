using System;

public class Entry
{
    public string _prompt;
    public string _date;  
    public string _answer;
    public string _scripture;

    public string Display() {
        string _entry = $"> Date: {_date}\n- You read this scripture today: {_scripture}\n- Prompt: {_prompt} \n- Your answer: {_answer}";
        return _entry;       
    }

}