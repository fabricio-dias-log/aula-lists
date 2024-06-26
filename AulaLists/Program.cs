namespace AulaLists;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        
        list.Add("Fabricio");
        list.Add("João");
        list.Add("Linux");
        list.Add("Windows");
        
        list.Insert(2, "Ana"); // insere o item de acordo com a posição 

        foreach (var obj in list)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine($"list count: {list.Count}");
    }
}
