namespace Exercicio1;

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
        btnMaximizar = new Button();
        btnRestaurar = new Button();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        SuspendLayout();
        // 
        // btnMaximizar
        // 
        btnMaximizar.Location = new Point(12, 12);
        btnMaximizar.Name = "btnMaximizar";
        btnMaximizar.Size = new Size(94, 29);
        btnMaximizar.TabIndex = 0;
        btnMaximizar.Text = "Maximizar";
        btnMaximizar.UseVisualStyleBackColor = true;
        btnMaximizar.Click += btnMaximizar_Click;
        // 
        // btnRestaurar
        // 
        btnRestaurar.Location = new Point(694, 12);
        btnRestaurar.Name = "btnRestaurar";
        btnRestaurar.Size = new Size(94, 29);
        btnRestaurar.TabIndex = 1;
        btnRestaurar.Text = "Restaurar";
        btnRestaurar.UseVisualStyleBackColor = true;
        btnRestaurar.Click += btnRestaurar_Click;
        // 
        // button1
        // 
        button1.Location = new Point(353, 211);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 2;
        button1.Text = "Form3";
        button1.UseVisualStyleBackColor = true;
        button1.Click += btnForm3_Click;
        // 
        // button2
        // 
        button2.Location = new Point(353, 165);
        button2.Name = "button2";
        button2.Size = new Size(94, 29);
        button2.TabIndex = 3;
        button2.Text = "Form2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += btnForm2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(353, 258);
        button3.Name = "button3";
        button3.Size = new Size(94, 29);
        button3.TabIndex = 4;
        button3.Text = "Form4";
        button3.UseVisualStyleBackColor = true;
        button3.Click += btnForm4_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(btnRestaurar);
        Controls.Add(btnMaximizar);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Button btnMaximizar;
    private Button btnRestaurar;
    private Button button1;
    private Button button2;
    private Button button3;
}
