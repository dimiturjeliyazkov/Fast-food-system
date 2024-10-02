using System.Drawing;
using System.Windows.Forms;

namespace PastaMadnessSystem
{
    partial class Deserti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ShokoPastaBtn = new System.Windows.Forms.Button();
            this.ShokoRaviBtn = new System.Windows.Forms.Button();
            this.MakNaFurnBtn = new System.Windows.Forms.Button();
            this.NazadBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.5F));
            this.tableLayoutPanel1.Controls.Add(this.ShokoPastaBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ShokoRaviBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.MakNaFurnBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.NazadBtn, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 360);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ShokoPastaBtn
            // 
            this.ShokoPastaBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShokoPastaBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShokoPastaBtn.Location = new System.Drawing.Point(3, 2);
            this.ShokoPastaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShokoPastaBtn.Name = "ShokoPastaBtn";
            this.ShokoPastaBtn.Size = new System.Drawing.Size(203, 85);
            this.ShokoPastaBtn.TabIndex = 0;
            this.ShokoPastaBtn.Text = "Шоко Паста";
            this.ShokoPastaBtn.UseVisualStyleBackColor = true;
            // 
            // ShokoRaviBtn
            // 
            this.ShokoRaviBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShokoRaviBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShokoRaviBtn.Location = new System.Drawing.Point(426, 2);
            this.ShokoRaviBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShokoRaviBtn.Name = "ShokoRaviBtn";
            this.ShokoRaviBtn.Size = new System.Drawing.Size(207, 85);
            this.ShokoRaviBtn.TabIndex = 1;
            this.ShokoRaviBtn.Text = "Шоко Равиоли";
            this.ShokoRaviBtn.UseVisualStyleBackColor = true;
            // 
            // MakNaFurnBtn
            // 
            this.MakNaFurnBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MakNaFurnBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakNaFurnBtn.Location = new System.Drawing.Point(212, 2);
            this.MakNaFurnBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MakNaFurnBtn.Name = "MakNaFurnBtn";
            this.MakNaFurnBtn.Size = new System.Drawing.Size(208, 85);
            this.MakNaFurnBtn.TabIndex = 2;
            this.MakNaFurnBtn.Text = "Макарони на фурна ";
            this.MakNaFurnBtn.UseVisualStyleBackColor = true;
            // 
            // NazadBtn
            // 
            this.NazadBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NazadBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NazadBtn.Location = new System.Drawing.Point(639, 2);
            this.NazadBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NazadBtn.Name = "NazadBtn";
            this.NazadBtn.Size = new System.Drawing.Size(158, 85);
            this.NazadBtn.TabIndex = 3;
            this.NazadBtn.Text = "Назад";
            this.NazadBtn.UseVisualStyleBackColor = true;
            this.NazadBtn.Click += new System.EventHandler(this.NazadBtn_Click_1);
            // 
            // Deserti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Deserti";
            this.Text = "Deserti";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button ShokoPastaBtn;
        private Button ShokoRaviBtn;
        private Button MakNaFurnBtn;
        private Button NazadBtn;
    }
}