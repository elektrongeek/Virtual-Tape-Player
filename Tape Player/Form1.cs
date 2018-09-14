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
            File_Dialog.ShowDialog();
            String Filepath;
            Filepath = File_Dialog.FileName;
            label1.Text = Filepath;
            Player.URL = Filepath;
        }
    }
}
