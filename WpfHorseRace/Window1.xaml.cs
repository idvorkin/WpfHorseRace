using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfHorseRace
{
	public partial class Window1 : System.Windows.Window
	{
		public Window1()
		{
			InitializeComponent();
					
			this.raceTrack.ItemsSource = CreateRaceHorses();

			this.Loaded += delegate { this.StartRace(); };
			this.lnkStartNewRace.Click += delegate { this.StartRace(); };
		}

		void StartRace()
		{		
            this.raceTrack.Items.Cast<RaceHorse>().ToList().ForEach(rh=>rh.StartNewRace());
		}

		static IEnumerable<RaceHorse> CreateRaceHorses()
		{
		    var horses = "Lucky;Sweet;Kentucky;Spice;BlueGrass;Kit".Split(';').ToList();
		    return horses.Select(name => new RaceHorse(name));
		}
	}
}