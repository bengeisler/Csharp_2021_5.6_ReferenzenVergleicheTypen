
namespace Csharp_2021_5._6_ReferenzenVergleicheTypen
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnKopie = new System.Windows.Forms.Button();
			this.btnReferenz = new System.Windows.Forms.Button();
			this.btnReferenzZuweisen = new System.Windows.Forms.Button();
			this.btnZweiFahrzeuge = new System.Windows.Forms.Button();
			this.btnZuweisungWertdatentyp = new System.Windows.Forms.Button();
			this.btnReferenzPrüfen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnKopie
			// 
			this.btnKopie.Location = new System.Drawing.Point(13, 13);
			this.btnKopie.Name = "btnKopie";
			this.btnKopie.Size = new System.Drawing.Size(75, 23);
			this.btnKopie.TabIndex = 0;
			this.btnKopie.Text = "Kopie";
			this.btnKopie.UseVisualStyleBackColor = true;
			this.btnKopie.Click += new System.EventHandler(this.btnKopie_Click);
			// 
			// btnReferenz
			// 
			this.btnReferenz.Location = new System.Drawing.Point(115, 12);
			this.btnReferenz.Name = "btnReferenz";
			this.btnReferenz.Size = new System.Drawing.Size(75, 23);
			this.btnReferenz.TabIndex = 1;
			this.btnReferenz.Text = "Referenz";
			this.btnReferenz.UseVisualStyleBackColor = true;
			this.btnReferenz.Click += new System.EventHandler(this.btnReferenz_Click);
			// 
			// btnReferenzZuweisen
			// 
			this.btnReferenzZuweisen.Location = new System.Drawing.Point(12, 65);
			this.btnReferenzZuweisen.Name = "btnReferenzZuweisen";
			this.btnReferenzZuweisen.Size = new System.Drawing.Size(75, 48);
			this.btnReferenzZuweisen.TabIndex = 2;
			this.btnReferenzZuweisen.Text = "Referenz zuweisen";
			this.btnReferenzZuweisen.UseVisualStyleBackColor = true;
			this.btnReferenzZuweisen.Click += new System.EventHandler(this.btnReferenzZuweisen_Click);
			// 
			// btnZweiFahrzeuge
			// 
			this.btnZweiFahrzeuge.Location = new System.Drawing.Point(115, 65);
			this.btnZweiFahrzeuge.Name = "btnZweiFahrzeuge";
			this.btnZweiFahrzeuge.Size = new System.Drawing.Size(75, 48);
			this.btnZweiFahrzeuge.TabIndex = 3;
			this.btnZweiFahrzeuge.Text = "Zwei Fahrzeuge";
			this.btnZweiFahrzeuge.UseVisualStyleBackColor = true;
			this.btnZweiFahrzeuge.Click += new System.EventHandler(this.btnZweiFahrzeuge_Click);
			// 
			// btnZuweisungWertdatentyp
			// 
			this.btnZuweisungWertdatentyp.Location = new System.Drawing.Point(216, 65);
			this.btnZuweisungWertdatentyp.Name = "btnZuweisungWertdatentyp";
			this.btnZuweisungWertdatentyp.Size = new System.Drawing.Size(89, 48);
			this.btnZuweisungWertdatentyp.TabIndex = 4;
			this.btnZuweisungWertdatentyp.Text = "Zuweisung Wertdatentyp";
			this.btnZuweisungWertdatentyp.UseVisualStyleBackColor = true;
			this.btnZuweisungWertdatentyp.Click += new System.EventHandler(this.btnZuweisungWertdatentyp_Click);
			// 
			// btnReferenzPrüfen
			// 
			this.btnReferenzPrüfen.Location = new System.Drawing.Point(334, 65);
			this.btnReferenzPrüfen.Name = "btnReferenzPrüfen";
			this.btnReferenzPrüfen.Size = new System.Drawing.Size(75, 48);
			this.btnReferenzPrüfen.TabIndex = 5;
			this.btnReferenzPrüfen.Text = "Referenz prüfen";
			this.btnReferenzPrüfen.UseVisualStyleBackColor = true;
			this.btnReferenzPrüfen.Click += new System.EventHandler(this.btnReferenzPrüfen_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnReferenzPrüfen);
			this.Controls.Add(this.btnZuweisungWertdatentyp);
			this.Controls.Add(this.btnZweiFahrzeuge);
			this.Controls.Add(this.btnReferenzZuweisen);
			this.Controls.Add(this.btnReferenz);
			this.Controls.Add(this.btnKopie);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnKopie;
		private System.Windows.Forms.Button btnReferenz;
		private System.Windows.Forms.Button btnReferenzZuweisen;
		private System.Windows.Forms.Button btnZweiFahrzeuge;
		private System.Windows.Forms.Button btnZuweisungWertdatentyp;
		private System.Windows.Forms.Button btnReferenzPrüfen;
	}
}

