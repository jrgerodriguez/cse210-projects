using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        
        string[] words = verse.Split(" ");
        foreach (string element in words)
        {
            Word word = new Word(element);
            _words.Add(word);
        }       
        
    }

    public void GetScripture() {
        Console.WriteLine(_reference.GetReference());
            foreach (Word word in _words)
        {
            Console.Write(word.GetWord() + " ");
        }

        Console.WriteLine();

    }

    public void HideWords() 
    {
        for (int i = 0; i < 3; i++)
        {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)        
        {
            if (word.IsHidden() == false)
            {
            visibleWords.Add(word);
            }
        }  
        if (visibleWords.Count != 0)
        {                              
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, visibleWords.Count);
            visibleWords[randomIndex].Hide();
        }        
        }  
    }

    public bool TotallyHidden() {
        
        int count = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == true)
            {
                count++;
            }
        }

        if (count == _words.Count)
        {
            return true;
        }
        else 
        {
            return false;
        }

    }

}