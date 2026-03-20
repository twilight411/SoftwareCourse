namespace GeometricShapes;

/// <summary>正方形：继承长方形，边长相等的特例。</summary>
public class Square : Rectangle
{
    public double Side => Width;

    public Square(double side)
        : base(side, side)
    {
    }
}
