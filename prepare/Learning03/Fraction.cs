using System;

public class Fraction
{
    private int _topNum;
    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }
    public Fraction(int top)
    {
        _topNum = top;
        _bottomNum = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNum = top;
        _bottomNum = bottom;
    }

    public void SetTopNum(int top)
    {
        _topNum = top;
    }

    public void SetBottomNum(int bottom)
    {
        _bottomNum = bottom;
    }

    public int GetTopNum()
    {
        return _topNum;
    }

    public int GetBottomNum()
    {
        return _bottomNum;
    }

    public string GetFractionString()
    {
        string topstring = _topNum.ToString();
        string bottomstring = _bottomNum.ToString();
        string _fraction = topstring +"/"+bottomstring;
        return _fraction;
    }

    public double GetDecimalValue()
    {
        
        double _decimal = (double)_topNum / (double)_bottomNum;
        return _decimal;
    }
}