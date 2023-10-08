using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
        public List<Entry> _entries = new List<Entry>();


        public void AddEntry(Entry entry) {
            _entries.Add(entry);
        }

        public void DisplayEntries()
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine(entry.Display());
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries) //I do this because this is working similar to DisplayEntries, just this time we are not displaying but saving to a file 
                {
                    outputFile.WriteLine(entry.Display());
                }
            }
                        
        }

        public void LoadFile(string filename)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
            }

        }

}