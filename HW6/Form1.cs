using System.Text.RegularExpressions;

namespace HW6;

public partial class Form1 : Form
{
    // 中国大陆手机号：1 开头 11 位
    private static readonly Regex PhoneRegex = new(@"1[3-9]\d{9}", RegexOptions.Compiled);
    // 常见邮箱形态（作业够用）
    private static readonly Regex EmailRegex = new(
        @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}",
        RegexOptions.Compiled);

    public Form1()
    {
        InitializeComponent();
    }

    private async void btnFetch_Click(object sender, EventArgs e)
    {
        var url = textUrl.Text.Trim();
        if (string.IsNullOrEmpty(url))
        {
            MessageBox.Show("请输入网址。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        btnFetch.Enabled = false;
        textPhones.Clear();
        textEmails.Clear();

        try
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.TryAddWithoutValidation(
                "User-Agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");
            var html = await client.GetStringAsync(url);

            var phones = PhoneRegex.Matches(html).Cast<Match>().Select(m => m.Value).Distinct().ToList();
            var emails = EmailRegex.Matches(html).Cast<Match>().Select(m => m.Value).Distinct().ToList();

            textPhones.Text = string.Join(Environment.NewLine, phones);
            textEmails.Text = string.Join(Environment.NewLine, emails);

            if (phones.Count == 0 && emails.Count == 0)
                MessageBox.Show("未在页面中找到手机号或邮箱（可能页面是动态加载的）。", "结果",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "获取失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            btnFetch.Enabled = true;
        }
    }
}
