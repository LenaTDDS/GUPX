using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GUPX
{
    public partial class Form1 : Form
    {
        private static string comtype = "";
        private static string filepath = "";
        private static string force = "";
        


        public Form1()
        {
            InitializeComponent();
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Exe Files|*.exe;*.dll";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = Path.GetFullPath(openFileDialog.FileName);
                    TextBox.Text = filepath;


                }
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://vk.com/lenatdds");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://soulcommunity.site");
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comtype = "-1";
            }
        }
	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                comtype = "-2";
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                comtype = "-3";
            }
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                comtype = "-4";
            }
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                comtype = "-5";
            }
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                comtype = "-6";
            }
        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                comtype = "-7";
            }
        }

        private void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                comtype = "-8";
            }
        }

        private void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                comtype = "-9";
            }
        }
	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                force = "-f";
            }
            else
            {
                force = "";
            }
        }

        private void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                comtype = "--best";
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            File.WriteAllText("temp.bat", "upx.exe" + " " + comtype + " " + force + " " + '\u0022' + filepath + '\u0022' + "\npause");
            Process.Start("temp.bat");

        }

        
    }
    }

