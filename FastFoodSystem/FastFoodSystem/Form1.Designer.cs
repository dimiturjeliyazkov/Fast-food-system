using System.Drawing;
using System.Windows.Forms;

namespace FastFoodSystem
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UpravlenieBtn = new System.Windows.Forms.Button();
            this.PoruchkiBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.UpravlenieBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PoruchkiBtn, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 360);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UpravlenieBtn
            // 
            this.UpravlenieBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpravlenieBtn.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold);
            this.UpravlenieBtn.Location = new System.Drawing.Point(3, 2);
            this.UpravlenieBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpravlenieBtn.Name = "UpravlenieBtn";
            this.UpravlenieBtn.Size = new System.Drawing.Size(394, 356);
            this.UpravlenieBtn.TabIndex = 0;
            this.UpravlenieBtn.Text = "Управление";
            this.UpravlenieBtn.UseVisualStyleBackColor = true;
            this.UpravlenieBtn.Click += new System.EventHandler(this.UpravlenieBtn_Click);
            // 
            // PoruchkiBtn
            // 
            this.PoruchkiBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PoruchkiBtn.Font = new System.Drawing.Font("Segoe UI", 37F, System.Drawing.FontStyle.Bold);
            this.PoruchkiBtn.Location = new System.Drawing.Point(403, 2);
            this.PoruchkiBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PoruchkiBtn.Name = "PoruchkiBtn";
            this.PoruchkiBtn.Size = new System.Drawing.Size(394, 356);
            this.PoruchkiBtn.TabIndex = 1;
            this.PoruchkiBtn.Text = "Поръчки";
            this.PoruchkiBtn.UseVisualStyleBackColor = true;
            this.PoruchkiBtn.Click += new System.EventHandler(this.PoruchkiBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button UpravlenieBtn;
        private Button PoruchkiBtn;
    }
}

