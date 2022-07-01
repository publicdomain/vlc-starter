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
    using System.Windows.Forms;

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
        /// Initializes a new instance of the <see cref="T:VLCstarter.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Reset text boxes
            this.pathTextBox.Text = string.Empty;
            this.commandTextBox.Text = string.Empty;

            // Toggle noCommand flag
            this.noCommand = true;

            // Reset HH MM SS numeric up down boxes
            this.startHourNumericUpDown.Value = 0;
            this.startMinuteNumericUpDown.Value = 0;
            this.startSecondNumericUpDown.Value = 0;
            this.endHourNumericUpDown.Value = 0;
            this.endMinuteNumericUpDown.Value = 0;
            this.endSecondNumericUpDown.Value = 0;

            // Toggle noCommand flag
            this.noCommand = false;

            // Focus path text box
            this.pathTextBox.Focus();
        }

        /// <summary>
        /// Handles the cut tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the copy tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCopyToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the select all tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSelectAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the free releases @ PublicDomain.is tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the original thread @ Reddit.com tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadRedditcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the source code @ Github.com tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the numeric up down value changed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNumericUpDownValueChanged(object sender, EventArgs e)
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
