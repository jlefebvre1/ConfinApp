using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfinApp.Filmothèque
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Data.openBDD();
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {

        }
        class FilDataGrid
        {
            public int fil_id { get; set; }
            public String fil_titre { get; set; }
            public String fil_categorie { get; set; }
            public String fil_realisateur { get; set; }
            public DateTime fil_duree { get; set; }
            public DateTime fil_dateSortie { get; set; }
            public String fil_acteurPrincipal { get; set; }
            public Film film { get; set; }
        }

        public List<Film> listeFilm()
        {
            List<Film> listeFilm = new List<Film>();
            Film film1;
            SqlConnection co;
            co = Data.openBDD();
            return listeFilm;
        }

    }
}
