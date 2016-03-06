/*
 * Crée par SharpDevelop.
 * Utilisateur: Ours
 * Date: 04/03/2016
 * Heure: 17:49
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Prompteur {

	public partial class MainForm : Form {

		Timer aTimer;
		Form formPrompteur;
		TextBox tbPrompteur;
		FontDialog fd;
		Button btnChxPolice;
		GroupBox groupBox1;
		GroupBox groupBox2;
		TrackBar trackBar1;
		Label label1;
		List<TextBox> _controlsTextBox;
		List<string> data;
		int intervalDeBase;

		public MainForm() {
			InitializeComponent();

			aTimer 				= new Timer();
			formPrompteur 		= new Form();
			tbPrompteur 		= new TextBox();
			fd 					= new FontDialog();
			btnChxPolice 		= new Button();
			groupBox1 			= new GroupBox();
			groupBox2 			= new GroupBox();
			trackBar1 			= new TrackBar();
			label1 				= new Label();

			_controlsTextBox 	= new List<TextBox>();
			data 				= new List<string>();

			intervalDeBase 		= 1000;

			InitializeFormPrompteur();
			btnChxPolice.Click 	+= BtnChxPolice_Click;
			trackBar1.Scroll 	+= TrackBar1_Scroll;
		}

		void BtnGoClick(object sender, EventArgs e) {

			if (!rdbVertical.Checked && !rdbHorizontal.Checked) { return; }

			data.AddRange(rtbText.Lines);

			CreateTextBox();
			/*
				tbPrompteur.Multiline 	= true;
				tbPrompteur.ReadOnly 	= true;
				tbPrompteur.Text 		= rtbText.Text;
				formPrompteur.Controls.Add(tbPrompteur);
			*/
			for (int j=0; j<_controlsTextBox.Count; j++) {
				
				if (j>=data.Count) 	{ _controlsTextBox[j].Text = ""; 		}
				else 				{ _controlsTextBox[j].Text = data[j]; 	}
				
				_controlsTextBox[j].ReadOnly = true;
				groupBox1.Controls.Add(_controlsTextBox[j]);
			}

			formPrompteur.Show();

            //aTimer.Tick 	+= Timer_Tick_Defilement_Horizontal;
            aTimer.Tick 	+= Timer_Tick_Defilement_Vertical;
            aTimer.Interval = intervalDeBase;
            aTimer.Start();
		}

		void CreateTextBox() {
			int ecart = 0;
			for (int i=0;i<data.Count; i++) {
				TextBox tb 		= new TextBox();
				tb.Name 		= "tb"+i;
				tb.Location 	= new Point(0, ecart);
				tb.BorderStyle 	= BorderStyle.None;
				tb.ReadOnly 	= true;
				tb.Size 		= new Size(808, 44);
				tb.TextAlign 	= HorizontalAlignment.Center;
				_controlsTextBox.Add(tb);
				ecart += 50;
			}
		}
		
		void InitializeFormPrompteur() {

			btnChxPolice.Location 	= new Point(6, 28);
			btnChxPolice.Size 		= new Size(111, 23);
			btnChxPolice.Text 		= "Police";
			btnChxPolice.UseVisualStyleBackColor = true;

			groupBox1.Location 		= new Point(12, 12);
			groupBox1.Name 			= "groupBox1";
			groupBox1.Size 			= new Size(749, 310);
			groupBox1.TabStop 		= false;

			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(trackBar1);
			groupBox2.Controls.Add(btnChxPolice);

			groupBox2.Location 		= new Point(779, 12);
			groupBox2.Name 			= "groupBox2";
			groupBox2.Size 			= new Size(123, 310);
			groupBox2.TabStop 		= false;
			groupBox2.Text 			= "Parametres";

			trackBar1.Location 		= new Point(6, 140);
			trackBar1.Maximum 		= 15;
			trackBar1.Name 			= "trackBar1";
			trackBar1.Orientation 	= Orientation.Vertical;
			trackBar1.RightToLeft 	= System.Windows.Forms.RightToLeft.No;
			trackBar1.Size 			= new Size(45, 164);
			trackBar1.TickStyle 	= TickStyle.Both;

			label1.Location 		= new Point(57, 140);
			label1.Name 			= "label1";
			label1.Size 			= new Size(60, 154);
			label1.TabIndex 		= 5;
			label1.Text 			= "Vitesse du prompteur";
			label1.TextAlign 		= ContentAlignment.MiddleCenter;

			formPrompteur.Controls.Add(groupBox1);
			formPrompteur.Controls.Add(groupBox2);

			formPrompteur.Size 				= new Size(926, 370);
			formPrompteur.StartPosition 	= FormStartPosition.CenterScreen;
			formPrompteur.FormBorderStyle 	= System.Windows.Forms.FormBorderStyle.FixedSingle;
			formPrompteur.Text 				= "Prompteur";
			
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			
			((System.ComponentModel.ISupportInitialize)(trackBar1)).EndInit();
		}

		void BtnChxPolice_Click(object sender, EventArgs e) {
			if (fd.ShowDialog() == DialogResult.OK) {
				foreach(TextBox tb in _controlsTextBox) {
					tb.Font = fd.Font;
				}
			}			
		}

		void TrackBar1_Scroll(object sender, EventArgs e) {
			aTimer.Interval = Convert.ToInt32(intervalDeBase-(trackBar1.Value*50));
		}

        void Timer_Tick_Defilement_Horizontal(object sender, EventArgs e) {
			try {
				string lettreSupprimer 	= tbPrompteur.Text.Substring(0, 1);
    	        tbPrompteur.Text 		= tbPrompteur.Text.Remove(0, 1);
    	        tbPrompteur.Text 		+= lettreSupprimer;
			}
			catch(Exception ex) {
				//
			}
        }
		
		void Timer_Tick_Defilement_Vertical(object sender, EventArgs e) {
			string tmp = "";

			try {
				for (int i=0;i<_controlsTextBox.Count;i++) {
					_controlsTextBox[i].Text = data[i];
				}
				tmp = data[0];
				data.RemoveAt(0);
				data.Add(tmp);
			}
			catch(Exception ex) {
				//
			}
		}
	}
}
