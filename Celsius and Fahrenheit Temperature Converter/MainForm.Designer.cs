/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 5/11/2021
 * Time: 10:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Celsius_and_Fahrenheit_Temperature_Converter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TemperaturetextBox;
		private System.Windows.Forms.Button ConvertToFahrenheitbutton;
		private System.Windows.Forms.Button ConvertToCelsiusbutton;
		private System.Windows.Forms.Button Clearbutton;
		private System.Windows.Forms.Button Exitbutton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label resultlabel;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
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
			this.label1 = new System.Windows.Forms.Label();
			this.TemperaturetextBox = new System.Windows.Forms.TextBox();
			this.ConvertToFahrenheitbutton = new System.Windows.Forms.Button();
			this.ConvertToCelsiusbutton = new System.Windows.Forms.Button();
			this.Clearbutton = new System.Windows.Forms.Button();
			this.Exitbutton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.resultlabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(46, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter temperature : ";
			// 
			// TemperaturetextBox
			// 
			this.TemperaturetextBox.Location = new System.Drawing.Point(225, 56);
			this.TemperaturetextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.TemperaturetextBox.Name = "TemperaturetextBox";
			this.TemperaturetextBox.Size = new System.Drawing.Size(126, 26);
			this.TemperaturetextBox.TabIndex = 1;
			this.TemperaturetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ConvertToFahrenheitbutton
			// 
			this.ConvertToFahrenheitbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ConvertToFahrenheitbutton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConvertToFahrenheitbutton.ForeColor = System.Drawing.Color.RoyalBlue;
			this.ConvertToFahrenheitbutton.Location = new System.Drawing.Point(129, 175);
			this.ConvertToFahrenheitbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ConvertToFahrenheitbutton.Name = "ConvertToFahrenheitbutton";
			this.ConvertToFahrenheitbutton.Size = new System.Drawing.Size(173, 44);
			this.ConvertToFahrenheitbutton.TabIndex = 2;
			this.ConvertToFahrenheitbutton.Text = "Convert to Fahrenheit";
			this.ConvertToFahrenheitbutton.UseVisualStyleBackColor = false;
			this.ConvertToFahrenheitbutton.Click += new System.EventHandler(this.ConvertToFahrenheitbuttonClick);
			// 
			// ConvertToCelsiusbutton
			// 
			this.ConvertToCelsiusbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ConvertToCelsiusbutton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConvertToCelsiusbutton.ForeColor = System.Drawing.Color.RoyalBlue;
			this.ConvertToCelsiusbutton.Location = new System.Drawing.Point(129, 226);
			this.ConvertToCelsiusbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ConvertToCelsiusbutton.Name = "ConvertToCelsiusbutton";
			this.ConvertToCelsiusbutton.Size = new System.Drawing.Size(173, 41);
			this.ConvertToCelsiusbutton.TabIndex = 3;
			this.ConvertToCelsiusbutton.Text = "Convert to Celsius";
			this.ConvertToCelsiusbutton.UseVisualStyleBackColor = false;
			this.ConvertToCelsiusbutton.Click += new System.EventHandler(this.ConvertToCelsiusbuttonClick);
			// 
			// Clearbutton
			// 
			this.Clearbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Clearbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Clearbutton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Clearbutton.ForeColor = System.Drawing.Color.RoyalBlue;
			this.Clearbutton.Location = new System.Drawing.Point(175, 301);
			this.Clearbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Clearbutton.Name = "Clearbutton";
			this.Clearbutton.Size = new System.Drawing.Size(75, 35);
			this.Clearbutton.TabIndex = 4;
			this.Clearbutton.Text = "Clear";
			this.Clearbutton.UseVisualStyleBackColor = false;
			this.Clearbutton.Click += new System.EventHandler(this.ClearbuttonClick);
			// 
			// Exitbutton
			// 
			this.Exitbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Exitbutton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Exitbutton.ForeColor = System.Drawing.Color.RoyalBlue;
			this.Exitbutton.Location = new System.Drawing.Point(175, 343);
			this.Exitbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Exitbutton.Name = "Exitbutton";
			this.Exitbutton.Size = new System.Drawing.Size(75, 35);
			this.Exitbutton.TabIndex = 5;
			this.Exitbutton.Text = "Exit";
			this.Exitbutton.UseVisualStyleBackColor = false;
			this.Exitbutton.Click += new System.EventHandler(this.ExitbuttonClick);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(46, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(173, 26);
			this.label2.TabIndex = 6;
			this.label2.Text = "Converted Temperature : ";
			// 
			// resultlabel
			// 
			this.resultlabel.BackColor = System.Drawing.Color.Transparent;
			this.resultlabel.Location = new System.Drawing.Point(225, 109);
			this.resultlabel.Name = "resultlabel";
			this.resultlabel.Size = new System.Drawing.Size(101, 26);
			this.resultlabel.TabIndex = 7;
			this.resultlabel.Text = "label3";
			this.resultlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(413, 426);
			this.Controls.Add(this.resultlabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Exitbutton);
			this.Controls.Add(this.Clearbutton);
			this.Controls.Add(this.ConvertToCelsiusbutton);
			this.Controls.Add(this.ConvertToFahrenheitbutton);
			this.Controls.Add(this.TemperaturetextBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.Text = "Celsius and Fahrenheit Temperature Converter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
