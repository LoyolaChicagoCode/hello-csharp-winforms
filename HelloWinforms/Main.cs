using System;
using System.Drawing;
using System.Windows.Forms;

namespace HelloWinforms
{
	class HelloWorld : Form
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Application.Run(new HelloWorld ());
		}

		public HelloWorld()
		{
			var b = new Button();
			b.Text = "Click Me!";
			b.Click += new EventHandler (Button_Click);
			Controls.Add (b);
		}
	 
		private void Button_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Button Clicked!");
		}		
			
	}
}