using System.Drawing;
using System.Windows.Forms;

namespace PastaMadnessSystem
{
    partial class Glovo
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
            tableLayoutPanel2 = new TableLayoutPanel();
            PastaBtn = new Button();
            NapitkaBtn = new Button();
            DesertiBtn = new Button();
            NazadBtn = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            RazplashtaneBtn = new Button();
            IztrivaneBtn = new Button();
            CenaNaPoruchkaLBL = new Label();
            ListItemsTLP = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.5F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(PastaBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(NapitkaBtn, 0, 1);
            tableLayoutPanel2.Controls.Add(DesertiBtn, 0, 2);
            tableLayoutPanel2.Controls.Add(NazadBtn, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.63964F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3153152F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.5135136F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7657661F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40.7657661F));
            tableLayoutPanel2.Size = new Size(182, 444);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // PastaBtn
            // 
            PastaBtn.Dock = DockStyle.Fill;
            PastaBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            PastaBtn.Location = new Point(3, 3);
            PastaBtn.Name = "PastaBtn";
            PastaBtn.Size = new Size(176, 59);
            PastaBtn.TabIndex = 0;
            PastaBtn.Text = "Паста";
            PastaBtn.UseVisualStyleBackColor = true;
            PastaBtn.Click += PastaBtn_Click;
            // 
            // NapitkaBtn
            // 
            NapitkaBtn.Dock = DockStyle.Fill;
            NapitkaBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            NapitkaBtn.Location = new Point(3, 68);
            NapitkaBtn.Name = "NapitkaBtn";
            NapitkaBtn.Size = new Size(176, 62);
            NapitkaBtn.TabIndex = 1;
            NapitkaBtn.Text = "Напитки";
            NapitkaBtn.UseVisualStyleBackColor = true;
            NapitkaBtn.Click += NapitkaBtn_Click;
            // 
            // DesertiBtn
            // 
            DesertiBtn.Dock = DockStyle.Fill;
            DesertiBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            DesertiBtn.Location = new Point(3, 136);
            DesertiBtn.Name = "DesertiBtn";
            DesertiBtn.Size = new Size(176, 54);
            DesertiBtn.TabIndex = 2;
            DesertiBtn.Text = "Десерти";
            DesertiBtn.UseVisualStyleBackColor = true;
            DesertiBtn.Click += DesertiBtn_Click;
            // 
            // NazadBtn
            // 
            NazadBtn.Dock = DockStyle.Fill;
            NazadBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            NazadBtn.Location = new Point(3, 196);
            NazadBtn.Name = "NazadBtn";
            NazadBtn.Size = new Size(176, 64);
            NazadBtn.TabIndex = 3;
            NazadBtn.Text = "Назад";
            NazadBtn.UseVisualStyleBackColor = true;
            NazadBtn.Click += NazadBtn_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Controls.Add(ListItemsTLP, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(191, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80.18018F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.81982F));
            tableLayoutPanel3.Size = new Size(606, 444);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.8333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.166666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29F));
            tableLayoutPanel4.Controls.Add(RazplashtaneBtn, 1, 0);
            tableLayoutPanel4.Controls.Add(IztrivaneBtn, 2, 0);
            tableLayoutPanel4.Controls.Add(CenaNaPoruchkaLBL, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 359);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(600, 82);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // RazplashtaneBtn
            // 
            RazplashtaneBtn.Dock = DockStyle.Fill;
            RazplashtaneBtn.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            RazplashtaneBtn.Location = new Point(266, 3);
            RazplashtaneBtn.Name = "RazplashtaneBtn";
            RazplashtaneBtn.Size = new Size(157, 76);
            RazplashtaneBtn.TabIndex = 0;
            RazplashtaneBtn.Text = "Разплащане";
            RazplashtaneBtn.UseVisualStyleBackColor = true;
            RazplashtaneBtn.Click += RazplashtaneBtn_Click;
            // 
            // IztrivaneBtn
            // 
            IztrivaneBtn.Dock = DockStyle.Fill;
            IztrivaneBtn.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold);
            IztrivaneBtn.Location = new Point(429, 3);
            IztrivaneBtn.Name = "IztrivaneBtn";
            IztrivaneBtn.Size = new Size(168, 76);
            IztrivaneBtn.TabIndex = 1;
            IztrivaneBtn.Text = "Изтриване ";
            IztrivaneBtn.UseVisualStyleBackColor = true;
            IztrivaneBtn.Click += IztrivaneBtn_Click;
            // 
            // CenaNaPoruchkaLBL
            // 
            CenaNaPoruchkaLBL.AutoSize = true;
            CenaNaPoruchkaLBL.Dock = DockStyle.Fill;
            CenaNaPoruchkaLBL.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CenaNaPoruchkaLBL.Location = new Point(3, 0);
            CenaNaPoruchkaLBL.Name = "CenaNaPoruchkaLBL";
            CenaNaPoruchkaLBL.Size = new Size(257, 82);
            CenaNaPoruchkaLBL.TabIndex = 2;
            CenaNaPoruchkaLBL.Text = "обща цена";
            CenaNaPoruchkaLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ListItemsTLP
            // 
            ListItemsTLP.ColumnCount = 1;
            ListItemsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ListItemsTLP.Dock = DockStyle.Fill;
            ListItemsTLP.Location = new Point(3, 3);
            ListItemsTLP.Name = "ListItemsTLP";
            ListItemsTLP.RowCount = 1;
            ListItemsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ListItemsTLP.Size = new Size(600, 350);
            ListItemsTLP.TabIndex = 1;
            // 
            // Glovo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Glovo";
            Text = "Glovo";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button PastaBtn;
        private Button NapitkaBtn;
        private Button DesertiBtn;
        private Button NazadBtn;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button RazplashtaneBtn;
        private Button IztrivaneBtn;
        private Label CenaNaPoruchkaLBL;
        private TableLayoutPanel ListItemsTLP;
    }
}