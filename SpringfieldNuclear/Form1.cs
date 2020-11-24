using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace SpringfieldNuclear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void EnableReactor_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.alert);
            player.Play();
            titleLabel.Text = "Reactor Is Reacting...";
            reactor1StateLabel.BackColor = Color.Green;
            reactor2StateLabel.BackColor = Color.Green;
            Refresh();
            Thread.Sleep(1000);
            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            titleLabel.Text = "SYSTEM FAILURE";
            
        }   

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Reactor1StateLabel_Click(object sender, EventArgs e)
        {

        }

    }
}