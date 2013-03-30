using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deployment
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void buttonNewProject_Click(object sender, EventArgs e)
        {
            DisplayNewProjectForm();
        }

        private static void DisplayNewProjectForm()
        {
            Form newProject = frmNewProject;

            Label labelName = new Label();
            labelName.Name = "labelName";
            labelName.Text = "Name:";

            project.newProject

            project.Show();
        }
        private static Form CreateProjectForm()
        {
        }

    }
}
