
namespace SizingHelper
{
    partial class Main
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSizingTool = new System.Windows.Forms.Button();
            this.btnPatternViewer = new System.Windows.Forms.Button();
            this.btnPatternImport = new System.Windows.Forms.Button();
            this.btnGeneralSettings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(72, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sizing Helper";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSizingTool
            // 
            this.btnSizingTool.Location = new System.Drawing.Point(113, 80);
            this.btnSizingTool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSizingTool.Name = "btnSizingTool";
            this.btnSizingTool.Size = new System.Drawing.Size(132, 22);
            this.btnSizingTool.TabIndex = 1;
            this.btnSizingTool.Text = "Sizing Tool";
            this.btnSizingTool.UseVisualStyleBackColor = true;
            this.btnSizingTool.Click += new System.EventHandler(this.btnSizingTool_Click);
            // 
            // btnPatternViewer
            // 
            this.btnPatternViewer.Location = new System.Drawing.Point(113, 106);
            this.btnPatternViewer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPatternViewer.Name = "btnPatternViewer";
            this.btnPatternViewer.Size = new System.Drawing.Size(132, 22);
            this.btnPatternViewer.TabIndex = 2;
            this.btnPatternViewer.Text = "Pattern Viewer";
            this.btnPatternViewer.UseVisualStyleBackColor = true;
            this.btnPatternViewer.Click += new System.EventHandler(this.btnPatternViewer_Click);
            // 
            // btnPatternImport
            // 
            this.btnPatternImport.Location = new System.Drawing.Point(113, 132);
            this.btnPatternImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPatternImport.Name = "btnPatternImport";
            this.btnPatternImport.Size = new System.Drawing.Size(132, 22);
            this.btnPatternImport.TabIndex = 3;
            this.btnPatternImport.Text = "Pattern Import";
            this.btnPatternImport.UseVisualStyleBackColor = true;
            this.btnPatternImport.Click += new System.EventHandler(this.btnPatternImport_Click);
            // 
            // btnGeneralSettings
            // 
            this.btnGeneralSettings.Location = new System.Drawing.Point(113, 158);
            this.btnGeneralSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeneralSettings.Name = "btnGeneralSettings";
            this.btnGeneralSettings.Size = new System.Drawing.Size(132, 22);
            this.btnGeneralSettings.TabIndex = 4;
            this.btnGeneralSettings.Text = "General Settings";
            this.btnGeneralSettings.UseVisualStyleBackColor = true;
            this.btnGeneralSettings.Click += new System.EventHandler(this.btnGeneralSettings_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(113, 184);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 22);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 248);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGeneralSettings);
            this.Controls.Add(this.btnPatternImport);
            this.Controls.Add(this.btnPatternViewer);
            this.Controls.Add(this.btnSizingTool);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Sizing Helper";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSizingTool;
        private System.Windows.Forms.Button btnPatternViewer;
        private System.Windows.Forms.Button btnPatternImport;
        private System.Windows.Forms.Button btnGeneralSettings;
        private System.Windows.Forms.Button btnExit;
    }
}

