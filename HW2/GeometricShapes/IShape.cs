namespace GeometricShapes;

/// <summary>
/// 图形契约：可计算面积，并可判断尺寸是否合法（如边长、半径大于 0）。
/// </summary>
public interface IShape
{
    /// <summary>图形面积；若图形不合法，实现中可约定为 0。</summary>
    double Area { get; }

    /// <summary>尺寸是否合法。</summary>
    bool IsValid { get; }
}
