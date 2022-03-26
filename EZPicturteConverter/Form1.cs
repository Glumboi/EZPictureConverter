using EZPicturteConverter.Core;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZPicturteConverter
{
    public partial class Form_converter : Form
    {
        private string filename;
        private string filesave;
        private string fileformat;
        private int ICO_res = 128;
        private bool ico_selected;

        private string[] links = { "https://github.com/Glumboi/", "https://github.com/Glumboi/EZPictureConverter" };

        public Form_converter()
        {
            InitializeComponent();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.ico)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.ico";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = open.FileName;
                filename = open.FileName;
            }
        }

        //This will check on combobox change which format got selected

        private void comboBox_formats_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox_formats.SelectedIndex;

            if (selectedIndex == 0)
            {
                fileformat = "Image Files(*.ico;)|*.ico;";
                ico_selected = true;
            }
            if (selectedIndex == 1)
            {
                fileformat = "Image Files(*.png;)|*.png;";
                ico_selected = false;
            }
            if (selectedIndex == 2)
            {
                fileformat = "Image Files(*.jpeg;)|*.jpeg;";
                ico_selected = false;
            }

            switch (selectedIndex)
            {
                case 0:
                    fileformat = "Image Files(*.ico;)|*.ico;";
                    ico_selected = true;
                    break;
                
                case 1:
                    fileformat = "Image Files(*.png;)|*.png;";
                    ico_selected = false;
                    break;

                case 2:
                    fileformat = "Image Files(*.jpeg;)|*.jpeg;";
                    ico_selected = false;
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_formats.SelectedIndex = 1;
            comboBox_resolution.SelectedIndex = 0;
            

        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            convert();   
        }

        private void convert()
        {
            if (filename == null)
            {
                MessageBox.Show("Slelect a file first!");
            }
            else
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = fileformat;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    saveFileDialog.Filter = fileformat;
                    filesave = saveFileDialog.FileName;
                }

                try
                {
                    checkselectedformat();
                }
                catch
                {
                    MessageBox.Show("Could not check the selected format.\nPlease try again or check if the iamge is corrupted!");
                }
            }
        }

        private void checkselectedformat()
        {

            if (comboBox_formats.SelectedIndex == 0)
            {
                try 
                { 
                    PngIconConverter.Convert(filename, filesave, ICO_res);
                }
                catch
                {
                    MessageBox.Show("Could not convert the image into .ICO. \nMake sure you selected a non corrupted image!");
                }
            }
            else if (comboBox_formats.SelectedIndex == 1)
            {
                System.Drawing.Image image = System.Drawing.Image.FromFile(filename);
                if (filesave == null)
                {
                    return;
                }
                else
                {
                    try
                    {
                        image.Save(filesave, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    catch
                    {
                        MessageBox.Show("Could not convert the image into .PNG. \nMake sure you selected a non corrupted image!");
                    }
                }
            }
            else if (comboBox_formats.SelectedIndex == 2)
            {
                try
                {
                    System.Drawing.Image image = System.Drawing.Image.FromFile(filename);
                    image.Save(filesave, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("Could not convert the image into .JPEG. \nMake sure you selected a non corrupted image!");
                }
            }
        }

        private void comboBox_reselution_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_resolution.SelectedIndex)
            {
                case 0:
                    ICO_res = 128;
                    break;

                case 1:
                    ICO_res = 64;
                    break;

                case 2:
                    ICO_res = 48;
                    break;

                case 3:
                    ICO_res = 32;
                    break;

                case 4:
                    ICO_res = 16;
                    break;
            }
        }

        private void OnTick_Tick(object sender, EventArgs e)
        { 
            switch (ico_selected)
            {
                case true:
                    label_Resolution.Visible = true;
                    comboBox_resolution.Visible = true;
                    break;
                case false:
                    label_Resolution.Visible = false;
                    comboBox_resolution.Visible = false;
                    break;
            }           
        }

        private void linkLabel_Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(links[0]);
        }

        private void linkLabel_version_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(links[1]);
        }
    }
}