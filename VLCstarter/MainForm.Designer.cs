
namespace VLCstarter
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeReleasesPublicDomainisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalThreadRedditcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.countTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.countToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pathLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLbel = new System.Windows.Forms.Label();
            this.launchButton = new System.Windows.Forms.Button();
            this.pathTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.browseButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.startTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.startHourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startMinuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startSecondNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.endHourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endMinuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endSecondNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.pathTableLayoutPanel.SuspendLayout();
            this.startTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startHourNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinuteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSecondNumericUpDown)).BeginInit();
            this.endTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endHourNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinuteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endSecondNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.fileToolStripMenuItem1,
                                    this.editToolStripMenuItem,
                                    this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.mainMenuStrip.TabIndex = 59;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.newToolStripMenuItem,
                                    this.toolStripSeparator3,
                                    this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.cutToolStripMenuItem,
                                    this.copyToolStripMenuItem,
                                    this.toolStripSeparator6,
                                    this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.OnCutToolStripMenuItemClick);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.OnCopyToolStripMenuItemClick);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.OnSelectAllToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.freeReleasesPublicDomainisToolStripMenuItem,
                                    this.originalThreadRedditcomToolStripMenuItem,
                                    this.sourceCodeGithubcomToolStripMenuItem,
                                    this.toolStripSeparator2,
                                    this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // freeReleasesPublicDomainisToolStripMenuItem
            // 
            this.freeReleasesPublicDomainisToolStripMenuItem.Name = "freeReleasesPublicDomainisToolStripMenuItem";
            this.freeReleasesPublicDomainisToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.freeReleasesPublicDomainisToolStripMenuItem.Text = "&Free Releases @ PublicDomain.is";
            this.freeReleasesPublicDomainisToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainisToolStripMenuItemClick);
            // 
            // originalThreadRedditcomToolStripMenuItem
            // 
            this.originalThreadRedditcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadRedditcomToolStripMenuItem.Image")));
            this.originalThreadRedditcomToolStripMenuItem.Name = "originalThreadRedditcomToolStripMenuItem";
            this.originalThreadRedditcomToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.originalThreadRedditcomToolStripMenuItem.Text = "Original thread @ Reddit.com";
            this.originalThreadRedditcomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadRedditcomToolStripMenuItemClick);
            // 
            // sourceCodeGithubcomToolStripMenuItem
            // 
            this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
            this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
            this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.sourceCodeGithubcomToolStripMenuItem.Text = "&Source code @ Github.com";
            this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(243, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.countTextToolStripStatusLabel,
                                    this.countToolStripStatusLabel,
                                    this.toolStripStatusLabel1,
                                    this.toolStripStatusLabel2});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 205);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(284, 22);
            this.mainStatusStrip.SizingGrip = false;
            this.mainStatusStrip.TabIndex = 58;
            // 
            // countTextToolStripStatusLabel
            // 
            this.countTextToolStripStatusLabel.Name = "countTextToolStripStatusLabel";
            this.countTextToolStripStatusLabel.Size = new System.Drawing.Size(43, 17);
            this.countTextToolStripStatusLabel.Text = "Count:";
            // 
            // countToolStripStatusLabel
            // 
            this.countToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.countToolStripStatusLabel.Name = "countToolStripStatusLabel";
            this.countToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.countToolStripStatusLabel.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "/";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(113, 17);
            this.toolStripStatusLabel2.Text = "Times in HH MM SS";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.mainTableLayoutPanel.Controls.Add(this.pathLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.startLabel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.endLbel, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.launchButton, 1, 4);
            this.mainTableLayoutPanel.Controls.Add(this.pathTableLayoutPanel, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.startTableLayoutPanel, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.endTableLayoutPanel, 1, 2);
            this.mainTableLayoutPanel.Controls.Add(this.label1, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.commandTextBox, 1, 3);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 5;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(284, 181);
            this.mainTableLayoutPanel.TabIndex = 60;
            // 
            // pathLabel
            // 
            this.pathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(3, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pathLabel.Size = new System.Drawing.Size(79, 35);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "&Path";
            this.pathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startLabel
            // 
            this.startLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(3, 35);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(79, 35);
            this.startLabel.TabIndex = 1;
            this.startLabel.Text = "&Start";
            this.startLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endLbel
            // 
            this.endLbel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endLbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLbel.Location = new System.Drawing.Point(3, 70);
            this.endLbel.Name = "endLbel";
            this.endLbel.Size = new System.Drawing.Size(79, 35);
            this.endLbel.TabIndex = 2;
            this.endLbel.Text = "&End";
            this.endLbel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // launchButton
            // 
            this.launchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.launchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.launchButton.Location = new System.Drawing.Point(88, 143);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(193, 35);
            this.launchButton.TabIndex = 3;
            this.launchButton.Text = "&Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.OnLaunchButtonClick);
            // 
            // pathTableLayoutPanel
            // 
            this.pathTableLayoutPanel.ColumnCount = 2;
            this.pathTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pathTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.pathTableLayoutPanel.Controls.Add(this.browseButton, 1, 0);
            this.pathTableLayoutPanel.Controls.Add(this.pathTextBox, 0, 0);
            this.pathTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathTableLayoutPanel.Location = new System.Drawing.Point(85, 0);
            this.pathTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.pathTableLayoutPanel.Name = "pathTableLayoutPanel";
            this.pathTableLayoutPanel.RowCount = 1;
            this.pathTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pathTableLayoutPanel.Size = new System.Drawing.Size(199, 35);
            this.pathTableLayoutPanel.TabIndex = 4;
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(157, 3);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(39, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.OnBrowseButtonClick);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathTextBox.Location = new System.Drawing.Point(3, 3);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(148, 26);
            this.pathTextBox.TabIndex = 1;
            this.pathTextBox.TextChanged += new System.EventHandler(this.OnPathTextBoxTextChanged);
            // 
            // startTableLayoutPanel
            // 
            this.startTableLayoutPanel.ColumnCount = 3;
            this.startTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.startTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.startTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.startTableLayoutPanel.Controls.Add(this.startHourNumericUpDown, 0, 0);
            this.startTableLayoutPanel.Controls.Add(this.startMinuteNumericUpDown, 1, 0);
            this.startTableLayoutPanel.Controls.Add(this.startSecondNumericUpDown, 2, 0);
            this.startTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startTableLayoutPanel.Location = new System.Drawing.Point(85, 35);
            this.startTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.startTableLayoutPanel.Name = "startTableLayoutPanel";
            this.startTableLayoutPanel.RowCount = 1;
            this.startTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.startTableLayoutPanel.Size = new System.Drawing.Size(199, 35);
            this.startTableLayoutPanel.TabIndex = 5;
            // 
            // startHourNumericUpDown
            // 
            this.startHourNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startHourNumericUpDown.Location = new System.Drawing.Point(3, 3);
            this.startHourNumericUpDown.Maximum = new decimal(new int[] {
                                    1000,
                                    0,
                                    0,
                                    0});
            this.startHourNumericUpDown.Name = "startHourNumericUpDown";
            this.startHourNumericUpDown.Size = new System.Drawing.Size(60, 26);
            this.startHourNumericUpDown.TabIndex = 0;
            this.startHourNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startHourNumericUpDown.ValueChanged += new System.EventHandler(this.OnNumericUpDownValueChanged);
            // 
            // startMinuteNumericUpDown
            // 
            this.startMinuteNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMinuteNumericUpDown.Location = new System.Drawing.Point(69, 3);
            this.startMinuteNumericUpDown.Maximum = new decimal(new int[] {
                                    60,
                                    0,
                                    0,
                                    0});
            this.startMinuteNumericUpDown.Name = "startMinuteNumericUpDown";
            this.startMinuteNumericUpDown.Size = new System.Drawing.Size(60, 26);
            this.startMinuteNumericUpDown.TabIndex = 1;
            this.startMinuteNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startMinuteNumericUpDown.ValueChanged += new System.EventHandler(this.OnNumericUpDownValueChanged);
            // 
            // startSecondNumericUpDown
            // 
            this.startSecondNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSecondNumericUpDown.Location = new System.Drawing.Point(135, 3);
            this.startSecondNumericUpDown.Maximum = new decimal(new int[] {
                                    60,
                                    0,
                                    0,
                                    0});
            this.startSecondNumericUpDown.Name = "startSecondNumericUpDown";
            this.startSecondNumericUpDown.Size = new System.Drawing.Size(61, 26);
            this.startSecondNumericUpDown.TabIndex = 2;
            this.startSecondNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startSecondNumericUpDown.ValueChanged += new System.EventHandler(this.OnNumericUpDownValueChanged);
            // 
            // endTableLayoutPanel
            // 
            this.endTableLayoutPanel.ColumnCount = 3;
            this.endTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.endTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.endTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.endTableLayoutPanel.Controls.Add(this.endHourNumericUpDown, 0, 0);
            this.endTableLayoutPanel.Controls.Add(this.endMinuteNumericUpDown, 1, 0);
            this.endTableLayoutPanel.Controls.Add(this.endSecondNumericUpDown, 2, 0);
            this.endTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endTableLayoutPanel.Location = new System.Drawing.Point(85, 70);
            this.endTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.endTableLayoutPanel.Name = "endTableLayoutPanel";
            this.endTableLayoutPanel.RowCount = 1;
            this.endTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.endTableLayoutPanel.Size = new System.Drawing.Size(199, 35);
            this.endTableLayoutPanel.TabIndex = 6;
            // 
            // endHourNumericUpDown
            // 
            this.endHourNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endHourNumericUpDown.Location = new System.Drawing.Point(3, 3);
            this.endHourNumericUpDown.Maximum = new decimal(new int[] {
                                    1000,
                                    0,
                                    0,
                                    0});
            this.endHourNumericUpDown.Name = "endHourNumericUpDown";
            this.endHourNumericUpDown.Size = new System.Drawing.Size(60, 26);
            this.endHourNumericUpDown.TabIndex = 0;
            this.endHourNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endHourNumericUpDown.ValueChanged += new System.EventHandler(this.OnNumericUpDownValueChanged);
            // 
            // endMinuteNumericUpDown
            // 
            this.endMinuteNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endMinuteNumericUpDown.Location = new System.Drawing.Point(69, 3);
            this.endMinuteNumericUpDown.Maximum = new decimal(new int[] {
                                    60,
                                    0,
                                    0,
                                    0});
            this.endMinuteNumericUpDown.Name = "endMinuteNumericUpDown";
            this.endMinuteNumericUpDown.Size = new System.Drawing.Size(60, 26);
            this.endMinuteNumericUpDown.TabIndex = 1;
            this.endMinuteNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endMinuteNumericUpDown.ValueChanged += new System.EventHandler(this.OnNumericUpDownValueChanged);
            // 
            // endSecondNumericUpDown
            // 
            this.endSecondNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endSecondNumericUpDown.Location = new System.Drawing.Point(135, 3);
            this.endSecondNumericUpDown.Maximum = new decimal(new int[] {
                                    60,
                                    0,
                                    0,
                                    0});
            this.endSecondNumericUpDown.Name = "endSecondNumericUpDown";
            this.endSecondNumericUpDown.Size = new System.Drawing.Size(61, 26);
            this.endSecondNumericUpDown.TabIndex = 2;
            this.endSecondNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endSecondNumericUpDown.ValueChanged += new System.EventHandler(this.OnNumericUpDownValueChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "&Command";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commandTextBox
            // 
            this.commandTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.commandTextBox.Location = new System.Drawing.Point(88, 108);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(193, 26);
            this.commandTextBox.TabIndex = 8;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = resources.GetString("openFileDialog.Filter");
            // 
            // MainForm
            // 
            this.AcceptButton = this.launchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.mainStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VLC starter";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.pathTableLayoutPanel.ResumeLayout(false);
            this.pathTableLayoutPanel.PerformLayout();
            this.startTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.startHourNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinuteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSecondNumericUpDown)).EndInit();
            this.endTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.endHourNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinuteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endSecondNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.NumericUpDown endSecondNumericUpDown;
        private System.Windows.Forms.NumericUpDown endMinuteNumericUpDown;
        private System.Windows.Forms.NumericUpDown endHourNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel endTableLayoutPanel;
        private System.Windows.Forms.NumericUpDown startSecondNumericUpDown;
        private System.Windows.Forms.NumericUpDown startMinuteNumericUpDown;
        private System.Windows.Forms.NumericUpDown startHourNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel startTableLayoutPanel;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TableLayoutPanel pathTableLayoutPanel;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Label endLbel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.ToolStripStatusLabel countToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel countTextToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadRedditcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
    }
}
