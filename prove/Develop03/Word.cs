using System;
using System.Collections.Generic;

class Word
{
    private string _word;   //This is the actual word
    private bool _isHidden; //This holds the state of the word, hidden or shown.

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    
    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetWord()
    {
        string word = _word;
        if (_isHidden == false)
        {
            return word;
        }
        else
        {
            word = string.Concat(Enumerable.Repeat("_", _word.Length));
            return word;
        }
    }
}