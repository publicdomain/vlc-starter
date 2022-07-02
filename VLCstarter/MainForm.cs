// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace VLCstarter
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Reflection;
    using System.Windows.Forms;
    using PublicDomain;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The count.
        /// </summary>
        int count = 0;

        /// <summary>
        /// The no command flag.
        /// </summary>
        bool noCommand = false;

        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:VLCstarter.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Set icons */

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set PublicDomain.is tool strip menu item image
            this.freeReleasesPublicDomainisToolStripMenuItem.Image = this.associatedIcon.ToBitmap();
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Toggle noCommand flag
            this.noCommand = true;

            // Reset text boxes
            this.pathTextBox.Text = string.Empty;
            this.commandTextBox.Text = string.Empty;

            // Reset HH MM SS numeric up down boxes
            this.startHourNumericUpDown.Value = 0;
            this.startMinuteNumericUpDown.Value = 0;
            this.startSecondNumericUpDown.Value = 0;
            this.endHourNumericUpDown.Value = 0;
            this.endMinuteNumericUpDown.Value = 0;
            this.endSecondNumericUpDown.Value = 0;

            // Focus path text box
            this.pathTextBox.Focus();

            // Toggle noCommand flag
            this.noCommand = false;
        }

        /// <summary>
        /// Handles the cut tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Check for command
            if (this.commandTextBox.Text.Length > 0)
            {
                // Copy to clipboard
                Clipboard.Clear();
                Clipboard.SetText(this.commandTextBox.Text);

                // Clear command text
                this.commandTextBox.Text = string.Empty;
            }
        }

        /// <summary>
        /// Handles the copy tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCopyToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Check for command
            if (this.commandTextBox.Text.Length > 0)
            {
                // Copy to clipboard
                Clipboard.Clear();
                Clipboard.SetText(this.commandTextBox.Text);
            }
        }

        /// <summary>
        /// Handles the select all tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSelectAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.commandTextBox.SelectAll();
            this.commandTextBox.Focus();
        }

        /// <summary>
        /// Handles the free releases @ PublicDomain.is tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our website
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        /// Handles the original thread @ Reddit.com tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadRedditcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.reddit.com/r/software/comments/vki0cd/open_video_file_at_a_precise_minute/");
        }

        /// <summary>
        /// Handles the source code @ Github.com tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/publicdomain/vlc-starter");
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"Video player icon by Pixel_perfect - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/vector-video-player-movie-player-941434/{Environment.NewLine}{Environment.NewLine}" +
                $"Reddit icon used according to published brand guidelines{Environment.NewLine}" +
                $"https://www.redditinc.com/brand{Environment.NewLine}{Environment.NewLine}" +
                $"GitHub mark icon used according to published logos and usage guidelines{Environment.NewLine}" +
                $"https://github.com/logos{Environment.NewLine}{Environment.NewLine}" +
                $"PublicDomain icon is based on the following source images:{Environment.NewLine}{Environment.NewLine}" +
                $"Bitcoin by GDJ - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/bitcoin-digital-currency-4130319/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter P by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/p-glamour-gold-lights-2790632/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter D by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/d-glamour-gold-lights-2790573/{Environment.NewLine}{Environment.NewLine}";

            // Prepend supporters
            licenseText = $"RELEASE SUPPORTERS:{Environment.NewLine}{Environment.NewLine}* Jesse Reichler{Environment.NewLine}* Max P.{Environment.NewLine}* Kathryn S.{Environment.NewLine}* Y0himba{Environment.NewLine}{Environment.NewLine}=========={Environment.NewLine}{Environment.NewLine}" + licenseText;

            // Set title
            string programTitle = typeof(MainForm).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

            // Set version for generating semantic version
            Version version = typeof(MainForm).GetTypeInfo().Assembly.GetName().Version;

            // Set about form
            var aboutForm = new AboutForm(
                $"About {programTitle}",
                $"{programTitle} {version.Major}.{version.Minor}.{version.Build}",
                $"Made for: u/andry360{ Environment.NewLine}Reddit.com{Environment.NewLine}Day #183, Week #26 @ July 02, 2022",
                licenseText,
                this.Icon.ToBitmap())
            {
                // Set about form icon
                Icon = this.associatedIcon,

                // Set always on top
                TopMost = this.TopMost
            };

            // Show about form
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Handles the numeric up down value changed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNumericUpDownValueChanged(object sender, EventArgs e)
        {
            // Process VLC command
            this.ProcessCommand();
        }

        /// <summary>
        /// Handles the path text box text changed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnPathTextBoxTextChanged(object sender, EventArgs e)
        {
            // Process VLC command
            this.ProcessCommand();
        }

        /// <summary>
        /// Processes the command.
        /// </summary>
        private void ProcessCommand()
        {
            // TODO Check no command flag [Can be made by event handler]
            if (this.noCommand)
            {
                // Halt flow
                return;
            }

            // Try to set command
            string command = this.GetCommand();

            // Check there's something
            if (command.Length > 0)
            {
                // Update launch command
                this.commandTextBox.Text = command;
            }
        }

        /// <summary>
        /// Gets the command.
        /// </summary>
        /// <returns>The command.</returns>
        private string GetCommand()
        {
            // Check path
            if (this.pathTextBox.Text.Length == 0)
            {
                // Advise user
                MessageBox.Show("Please set target file path", "Path missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Focus text box
                this.pathTextBox.Focus();

                // Halt flow
                return string.Empty;
            }

            // Set command
            string command = "vlc";

            // Check start time
            if (!(this.startHourNumericUpDown.Value == 0 && this.startMinuteNumericUpDown.Value == 0 && this.startSecondNumericUpDown.Value == 0))
            {
                // Set start seconds
                int startSeconds = ((int)this.startHourNumericUpDown.Value * 60 * 60) + ((int)this.startMinuteNumericUpDown.Value * 60) + (int)this.startSecondNumericUpDown.Value;

                // Append to command
                command += $" --start-time={startSeconds}";
            }

            // Check end time
            if (!(this.endHourNumericUpDown.Value == 0 && this.endMinuteNumericUpDown.Value == 0 && this.endSecondNumericUpDown.Value == 0))
            {
                // Set end seconds
                int endSeconds = ((int)this.endHourNumericUpDown.Value * 60 * 60) + ((int)this.endMinuteNumericUpDown.Value * 60) + (int)this.endSecondNumericUpDown.Value;

                // Append to command
                command += $" --stop-time={endSeconds}";
            }

            // Return command
            return $"{command} \"{this.pathTextBox.Text}\"";
        }

        /// <summary>
        /// Handles the launch button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnLaunchButtonClick(object sender, EventArgs e)
        {
            // Try to set command
            string command = this.GetCommand();

            // Check there's something
            if (command.Length > 0)
            {
                // Update launch command
                this.commandTextBox.Text = command;
            }

            // TODO Perform launch [can be improved]
            try
            {
                // Launch
                Process.Start("vlc", command.Substring(4));

                // Raise count
                this.count++;

                // Update status
                this.countToolStripStatusLabel.Text = this.count.ToString();
            }
            catch (Exception ex)
            {
                // Advise user
                MessageBox.Show($"Error when launching VLC:{Environment.NewLine}{Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnBrowseButtonClick(object sender, EventArgs e)
        {
            // Show open file dialog
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set path
                this.pathTextBox.Text = this.openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }
    }
}
