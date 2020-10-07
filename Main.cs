using AppKit;

namespace TestApp
{
	static class MainClass
	{
		static void Main(string[] args)
		{
			NSApplication.Init();

			/*var alert = new NSAlert()
			{
				AlertStyle = NSAlertStyle.Critical,
				InformativeText = "We need to save the document here...",
				MessageText = "Save Document",
			};
			alert.RunModal();*/

			NSApplication.Main(args);
		}
	}
}
