
namespace WinFormsApp1
{
    partial class FormNama
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
            this.Tbox = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LabelNama = new System.Windows.Forms.Label();
            this.LALA = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tbox
            // 
            this.Tbox.Location = new System.Drawing.Point(200, 116);
            this.Tbox.Name = "Tbox";
            this.Tbox.Size = new System.Drawing.Size(125, 27);
            this.Tbox.TabIndex = 0;
            this.Tbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(321, 280);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(94, 29);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LabelNama
            // 
            this.LabelNama.AutoSize = true;
            this.LabelNama.Location = new System.Drawing.Point(75, 119);
            this.LabelNama.Name = "LabelNama";
            this.LabelNama.Size = new System.Drawing.Size(53, 20);
            this.LabelNama.TabIndex = 2;
            this.LabelNama.Text = "NAMA";
            // 
            // LALA
            // 
            this.LALA.AutoSize = true;
            this.LALA.Location = new System.Drawing.Point(200, 203);
            this.LALA.Name = "LALA";
            this.LALA.Size = new System.Drawing.Size(37, 20);
            this.LALA.TabIndex = 3;
            this.LALA.Text = "(///)";
            this.LALA.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LALA);
            this.Controls.Add(this.LabelNama);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.Tbox);
            this.Name = "FormNama";
            this.Text = "Nama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbox;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LabelNama;
        private System.Windows.Forms.Label LALA;
        private System.Windows.Forms.Button button1;
    }
}

