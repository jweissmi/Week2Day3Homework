using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2Day3Homework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void HumanButton_Click(object sender, EventArgs e)
        {
            panelHumanDesign.Show();
            panelDogDesign.Hide();
            panelSnakeDesign.Hide();
            panelLizardDesign.Hide();
        }

        private void DogButton_Click(object sender, EventArgs e)
        {
            panelDogDesign.Show();
            panelHumanDesign.Hide();
            panelSnakeDesign.Hide();
            panelLizardDesign.Hide();
        }

        private void panelSelection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHumanDesign_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonHumanDesignCancel_Click_1(object sender, EventArgs e)
        {
            panelHumanDesign.Hide();
        }

        private void buttonDogDesignCancel_Click(object sender, EventArgs e)
        {
            panelDogDesign.Hide();
        }

        private void buttonSnake_Click(object sender, EventArgs e)
        {
            panelSnakeDesign.Show();
            panelHumanDesign.Hide();
            panelDogDesign.Hide();
            panelLizardDesign.Hide();

        }

        private void buttonSnakeDesignCancel_Click(object sender, EventArgs e)
        {
            panelSnakeDesign.Hide();
        }

        private void buttonLizard_Click(object sender, EventArgs e)
        {
            panelLizardDesign.Show();
            panelHumanDesign.Hide();
            panelDogDesign.Hide();
            panelSnakeDesign.Hide();
        }

        private void buttonLizardDesignCancel_Click(object sender, EventArgs e)
        {
            panelLizardDesign.Hide();
        }
    }
}
