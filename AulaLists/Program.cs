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

        foreach (var obj in list)
        {
            Console.WriteLine(obj);
        }
    }
}
