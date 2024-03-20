namespace TestConsole.Classes;

public class TestGeneric<T>
{
    public T X;
    public TestGeneric(T param)
    {
        X = param;
    }
    public string? GetString()
    {
        return X?.ToString();
    }
}