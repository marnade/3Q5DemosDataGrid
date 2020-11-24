using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Informaticien : INotifyPropertyChanged
    {
        public enum GenreEnum { Homme, Femme };

        public event PropertyChangedEventHandler PropertyChanged;
        private string _prenom;
        private string _nom;
        private GenreEnum _genre;
        private Uri _siteWeb;
        private bool _abonnementNouvelles;
        private string _image;
        private DateTime _ddn;
        private string _niveauEtudes;
        public string NiveauEtudes { get; set; }


        public string Prenom
        {
            get { return _prenom; }
            set
            {
                _prenom = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Prenom"));
            }
        }
        public string Nom
        {
            get { return _nom; }
            set
            {
                _nom = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Nom"));
            }
        }
        public GenreEnum Genre
        {
            get { return _genre; }
            set
            {
                _genre = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Genre"));
            }
        }
        public Uri SiteWeb
        {
            get { return _siteWeb; }
            set
            {
                _siteWeb = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("SiteWeb"));
            }
        }
        public bool AbonnementNouvelles
        {
            get { return _abonnementNouvelles; }
            set
            {
                _abonnementNouvelles = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("AbonnementNouvelles"));
            }
        }
        public string Image
        {
            get { return _image; }
            set
            {
                _image = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Image"));
            }
        }
        public DateTime DDN
        {
            get { return _ddn; }
            set
            {
                _ddn = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("DDN"));
            }
        }
    }
}
