using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using static System.Windows.Media.VisualTreeHelper;

namespace WpfApp1
{
    public static class WindowHelpers
    {
        /// <summary>
        /// Clear TextBox controls in a container
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control"></param>
        public static void ClearTextBoxes<T>(this DependencyObject control)
        {
            foreach (var textBox in FindChildren<TextBox>(control))
            {
                textBox.Text = "";
            }
        }
        /// <summary>
        /// Enable or disable a TextBox in a container
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control"></param>
        /// <param name="enable"></param>
        public static void EnableTextBoxes<T>(this DependencyObject control, bool enable = false)
        {
            foreach (var textBox in FindChildren<TextBox>(control))
            {
                textBox.IsReadOnly = enable;
            }
        }

        public static IEnumerable<T> FindChildren<T>(DependencyObject dependencyItem) where T : DependencyObject
        {
            if (dependencyItem != null)
            {
                for (var index = 0; index < GetChildrenCount(dependencyItem); index++)
                {
                    var child = GetChild(dependencyItem, index);
                    if (child is T dependencyObject)
                    {
                        yield return dependencyObject;
                    }

                    foreach (var childOfChild in FindChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
    }
}