
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_5._6_ReferenzenVergleicheTypen
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnKopie_Click(object sender, EventArgs e)
		{
			int meinWert = 1;
			Console.WriteLine("Kopie:");
			Console.WriteLine("Vorher: " + meinWert);
			AddiereEins(meinWert);
			Console.WriteLine("Nachher: " + meinWert);
		}

		private void AddiereEins(int wert)
		{
			wert++;
		}

		private void btnReferenz_Click(object sender, EventArgs e)
		{
			int meinWert = 1;
			Console.WriteLine("Referenz:");
			Console.WriteLine("Vorher: " + meinWert);
			AddiereEins(ref meinWert);
			Console.WriteLine("Nachher: " + meinWert);
		}

		private void AddiereEins(ref int wert)
		{
			wert++;
		}

		private void btnReferenzZuweisen_Click(object sender, EventArgs e)
		{
			// Es wird nur ein Objekt erzeugt!!!
			// lokale Variable "vespa" verweist auf dieses Objekt (Objektverweis)
			Fahrzeug vespa = new Fahrzeug("Moped", 50);
			Fahrzeug schwalbe;

			// Referenz zuweisen
			// lokale Variable "schwalbe" verweist nun auch auf das eine erstellte
			// Objekt, auf das die Variable "vespa" verweist
			// => Beide Variablen verweisen auf das SELBE Objekt
			schwalbe = vespa;

			// Anzeigen
			Console.WriteLine("Start:");
			Console.WriteLine(vespa + " / " + schwalbe);

			// Vespa beschleunigen
			vespa.Beschleunigen(35);

			// Anzeigen
			Console.WriteLine("Nach Beschleunigung der Vespa:");
			Console.WriteLine(vespa + " / " + schwalbe);

			// Schwalbe beschleunigen
			schwalbe.Beschleunigen(10);

			// Anzeigen
			Console.WriteLine("Nach Beschleunigung der Schwalbe:");
			Console.WriteLine(vespa + " / " + schwalbe);
		}

		private void btnZweiFahrzeuge_Click(object sender, EventArgs e)
		{
			// Es werden zwei Objekte erzeugt und
			// deren Objektverweis wird jeweils in einer lokalen Variablen gespeichert
			Fahrzeug vespa = new Fahrzeug("Vespa", 50);
			Fahrzeug schwalbe = new Fahrzeug("Schwalbe", 20); ;

			// Referenz zuweisen
			// lokale Variable "schwalbe" verweist nun auch auf das eine erstellte
			// Objekt, auf das die Variable "vespa" verweist
			// => Beide Variablen verweisen auf das SELBE Objekt
			schwalbe = vespa;

			// Anzeigen
			Console.WriteLine("Start:");
			Console.WriteLine(vespa + " / " + schwalbe);

			// Vespa beschleunigen
			vespa.Beschleunigen(35);

			// Anzeigen
			Console.WriteLine("Nach Beschleunigung der Vespa:");
			Console.WriteLine(vespa + " / " + schwalbe);

			// Schwalbe beschleunigen
			schwalbe.Beschleunigen(10);

			// Anzeigen
			Console.WriteLine("Nach Beschleunigung der Schwalbe:");
			Console.WriteLine(vespa + " / " + schwalbe);
		}

		private void btnZuweisungWertdatentyp_Click(object sender, EventArgs e)
		{
			// Basisdatentypen werden als Werttypen behandelt !!
			// Übergabe IMMER per Kopie
			int zahl1 = 5;
			int zahl2 = 10;

			// Zuweisung (nur der Wert wird zugewiesen!)
			zahl1 = zahl2;

			// Start
			Console.WriteLine("Start:");
			Console.WriteLine("zahl1: " + zahl1 + " / " + "zahl2: " + zahl2);

			// Erhöhung Zahl 1
			zahl1 += 10;
			Console.WriteLine("Nach Erhöhung von Zahl 1:");
			Console.WriteLine("zahl1: " + zahl1 + " / " + "zahl2: " + zahl2);

			// Erhöhung Zahl 2
			zahl2 += 10;
			Console.WriteLine("Nach Erhöhung von Zahl 2:");
			Console.WriteLine("zahl1: " + zahl1 + " / " + "zahl2: " + zahl2);
		}

		private void btnReferenzPrüfen_Click(object sender, EventArgs e)
		{
			// Objekt erzeugen
			Fahrzeug vespa = new Fahrzeug("Vespa", 50);

			Fahrzeug vespa2 = new Fahrzeug("Vespa", 50);

			// Referenz zuweisen
			// vespa2 = vespa;

			// Objekte vergleichen (über == Operator)
			Console.WriteLine("Vergleich über ==");
			if (vespa2 == vespa) Console.WriteLine("Beide Objekte sind gleich");
			else Console.WriteLine("Die Objekte sind unterschiedlich");

			// Objekte vergleichen (über Equals()-Methode)
			Console.WriteLine("Vergleich über Equals()");
			if (vespa2.Equals(vespa)) Console.WriteLine("Beide Objekte sind gleich");
			else Console.WriteLine("Die Objekte sind unterschiedlich");
		}
	}
}
