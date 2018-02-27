// Fenix Ruler Screen 1.0
// © Ismael Heredia , Argentina , 2018
// Based in ruler by Jeff Key
// Thanks to Jeff Key

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FenixRulerScreen
{
    public partial class FormHome : Form
    {
        Helpers helper = new Helpers();

        string application_title = "Fenix Ruler Screen 1.0";
        string app_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

        public FormHome()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            helper.play_sound("click");

            if (txtDimensions.Text == "")
            {
                MessageBox.Show("Use ruler first, to find dimensions", application_title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Clipboard.Clear();
                    Clipboard.SetText(txtDimensions.Text);
                    MessageBox.Show("Dimensions copied", application_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error copying dimensions", application_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOpenRuler_Click(object sender, EventArgs e)
        {
            helper.play_sound("click");

            string ruler_path = app_path + "/Data/Ruler.exe";
            System.Diagnostics.Process.Start(ruler_path);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            helper.play_sound("click");

            MessageBox.Show("For use this program, open the ruler in the program, in the ruler, select the area and use mouse doble click for capture the dimensions", application_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
            
        private void tmFindDimensions_Tick(object sender, EventArgs e)
        {
            string dimensions_file = app_path + "/Data/options.zzz";
            if (File.Exists(dimensions_file))
            {
                string output = System.IO.File.ReadAllText(dimensions_file);
                if (output.Contains("x"))
                {
                    string[] dimensions = output.Split(new[] { "x" }, StringSplitOptions.None);
                    int width = Convert.ToInt32(dimensions[0]);
                    int height = Convert.ToInt32(dimensions[1]);
                    string result = width + " x " + height + " px";
                    txtDimensions.Text = result;
                    File.Delete(dimensions_file);
                    helper.play_sound("done");
                }
            }
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("Ruler"))
            {
                process.Kill();
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            helper.play_sound("loaded");
        }
    }
}
