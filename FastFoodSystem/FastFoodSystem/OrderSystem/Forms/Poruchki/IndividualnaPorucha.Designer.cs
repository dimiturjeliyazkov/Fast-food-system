using System.Drawing;
using System.Windows.Forms;

namespace PastaMadnessSystem
{
    partial class IndividualnaPorucha
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
            NapitkiBtn = new Button();
            DessertButton = new Button();
            NazadBtn = new Button();
            PastaBtn = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            ListItemsTLP = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            CqlaSumaLbl = new Label();
            RazplashtaneBtn = new Button();
            IztrivaneBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.875F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(NapitkiBtn, 0, 1);
            tableLayoutPanel2.Controls.Add(DessertButton, 0, 2);
            tableLayoutPanel2.Controls.Add(NazadBtn, 0, 3);
            tableLayoutPanel2.Controls.Add(PastaBtn, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.09009F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8648653F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.63964F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.63964F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 41.44144F));
            tableLayoutPanel2.Size = new Size(179, 444);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // NapitkiBtn
            // 
            NapitkiBtn.Dock = DockStyle.Fill;
            NapitkiBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NapitkiBtn.Location = new Point(3, 69);
            NapitkiBtn.Name = "NapitkiBtn";
            NapitkiBtn.Size = new Size(173, 59);
            NapitkiBtn.TabIndex = 1;
            NapitkiBtn.Text = "Напитки";
            NapitkiBtn.UseVisualStyleBackColor = true;
            NapitkiBtn.Click += NapitkiBtn_Click;
            // 
            // DessertButton
            // 
            DessertButton.Dock = DockStyle.Fill;
            DessertButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DessertButton.Location = new Point(3, 134);
            DessertButton.Name = "DessertButton";
            DessertButton.Size = new Size(173, 58);
            DessertButton.TabIndex = 2;
            DessertButton.Text = "Десерти";
            DessertButton.UseVisualStyleBackColor = true;
            DessertButton.Click += DessertButton_Click;
            // 
            // NazadBtn
            // 
            NazadBtn.AllowDrop = true;
            NazadBtn.Dock = DockStyle.Fill;
            NazadBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NazadBtn.Location = new Point(3, 198);
            NazadBtn.Name = "NazadBtn";
            NazadBtn.Size = new Size(173, 58);
            NazadBtn.TabIndex = 3;
            NazadBtn.Text = "Назад";
            NazadBtn.UseVisualStyleBackColor = true;
            NazadBtn.Click += NazadBtn_Click;
            // 
            // PastaBtn
            // 
            PastaBtn.Dock = DockStyle.Fill;
            PastaBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PastaBtn.Location = new Point(3, 3);
            PastaBtn.Name = "PastaBtn";
            PastaBtn.Size = new Size(173, 60);
            PastaBtn.TabIndex = 4;
            PastaBtn.Text = "Паста";
            PastaBtn.UseVisualStyleBackColor = true;
            PastaBtn.Click += PastaBtn_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(ListItemsTLP, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(188, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(609, 444);
            tableLayoutPanel3.TabIndex = 1;
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
            ListItemsTLP.Size = new Size(603, 349);
            ListItemsTLP.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.7611923F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.3532333F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0514088F));
            tableLayoutPanel4.Controls.Add(CqlaSumaLbl, 0, 0);
            tableLayoutPanel4.Controls.Add(RazplashtaneBtn, 1, 0);
            tableLayoutPanel4.Controls.Add(IztrivaneBtn, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 358);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(603, 83);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // CqlaSumaLbl
            // 
            CqlaSumaLbl.AutoSize = true;
            CqlaSumaLbl.Dock = DockStyle.Fill;
            CqlaSumaLbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CqlaSumaLbl.Location = new Point(3, 0);
            CqlaSumaLbl.Name = "CqlaSumaLbl";
            CqlaSumaLbl.Size = new Size(281, 83);
            CqlaSumaLbl.TabIndex = 0;
            CqlaSumaLbl.Text = "Тук се пише цената";
            CqlaSumaLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RazplashtaneBtn
            // 
            RazplashtaneBtn.Dock = DockStyle.Fill;
            RazplashtaneBtn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RazplashtaneBtn.Location = new Point(290, 3);
            RazplashtaneBtn.Name = "RazplashtaneBtn";
            RazplashtaneBtn.Size = new Size(170, 77);
            RazplashtaneBtn.TabIndex = 1;
            RazplashtaneBtn.Text = "Разплащане";
            RazplashtaneBtn.UseVisualStyleBackColor = true;
            RazplashtaneBtn.Click += RazplashtaneBtn_Click;
            // 
            // IztrivaneBtn
            // 
            IztrivaneBtn.Dock = DockStyle.Fill;
            IztrivaneBtn.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            IztrivaneBtn.Location = new Point(466, 3);
            IztrivaneBtn.Name = "IztrivaneBtn";
            IztrivaneBtn.Size = new Size(134, 77);
            IztrivaneBtn.TabIndex = 2;
            IztrivaneBtn.Text = "Изтриване на поръчка";
            IztrivaneBtn.UseVisualStyleBackColor = true;
            IztrivaneBtn.Click += IztrivaneBtn_Click;
            // 
            // IndividualnaPorucha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "IndividualnaPorucha";
            Text = "IndividualnaPorucha";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button NapitkiBtn;
        private Button DessertButton;
        private Button NazadBtn;
        private TableLayoutPanel ListItemsTLP;
        private Button PastaBtn;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label CqlaSumaLbl;
        private Button RazplashtaneBtn;
        private Button IztrivaneBtn;
    }
}