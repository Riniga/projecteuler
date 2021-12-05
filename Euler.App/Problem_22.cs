using Euler.Library;
using System;
using System.Linq;

internal class Problem_22 : ProblemBase
{
    string NamesFromFile = File.ReadAllText("p022_names.txt");

    long result = 0;
    public Problem_22()
    {
        title = "Problem 22 - Names scores";
        description = "Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.";
        question = "What is the total of all the name scores in the file?";
    }
    public override void Solve()
    {
        var names = NamesFromFile.Replace("\"","").Split(',');
        //string[] temp = new string[] {"Olof","Nils","Jenny","Adam"};


        //Size("COLIN");
        
        Sort(names);
        var pos = 1;
        foreach (var name in names)
        {
            result += Score(name, pos);
            //if (name == "COLIN") Console.WriteLine($"{name} ({Size(name)},{pos}): {Score(name, pos)}");
            pos++;
        }



    }

    private int Size(string text)
    {
        int result = 0;
        foreach (var c in text)
        {
            result += c - 64;
        }
        return result;
    }
    private int Score(string text, int pos)
    {
        return Size(text)*pos;
    }

    private void Sort(string[] list)
    { 
        string [] result = new string[list.Length];
        for (int i = 0; i < list.Length; i++)
        {
            result[i] = list[i];
            var smallest = IndexOfSmallest(list, i);
            Swap(list, i, smallest);
        }
    }

    private void Swap(string[] list, int i, int j)
    { 
        var temp = list[i];
        list[i] = list[j];  
        list[j] = temp;
    }

    private int IndexOfSmallest(string[] list, int start)
    {
        var smallest = start;
        for (int i = start; i < list.Length; i++)
        {
            if (list[i] == Smallest(list[i], list[smallest])) smallest = i;
        }
        return smallest;
    }

    private string Smallest(string item1, string item2)
    {
        int compareLinguistic = String.Compare(item1, item2, StringComparison.InvariantCulture);

        if (compareLinguistic < 0) return item1;
        else return item2;
    }

    public override void DisplayResult()
    {
        DisplayResult($"The total of all the name scores in the file: {result}");
    }
}