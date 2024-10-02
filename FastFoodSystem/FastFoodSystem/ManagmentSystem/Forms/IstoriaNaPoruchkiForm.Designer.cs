namespace FastFoodSystem.ManagmentSystem.Forms
{
    partial class IstoriaNaPoruchkiForm
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
            this.NazadBtn = new System.Windows.Forms.Button();
            this.DostavchiTLP = new System.Windows.Forms.FlowLayoutPanel();
            this.ElementsTLP = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.25F));
            this.tableLayoutPanel1.Controls.Add(this.NazadBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DostavchiTLP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ElementsTLP, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // NazadBtn
            // 
            this.NazadBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NazadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NazadBtn.Location = new System.Drawing.Point(401, 3);
            this.NazadBtn.Name = "NazadBtn";
            this.NazadBtn.Size = new System.Drawing.Size(396, 70);
            this.NazadBtn.TabIndex = 2;
            this.NazadBtn.Text = "Назад";
            this.NazadBtn.UseVisualStyleBackColor = true;
            this.NazadBtn.Click += new System.EventHandler(this.NazadBtn_Click);
            // 
            // DostavchiTLP
            // 
            this.DostavchiTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DostavchiTLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DostavchiTLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DostavchiTLP.Location = new System.Drawing.Point(3, 79);
            this.DostavchiTLP.Name = "DostavchiTLP";
            this.DostavchiTLP.Size = new System.Drawing.Size(392, 368);
            this.DostavchiTLP.TabIndex = 3;
            this.DostavchiTLP.Paint += new System.Windows.Forms.PaintEventHandler(this.DostavchiTLP_Paint);
            // 
            // ElementsTLP
            // 
            this.ElementsTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ElementsTLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ElementsTLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElementsTLP.Location = new System.Drawing.Point(401, 79);
            this.ElementsTLP.Name = "ElementsTLP";
            this.ElementsTLP.Size = new System.Drawing.Size(396, 368);
            this.ElementsTLP.TabIndex = 4;
            this.ElementsTLP.Paint += new System.Windows.Forms.PaintEventHandler(this.ElementsTLP_Paint);
            // 
            // IstoriaNaPoruchkiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IstoriaNaPoruchkiForm";
            this.Text = "IstoriaNaPoruchkiForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button NazadBtn;
        private System.Windows.Forms.FlowLayoutPanel DostavchiTLP;
        private System.Windows.Forms.FlowLayoutPanel ElementsTLP;
    }
}