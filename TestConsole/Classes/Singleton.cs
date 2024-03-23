namespace TestConsole.Classes;

public class Singleton<T> where T : new()
{
    private static T? _instance;
    public T GetInstance()
    {
        if (_instance is not null)
        {
            return _instance;
        }
        _instance = new();
        return _instance;
    }
}