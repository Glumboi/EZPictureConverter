namespace EZPictureConverter_Remake
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.Button_Open_Image = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Button_Convert = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Textbox_Path = new Bunifu.UI.WinForms.BunifuTextBox();
            this.Dropdown_Convert_Format = new Bunifu.UI.WinForms.BunifuDropdown();
            this.Dropdown_Ico_Res = new Bunifu.UI.WinForms.BunifuDropdown();
            this.SuspendLayout();
            // 
            // Button_Open_Image
            // 
            this.Button_Open_Image.AllowAnimations = true;
            this.Button_Open_Image.AllowMouseEffects = true;
            this.Button_Open_Image.AllowToggling = false;
            this.Button_Open_Image.AnimationSpeed = 200;
            this.Button_Open_Image.AutoGenerateColors = false;
            this.Button_Open_Image.AutoRoundBorders = true;
            this.Button_Open_Image.AutoSizeLeftIcon = true;
            this.Button_Open_Image.AutoSizeRightIcon = true;
            this.Button_Open_Image.BackColor = System.Drawing.Color.Transparent;
            this.Button_Open_Image.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Open_Image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Open_Image.BackgroundImage")));
            this.Button_Open_Image.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Open_Image.ButtonText = "Open image";
            this.Button_Open_Image.ButtonTextMarginLeft = 0;
            this.Button_Open_Image.ColorContrastOnClick = 45;
            this.Button_Open_Image.ColorContrastOnHover = 45;
            this.Button_Open_Image.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Button_Open_Image.CustomizableEdges = borderEdges1;
            this.Button_Open_Image.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button_Open_Image.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Open_Image.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Open_Image.DisabledForecolor = System.Drawing.Color.White;
            this.Button_Open_Image.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Button_Open_Image.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Open_Image.ForeColor = System.Drawing.Color.White;
            this.Button_Open_Image.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Open_Image.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Button_Open_Image.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Button_Open_Image.IconMarginLeft = 11;
            this.Button_Open_Image.IconPadding = 10;
            this.Button_Open_Image.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Open_Image.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Button_Open_Image.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Button_Open_Image.IconSize = 25;
            this.Button_Open_Image.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Open_Image.IdleBorderRadius = 37;
            this.Button_Open_Image.IdleBorderThickness = 1;
            this.Button_Open_Image.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Open_Image.IdleIconLeftImage = global::EZPictureConverter_Remake.Properties.Resources.open_folder;
            this.Button_Open_Image.IdleIconRightImage = null;
            this.Button_Open_Image.IndicateFocus = false;
            this.Button_Open_Image.Location = new System.Drawing.Point(278, 12);
            this.Button_Open_Image.Name = "Button_Open_Image";
            this.Button_Open_Image.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Open_Image.OnDisabledState.BorderRadius = 1;
            this.Button_Open_Image.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Open_Image.OnDisabledState.BorderThickness = 1;
            this.Button_Open_Image.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Open_Image.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.Button_Open_Image.OnDisabledState.IconLeftImage = null;
            this.Button_Open_Image.OnDisabledState.IconRightImage = null;
            this.Button_Open_Image.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Button_Open_Image.onHoverState.BorderRadius = 1;
            this.Button_Open_Image.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Open_Image.onHoverState.BorderThickness = 1;
            this.Button_Open_Image.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Button_Open_Image.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Button_Open_Image.onHoverState.IconLeftImage = null;
            this.Button_Open_Image.onHoverState.IconRightImage = null;
            this.Button_Open_Image.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Open_Image.OnIdleState.BorderRadius = 1;
            this.Button_Open_Image.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Open_Image.OnIdleState.BorderThickness = 1;
            this.Button_Open_Image.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Open_Image.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Button_Open_Image.OnIdleState.IconLeftImage = global::EZPictureConverter_Remake.Properties.Resources.open_folder;
            this.Button_Open_Image.OnIdleState.IconRightImage = null;
            this.Button_Open_Image.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Button_Open_Image.OnPressedState.BorderRadius = 1;
            this.Button_Open_Image.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Open_Image.OnPressedState.BorderThickness = 1;
            this.Button_Open_Image.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Button_Open_Image.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Button_Open_Image.OnPressedState.IconLeftImage = null;
            this.Button_Open_Image.OnPressedState.IconRightImage = null;
            this.Button_Open_Image.Size = new System.Drawing.Size(150, 39);
            this.Button_Open_Image.TabIndex = 0;
            this.Button_Open_Image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Open_Image.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Button_Open_Image.TextMarginLeft = 0;
            this.Button_Open_Image.TextPadding = new System.Windows.Forms.Padding(0);
            this.Button_Open_Image.UseDefaultRadiusAndThickness = true;
            this.Button_Open_Image.Click += new System.EventHandler(this.Button_Open_Image_Click);
            // 
            // Button_Convert
            // 
            this.Button_Convert.AllowAnimations = true;
            this.Button_Convert.AllowMouseEffects = true;
            this.Button_Convert.AllowToggling = false;
            this.Button_Convert.AnimationSpeed = 200;
            this.Button_Convert.AutoGenerateColors = false;
            this.Button_Convert.AutoRoundBorders = true;
            this.Button_Convert.AutoSizeLeftIcon = true;
            this.Button_Convert.AutoSizeRightIcon = true;
            this.Button_Convert.BackColor = System.Drawing.Color.Transparent;
            this.Button_Convert.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Convert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Convert.BackgroundImage")));
            this.Button_Convert.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Convert.ButtonText = "Convert";
            this.Button_Convert.ButtonTextMarginLeft = 0;
            this.Button_Convert.ColorContrastOnClick = 45;
            this.Button_Convert.ColorContrastOnHover = 45;
            this.Button_Convert.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Button_Convert.CustomizableEdges = borderEdges2;
            this.Button_Convert.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Button_Convert.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Convert.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Convert.DisabledForecolor = System.Drawing.Color.White;
            this.Button_Convert.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Button_Convert.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Convert.ForeColor = System.Drawing.Color.White;
            this.Button_Convert.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Convert.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Button_Convert.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Button_Convert.IconMarginLeft = 11;
            this.Button_Convert.IconPadding = 10;
            this.Button_Convert.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Convert.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Button_Convert.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Button_Convert.IconSize = 25;
            this.Button_Convert.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Convert.IdleBorderRadius = 37;
            this.Button_Convert.IdleBorderThickness = 1;
            this.Button_Convert.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Convert.IdleIconLeftImage = global::EZPictureConverter_Remake.Properties.Resources.convert;
            this.Button_Convert.IdleIconRightImage = null;
            this.Button_Convert.IndicateFocus = false;
            this.Button_Convert.Location = new System.Drawing.Point(278, 57);
            this.Button_Convert.Name = "Button_Convert";
            this.Button_Convert.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Convert.OnDisabledState.BorderRadius = 1;
            this.Button_Convert.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Convert.OnDisabledState.BorderThickness = 1;
            this.Button_Convert.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Convert.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.Button_Convert.OnDisabledState.IconLeftImage = null;
            this.Button_Convert.OnDisabledState.IconRightImage = null;
            this.Button_Convert.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Button_Convert.onHoverState.BorderRadius = 1;
            this.Button_Convert.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Convert.onHoverState.BorderThickness = 1;
            this.Button_Convert.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Button_Convert.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Button_Convert.onHoverState.IconLeftImage = null;
            this.Button_Convert.onHoverState.IconRightImage = null;
            this.Button_Convert.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Convert.OnIdleState.BorderRadius = 1;
            this.Button_Convert.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Convert.OnIdleState.BorderThickness = 1;
            this.Button_Convert.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Button_Convert.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Button_Convert.OnIdleState.IconLeftImage = global::EZPictureConverter_Remake.Properties.Resources.convert;
            this.Button_Convert.OnIdleState.IconRightImage = null;
            this.Button_Convert.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Button_Convert.OnPressedState.BorderRadius = 1;
            this.Button_Convert.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Button_Convert.OnPressedState.BorderThickness = 1;
            this.Button_Convert.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Button_Convert.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Button_Convert.OnPressedState.IconLeftImage = null;
            this.Button_Convert.OnPressedState.IconRightImage = null;
            this.Button_Convert.Size = new System.Drawing.Size(150, 39);
            this.Button_Convert.TabIndex = 1;
            this.Button_Convert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Convert.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Button_Convert.TextMarginLeft = 0;
            this.Button_Convert.TextPadding = new System.Windows.Forms.Padding(0);
            this.Button_Convert.UseDefaultRadiusAndThickness = true;
            this.Button_Convert.Click += new System.EventHandler(this.Button_Convert_Click);
            // 
            // Textbox_Path
            // 
            this.Textbox_Path.AcceptsReturn = false;
            this.Textbox_Path.AcceptsTab = false;
            this.Textbox_Path.AllowDrop = true;
            this.Textbox_Path.AnimationSpeed = 200;
            this.Textbox_Path.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Textbox_Path.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Textbox_Path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Textbox_Path.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Textbox_Path.BackgroundImage")));
            this.Textbox_Path.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Textbox_Path.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Textbox_Path.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Textbox_Path.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Textbox_Path.BorderRadius = 1;
            this.Textbox_Path.BorderThickness = 1;
            this.Textbox_Path.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Textbox_Path.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_Path.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Textbox_Path.DefaultText = "";
            this.Textbox_Path.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Textbox_Path.ForeColor = System.Drawing.Color.White;
            this.Textbox_Path.HideSelection = true;
            this.Textbox_Path.IconLeft = null;
            this.Textbox_Path.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_Path.IconPadding = 10;
            this.Textbox_Path.IconRight = null;
            this.Textbox_Path.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_Path.Lines = new string[0];
            this.Textbox_Path.Location = new System.Drawing.Point(12, 12);
            this.Textbox_Path.MaxLength = 32767;
            this.Textbox_Path.MinimumSize = new System.Drawing.Size(1, 1);
            this.Textbox_Path.Modified = false;
            this.Textbox_Path.Multiline = false;
            this.Textbox_Path.Name = "Textbox_Path";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Textbox_Path.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Textbox_Path.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Textbox_Path.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Textbox_Path.OnIdleState = stateProperties4;
            this.Textbox_Path.Padding = new System.Windows.Forms.Padding(3);
            this.Textbox_Path.PasswordChar = '\0';
            this.Textbox_Path.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Textbox_Path.PlaceholderText = "Image path...";
            this.Textbox_Path.ReadOnly = false;
            this.Textbox_Path.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Textbox_Path.SelectedText = "";
            this.Textbox_Path.SelectionLength = 0;
            this.Textbox_Path.SelectionStart = 0;
            this.Textbox_Path.ShortcutsEnabled = true;
            this.Textbox_Path.Size = new System.Drawing.Size(260, 37);
            this.Textbox_Path.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.Textbox_Path.TabIndex = 2;
            this.Textbox_Path.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_Path.TextMarginBottom = 0;
            this.Textbox_Path.TextMarginLeft = 3;
            this.Textbox_Path.TextMarginTop = 0;
            this.Textbox_Path.TextPlaceholder = "Image path...";
            this.Textbox_Path.UseSystemPasswordChar = false;
            this.Textbox_Path.WordWrap = true;
            this.Textbox_Path.DragDrop += new System.Windows.Forms.DragEventHandler(this.Textbox_Path_Path_DragDrop);
            this.Textbox_Path.DragEnter += new System.Windows.Forms.DragEventHandler(this.Textbox_Path_DragEnter);
            // 
            // Dropdown_Convert_Format
            // 
            this.Dropdown_Convert_Format.BackColor = System.Drawing.Color.Transparent;
            this.Dropdown_Convert_Format.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_Convert_Format.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_Convert_Format.BorderRadius = 1;
            this.Dropdown_Convert_Format.Color = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_Convert_Format.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.Dropdown_Convert_Format.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_Convert_Format.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_Convert_Format.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_Convert_Format.DisabledForeColor = System.Drawing.Color.White;
            this.Dropdown_Convert_Format.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.Dropdown_Convert_Format.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Dropdown_Convert_Format.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.Dropdown_Convert_Format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dropdown_Convert_Format.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.Dropdown_Convert_Format.FillDropDown = true;
            this.Dropdown_Convert_Format.FillIndicator = false;
            this.Dropdown_Convert_Format.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dropdown_Convert_Format.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dropdown_Convert_Format.ForeColor = System.Drawing.Color.White;
            this.Dropdown_Convert_Format.FormattingEnabled = true;
            this.Dropdown_Convert_Format.Icon = null;
            this.Dropdown_Convert_Format.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.Dropdown_Convert_Format.IndicatorColor = System.Drawing.Color.Gray;
            this.Dropdown_Convert_Format.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.Dropdown_Convert_Format.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_Convert_Format.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_Convert_Format.ItemForeColor = System.Drawing.Color.White;
            this.Dropdown_Convert_Format.ItemHeight = 26;
            this.Dropdown_Convert_Format.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Dropdown_Convert_Format.ItemHighLightForeColor = System.Drawing.Color.White;
            this.Dropdown_Convert_Format.Items.AddRange(new object[] {
            "ICO",
            "PNG",
            "JPEG"});
            this.Dropdown_Convert_Format.ItemTopMargin = 3;
            this.Dropdown_Convert_Format.Location = new System.Drawing.Point(12, 62);
            this.Dropdown_Convert_Format.Name = "Dropdown_Convert_Format";
            this.Dropdown_Convert_Format.Size = new System.Drawing.Size(260, 32);
            this.Dropdown_Convert_Format.TabIndex = 3;
            this.Dropdown_Convert_Format.Text = null;
            this.Dropdown_Convert_Format.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.Dropdown_Convert_Format.TextLeftMargin = 5;
            this.Dropdown_Convert_Format.SelectedIndexChanged += new System.EventHandler(this.Dropdown_Convert_Format_SelectedIndexChanged);
            // 
            // Dropdown_Ico_Res
            // 
            this.Dropdown_Ico_Res.BackColor = System.Drawing.Color.Transparent;
            this.Dropdown_Ico_Res.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_Ico_Res.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_Ico_Res.BorderRadius = 1;
            this.Dropdown_Ico_Res.Color = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_Ico_Res.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.Dropdown_Ico_Res.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_Ico_Res.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_Ico_Res.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_Ico_Res.DisabledForeColor = System.Drawing.Color.White;
            this.Dropdown_Ico_Res.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.Dropdown_Ico_Res.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Dropdown_Ico_Res.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.Dropdown_Ico_Res.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dropdown_Ico_Res.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.Dropdown_Ico_Res.FillDropDown = true;
            this.Dropdown_Ico_Res.FillIndicator = false;
            this.Dropdown_Ico_Res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dropdown_Ico_Res.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dropdown_Ico_Res.ForeColor = System.Drawing.Color.White;
            this.Dropdown_Ico_Res.FormattingEnabled = true;
            this.Dropdown_Ico_Res.Icon = null;
            this.Dropdown_Ico_Res.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.Dropdown_Ico_Res.IndicatorColor = System.Drawing.Color.Gray;
            this.Dropdown_Ico_Res.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.Dropdown_Ico_Res.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_Ico_Res.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_Ico_Res.ItemForeColor = System.Drawing.Color.White;
            this.Dropdown_Ico_Res.ItemHeight = 26;
            this.Dropdown_Ico_Res.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Dropdown_Ico_Res.ItemHighLightForeColor = System.Drawing.Color.White;
            this.Dropdown_Ico_Res.Items.AddRange(new object[] {
            "128",
            "64",
            "48",
            "32",
            "16"});
            this.Dropdown_Ico_Res.ItemTopMargin = 3;
            this.Dropdown_Ico_Res.Location = new System.Drawing.Point(12, 109);
            this.Dropdown_Ico_Res.Name = "Dropdown_Ico_Res";
            this.Dropdown_Ico_Res.Size = new System.Drawing.Size(416, 32);
            this.Dropdown_Ico_Res.TabIndex = 4;
            this.Dropdown_Ico_Res.Text = null;
            this.Dropdown_Ico_Res.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.Dropdown_Ico_Res.TextLeftMargin = 5;
            this.Dropdown_Ico_Res.Visible = false;
            this.Dropdown_Ico_Res.SelectedIndexChanged += new System.EventHandler(this.Dropdown_Ico_Res_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(440, 154);
            this.Controls.Add(this.Dropdown_Ico_Res);
            this.Controls.Add(this.Dropdown_Convert_Format);
            this.Controls.Add(this.Textbox_Path);
            this.Controls.Add(this.Button_Convert);
            this.Controls.Add(this.Button_Open_Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EZImageConverter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Button_Open_Image;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Button_Convert;
        private Bunifu.UI.WinForms.BunifuTextBox Textbox_Path;
        private Bunifu.UI.WinForms.BunifuDropdown Dropdown_Convert_Format;
        private Bunifu.UI.WinForms.BunifuDropdown Dropdown_Ico_Res;
    }
}

