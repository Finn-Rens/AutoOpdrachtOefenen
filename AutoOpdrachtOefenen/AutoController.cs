using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AutoOpdrachtOefenen
{
    public class AutoController
    {
        //public List<Auto> Autos { get; }
        public ObservableCollection<Auto> Autos { get; set; }
        public AutoController()
        {
            //Autos = new List<Auto>();
            Autos = new ObservableCollection<Auto>();


            Autos.Add(new Auto { Kenteken = "GL-168-K", Prijs = 28000, Merk = "Peugeot", Bouwjaar = 2015 });

            var auto2 = new Auto();

            auto2.Kenteken = "375-384-73";
            auto2.Prijs = 60000.5m;
            auto2.Merk = "Mercedes";
            auto2.Bouwjaar = 2020;

            Autos.Add(auto2);

            //this.Verwijderen(auto2);

            //var autoOnbekend = new Auto();

            //autoOnbekend.Kenteken = "ik zit niet in de lijst";

            //this.Verwijderen(autoOnbekend);
        }

        public void Verwijderen(Auto auto) 
        {
            Autos.Remove(auto);
        }
    }
}
