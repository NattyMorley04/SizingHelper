﻿
namespace SizingHelper
{
    partial class Area
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
            this.btnGo = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(80, 111);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(82, 55);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(80, 34);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(118, 27);
            this.txtArea.TabIndex = 1;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(31, 37);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(43, 20);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area:";
            // 
            // Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 206);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.btnGo);
            this.Name = "Area";
            this.Text = "Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
    }
}