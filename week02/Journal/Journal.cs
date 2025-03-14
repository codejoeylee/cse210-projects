using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string file)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(_entries, options);
        File.WriteAllText(file, json);
    }

    public void LoadFromFile(string file)
    {
        try
        {
            string json = File.ReadAllText(file);
            _entries = JsonSerializer.Deserialize<List<Entry>>(json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }

}