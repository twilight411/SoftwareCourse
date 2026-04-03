#nullable disable
namespace Calculator;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private TextBox textDisplay = null!;
    private Button btn7 = null!;
    private Button btn8 = null!;
    private Button btn9 = null!;
    private Button btnDiv = null!;
    private Button btn4 = null!;
    private Button btn5 = null!;
    private Button btn6 = null!;
    private Button btnMul = null!;
    private Button btn1 = null!;
    private Button btn2 = null!;
    private Button btn3 = null!;
    private Button btnSub = null!;
    private Button btn0 = null!;
    private Button btnClear = null!;
    private Button btnEq = null!;
    private Button btnAdd = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        textDisplay = new TextBox();
        btn7 = new Button();
        btn8 = new Button();
        btn9 = new Button();
        btnDiv = new Button();
        btn4 = new Button();
        btn5 = new Button();
        btn6 = new Button();
        btnMul = new Button();
        btn1 = new Button();
        btn2 = new Button();
        btn3 = new Button();
        btnSub = new Button();
        btn0 = new Button();
        btnClear = new Button();
        btnEq = new Button();
        btnAdd = new Button();
        SuspendLayout();
        //
        // textDisplay
        //
        textDisplay.Font = new Font("Microsoft YaHei UI", 12F);
        textDisplay.Location = new Point(12, 12);
        textDisplay.Name = "textDisplay";
        textDisplay.ReadOnly = true;
        textDisplay.Size = new Size(356, 34);
        textDisplay.TabIndex = 0;
        textDisplay.TextAlign = HorizontalAlignment.Right;
        //
        // row 7 8 9 /
        //
        btn7.Location = new Point(12, 58);
        btn7.Name = "btn7";
        btn7.Size = new Size(80, 44);
        btn7.TabIndex = 1;
        btn7.Text = "7";
        btn7.Tag = "7";
        btn7.UseVisualStyleBackColor = true;
        btn7.Click += OnDigit;
        btn8.Location = new Point(102, 58);
        btn8.Name = "btn8";
        btn8.Size = new Size(80, 44);
        btn8.TabIndex = 2;
        btn8.Text = "8";
        btn8.Tag = "8";
        btn8.UseVisualStyleBackColor = true;
        btn8.Click += OnDigit;
        btn9.Location = new Point(192, 58);
        btn9.Name = "btn9";
        btn9.Size = new Size(80, 44);
        btn9.TabIndex = 3;
        btn9.Text = "9";
        btn9.Tag = "9";
        btn9.UseVisualStyleBackColor = true;
        btn9.Click += OnDigit;
        btnDiv.Location = new Point(282, 58);
        btnDiv.Name = "btnDiv";
        btnDiv.Size = new Size(80, 44);
        btnDiv.TabIndex = 4;
        btnDiv.Text = "/";
        btnDiv.Tag = "/";
        btnDiv.UseVisualStyleBackColor = true;
        btnDiv.Click += OnOperator;
        //
        // row 4 5 6 *
        //
        btn4.Location = new Point(12, 110);
        btn4.Name = "btn4";
        btn4.Size = new Size(80, 44);
        btn4.TabIndex = 5;
        btn4.Text = "4";
        btn4.Tag = "4";
        btn4.UseVisualStyleBackColor = true;
        btn4.Click += OnDigit;
        btn5.Location = new Point(102, 110);
        btn5.Name = "btn5";
        btn5.Size = new Size(80, 44);
        btn5.TabIndex = 6;
        btn5.Text = "5";
        btn5.Tag = "5";
        btn5.UseVisualStyleBackColor = true;
        btn5.Click += OnDigit;
        btn6.Location = new Point(192, 110);
        btn6.Name = "btn6";
        btn6.Size = new Size(80, 44);
        btn6.TabIndex = 7;
        btn6.Text = "6";
        btn6.Tag = "6";
        btn6.UseVisualStyleBackColor = true;
        btn6.Click += OnDigit;
        btnMul.Location = new Point(282, 110);
        btnMul.Name = "btnMul";
        btnMul.Size = new Size(80, 44);
        btnMul.TabIndex = 8;
        btnMul.Text = "*";
        btnMul.Tag = "*";
        btnMul.UseVisualStyleBackColor = true;
        btnMul.Click += OnOperator;
        //
        // row 1 2 3 -
        //
        btn1.Location = new Point(12, 162);
        btn1.Name = "btn1";
        btn1.Size = new Size(80, 44);
        btn1.TabIndex = 9;
        btn1.Text = "1";
        btn1.Tag = "1";
        btn1.UseVisualStyleBackColor = true;
        btn1.Click += OnDigit;
        btn2.Location = new Point(102, 162);
        btn2.Name = "btn2";
        btn2.Size = new Size(80, 44);
        btn2.TabIndex = 10;
        btn2.Text = "2";
        btn2.Tag = "2";
        btn2.UseVisualStyleBackColor = true;
        btn2.Click += OnDigit;
        btn3.Location = new Point(192, 162);
        btn3.Name = "btn3";
        btn3.Size = new Size(80, 44);
        btn3.TabIndex = 11;
        btn3.Text = "3";
        btn3.Tag = "3";
        btn3.UseVisualStyleBackColor = true;
        btn3.Click += OnDigit;
        btnSub.Location = new Point(282, 162);
        btnSub.Name = "btnSub";
        btnSub.Size = new Size(80, 44);
        btnSub.TabIndex = 12;
        btnSub.Text = "-";
        btnSub.Tag = "-";
        btnSub.UseVisualStyleBackColor = true;
        btnSub.Click += OnOperator;
        //
        // row 0 C = +
        //
        btn0.Location = new Point(12, 214);
        btn0.Name = "btn0";
        btn0.Size = new Size(80, 44);
        btn0.TabIndex = 13;
        btn0.Text = "0";
        btn0.Tag = "0";
        btn0.UseVisualStyleBackColor = true;
        btn0.Click += OnDigit;
        btnClear.Location = new Point(102, 214);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(80, 44);
        btnClear.TabIndex = 14;
        btnClear.Text = "清除";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += OnClear;
        btnEq.Location = new Point(192, 214);
        btnEq.Name = "btnEq";
        btnEq.Size = new Size(80, 44);
        btnEq.TabIndex = 15;
        btnEq.Text = "=";
        btnEq.UseVisualStyleBackColor = true;
        btnEq.Click += OnEquals;
        btnAdd.Location = new Point(282, 214);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(80, 44);
        btnAdd.TabIndex = 16;
        btnAdd.Text = "+";
        btnAdd.Tag = "+";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += OnOperator;
        //
        // Form1
        //
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(380, 272);
        Controls.Add(btnAdd);
        Controls.Add(btnEq);
        Controls.Add(btnClear);
        Controls.Add(btn0);
        Controls.Add(btnSub);
        Controls.Add(btn3);
        Controls.Add(btn2);
        Controls.Add(btn1);
        Controls.Add(btnMul);
        Controls.Add(btn6);
        Controls.Add(btn5);
        Controls.Add(btn4);
        Controls.Add(btnDiv);
        Controls.Add(btn9);
        Controls.Add(btn8);
        Controls.Add(btn7);
        Controls.Add(textDisplay);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "计算器";
        ResumeLayout(false);
        PerformLayout();
    }
}
