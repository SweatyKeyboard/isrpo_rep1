abstract class a_Shape
{
    protected string _name;
    protected double _square;
    protected double _perimeter;

    public a_Shape()
    {
        _name = "Без названия";
        _square = 0;
        _perimeter = 0;
    }

    public string Show()
    {
        return $"{_name} (square: {_square}, perimeter: {_perimeter})";
    }
}
