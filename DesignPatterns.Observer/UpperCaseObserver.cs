namespace DesignPatterns.Observer;

using DesignPatterns.Observer.interfaces;

public class UpperCaseObserver : IObserver<string>
{
    public void Update(string param)
    {
        Console.WriteLine(param.ToUpper());
    }
}