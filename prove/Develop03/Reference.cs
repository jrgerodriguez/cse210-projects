using System;
using System.Collections.Generic;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _initialVerse;
    private int _finalVerse;

    public Reference(string book, int chapter, int initialVerse)
    {
        _book = book;
        _chapter = chapter;
        _initialVerse = initialVerse;
        _finalVerse = 0;
    }

    public Reference(string book, int chapter, int initialVerse, int finalVerse)
    {
        _book = book;
        _chapter = chapter;
        _initialVerse = initialVerse;
        _finalVerse = finalVerse;
    }

    public string GetReference()
    {

        if (_finalVerse == 0)
        {
            string text = $"{_book} {_chapter}:{_initialVerse}";
            return text;
        }
        else
        {            
            string text = $"{_book} {_chapter}:{_initialVerse}-{_finalVerse}";
            return text;
        }
    }
}

