namespace HW4;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblFile1 = new Label();
        txtPath1 = new TextBox();
        btnPick1 = new Button();
        lblFile2 = new Label();
        txtPath2 = new TextBox();
        btnPick2 = new Button();
        btnMerge = new Button();
        lblHint = new Label();
        SuspendLayout();
        //
        // lblFile1
        //
        lblFile1.AutoSize = true;
        lblFile1.Location = new Point(12, 15);
        lblFile1.Name = "lblFile1";
        lblFile1.Size = new Size(56, 17);
        lblFile1.Text = "文本文件 1";
        //
        // txtPath1
        //
        txtPath1.Location = new Point(100, 12);
        txtPath1.Name = "txtPath1";
        txtPath1.ReadOnly = true;
        txtPath1.Size = new Size(420, 23);
        txtPath1.TabStop = false;
        //
        // btnPick1
        //
        btnPick1.Location = new Point(530, 10);
        btnPick1.Name = "btnPick1";
        btnPick1.Size = new Size(100, 27);
        btnPick1.Text = "选择…";
        btnPick1.UseVisualStyleBackColor = true;
        btnPick1.Click += BtnPick1_Click;
        //
        // lblFile2
        //
        lblFile2.AutoSize = true;
        lblFile2.Location = new Point(12, 55);
        lblFile2.Name = "lblFile2";
        lblFile2.Size = new Size(56, 17);
        lblFile2.Text = "文本文件 2";
        //
        // txtPath2
        //
        txtPath2.Location = new Point(100, 52);
        txtPath2.Name = "txtPath2";
        txtPath2.ReadOnly = true;
        txtPath2.Size = new Size(420, 23);
        txtPath2.TabStop = false;
        //
        // btnPick2
        //
        btnPick2.Location = new Point(530, 50);
        btnPick2.Name = "btnPick2";
        btnPick2.Size = new Size(100, 27);
        btnPick2.Text = "选择…";
        btnPick2.UseVisualStyleBackColor = true;
        btnPick2.Click += BtnPick2_Click;
        //
        // btnMerge
        //
        btnMerge.Location = new Point(100, 95);
        btnMerge.Name = "btnMerge";
        btnMerge.Size = new Size(200, 32);
        btnMerge.Text = "合并并保存到 Data 文件夹";
        btnMerge.UseVisualStyleBackColor = true;
        btnMerge.Click += BtnMerge_Click;
        //
        // lblHint
        //
        lblHint.AutoSize = true;
        lblHint.ForeColor = SystemColors.GrayText;
        lblHint.Location = new Point(12, 145);
        lblHint.MaximumSize = new Size(620, 0);
        lblHint.Name = "lblHint";
        lblHint.Size = new Size(0, 17);
        lblHint.Text = "合并结果保存为 exe 同目录下 Data\\merged.txt";
        //
        // Form1
        //
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(650, 180);
        Controls.Add(lblHint);
        Controls.Add(btnMerge);
        Controls.Add(btnPick2);
        Controls.Add(txtPath2);
        Controls.Add(lblFile2);
        Controls.Add(btnPick1);
        Controls.Add(txtPath1);
        Controls.Add(lblFile1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "合并两个文本文件";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblFile1;
    private TextBox txtPath1;
    private Button btnPick1;
    private Label lblFile2;
    private TextBox txtPath2;
    private Button btnPick2;
    private Button btnMerge;
    private Label lblHint;
}
