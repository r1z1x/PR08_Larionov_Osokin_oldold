namespace WindowsFormsApp1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Логин = new Label();
        label2 = new Label();
        label3 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // Логин
        // 
        Логин.AutoSize = true;
        Логин.Location = new Point(54, 25);
        Логин.Name = "Логин";
        Логин.Size = new Size(41, 15);
        Логин.TabIndex = 0;
        Логин.Text = "Логин";
        Логин.Click += label1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(54, 49);
        label2.Name = "label2";
        label2.Size = new Size(49, 15);
        label2.TabIndex = 1;
        label2.Text = "Пароль";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(54, 76);
        label3.Name = "label3";
        label3.Size = new Size(78, 15);
        label3.TabIndex = 2;
        label3.Text = "Авторизация";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(126, 143);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(100, 23);
        textBox1.TabIndex = 3;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(126, 172);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(100, 23);
        textBox2.TabIndex = 4;
        // 
        // button1
        // 
        button1.Location = new Point(137, 282);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 5;
        button1.Text = "Войти";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(335, 282);
        button2.Name = "button2";
        button2.Size = new Size(114, 23);
        button2.TabIndex = 6;
        button2.Text = "Войти как гость";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(516, 282);
        button3.Name = "button3";
        button3.Size = new Size(75, 23);
        button3.TabIndex = 7;
        button3.Text = "Выйти";
        button3.UseVisualStyleBackColor = true;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        pictureBox1.Image = Properties.Resources.Icon1;
        pictureBox1.Location = new Point(325, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(190, 117);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 8;
        pictureBox1.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(pictureBox1);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(Логин);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label Логин;
    private Label label2;
    private Label label3;
    private TextBox textBox1;
    private TextBox textBox2;
    private Button button1;
    private Button button2;
    private Button button3;
    private PictureBox pictureBox1;
}
