public class Fraction
{
    private int _numerator;
    private int _denomenator;

    public Fraction()
    {
        _numerator = 1;
        _denomenator = 1;
    }
    public Fraction(int num)
    {
        _numerator = num;
        _denomenator = 1;
    }
    public Fraction(int n, int d)
    {
        _numerator = n;
        SetFractionD(d);
    }
    public void SetFractionN(int num)
    {
        _numerator = num;
    }

    public void SetFractionD(int num)
    {
        if (num != 0)
        {
            _denomenator = num;
        }
        else
        {
            _denomenator = 1;
        }
    }

    public int GetNumerator()
    {
        return _numerator;
    }
    public int GetDenomenator()
    {
        return _denomenator;
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denomenator}";
    }
    public double GetDecimalValue()
    {
        double decimalVal = (double) _numerator / (double) _denomenator;
        return decimalVal;
    }
}