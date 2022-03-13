
namespace week3
{
    partial class Form
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
            this.tBoxInput = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.labelInputData = new System.Windows.Forms.Label();
            this.labelJawaban = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBoxInput
            // 
            this.tBoxInput.Location = new System.Drawing.Point(194, 45);
            this.tBoxInput.Name = "tBoxInput";
            this.tBoxInput.Size = new System.Drawing.Size(125, 27);
            this.tBoxInput.TabIndex = 0;
            this.tBoxInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(194, 105);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(94, 29);
            this.btnProses.TabIndex = 1;
            this.btnProses.TabStop = false;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // labelInputData
            // 
            this.labelInputData.AutoSize = true;
            this.labelInputData.Location = new System.Drawing.Point(79, 45);
            this.labelInputData.Name = "labelInputData";
            this.labelInputData.Size = new System.Drawing.Size(82, 20);
            this.labelInputData.TabIndex = 2;
            this.labelInputData.Text = "Input Data:";
            this.labelInputData.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelJawaban
            // 
            this.labelJawaban.AutoSize = true;
            this.labelJawaban.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJawaban.Location = new System.Drawing.Point(194, 168);
            this.labelJawaban.Name = "labelJawaban";
            this.labelJawaban.Size = new System.Drawing.Size(107, 35);
            this.labelJawaban.TabIndex = 3;
            this.labelJawaban.Text = "[EMPTY]";
            this.labelJawaban.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelJawaban);
            this.Controls.Add(this.labelInputData);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.tBoxInput);
            this.Name = "Form";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxInput;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Label labelInputData;
        private System.Windows.Forms.Label labelJawaban;
    }
}

