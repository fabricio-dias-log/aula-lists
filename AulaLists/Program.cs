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

        //Lógica em método
        string s1 = list.Find(FirstA); //espera um predicado ou lógica como parametro para encontrar item
        Console.WriteLine($"Primeiro com a letra 'A': {s1}");
        
        //expressão lâmbida
        string s2 = list.Find(x => x[0] == 'A'); //espera um predicado ou lógica como parametro para encontrar item
        Console.WriteLine($"Primeiro com a letra 'A': {s1}");

        string s3 = list.FindLast(x => x[0] == 'A'); //retorna ultimo item de acordo com a lógica
        Console.WriteLine($"Último com a letra 'A': {s1}");
    }

    static bool FirstA(string list)
    {
        return list[0] == 'A';
    }
}
