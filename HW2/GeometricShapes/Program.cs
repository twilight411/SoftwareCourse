using System.Text;
using GeometricShapes;

Console.OutputEncoding = Encoding.UTF8;

var random = Random.Shared;
var shapes = new List<IShape>(capacity: 10);

for (int i = 0; i < 10; i++)
{
    IShape shape = CreateRandomShape(random);
    shapes.Add(shape);
    Console.WriteLine($"{i + 1,2}. {Describe(shape)} — 合法: {shape.IsValid}, 面积: {shape.Area:F4}");
}

double totalArea = shapes.Sum(s => s.Area);
Console.WriteLine();
Console.WriteLine($"10 个图形面积之和: {totalArea:F4}");

static IShape CreateRandomShape(Random random)
{
    return random.Next(3) switch
    {
        0 => new Rectangle(NextPositive(random), NextPositive(random)),
        1 => new Square(NextPositive(random)),
        _ => new Circle(NextPositive(random)),
    };
}

/// <summary>生成 (1, 10] 内的正实数，保留两位小数。</summary>
static double NextPositive(Random random)
{
    return Math.Round(random.NextDouble() * 9 + 1, 2);
}

static string Describe(IShape shape)
{
    return shape switch
    {
        Square sq => $"正方形 边长={sq.Side:F2}",
        Rectangle r => $"长方形 宽={r.Width:F2} 高={r.Height:F2}",
        Circle c => $"圆形 半径={c.Radius:F2}",
        _ => shape.GetType().Name,
    };
}
