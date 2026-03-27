using System.Text;

namespace HW4;

public partial class Form1 : Form
{
    private readonly OpenFileDialog _openDialog = new()
    {
        Filter = "文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*",
        Title = "选择文本文件",
    };

    public Form1()
    {
        InitializeComponent();
    }

    private void BtnPick1_Click(object? sender, EventArgs e)
    {
        if (_openDialog.ShowDialog() == DialogResult.OK)
        {
            txtPath1.Text = _openDialog.FileName;
        }
    }

    private void BtnPick2_Click(object? sender, EventArgs e)
    {
        if (_openDialog.ShowDialog() == DialogResult.OK)
        {
            txtPath2.Text = _openDialog.FileName;
        }
    }

    private void BtnMerge_Click(object? sender, EventArgs e)
    {
        string path1 = txtPath1.Text.Trim();
        string path2 = txtPath2.Text.Trim();

        if (string.IsNullOrEmpty(path1) || string.IsNullOrEmpty(path2))
        {
            MessageBox.Show("请先选择两个文本文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (path1.Equals(path2, StringComparison.OrdinalIgnoreCase))
        {
            MessageBox.Show("两个文件不能是同一个。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            string text1 = File.ReadAllText(path1, Encoding.UTF8);
            string text2 = File.ReadAllText(path2, Encoding.UTF8);
            string merged = text1 + Environment.NewLine + text2;

            string dataDir = Path.Combine(AppContext.BaseDirectory, "Data");
            Directory.CreateDirectory(dataDir);

            string outPath = Path.Combine(dataDir, "merged.txt");
            File.WriteAllText(outPath, merged, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));

            MessageBox.Show($"已保存：{outPath}", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "读写失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
