using System.Drawing;
using System.Windows.Forms;

namespace PastaMadnessSystem
{
    partial class Poruchki
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
            ZadenTpl = new TableLayoutPanel();
            GorenTPL = new TableLayoutPanel();
            NovaPoruchkaBtn = new Button();
            GlovoBtn = new Button();
            TakeawayBtn = new Button();
            NazadBtn = new Button();
            ListSPoruchkiTLP = new TableLayoutPanel();
            ZadenTpl.SuspendLayout();
            GorenTPL.SuspendLayout();
            SuspendLayout();
            // 
            // ZadenTpl
            // 
            ZadenTpl.ColumnCount = 1;
            ZadenTpl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ZadenTpl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            ZadenTpl.Controls.Add(GorenTPL, 0, 0);
            ZadenTpl.Controls.Add(ListSPoruchkiTLP, 0, 1);
            ZadenTpl.Dock = DockStyle.Fill;
            ZadenTpl.Location = new Point(0, 0);
            ZadenTpl.Name = "ZadenTpl";
            ZadenTpl.RowCount = 2;
            ZadenTpl.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5555553F));
            ZadenTpl.RowStyles.Add(new RowStyle(SizeType.Percent, 84.44444F));
            ZadenTpl.Size = new Size(800, 450);
            ZadenTpl.TabIndex = 0;
            // 
            // GorenTPL
            // 
            GorenTPL.ColumnCount = 4;
            GorenTPL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.345089F));
            GorenTPL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.0931988F));
            GorenTPL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.9596977F));
            GorenTPL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.47607F));
            GorenTPL.Controls.Add(NovaPoruchkaBtn, 0, 0);
            GorenTPL.Controls.Add(GlovoBtn, 1, 0);
            GorenTPL.Controls.Add(TakeawayBtn, 2, 0);
            GorenTPL.Controls.Add(NazadBtn, 3, 0);
            GorenTPL.Dock = DockStyle.Fill;
            GorenTPL.Location = new Point(3, 3);
            GorenTPL.Name = "GorenTPL";
            GorenTPL.RowCount = 1;
            GorenTPL.RowStyles.Add(new RowStyle());
            GorenTPL.Size = new Size(794, 64);
            GorenTPL.TabIndex = 0;
            // 
            // NovaPoruchkaBtn
            // 
            NovaPoruchkaBtn.Dock = DockStyle.Fill;
            NovaPoruchkaBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            NovaPoruchkaBtn.Location = new Point(3, 3);
            NovaPoruchkaBtn.Name = "NovaPoruchkaBtn";
            NovaPoruchkaBtn.Size = new Size(227, 58);
            NovaPoruchkaBtn.TabIndex = 0;
            NovaPoruchkaBtn.Text = "Създай Нова порчъка";
            NovaPoruchkaBtn.UseVisualStyleBackColor = true;
            NovaPoruchkaBtn.Click += NovaPoruchkaBtn_Click;
            // 
            // GlovoBtn
            // 
            GlovoBtn.Dock = DockStyle.Fill;
            GlovoBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            GlovoBtn.Location = new Point(236, 3);
            GlovoBtn.Name = "GlovoBtn";
            GlovoBtn.Size = new Size(225, 58);
            GlovoBtn.TabIndex = 1;
            GlovoBtn.Text = "Glovo";
            GlovoBtn.UseVisualStyleBackColor = true;
            GlovoBtn.Click += GlovoBtn_Click;
            // 
            // TakeawayBtn
            // 
            TakeawayBtn.Dock = DockStyle.Fill;
            TakeawayBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TakeawayBtn.Location = new Point(467, 3);
            TakeawayBtn.Name = "TakeawayBtn";
            TakeawayBtn.Size = new Size(216, 58);
            TakeawayBtn.TabIndex = 2;
            TakeawayBtn.Text = "Takeaway";
            TakeawayBtn.UseVisualStyleBackColor = true;
            TakeawayBtn.Click += TakeawayBtn_Click;
            // 
            // NazadBtn
            // 
            NazadBtn.Dock = DockStyle.Fill;
            NazadBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NazadBtn.Location = new Point(689, 3);
            NazadBtn.Name = "NazadBtn";
            NazadBtn.Size = new Size(102, 58);
            NazadBtn.TabIndex = 3;
            NazadBtn.Text = "Назад";
            NazadBtn.UseVisualStyleBackColor = true;
            NazadBtn.Click += NazadBtn_Click;
            // 
            // ListSPoruchkiTLP
            // 
            ListSPoruchkiTLP.AutoSize = true;
            ListSPoruchkiTLP.ColumnCount = 1;
            ListSPoruchkiTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ListSPoruchkiTLP.Location = new Point(3, 73);
            ListSPoruchkiTLP.Name = "ListSPoruchkiTLP";
            ListSPoruchkiTLP.RowCount = 1;
            ListSPoruchkiTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ListSPoruchkiTLP.Size = new Size(0, 0);
            ListSPoruchkiTLP.TabIndex = 1;
            // 
            // Poruchki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ZadenTpl);
            Name = "Poruchki";
            Text = "Poruchki";
            ZadenTpl.ResumeLayout(false);
            ZadenTpl.PerformLayout();
            GorenTPL.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ZadenTpl;
        private TableLayoutPanel GorenTPL;
        private Button NovaPoruchkaBtn;
        private Button GlovoBtn;
        private Button TakeawayBtn;
        private Button NazadBtn;
        private TableLayoutPanel ListSPoruchkiTLP;
    }
}