#nullable disable
namespace HW6;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private Label labelUrl = null!;
    private TextBox textUrl = null!;
    private Button btnFetch = null!;
    private Label labelPhones = null!;
    private TextBox textPhones = null!;
    private Label labelEmails = null!;
    private TextBox textEmails = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        labelUrl = new Label();
        textUrl = new TextBox();
        btnFetch = new Button();
        labelPhones = new Label();
        textPhones = new TextBox();
        labelEmails = new Label();
        textEmails = new TextBox();
        SuspendLayout();
        //
        // labelUrl
        //
        labelUrl.AutoSize = true;
        labelUrl.Location = new Point(12, 15);
        labelUrl.Name = "labelUrl";
        labelUrl.Size = new Size(44, 17);
        labelUrl.Text = "网址：";
        //
        // textUrl
        //
        textUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        textUrl.Location = new Point(62, 12);
        textUrl.Name = "textUrl";
        textUrl.Size = new Size(526, 23);
        textUrl.TabIndex = 0;
        textUrl.Text = "https://";
        //
        // btnFetch
        //
        btnFetch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnFetch.Location = new Point(594, 11);
        btnFetch.Name = "btnFetch";
        btnFetch.Size = new Size(94, 25);
        btnFetch.TabIndex = 1;
        btnFetch.Text = "获取并提取";
        btnFetch.UseVisualStyleBackColor = true;
        btnFetch.Click += btnFetch_Click;
        //
        // labelPhones
        //
        labelPhones.AutoSize = true;
        labelPhones.Location = new Point(12, 50);
        labelPhones.Name = "labelPhones";
        labelPhones.Size = new Size(56, 17);
        labelPhones.Text = "手机号：";
        //
        // textPhones
        //
        textPhones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        textPhones.Location = new Point(12, 70);
        textPhones.Multiline = true;
        textPhones.Name = "textPhones";
        textPhones.ReadOnly = true;
        textPhones.ScrollBars = ScrollBars.Vertical;
        textPhones.Size = new Size(676, 140);
        textPhones.TabIndex = 2;
        //
        // labelEmails
        //
        labelEmails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        labelEmails.AutoSize = true;
        labelEmails.Location = new Point(12, 220);
        labelEmails.Name = "labelEmails";
        labelEmails.Size = new Size(44, 17);
        labelEmails.Text = "邮箱：";
        //
        // textEmails
        //
        textEmails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        textEmails.Location = new Point(12, 240);
        textEmails.Multiline = true;
        textEmails.Name = "textEmails";
        textEmails.ReadOnly = true;
        textEmails.ScrollBars = ScrollBars.Vertical;
        textEmails.Size = new Size(676, 140);
        textEmails.TabIndex = 3;
        //
        // Form1
        //
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(700, 392);
        Controls.Add(textEmails);
        Controls.Add(labelEmails);
        Controls.Add(textPhones);
        Controls.Add(labelPhones);
        Controls.Add(btnFetch);
        Controls.Add(textUrl);
        Controls.Add(labelUrl);
        MinimumSize = new Size(500, 300);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "HW6 - 网页提取手机号与邮箱";
        ResumeLayout(false);
        PerformLayout();
    }
}
