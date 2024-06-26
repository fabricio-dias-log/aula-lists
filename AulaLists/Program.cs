namespace AulaLists;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        
        list.Add("Alex");
        list.Add("Fabricio");
        list.Add("João");
        list.Add("Linux");
        list.Add("Marcos");
        list.Add("Joana");
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
        Console.WriteLine($"Primeiro com a letra 'A'(Lâmbida): {s2}");

        string s3 = list.FindLast(x => x[0] == 'A'); //retorna ultimo item de acordo com a lógica
        Console.WriteLine($"Último com a letra 'A': {s3}");

        int pos1 = list.FindIndex(x => x[0] == 'A'); //retorna indice/posição do item de acordo com a lógica
        Console.WriteLine($"Primeira posição com a letra 'A': {pos1}");
        
        int pos2 = list.FindLastIndex(x => x[0] == 'A'); //retorna ultimo indice/posição do item de acordo com a lógica
        Console.WriteLine($"Última posição com a letra 'A': {pos2}");

        List<string> resultList = list.FindAll(x => x.Length == 5); // retorna todos os resultados de acordo com a lógica
        Console.WriteLine("------------------------------");
        Console.WriteLine("Lista de nomes com 5 letras:");
        foreach (var obj in resultList)
        {
            Console.WriteLine(obj);
        }
        
        Console.WriteLine("------------------------------");
        Console.WriteLine("Lista atualizada (Alex Removido)");
        list.Remove("Alex");
        foreach (var obj in list)
        {
            Console.WriteLine(obj);
        }

        list.RemoveAll(x => x[0] == 'M'); // remove todos os resultados de acordo com a lógica
        Console.WriteLine("------------------------------");
        Console.WriteLine("Lista atualizada (Sem nomes com letra M)");
        foreach (var obj in list)
        {
            Console.WriteLine(obj);
        }
        
        list.RemoveAt(2); // remove de acordo com o indice passado como parametro
        Console.WriteLine("------------------------------");
        Console.WriteLine("Lista atualizada (indice 2 removido)");
        foreach (var obj in list)
        {
            Console.WriteLine(obj);
        }
        
        list.RemoveRange(2, 2); // remove de acordo com o indice e contagem a partir do indice passado como parametro
        Console.WriteLine("------------------------------");
        Console.WriteLine("Lista atualizada (2 itens a partir indice 2 removido)");
        foreach (var obj in list)
        {
            Console.WriteLine(obj);
        }
    }

    static bool FirstA(string list)
    {
        return list[0] == 'A';
    }
}
