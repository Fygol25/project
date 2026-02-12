using System;

namespace project;

class Robot
{
    private string name;
    private short weight;
    private byte[] coordinate;

    public void SetValues(string name, short weight, byte[] coordinate)
    {
        this.name = name;
        this.weight = weight;
        this.coordinate = coordinate;
    }

    public void PrintValues()
    {
        Console.WriteLine($"Name:{name}, weight:{weight}, coordinate: ");
        foreach (byte el in coordinate)
        {
            Console.WriteLine(el);
        }
    }
}
