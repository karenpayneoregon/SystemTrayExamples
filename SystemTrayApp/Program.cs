using System;
using System.Windows.Forms;
using SystemTrayApp.Classes;

namespace SystemTrayApp
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			using (var processIcon = new ProcessIcon())
			{
				processIcon.Display();
				Application.Run();
			}
		}
	}
}