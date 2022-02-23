using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZPicturteConverter.Core;

namespace EZPicturteConverter
{
    public partial class Form_converter : Form
    {
        string filename;
        string filesave;
        string fileformat;
        int ICO_res = 128;
        bool ico_selected;

        string[] links = { "https://github.com/Glumboi/", "https://github.com/Glumboi/EZPictureConverter" };

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
                // display image in picture box  
                //Bitmap bitmap = new Bitmap(open.FileName);
                //Image image = (Image)bitmap.Clone();
                //pictureBox_file.Image = image;
                // image file path  
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_formats.SelectedIndex = 1;
            comboBox_resolution.SelectedIndex = 0;
        }

        private void button_convert_Click(object sender, EventArgs e)
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

                checkselectedformat();
            }

        }

        private void checkselectedformat()
        {
            if (comboBox_formats.SelectedIndex == 0)
            {
                PngIconConverter.Convert(filename,filesave,ICO_res);
            }
            else if (comboBox_formats.SelectedIndex == 1)
            {
                System.Drawing.Image image = System.Drawing.Image.FromFile(filename);
                if(filesave == null)
                {
                    Close();
                }
                else
                {
                image.Save(filesave, System.Drawing.Imaging.ImageFormat.Png);

                }
            }
            else if (comboBox_formats.SelectedIndex == 2)
            {
                System.Drawing.Image image = System.Drawing.Image.FromFile(filename);
                image.Save(filesave, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void comboBox_reselution_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (comboBox_resolution.SelectedIndex == 0)
            {
                ICO_res = 128;
            }

            if (comboBox_resolution.SelectedIndex == 1)
            {
                ICO_res = 64;
            }
            else if (comboBox_resolution.SelectedIndex == 2)
            {
                ICO_res = 48;
            }
            else if (comboBox_resolution.SelectedIndex == 3)
            {
                ICO_res = 32;
            }
            else if (comboBox_resolution.SelectedIndex == 4)
            {
                ICO_res = 16;
            }
        }

        private void OnTick_Tick(object sender, EventArgs e)
        {
            if (ico_selected)
            {
                label_Resolution.Visible = true;
                comboBox_resolution.Visible = true;
            }
            else
            {
                label_Resolution.Visible = false;
                comboBox_resolution.Visible = false;
                return;
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
