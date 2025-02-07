using System;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>()
    {
        "What did I have for breakfast today?",
        "What is my favorite color? Why?",
        "What is one thing I wish I could've done better today?",
        "What success, no matter how small, did I have today?",
        "What am I going to do better tomorrow?",
    };

    public void WriteNewEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        entries.Add(new Entry {_prompt = prompt, _response = response, _date = DateTime.Now});
    }
    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
    public void SaveToFile()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._prompt);
                writer.WriteLine(entry._response);
                writer.WriteLine(""); //for blank space!
            }
        }
    }
    public void LoadFromFile()
    {
        Console.Write("Enter filename to Load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < lines.Length; i += 4)
            {
                if (i + 2 < lines.Length)
                {
                    entries.Add(new Entry
                    {
                        _date = DateTime.Parse(lines[1]),
                        _prompt = lines[i+1],
                        _response = lines[i + 2]
                    });
                }
            }
        }
        else
        {
            Console.Write("File not found.");
        }
    }
}