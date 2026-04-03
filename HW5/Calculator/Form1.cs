namespace Calculator;

public partial class Form1 : Form
{
    private string _left = "";
    private string _right = "";
    private char? _op;
    private bool _afterEquals;

    public Form1()
    {
        InitializeComponent();
    }

    private void RefreshPreview()
    {
        if (_afterEquals && _op is null && _right.Length == 0)
        {
            textDisplay.Text = _left;
            return;
        }

        var mid = _op.HasValue ? _op.Value.ToString() : "";
        textDisplay.Text = _left + mid + _right;
    }

    private void OnDigit(object? sender, EventArgs e)
    {
        if (sender is not Button b || b.Tag is not string s || s.Length != 1 || !char.IsDigit(s[0]))
            return;

        var d = s[0];
        if (_afterEquals)
        {
            _left = d.ToString();
            _right = "";
            _op = null;
            _afterEquals = false;
        }
        else if (_op is null)
        {
            if (_left == "0" && d == '0')
                return;
            if (_left == "0" && d != '0')
                _left = d.ToString();
            else
                _left += d;
        }
        else
        {
            if (_right == "0" && d == '0')
                return;
            if (_right == "0" && d != '0')
                _right = d.ToString();
            else
                _right += d;
        }

        RefreshPreview();
    }

    private void OnOperator(object? sender, EventArgs e)
    {
        if (sender is not Button b || b.Tag is not string tag || tag.Length != 1)
            return;

        var opChar = tag[0];
        if (opChar is not ('+' or '-' or '*' or '/'))
            return;

        if (_afterEquals)
        {
            _afterEquals = false;
        }

        if (_left.Length == 0)
            return;

        if (_op is not null && _right.Length > 0)
        {
            if (!TryEvaluate(out var value, out var error))
            {
                textDisplay.Text = error;
                return;
            }

            _left = FormatResult(value);
            _right = "";
        }

        _op = opChar;
        RefreshPreview();
    }

    private void OnEquals(object? sender, EventArgs e)
    {
        if (_left.Length == 0 || _op is null || _right.Length == 0)
            return;

        if (!TryEvaluate(out var value, out var error))
        {
            textDisplay.Text = error;
            return;
        }

        var expr = $"{_left}{_op}{_right}";
        _left = FormatResult(value);
        textDisplay.Text = $"{expr}={_left}";
        _right = "";
        _op = null;
        _afterEquals = true;
    }

    private void OnClear(object? sender, EventArgs e)
    {
        _left = "";
        _right = "";
        _op = null;
        _afterEquals = false;
        textDisplay.Text = "";
    }

    private bool TryEvaluate(out double value, out string error)
    {
        value = 0;
        error = "";

        if (!double.TryParse(_left, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out var a) ||
            !double.TryParse(_right, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out var b))
        {
            error = "输入无效";
            return false;
        }

        value = _op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => b == 0 ? double.NaN : a / b,
            _ => double.NaN
        };

        if (double.IsNaN(value))
        {
            error = "除数不能为0";
            return false;
        }

        return true;
    }

    private static string FormatResult(double v)
    {
        if (double.IsInfinity(v) || double.IsNaN(v))
            return v.ToString(System.Globalization.CultureInfo.InvariantCulture);
        if (Math.Abs(v - Math.Round(v)) < 1e-10)
            return ((long)Math.Round(v)).ToString(System.Globalization.CultureInfo.InvariantCulture);
        return v.ToString("G15", System.Globalization.CultureInfo.InvariantCulture);
    }
}
