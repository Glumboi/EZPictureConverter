using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using EZPictureConverter_Remake.Core;
using EZPictureConverter_Remake.HelpWindow;
using Glumboi.UI;

namespace EZPictureConverter_Remake
{
    public partial class Form1 : Form
    {
        public string FileName { get; private set; } //Used for the checkbox and branches

        public int IconResolution { get; private set; } //Used for the ico converter

        private HelpForm helpForm = new HelpForm();
        
        public Form1()
        {
            InitializeComponent();
            
            this.Activated += Form1_Activated;
            this.Deactivate += Form1_Deactivate;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Hotkeys.Unloadhotkeys(this);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Hotkeys.LoadHotkeys(this);
        }

        /// <summary>
        ///This doesn't load real settings rather it just sets the format and resolution to the recommended
        /// </summary>
        private void LoadSettings()
        {
            Dropdown_Convert_Format.SelectedItem = Dropdown_Convert_Format.Items[1];
            Dropdown_Ico_Res.SelectedItem = Dropdown_Ico_Res.Items[0];
        }

        /// <summary>
        /// Function that fires the filesaver save function and the converter function which is called":
        /// "CheckselectedFormatAndConvert"
        /// </summary>
        private async void CheckSelectedIndexAndConvert()
        {
            if (FileName == null)
            {
                MessageBox.Show("Please select an image to convert first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FileSaver.SaveFile();
                CheckselectedFormatAndConvert();
            }
        }

        /// <summary>
        /// Gets the selected format and fires the needed converter functions, not my cleanest work it works so.
        /// </summary>
        private void CheckselectedFormatAndConvert()
        {
            if (Dropdown_Convert_Format.SelectedIndex == 0)
            {
                try
                {
                    Converter.Convert(FileOpener.FilePath, FileSaver.FileName, IconResolution);
                }
                catch (IOException ex)
                {
                    if (FileSaver.Action == "Canceled") return;

                    MessageBox.Show("Could not convert the image into .ICO. \nMake sure you selected a non corrupted image!\n\nDetailed error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Dropdown_Convert_Format.SelectedIndex == 1)
            {
                System.Drawing.Image image = System.Drawing.Image.FromFile(FileName);

                var byteImage = ImageByte.ByteArrayToImage(ImageByte.ImageToByteArray(image));

                if (FileSaver.FileName == null)
                {
                    return;
                }
                else
                {
                    try
                    {
                        byteImage.Save(FileSaver.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    catch
                    {
                        if (FileSaver.Action == "Canceled") return;

                        MessageBox.Show("Could not convert the image into .PNG. \nMake sure you selected a non corrupted image!");
                    }
                }
            }
            else if (Dropdown_Convert_Format.SelectedIndex == 2)
            {
                try
                {
                    System.Drawing.Image image = System.Drawing.Image.FromFile(FileName);

                    var byteImage = ImageByte.ByteArrayToImage(ImageByte.ImageToByteArray(image));
                    byteImage.Save(FileSaver.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    if (FileSaver.Action == "Canceled") return;

                    MessageBox.Show("Could not convert the image into .JPEG. \nMake sure you selected a non corrupted image!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UIChanger.ChangeTitlebarToDark(Handle);

            LoadSettings();
        }

        private void Button_Open_Image_Click(object sender, EventArgs e)
        {
            FileOpener.OpenIamge();

            Textbox_Path.Text = FileOpener.FilePath;

            FileName = FileOpener.FilePath;
        }

        private void Button_Convert_Click(object sender, EventArgs e)
        {
            CheckSelectedIndexAndConvert();
        }

        private void ResizeForm(int x, int y)
        {
            this.Size = new Size(x, y);
        }

        private void Dropdown_Convert_Format_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Dropdown_Convert_Format.SelectedIndex)
            {
                case 0:
                    FileSaver.FormatOfSaveFile = "Image Files(*.ico;)|*.ico;";
                    Dropdown_Ico_Res.Visible = true;
                    ResizeForm(456, 193);
                    break;

                case 1:
                    FileSaver.FormatOfSaveFile = "Image Files(*.png;)|*.png;";
                    Dropdown_Ico_Res.Visible = false;
                    ResizeForm(456, 142);
                    break;

                case 2:
                    FileSaver.FormatOfSaveFile = "Image Files(*.jpeg;)|*.jpeg;";
                    Dropdown_Ico_Res.Visible = false;
                    ResizeForm(456, 142);
                    break;
            }
        }

        private void Textbox_Path_Path_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            FileOpener.FilePath = fileList[0];
            FileOpener.FileNameWithoutPath = Path.GetFileNameWithoutExtension(fileList[0]);
            FileName = fileList[0];
            Textbox_Path.Text = FileName;
        }

        private void Textbox_Path_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Dropdown_Ico_Res_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stringRes = Dropdown_Ico_Res.SelectedItem.ToString();
            IconResolution = Int32.Parse(stringRes);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0312 when m.WParam.ToInt32() == (int)Hotkeys.HotkeyIDs.HotkeyID:
                    FileOpener.OpenIamge();

                    Textbox_Path.Text = FileOpener.FilePath;

                    FileName = FileOpener.FilePath;
                    break;
                case 0x0312 when m.WParam.ToInt32() == (int)Hotkeys.HotkeyIDs.HotkeyID2:
                    CheckSelectedIndexAndConvert();
                    break;
                case 0x0312 when m.WParam.ToInt32() == (int)Hotkeys.HotkeyIDs.HotkeyID3:
                    helpForm.Show();
                    break;
            }

            base.WndProc(ref m);
        }
    }
}
