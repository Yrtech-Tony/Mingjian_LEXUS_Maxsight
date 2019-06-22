namespace XHX.View
{
    partial class AllPictureShow2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.kpImageViewer1 = new KaiwaProjects.KpImageViewer();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWarn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblWarn);
            this.panel1.Controls.Add(this.lblSum);
            this.panel1.Controls.Add(this.lblCurrent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 42);
            this.panel1.TabIndex = 3;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(367, 11);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "下一张";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(223, 11);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 5;
            this.btnPre.Text = "上一张";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // kpImageViewer1
            // 
            this.kpImageViewer1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.kpImageViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpImageViewer1.GifAnimation = false;
            this.kpImageViewer1.Image = null;
            this.kpImageViewer1.ImageList = null;
            this.kpImageViewer1.Location = new System.Drawing.Point(0, 42);
            this.kpImageViewer1.MenuColor = System.Drawing.Color.LightSteelBlue;
            this.kpImageViewer1.MenuPanelColor = System.Drawing.Color.LightSteelBlue;
            this.kpImageViewer1.MinimumSize = new System.Drawing.Size(618, 197);
            this.kpImageViewer1.Name = "kpImageViewer1";
            this.kpImageViewer1.NavigationPanelColor = System.Drawing.Color.LightSteelBlue;
            this.kpImageViewer1.NavigationTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kpImageViewer1.OpenButton = true;
            this.kpImageViewer1.PreviewButton = false;
            this.kpImageViewer1.PreviewPanelColor = System.Drawing.Color.LightSteelBlue;
            this.kpImageViewer1.PreviewText = "预览";
            this.kpImageViewer1.PreviewTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kpImageViewer1.Rotation = 0;
            this.kpImageViewer1.ShowPreview = true;
            this.kpImageViewer1.Size = new System.Drawing.Size(964, 600);
            this.kpImageViewer1.TabIndex = 4;
            this.kpImageViewer1.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(342, 15);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(14, 14);
            this.lblSum.TabIndex = 11;
            this.lblSum.Text = "1";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(309, 15);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(14, 14);
            this.lblCurrent.TabIndex = 10;
            this.lblCurrent.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "/";
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.ForeColor = System.Drawing.Color.Red;
            this.lblWarn.Location = new System.Drawing.Point(458, 15);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(0, 14);
            this.lblWarn.TabIndex = 12;
            // 
            // AllPictureShow2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 642);
            this.Controls.Add(this.kpImageViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "AllPictureShow2";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private KaiwaProjects.KpImageViewer kpImageViewer1;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWarn;
    }
}

