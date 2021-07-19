
namespace TeeChartAreaGraphSeriesOrder
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
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.cboAreaType = new System.Windows.Forms.ComboBox();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.cboAreaType);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(800, 90);
            this.pnlOptions.TabIndex = 0;
            // 
            // cboAreaType
            // 
            this.cboAreaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAreaType.FormattingEnabled = true;
            this.cboAreaType.Items.AddRange(new object[] {
            "Default Area",
            "Custom Area"});
            this.cboAreaType.Location = new System.Drawing.Point(13, 23);
            this.cboAreaType.Name = "cboAreaType";
            this.cboAreaType.Size = new System.Drawing.Size(242, 40);
            this.cboAreaType.TabIndex = 0;
            this.cboAreaType.SelectedIndexChanged += new System.EventHandler(this.cboAreaType_SelectedIndexChanged);
            // 
            // pnlChart
            // 
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChart.Location = new System.Drawing.Point(0, 90);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(800, 360);
            this.pnlChart.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlChart);
            this.Controls.Add(this.pnlOptions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.ComboBox cboAreaType;
        private System.Windows.Forms.Panel pnlChart;
    }
}

