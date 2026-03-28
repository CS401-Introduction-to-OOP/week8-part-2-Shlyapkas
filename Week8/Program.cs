
class Program
{
    public static void Main()
    {
        var file = new FileResource("report.txt");
        var network = new NetworkResource("api.company.local");
        var manager = new ResourceManager<Resource>();
        manager.Add(file);
        manager.Add(network);
        
        manager.OpenAll();
        
        using(var res = new FileResource("file"))
        {
            res.Open();
        }
        
        manager.CloseAll();
        Console.WriteLine("Done.");
    }
    
}