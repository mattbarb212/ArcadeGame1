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

namespace ArcadeGame1
{
    public partial class ArcadeMachineLabel : Form
    {
        public ArcadeMachineLabel()
        {
            InitializeComponent();
        }

        private void StartButton1_Click(object sender, EventArgs e)
        {
            StartButton1.Visible = false;
            CountdownLabel.BackColor = Color.White;
            NumberLabel3.BackColor = Color.White;
            NumberLabel3.Visible = true;
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources._557263__zzztefanos__zzzbeats_miscellaneous_music_fragments_0039);
            alertPlayer.Play();

            Refresh();
            Thread.Sleep(1000);

            CountdownLabel.BackColor = Color.White;
            NumberLabel3.Visible = false;
            NumberLabel2.BackColor = Color.White;
            NumberLabel2.Visible = true;
            alertPlayer.Play();

            Refresh();
            Thread.Sleep(1000);

            CountdownLabel.BackColor = Color.White;
            NumberLabel2.Visible = false;
            NumberLabel1.BackColor = Color.White;
            NumberLabel1.Visible = true;
            alertPlayer.Play();

            Refresh();
            Thread.Sleep(1000);

            CountdownLabel.BackColor = Color.Black;
            NumberLabel1.Visible = false;
            BeginLabel.BackColor = Color.White;
            alertPlayer.Play();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void NumberLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BeginLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
