using System;
internal class Angle
{
    private int _degrees;
    private float _minutes;
    private char _direction;

    public Angle()
    {
        _degrees = 0;
        _minutes = 0;
        _direction = 'S';
    }

    public Angle(int degrees, float minutes, char direction)
    {
        _degrees = degrees;
        _minutes = minutes;
        _direction = direction;
    }

    public void SetCoordinates()
    {
        Console.Write("Input degrees: ");
        _degrees = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input minutes: ");
        _minutes = float.Parse(Console.ReadLine());
        Console.Write("Input direction (N, E, S, W): ");
        _direction = Console.ReadLine()[0];
    }

    public string GetString()
    {
        return $"{_degrees}° {_minutes}' ({_direction})";
    }
}