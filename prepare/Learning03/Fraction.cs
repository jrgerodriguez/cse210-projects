using System;

class Fraction {
    private int _top;
    private int _bottom;

    public Fraction() // if there is no parameters in Programs.cs this one will be used
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top) // if there is one parameters in Programs.cs this one will be used
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) // if there are no parameters in Programs.cs this one will be used
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFraction()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }


}