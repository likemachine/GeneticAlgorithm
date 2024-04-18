
namespace Evo1
{
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
            textBox2 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBox5 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            button7 = new System.Windows.Forms.Button();
            label10 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(12, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 53);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(81, 15);
            label3.TabIndex = 5;
            label3.Text = "Размер генов";
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(12, 27);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(100, 23);
            textBox4.TabIndex = 9;
            textBox4.Text = "10";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(111, 15);
            label4.TabIndex = 10;
            label4.Text = "Размер популяции";
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(12, 115);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(100, 23);
            textBox5.TabIndex = 14;
            textBox5.Text = "5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 97);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(117, 15);
            label5.TabIndex = 15;
            label5.Text = "Точка скрещивания";
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(12, 157);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(158, 58);
            button7.TabIndex = 20;
            button7.Text = "Старт";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(194, 179);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(60, 15);
            label10.TabIndex = 21;
            label10.Text = "Результат";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(152, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 15);
            label1.TabIndex = 23;
            label1.Text = "Кол-во эпох";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(152, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 22;
            textBox1.Text = "100";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(272, 227);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(button7);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

