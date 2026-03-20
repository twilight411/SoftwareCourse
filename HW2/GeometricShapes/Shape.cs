namespace GeometricShapes;

/// <summary>
/// 抽象图形基类，统一实现 <see cref="IShape"/>，由具体图形提供面积与合法性规则。
/// </summary>
public abstract class Shape : IShape
{
    public abstract double Area { get; }

    public abstract bool IsValid { get; }
}
