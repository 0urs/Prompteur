/*
 * Crée par SharpDevelop.
 * Utilisateur: Ours
 * Date: 04/03/2016
 * Heure: 17:49
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
namespace Prompteur
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.RichTextBox rtbText;
		private System.Windows.Forms.RadioButton rdbVertical;
		private System.Windows.Forms.RadioButton rdbHorizontal;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnGo = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.rtbText = new System.Windows.Forms.RichTextBox();
			this.rdbVertical = new System.Windows.Forms.RadioButton();
			this.rdbHorizontal = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1046, 39);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1046, 68);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(1046, 551);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 2;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.BtnGoClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// rtbText
			// 
			this.rtbText.Location = new System.Drawing.Point(12, 39);
			this.rtbText.Name = "rtbText";
			this.rtbText.Size = new System.Drawing.Size(947, 535);
			this.rtbText.TabIndex = 3;
			this.rtbText.Text = "";
			// 
			// rdbVertical
			// 
			this.rdbVertical.Location = new System.Drawing.Point(980, 133);
			this.rdbVertical.Name = "rdbVertical";
			this.rdbVertical.Size = new System.Drawing.Size(141, 24);
			this.rdbVertical.TabIndex = 4;
			this.rdbVertical.TabStop = true;
			this.rdbVertical.Text = "Défilement vertical";
			this.rdbVertical.UseVisualStyleBackColor = true;
			// 
			// rdbHorizontal
			// 
			this.rdbHorizontal.Location = new System.Drawing.Point(980, 163);
			this.rdbHorizontal.Name = "rdbHorizontal";
			this.rdbHorizontal.Size = new System.Drawing.Size(141, 24);
			this.rdbHorizontal.TabIndex = 5;
			this.rdbHorizontal.TabStop = true;
			this.rdbHorizontal.Text = "Défilement horizontal";
			this.rdbHorizontal.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1148, 586);
			this.Controls.Add(this.rdbHorizontal);
			this.Controls.Add(this.rdbVertical);
			this.Controls.Add(this.rtbText);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "Prompteur";
			this.ResumeLayout(false);

		}
	}
}
