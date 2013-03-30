namespace Deployment
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabProject = new System.Windows.Forms.TabPage();
            this.tabDelpoyment = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabProject);
            this.tabControlMain.Controls.Add(this.tabDelpoyment);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(570, 314);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabProject
            // 
            this.tabProject.Location = new System.Drawing.Point(4, 22);
            this.tabProject.Name = "tabProject";
            this.tabProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabProject.Size = new System.Drawing.Size(562, 288);
            this.tabProject.TabIndex = 0;
            this.tabProject.Text = "Project";
            this.tabProject.UseVisualStyleBackColor = true;
            // 
            // tabDelpoyment
            // 
            this.tabDelpoyment.Location = new System.Drawing.Point(4, 22);
            this.tabDelpoyment.Name = "tabDelpoyment";
            this.tabDelpoyment.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelpoyment.Size = new System.Drawing.Size(562, 288);
            this.tabDelpoyment.TabIndex = 1;
            this.tabDelpoyment.Text = "Deployment";
            this.tabDelpoyment.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 314);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabProject;
        private System.Windows.Forms.TabPage tabDelpoyment;
    }
}

