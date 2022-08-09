/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 5/11/2021
 * Time: 10:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Celsius_and_Fahrenheit_Temperature_Converter
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ConvertToFahrenheitbuttonClick(object sender, EventArgs e)
		{
			int Temperature = Convert.ToInt16(TemperaturetextBox.Text);
			
			int result = Temperature * 9/5 + 32;
			resultlabel.Text=result.ToString();
		}
		void ConvertToCelsiusbuttonClick(object sender, EventArgs e)
		{
			int Temperature = Convert.ToInt16(TemperaturetextBox.Text);
			
			int result = (Temperature -32) * 5/9;
			resultlabel.Text=result.ToString();
		}
		void ClearbuttonClick(object sender, EventArgs e)
		{
			TemperaturetextBox.Clear();
			resultlabel.Text="";
		}
		void ExitbuttonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
