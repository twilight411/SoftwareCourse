namespace GeometricShapes;

/// <summary>圆形：半径为属性，须大于 0。</summary>
public class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override bool IsValid => Radius > 0;

    public override double Area => IsValid ? Math.PI * Radius * Radius : 0;
}
