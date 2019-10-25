using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemWatcher1
{
    /// <summary>
    /// Responsible for watching file operations in a specific folder.
    ///
    /// If when an event like file creation occurs and after processing the file it
    /// needs to be moved make sure to first execute <see cref="EnableWatch()"/>, perform
    /// the move then execute <see cref="DisableWatch()"/>
    /// </summary>
    public class WatchOperations : IDisposable
    {
        private string _folderName;
        public readonly FileSystemWatcher FileSystemWatcher;

        /// <summary>
        /// Enable FileSystemWatcher to monitor folder
        /// </summary>
        public void EnableWatch() => FileSystemWatcher.EnableRaisingEvents = true;
        /// <summary>
        /// Disable FileSystemWatcher from monitor folder
        /// </summary>
        public void DisableWatch() => FileSystemWatcher.EnableRaisingEvents = false;

        /// <summary>
        /// Create a instance of FileSystemWatcher with filters
        /// and events to react to file operations in path pasted in
        /// to this constructor.
        /// </summary>
        /// <param name="path">Directory to monitor</param>
        /// <param name="filter">File type defaults to .txt (text files)</param>
        public WatchOperations(string path, string filter = "*.txt")
        {
            _folderName = path;

            FileSystemWatcher = new FileSystemWatcher(path)
            {
                Filter = filter,
                NotifyFilter =   NotifyFilters.LastAccess
                               | NotifyFilters.LastWrite
                               | NotifyFilters.FileName
                               | NotifyFilters.DirectoryName
                
            };

            FileSystemWatcher.Changed += OnChanged;
            FileSystemWatcher.Created += OnCreated;
            FileSystemWatcher.Renamed += OnRenamed;

        }
        /// <summary>
        /// Constructor to permit setting up as a private form or
        /// class level property or variable
        /// </summary>
        public WatchOperations()
        {
            FileSystemWatcher = new FileSystemWatcher();
        }
        /// <summary>
        /// Fired when a file is renamed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Rename: {e.OldName}, {e.Name}");
        }
        /// <summary>
        /// Fired when a file is created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Created: {e.Name}");
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Changed: {e.Name}");
        }
        /// <summary>
        /// Destroy watcher which stops any watches
        /// </summary>
        public void Dispose()
        {
            FileSystemWatcher?.Dispose();
        }
    }
}
