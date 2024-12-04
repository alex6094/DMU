namespace TemplateMVC.Models;

public static class Repository
{
    private static List<InputResponse> _responses = new();

    public static IEnumerable<InputResponse> Responses => _responses;

    public static void AddResponse(InputResponse response)
    {
        Console.WriteLine(response);
        _responses.Add(response);
    }
    
    

}