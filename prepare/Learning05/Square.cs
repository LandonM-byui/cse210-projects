public class Square : Shape
{
    private float _side;

    public Square(string color, float side1) : base(color)
    {
        _side = side1;
    }

    public override float GetArea()
    {
        return _side * _side;
    }
}