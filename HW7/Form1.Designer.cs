#nullable disable
namespace HW7;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private Label label1;
    private Label lblChinese;
    private Label label2;
    private TextBox txtAnswer;
    private Label lblResult;
    private Button btnNext;
    private Label lblProgress;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        label1 = new Label();
        lblChinese = new Label();
        label2 = new Label();
        txtAnswer = new TextBox();
        lblResult = new Label();
        btnNext = new Button();
        lblProgress = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Microsoft YaHei UI", 10F);
        label1.Location = new Point(20, 20);
        label1.Name = "label1";
        label1.Size = new Size(65, 20);
        label1.Text = "中文词义：";
        // 
        // lblChinese
        // 
        lblChinese.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
        lblChinese.Location = new Point(20, 50);
        lblChinese.Name = "lblChinese";
        lblChinese.Size = new Size(440, 60);
        lblChinese.Text = "（这里显示中文）";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Microsoft YaHei UI", 10F);
        label2.Location = new Point(20, 130);
        label2.Name = "label2";
        label2.Size = new Size(191, 20);
        label2.Text = "在下面输入对应英文，回车判对错：";
        // 
        // txtAnswer
        // 
        txtAnswer.Font = new Font("Microsoft YaHei UI", 12F);
        txtAnswer.Location = new Point(20, 160);
        txtAnswer.Name = "txtAnswer";
        txtAnswer.Size = new Size(440, 29);
        txtAnswer.TabIndex = 0;
        txtAnswer.KeyDown += txtAnswer_KeyDown;
        // 
        // lblResult
        // 
        lblResult.AutoSize = true;
        lblResult.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
        lblResult.Location = new Point(20, 205);
        lblResult.Name = "lblResult";
        lblResult.Size = new Size(0, 26);
        lblResult.Text = "";
        // 
        // btnNext
        // 
        btnNext.Font = new Font("Microsoft YaHei UI", 10F);
        btnNext.Location = new Point(350, 250);
        btnNext.Name = "btnNext";
        btnNext.Size = new Size(110, 32);
        btnNext.TabIndex = 1;
        btnNext.Text = "下一题";
        btnNext.UseVisualStyleBackColor = true;
        btnNext.Click += btnNext_Click;
        // 
        // lblProgress
        // 
        lblProgress.AutoSize = true;
        lblProgress.Font = new Font("Microsoft YaHei UI", 9F);
        lblProgress.ForeColor = SystemColors.GrayText;
        lblProgress.Location = new Point(20, 257);
        lblProgress.Name = "lblProgress";
        lblProgress.Size = new Size(0, 17);
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(484, 301);
        Controls.Add(lblProgress);
        Controls.Add(btnNext);
        Controls.Add(lblResult);
        Controls.Add(txtAnswer);
        Controls.Add(label2);
        Controls.Add(lblChinese);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "背单词";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }
}
