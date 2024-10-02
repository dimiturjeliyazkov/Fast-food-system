using System.Drawing;
using System.Windows.Forms;

namespace PastaMadnessSystem
{
    partial class Recepti
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            TaglaBolBtn = new Button();
            SpagCarbBtn = new Button();
            FetchAlfterd = new Button();
            SpagSKufBtn = new Button();
            MakSPestoIchrBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(TaglaBolBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(SpagCarbBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(FetchAlfterd, 0, 3);
            tableLayoutPanel1.Controls.Add(SpagSKufBtn, 0, 4);
            tableLayoutPanel1.Controls.Add(MakSPestoIchrBtn, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 75);
            label1.TabIndex = 0;
            label1.Text = "Класически рецепти";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(403, 0);
            label2.Name = "label2";
            label2.Size = new Size(394, 75);
            label2.TabIndex = 1;
            label2.Text = "Наши предложения";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TaglaBolBtn
            // 
            TaglaBolBtn.Dock = DockStyle.Fill;
            TaglaBolBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            TaglaBolBtn.Location = new Point(3, 78);
            TaglaBolBtn.Name = "TaglaBolBtn";
            TaglaBolBtn.Size = new Size(394, 69);
            TaglaBolBtn.TabIndex = 2;
            TaglaBolBtn.Text = "Таглиятели болонезе";
            TaglaBolBtn.UseVisualStyleBackColor = true;
            TaglaBolBtn.Click += TaglaBolBtn_Click;
            // 
            // SpagCarbBtn
            // 
            SpagCarbBtn.Dock = DockStyle.Fill;
            SpagCarbBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            SpagCarbBtn.Location = new Point(3, 153);
            SpagCarbBtn.Name = "SpagCarbBtn";
            SpagCarbBtn.Size = new Size(394, 69);
            SpagCarbBtn.TabIndex = 3;
            SpagCarbBtn.Text = "Спагети Карбонара";
            SpagCarbBtn.UseVisualStyleBackColor = true;
            SpagCarbBtn.Click += SpagCarbBtn_Click;
            // 
            // FetchAlfterd
            // 
            FetchAlfterd.Dock = DockStyle.Fill;
            FetchAlfterd.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            FetchAlfterd.Location = new Point(3, 228);
            FetchAlfterd.Name = "FetchAlfterd";
            FetchAlfterd.Size = new Size(394, 69);
            FetchAlfterd.TabIndex = 4;
            FetchAlfterd.Text = "Фетучини алфредо";
            FetchAlfterd.UseVisualStyleBackColor = true;
            FetchAlfterd.Click += FetchAlfterd_Click;
            // 
            // SpagSKufBtn
            // 
            SpagSKufBtn.Dock = DockStyle.Fill;
            SpagSKufBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            SpagSKufBtn.Location = new Point(3, 303);
            SpagSKufBtn.Name = "SpagSKufBtn";
            SpagSKufBtn.Size = new Size(394, 69);
            SpagSKufBtn.TabIndex = 5;
            SpagSKufBtn.Text = "Спагети с кюфтенца";
            SpagSKufBtn.UseVisualStyleBackColor = true;
            SpagSKufBtn.Click += SpagSKufBtn_Click;
            // 
            // MakSPestoIchrBtn
            // 
            MakSPestoIchrBtn.Dock = DockStyle.Fill;
            MakSPestoIchrBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            MakSPestoIchrBtn.Location = new Point(3, 378);
            MakSPestoIchrBtn.Name = "MakSPestoIchrBtn";
            MakSPestoIchrBtn.Size = new Size(394, 69);
            MakSPestoIchrBtn.TabIndex = 6;
            MakSPestoIchrBtn.Text = "Макарони с песто и чери домати";
            MakSPestoIchrBtn.UseVisualStyleBackColor = true;
            MakSPestoIchrBtn.Click += MakSPestoIchrBtn_Click;
            // 
            // Recepti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Recepti";
            Text = "Recepti";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button TaglaBolBtn;
        private Button SpagCarbBtn;
        private Button FetchAlfterd;
        private Button SpagSKufBtn;
        private Button MakSPestoIchrBtn;
    }
}