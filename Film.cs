using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfinApp
{
    class Film
    {
        private int fil_id;
        private String fil_titre;
        private String fil_categorie;
        private String fil_realisateur;
        private DateTime fil_duree;
        private DateTime fil_dateSortie;
        private String fil_acteurPrincipal;

        public int Fil_id
        {
            get
            {
                return fil_id;
            }

            set
            {
                fil_id = value;
            }
        }

        public string Fil_titre
        {
            get
            {
                return fil_titre;
            }

            set
            {
                fil_titre = value;
            }
        }

        public string Fil_categorie
        {
            get
            {
                return fil_categorie;
            }

            set
            {
                fil_categorie = value;
            }
        }

        public string Fil_realisateur
        {
            get
            {
                return fil_realisateur;
            }

            set
            {
                fil_realisateur = value;
            }
        }

        public DateTime Fil_duree
        {
            get
            {
                return fil_duree;
            }

            set
            {
                fil_duree = value;
            }
        }

        public DateTime Fil_dateSortie
        {
            get
            {
                return fil_dateSortie;
            }

            set
            {
                fil_dateSortie = value;
            }
        }

        public string Fil_acteurPrincipal
        {
            get
            {
                return fil_acteurPrincipal;
            }

            set
            {
                fil_acteurPrincipal = value;
            }
        }

        public Film(int fil_id, string fil_titre, string fil_categorie, string fil_realisateur, DateTime fil_duree, DateTime fil_dateSortie, string fil_acteurPrincipal)
        {
            this.Fil_id = fil_id;
            this.Fil_titre = fil_titre;
            this.Fil_categorie = fil_categorie;
            this.Fil_realisateur = fil_realisateur;
            this.Fil_duree = fil_duree;
            this.Fil_dateSortie = fil_dateSortie;
            this.Fil_acteurPrincipal = fil_acteurPrincipal;
        }
    }
}
