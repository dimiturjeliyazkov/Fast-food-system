using System.Drawing;
using System.Windows.Forms;

namespace PastaMadnessSystem
{
    partial class Napitki
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
            KolaBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            FantaBtn = new Button();
            VodaBtn = new Button();
            StudenChaiBtn = new Button();
            VinoBtn = new Button();
            NazadBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // KolaBtn
            // 
            KolaBtn.Dock = DockStyle.Fill;
            KolaBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            KolaBtn.Location = new Point(3, 3);
            KolaBtn.Name = "KolaBtn";
            KolaBtn.Size = new Size(154, 102);
            KolaBtn.TabIndex = 0;
            KolaBtn.Text = "Кола";
            KolaBtn.UseVisualStyleBackColor = true;
            KolaBtn.Click += KolaBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(KolaBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(FantaBtn, 1, 0);
            tableLayoutPanel1.Controls.Add(VodaBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(StudenChaiBtn, 3, 0);
            tableLayoutPanel1.Controls.Add(VinoBtn, 4, 0);
            tableLayoutPanel1.Controls.Add(NazadBtn, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // FantaBtn
            // 
            FantaBtn.Dock = DockStyle.Fill;
            FantaBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FantaBtn.Location = new Point(163, 3);
            FantaBtn.Name = "FantaBtn";
            FantaBtn.Size = new Size(154, 102);
            FantaBtn.TabIndex = 1;
            FantaBtn.Text = "Фанта";
            FantaBtn.UseVisualStyleBackColor = true;
            FantaBtn.Click += FantaBtn_Click;
            // 
            // VodaBtn
            // 
            VodaBtn.Dock = DockStyle.Fill;
            VodaBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            VodaBtn.Location = new Point(323, 3);
            VodaBtn.Name = "VodaBtn";
            VodaBtn.Size = new Size(154, 102);
            VodaBtn.TabIndex = 2;
            VodaBtn.Text = "Вода";
            VodaBtn.UseVisualStyleBackColor = true;
            VodaBtn.Click += VodaBtn_Click;
            // 
            // StudenChaiBtn
            // 
            StudenChaiBtn.Dock = DockStyle.Fill;
            StudenChaiBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            StudenChaiBtn.Location = new Point(483, 3);
            StudenChaiBtn.Name = "StudenChaiBtn";
            StudenChaiBtn.Size = new Size(154, 102);
            StudenChaiBtn.TabIndex = 3;
            StudenChaiBtn.Text = "Студен чай";
            StudenChaiBtn.UseVisualStyleBackColor = true;
            StudenChaiBtn.Click += StudenChaiBtn_Click;
            // 
            // VinoBtn
            // 
            VinoBtn.Dock = DockStyle.Fill;
            VinoBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            VinoBtn.Location = new Point(643, 3);
            VinoBtn.Name = "VinoBtn";
            VinoBtn.Size = new Size(154, 102);
            VinoBtn.TabIndex = 4;
            VinoBtn.Text = "Вино";
            VinoBtn.UseVisualStyleBackColor = true;
            VinoBtn.Click += VinoBtn_Click;
            // 
            // NazadBtn
            // 
            NazadBtn.Dock = DockStyle.Fill;
            NazadBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NazadBtn.Location = new Point(3, 111);
            NazadBtn.Name = "NazadBtn";
            NazadBtn.Size = new Size(154, 93);
            NazadBtn.TabIndex = 5;
            NazadBtn.Text = "Назад";
            NazadBtn.UseVisualStyleBackColor = true;
            NazadBtn.Click += NazadBtn_Click;
            // 
            // Napitki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Napitki";
            Text = "Napitki";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button KolaBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Button FantaBtn;
        private Button VodaBtn;
        private Button StudenChaiBtn;
        private Button VinoBtn;
        private Button NazadBtn;
    }
}