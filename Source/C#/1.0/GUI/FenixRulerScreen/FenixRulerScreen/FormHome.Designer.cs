namespace FenixRulerScreen
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbHome = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnOpenRuler = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtDimensions = new System.Windows.Forms.TextBox();
            this.lblDimensions = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pbAbout = new System.Windows.Forms.PictureBox();
            this.tmFindDimensions = new System.Windows.Forms.Timer(this.components);
            this.tcMenu.SuspendLayout();
            this.tpHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbHome.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.tpHome);
            this.tcMenu.Controls.Add(this.tabPage2);
            this.tcMenu.Location = new System.Drawing.Point(12, 12);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(483, 243);
            this.tcMenu.TabIndex = 1;
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.pbLogo);
            this.tpHome.Controls.Add(this.gbHome);
            this.tpHome.Location = new System.Drawing.Point(4, 22);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(475, 217);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(17, 16);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(441, 96);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // gbHome
            // 
            this.gbHome.Controls.Add(this.btnHelp);
            this.gbHome.Controls.Add(this.btnOpenRuler);
            this.gbHome.Controls.Add(this.btnCopy);
            this.gbHome.Controls.Add(this.txtDimensions);
            this.gbHome.Controls.Add(this.lblDimensions);
            this.gbHome.Location = new System.Drawing.Point(17, 130);
            this.gbHome.Name = "gbHome";
            this.gbHome.Size = new System.Drawing.Size(441, 67);
            this.gbHome.TabIndex = 0;
            this.gbHome.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(359, 27);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnOpenRuler
            // 
            this.btnOpenRuler.Location = new System.Drawing.Point(278, 27);
            this.btnOpenRuler.Name = "btnOpenRuler";
            this.btnOpenRuler.Size = new System.Drawing.Size(75, 23);
            this.btnOpenRuler.TabIndex = 3;
            this.btnOpenRuler.Text = "Open Ruler";
            this.btnOpenRuler.UseVisualStyleBackColor = true;
            this.btnOpenRuler.Click += new System.EventHandler(this.btnOpenRuler_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(197, 27);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtDimensions
            // 
            this.txtDimensions.Location = new System.Drawing.Point(91, 27);
            this.txtDimensions.Name = "txtDimensions";
            this.txtDimensions.ReadOnly = true;
            this.txtDimensions.Size = new System.Drawing.Size(100, 20);
            this.txtDimensions.TabIndex = 1;
            // 
            // lblDimensions
            // 
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.Location = new System.Drawing.Point(15, 27);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(70, 13);
            this.lblDimensions.TabIndex = 0;
            this.lblDimensions.Text = "Dimensions : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblAbout);
            this.tabPage2.Controls.Add(this.pbAbout);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(475, 217);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(231, 33);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(128, 65);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = "Written by Ismael Heredia\r\n\r\nBased in ruler by Jeff Key\r\n\r\nThanks to Jeff Key";
            // 
            // pbAbout
            // 
            this.pbAbout.Image = ((System.Drawing.Image)(resources.GetObject("pbAbout.Image")));
            this.pbAbout.Location = new System.Drawing.Point(36, 33);
            this.pbAbout.Name = "pbAbout";
            this.pbAbout.Size = new System.Drawing.Size(173, 148);
            this.pbAbout.TabIndex = 0;
            this.pbAbout.TabStop = false;
            // 
            // tmFindDimensions
            // 
            this.tmFindDimensions.Enabled = true;
            this.tmFindDimensions.Interval = 500;
            this.tmFindDimensions.Tick += new System.EventHandler(this.tmFindDimensions_Tick);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 266);
            this.Controls.Add(this.tcMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHome";
            this.Text = "Fenix Ruler Screen 1.0 - © Ismael Heredia , Argentina , 2018";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.tcMenu.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbHome.ResumeLayout(false);
            this.gbHome.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbHome;
        private System.Windows.Forms.Label lblDimensions;
        private System.Windows.Forms.TextBox txtDimensions;
        private System.Windows.Forms.Button btnOpenRuler;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbAbout;
        private System.Windows.Forms.Timer tmFindDimensions;
        private System.Windows.Forms.Label lblAbout;
    }
}

