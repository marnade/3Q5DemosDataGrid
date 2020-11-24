using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo1
{
    public partial class MainWindow : Window
    {
        public ICollectionView CVInformaticiens { get; set; }
        public ICollectionView CVInformaticiensGroupes { get; set; }


        public MainWindow()
        {
            peupler();
            InitializeComponent();
            this.DataContext = this;
        }
        private void peupler()
        {
            List<Informaticien> informaticiens = new List<Informaticien>() {
                new Informaticien {
                    Prenom = "Kent",
                    Nom = "Beck",
                    Genre = Informaticien.GenreEnum.Homme,
                    SiteWeb = new Uri("http://fr.wikipedia.org/wiki/Kent_Beck"),
                    Image = "http://dinfo.ca/kent_beck.gif",
                    AbonnementNouvelles = true,
                    DDN = new DateTime(1961,3,31)
                },
                new Informaticien {
                    Prenom = "Barbara",
                    Nom = "Liskov",
                    Genre = Informaticien.GenreEnum.Femme,
                    SiteWeb = new Uri("http://fr.wikipedia.org/wiki/Barbara_Liskov"),
                    Image = "https://dinfo.ca/barbara_liskov.jpg",
                    AbonnementNouvelles = true,
                    DDN = new DateTime(1939,11,7)
                },
                new Informaticien {
                    Prenom = "Martin",
                    Nom = "Fowler",
                    Genre = Informaticien.GenreEnum.Homme,
                    SiteWeb = new Uri("http://fr.wikipedia.org/wiki/Martin_Fowler"),
                    Image = "https://dinfo.ca/martin_fowler.jpg",
                    AbonnementNouvelles = false,
                    DDN = new DateTime(1963,1,1)
                },
                new Informaticien {
                    Prenom = "Yoshua",
                    Nom = "Bengio",
                    Genre = Informaticien.GenreEnum.Homme,
                    SiteWeb = new Uri("http://https://fr.wikipedia.org/wiki/Yoshua_Bengio"),
                    Image = "https://dinfo.ca/yoshua_bengio.jpg",
                    AbonnementNouvelles = true,
                    DDN = new DateTime(1964,3,5)
                },
                new Informaticien {
                    Prenom = "Jeannette",
                    Nom = "Wing",
                    Genre = Informaticien.GenreEnum.Femme,
                    SiteWeb = new Uri("http://fr.wikipedia.org/wiki/Jeannette_Wing"),
                    Image = "https://dinfo.ca/jeannette_wing.jpg",
                    AbonnementNouvelles = false,
                    DDN = new DateTime(1956,12,4)
                }
            };
            CVInformaticiens = new ListCollectionView(informaticiens);
            CVInformaticiensGroupes = new ListCollectionView(informaticiens);
            CVInformaticiensGroupes.GroupDescriptions.Add(new PropertyGroupDescription("AbonnementNouvelles"));
            CVInformaticiensGroupes.GroupDescriptions.Add(new PropertyGroupDescription("Genre"));


        }
    }
}
