using IlmaMeskic_studentaqEvents.models;

namespace IlmaMeskic_studentaqEvents;

public partial class MainPage : ContentPage
{
    public List<VrstaUsluge> listVrstaUsluge { get; set; }
    public List<KlasaUsluge> listKlasaUsluge { get; set; }

    public MainPage()
	{
		InitializeComponent();


        listVrstaUsluge = new List<VrstaUsluge>
        {
            new VrstaUsluge {id=1, Ikona="dizajn.png", Naziv="DESIGN & \nBRANDING", Cijena=250},
           new VrstaUsluge {id=2, Ikona="pozivnica.png", Naziv="INVITATION & \nACCESS", Cijena=2.5F},
           new VrstaUsluge {id=3, Ikona="dostava.png", Naziv="DELIVERY & \nTRANSPORT", Cijena=10},
           new VrstaUsluge {id=4, Ikona="dekoracija.png", Naziv="SPACE & \nDECORATION", Cijena=500},
           new VrstaUsluge {id=5, Ikona="stagee.png", Naziv="STAGE & \nLIGHT", Cijena=500},
           new VrstaUsluge {id=6, Ikona="sati.png", Naziv="FOOD & \nCATERING", Cijena=10},


        };

        listKlasaUsluge = new List<KlasaUsluge>
        {
            new KlasaUsluge{id=1, NazivKlase="Osnovno", OznakaKvaliteta="Dobar", FaktorCijene=1},
            new KlasaUsluge{id=2, NazivKlase="Plus", OznakaKvaliteta="Odlican", FaktorCijene=2},
            new KlasaUsluge{id=3, NazivKlase="Premium", OznakaKvaliteta="Luksuzan", FaktorCijene=3}
        };

        BindingContext = this;

        slika1.Source = listVrstaUsluge[0].Ikona;
        label1.Text = listVrstaUsluge[0].Naziv;

        slika4.Source = listVrstaUsluge[3].Ikona;
        label4.Text = listVrstaUsluge[3].Naziv;

        slika2.Source = listVrstaUsluge[1].Ikona;
        label2.Text = listVrstaUsluge[1].Naziv;

        slika5.Source = listVrstaUsluge[4].Ikona;
        label5.Text = listVrstaUsluge[4].Naziv;

        slika3.Source = listVrstaUsluge[2].Ikona;
        label3.Text = listVrstaUsluge[2].Naziv;

        slika6.Source = listVrstaUsluge[5].Ikona;
        label6.Text = listVrstaUsluge[5].Naziv;

        klasa.ItemsSource = listKlasaUsluge;



    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        KlasaUsluge klasaUsluge = (KlasaUsluge)klasa.SelectedItem;

        int br = 0;


        if (klasa.SelectedItem is null)
        {
            DisplayAlert("GRESKA", "Nije odabrana klasa usluge", "OK");
        }
        else if(Entry1.Text is null)
        {
            DisplayAlert("GRESKA", "Nije unesen broj dana", "OK");

        }
        else if(Entry2.Text is null)
        {
            DisplayAlert("GRESKA", "Nije unesen broj zvanica", "OK");
        }
        else
        {

            
            float cijenaCijeliDan = 0;
            float cijena = 0;
            float cijena1 = 0;
            float cijena2 = 0;
            float cijena3 = 0;
            float cijena4 = 0;
            float cijena5 = 0;
            float cijena6 = 0;

            float cijena1lista = listVrstaUsluge[0].Cijena;
            float cijena2lista= listVrstaUsluge[1].Cijena;
            float cijena3lista = listVrstaUsluge[2].Cijena;
            float cijena4lista = listVrstaUsluge[3].Cijena;
            float cijena5lista= listVrstaUsluge[4].Cijena;
            float cijena6lista = listVrstaUsluge[5].Cijena;



            int trajanje = int.Parse(Entry1.Text);

            int kol1 = 0;
            int kol2 = 0;
            int kol3 = 0;
            int kol4 = 0;
            int kol5 = 0;
            int kol6 = 0;


            if (check1.IsChecked)
            {
                kol1 = int.Parse(Entry2.Text);
                br++;
            }

            if (check2.IsChecked)
            {
                kol2 = int.Parse(Entry2.Text);
                br++;
            }
            if (check3.IsChecked)
            {
                kol3 = int.Parse(Entry2.Text);
                br++;
            }
            if (check4.IsChecked)
            {
                kol4 = int.Parse(Entry2.Text);
                br++;
            }
            if (check5.IsChecked)
            {
                kol5 = int.Parse(Entry2.Text);
                br++;
            }
            if (check6.IsChecked)
            {
                kol6 = int.Parse(Entry2.Text);
                br++;
            }




            if (kol1 > 0)
            {

                cijena1 = cijena1 + (cijena1lista * trajanje) * kol1;
                

            }
            else
            {
                cijena1 = 0;
            }


            if (kol2 > 0)
            {

                cijena2 = cijena2 + (cijena2lista * trajanje) * kol2;

            }
            else
            {
                cijena2 = 0;
            }


            if (kol3 > 0)
            {

                cijena3 = cijena3+ (cijena3lista * trajanje) * kol3;

            }
            else
            {
                cijena3 = 0;
            }

            if (kol4 > 0)
            {

                cijena4 = cijena4 + (cijena4lista * trajanje) * kol4;

            }
            else
            {
                cijena4 = 0;
            }

            if (kol5 > 0)
            {

                cijena5 = cijena5 + (cijena5lista * trajanje) * kol5;

            }
            else
            {
                cijena5 = 0;
            }

            if (kol6 > 0)
            {

                cijena6= cijena6 + (cijena6lista * trajanje) * kol6;

            }
            else
            {
                cijena6 = 0;
            }


            cijena = cijena1 + cijena2 + cijena3 + cijena4 + cijena5 + cijena6;


            if (EventSwitch.IsToggled)
            {
                cijenaCijeliDan = cijena + (cijena - (cijena * 0.6f));
            }


            String ispis;

            if (klasaUsluge.NazivKlase == listKlasaUsluge[0].NazivKlase)
            {
                ispis = listKlasaUsluge[0].OznakaKvaliteta;
            }
            else if (klasaUsluge.NazivKlase == listKlasaUsluge[1].NazivKlase)
            {
                ispis = listKlasaUsluge[1].OznakaKvaliteta;
            }
            else
            {
                ispis = listKlasaUsluge[2].OznakaKvaliteta;
            }


            string poruka = "POLICA OSIGURANJA" +
                            "\r\nUkupna vrijednost usluge: " + cijena.ToString() + " KM" +
                            "\r\nBroj odabranih usluga: " + br +
                            "\r\nNivo kvaliteta:" + ispis +
                            "\r\nCjelodnevna dostupnost " + cijenaCijeliDan.ToString() + "KM" +
                            "\r\nTrajanje eventa (dana) : " + trajanje +
                            "\r\nDatum od " + uneseniDatum.Date.ToShortDateString() + " do " + uneseniDatum.Date.AddDays(trajanje).ToShortDateString()
                            ;

            DisplayAlert("Kalkulacija ponude", poruka, "OK");



        }



    }
}

