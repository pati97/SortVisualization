namespace SortVisualization
{
    partial class Form1
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
            this.cboAlgorithms1 = new System.Windows.Forms.ComboBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.pcbSort1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSort1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAlgorithms1
            // 
            this.cboAlgorithms1.FormattingEnabled = true;
            this.cboAlgorithms1.Location = new System.Drawing.Point(23, 264);
            this.cboAlgorithms1.Name = "cboAlgorithms1";
            this.cboAlgorithms1.Size = new System.Drawing.Size(172, 28);
            this.cboAlgorithms1.TabIndex = 1;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(261, 254);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(100, 38);
            this.btnShuffle.TabIndex = 2;
            this.btnShuffle.Text = "SHUFFLE";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(380, 254);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(103, 38);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "SORT";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // pcbSort1
            // 
            this.pcbSort1.BackColor = System.Drawing.Color.White;
            this.pcbSort1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbSort1.Location = new System.Drawing.Point(23, 12);
            this.pcbSort1.Name = "pcbSort1";
            this.pcbSort1.Size = new System.Drawing.Size(460, 211);
            this.pcbSort1.TabIndex = 4;
            this.pcbSort1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 337);
            this.Controls.Add(this.pcbSort1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.cboAlgorithms1);
            this.Name = "Form1";
            this.Text = "Sort Visualization";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSort1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAlgorithms1;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.PictureBox pcbSort1;
    }
}

