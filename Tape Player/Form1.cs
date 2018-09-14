using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tape_PLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void Load_File_Click(object sender, EventArgs e)
        {
            //Opening File selector
            File_Dialog.ShowDialog();
            //Creating a string to hold filepath given by file selector
            String Filepath;
            //Filling filepath given by file selector inside the string "filepath"
            Filepath = File_Dialog.FileName;
            //Just to check the filepaht (can be removed)
            label1.Text = Filepath;
            //Setting filepath as the source for the embeded Windows Media Player
            Player.URL = Filepath;
            //Stop the the embeded Windows Media Player cause it will autostart instead
            Player.Ctlcontrols.stop();
            
        }

        private void Play_Button_Click(object sender, EventArgs e)
        {
            //Send Play signal to the embeded Windows Media Player
            Player.Ctlcontrols.play();
        }

        private void Pause_Button_Click(object sender, EventArgs e)
        {
            //Send Pause signal to the embeded Windows Media Player
            Player.Ctlcontrols.pause();
        }
    }
}
