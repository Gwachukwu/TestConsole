namespace DesignPatterns.Observer;

using DesignPatterns.Observer.interfaces;

public class LowerCaseObserver : IObserver<string>
{
    public void Update(string param)
    {
        Console.WriteLine(param.ToLower());
    }
}