public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }
    public void SetColor(string str)
    {
        _color = str;
    }
    public string GetColor()
    {
        return _color;
    }

    public abstract float GetArea();
}