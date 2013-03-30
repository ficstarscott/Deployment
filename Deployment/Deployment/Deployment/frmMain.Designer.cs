namespace Deployment
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProject = new System.Windows.Forms.TabPage();
            this.tabDeploy = new System.Windows.Forms.TabPage();
            this.buttonNewProject = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProject);
            this.tabControl1.Controls.Add(this.tabDeploy);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 442);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProject
            // 
            this.tabProject.Controls.Add(this.buttonNewProject);
            this.tabProject.Location = new System.Drawing.Point(4, 22);
            this.tabProject.Name = "tabProject";
            this.tabProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabProject.Size = new System.Drawing.Size(841, 416);
            this.tabProject.TabIndex = 0;
            this.tabProject.Text = "Project";
            this.tabProject.UseVisualStyleBackColor = true;
            // 
            // tabDeploy
            // 
            this.tabDeploy.Location = new System.Drawing.Point(4, 22);
            this.tabDeploy.Name = "tabDeploy";
            this.tabDeploy.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeploy.Size = new System.Drawing.Size(192, 74);
            this.tabDeploy.TabIndex = 1;
            this.tabDeploy.Text = "Deployment";
            this.tabDeploy.UseVisualStyleBackColor = true;
            // 
            // buttonNewProject
            // 
            this.buttonNewProject.Location = new System.Drawing.Point(8, 19);
            this.buttonNewProject.Name = "buttonNewProject";
            this.buttonNewProject.Size = new System.Drawing.Size(75, 23);
            this.buttonNewProject.TabIndex = 0;
            this.buttonNewProject.Text = "New Project";
            this.buttonNewProject.UseVisualStyleBackColor = true;
            this.buttonNewProject.Click += new System.EventHandler(this.buttonNewProject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 442);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabProject.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProject;
        private System.Windows.Forms.TabPage tabDeploy;
        private System.Windows.Forms.Button buttonNewProject;
    }
}

