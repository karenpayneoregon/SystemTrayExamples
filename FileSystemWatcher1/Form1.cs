using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystemWatcher1
{
    
    public partial class Form1 : Form
    {
        private WatchOperations _watchOperations;
        public Form1()
        {
            InitializeComponent();
            Closing += Form1_Closing;
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            _watchOperations?.Dispose();
        }
        private void StartWatchingButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(DirectoryNameTextBox.Text))
            {
                _watchOperations = new WatchOperations(DirectoryNameTextBox.Text);
                _watchOperations.FileSystemWatcher.Deleted += FileSystemWatcher_Deleted;
                _watchOperations.EnableWatch();
            }
            else
            {
                MessageBox.Show(@"Need an existing directory!!!");
            }
        }
        /// <summary>
        /// Wired delete local event (other events are in the class) example
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            // ReSharper disable once LocalizableElement
            Console.WriteLine($"Deleted: Full Path: '{e.FullPath}' Just name: '{e.Name}'");
        }
    }
}
