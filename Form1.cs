using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestiondvd
{
    

    public partial class Form1 : Form
    {
        class ConnexionSql
        {
            // propriétés
            private bool finCurseur = true; // fin du curseur atteinte
            private MySqlConnection connection; // chaine de connexion
            private MySqlCommand command; // envoi de la requête à la base de données
            private MySqlDataReader reader; // gestion du curseur

            // constructeur
            public ConnexionSql(string chaineConnection)
            {
                this.connection = new MySqlConnection(chaineConnection);
                this.connection.Open();
            }

            // execution d'une requete select
            public void reqSelect(string chaineRequete)
            {
                this.command = new MySqlCommand(chaineRequete, this.connection);
                this.reader = this.command.ExecuteReader();
                this.finCurseur = false;
                this.suivant();
            }

            // execution d'une requete update
            public void reqUpdate(string chaineRequete)
            {
                this.command = new MySqlCommand(chaineRequete, this.connection);
                this.command.ExecuteNonQuery();
                this.finCurseur = true;
            }

            // récupération d'un champ
            public Object champ(string nomChamp)
            {
                return this.reader[nomChamp];
            }

            // passage à la ligne suivante du curseur
            public void suivant()
            {
                if (!this.finCurseur)
                {
                    this.finCurseur = !this.reader.Read();
                }
            }

            // test de la fin du curseur
            public Boolean fin()
            {
                return this.finCurseur;
            }

            // fermeture de la connexion
            public void close()
            {
                this.connection.Close();
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chaineConnection = null;
            MySqlConnection cnn;
            chaineConnection = "server=localhost;database=gestiondvd;uid=root;pwd=\"\";";
            cnn = new MySqlConnection(chaineConnection);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Connexion à la base de données
            string chaineConnection = "server=localhost;database=gestiondvd;uid=root;pwd=\"\";";
            ConnexionSql connexion = new ConnexionSql(chaineConnection);

            // Exécution de la requête SELECT
            connexion.reqSelect("SELECT titre FROM dvd");

            // Ajout des éléments à la ListBox
            while (!connexion.fin())
            {
                string item = connexion.champ("titre").ToString();
                lstDvd.Items.Add(item);
                connexion.suivant();
            }

            // Fermeture de la connexion
            connexion.close();

           /* // Connexion pour Genre
            ConnexionSql connexionGenre = new ConnexionSql(chaineConnection);
            connexion.reqSelect("SELECT libelle FROM genre");
            while (connexionGenre.fin())
            {
                *//*this.cboGenre.Items.Add((connexion.champ("libelle"))).ToString();
                connexion.suivant();*/

               /* string item = connexionGenre.champ("libelle").ToString();
                cboGenre.Items.Add(item);
                connexionGenre.suivant();
            }
            connexionGenre.close();


            // Connexion pour Acteur
            ConnexionSql connexionActeur = new ConnexionSql(chaineConnection);
            connexion.reqSelect("SELECT libelle FROM genre");
            while (connexionActeur.fin())
            {
             */   /*this.cboGenre.Items.Add((connexion.champ("libelle"))).ToString();
                connexion.suivant();*/
            /*
                string item = connexionActeur.champ("libelle").ToString();
                cboGenre.Items.Add(item);
                connexionActeur.suivant();
            }
            connexionActeur.close();*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
