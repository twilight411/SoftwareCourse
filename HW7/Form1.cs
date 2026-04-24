using Microsoft.Data.Sqlite;

namespace HW7;

public partial class Form1 : Form
{
    private string _dbPath = "";
    private readonly List<WordItem> _list = new();
    private int _pos;
    private readonly Random _rnd = new();

    private class WordItem
    {
        public int Id;
        public string English = "";
        public string Chinese = "";
    }

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        _dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "worddata.db");
        try
        {
            InitDb();
            LoadWords();
            if (_list.Count == 0)
            {
                MessageBox.Show("词库里没有单词。");
                return;
            }
            _pos = 0;
            ShowWord();
        }
        catch (Exception ex)
        {
            MessageBox.Show("数据库出错了：\n" + ex.Message);
        }
    }

    /// <summary>
    /// 建表，没有数据就插几条默认的
    /// </summary>
    private void InitDb()
    {
        using var conn = new SqliteConnection("Data Source=" + _dbPath);
        conn.Open();
        var cmd = conn.CreateCommand();
        cmd.CommandText = """
            CREATE TABLE IF NOT EXISTS words (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                english TEXT NOT NULL,
                chinese TEXT NOT NULL
            );
            """;
        cmd.ExecuteNonQuery();

        cmd.CommandText = "SELECT COUNT(*) FROM words";
        var n = Convert.ToInt64(cmd.ExecuteScalar());
        if (n > 0)
            return;

        // 预设一些数据
        var pairs = new (string en, string cn)[]
        {
            ("hello", "你好；喂"),
            ("world", "世界"),
            ("apple", "苹果"),
            ("book", "书；预订"),
            ("water", "水"),
            ("computer", "计算机"),
            ("memory", "记忆；内存"),
        };
        cmd.CommandText = "INSERT INTO words (english, chinese) VALUES ($e, $c);";
        foreach (var p in pairs)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("$e", p.en);
            cmd.Parameters.AddWithValue("$c", p.cn);
            cmd.ExecuteNonQuery();
        }
    }

    private void LoadWords()
    {
        _list.Clear();
        using var conn = new SqliteConnection("Data Source=" + _dbPath);
        conn.Open();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT id, english, chinese FROM words ORDER BY id;";
        using var r = cmd.ExecuteReader();
        while (r.Read())
        {
            _list.Add(new WordItem
            {
                Id = r.GetInt32(0),
                English = r.GetString(1),
                Chinese = r.GetString(2)
            });
        }

        // 打乱一下顺序
        for (int i = _list.Count - 1; i > 0; i--)
        {
            int j = _rnd.Next(i + 1);
            (_list[i], _list[j]) = (_list[j], _list[i]);
        }
    }

    private void ShowWord()
    {
        if (_pos < 0 || _pos >= _list.Count)
            return;

        lblChinese.Text = _list[_pos].Chinese;
        txtAnswer.Clear();
        lblResult.Text = "";
        lblResult.ForeColor = SystemColors.WindowText;
        lblProgress.Text = "第 " + (_pos + 1) + " / " + _list.Count + " 题";
        txtAnswer.Focus();
    }

    private void txtAnswer_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
            Check();
        }
    }

    private void Check()
    {
        if (_pos < 0 || _pos >= _list.Count)
            return;

        string right = _list[_pos].English.Trim();
        string user = txtAnswer.Text.Trim();
        if (string.IsNullOrEmpty(user))
        {
            lblResult.Text = "先输入英文再回车";
            lblResult.ForeColor = Color.DarkOrange;
            return;
        }

        if (string.Equals(user, right, StringComparison.OrdinalIgnoreCase))
        {
            lblResult.Text = "正确";
            lblResult.ForeColor = Color.DarkGreen;
        }
        else
        {
            lblResult.Text = "错误";
            lblResult.ForeColor = Color.DarkRed;
        }
    }

    private void btnNext_Click(object? sender, EventArgs e)
    {
        if (_list.Count == 0) return;
        _pos++;
        if (_pos >= _list.Count)
        {
            MessageBox.Show("本轮背完了。点确定重新开始一轮。");
            _pos = 0;
            LoadWords();
        }
        ShowWord();
    }
}
