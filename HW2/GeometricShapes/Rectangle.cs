namespace GeometricShapes;

/// <summary>长方形：宽、高为属性，均须大于 0 才合法。</summary>
public class Rectangle : Shape
{
    public double Width { get; }

    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override bool IsValid => Width > 0 && Height > 0;

    public override double Area => IsValid ? Width * Height : 0;
}
