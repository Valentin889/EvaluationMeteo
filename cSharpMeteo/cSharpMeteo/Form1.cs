using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HttpUtils;
using Newtonsoft.Json;

namespace cSharpMeteo
{
    public partial class FrmMeteo : Form
    {
        /// <summary>
        /// initialisation des variables global à la classe
        /// </summary>
        private Rootobject regionReponse = new Rootobject();
        private TableLayoutPanel tlpAffichage;
        /// <summary>
        /// constructeur principale, initialisation de la liste déroulante des localités,
        /// initialisation d'un TableLayoutPanel
        /// initialisation de la liste déroulante des jours à afficher
        /// </summary>
        public FrmMeteo()
        {
            InitializeComponent();


            ChargementListeDeroulante();

            tlpAffichage = new TableLayoutPanel();
            tlpAffichage.Location = new Point(39, 196);
            tlpAffichage.AutoScroll = true;
            tlpAffichage.AutoSize = true;
            Controls.Add(tlpAffichage);

            for (int i = 1; i < 6; i++)
            {
                cbxJours.Items.Add(i.ToString());
            }
        }
        /// <summary>
        /// affiche la météo pour la ville et le nombres de jours choisis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cbxLocalite.Text != "" && cbxJours.Text != "")
            {
                Rootobject InfoVille = Connection(cbxLocalite.Text);
                GenernerChamp(Convert.ToInt32(cbxJours.Text), InfoVille);
            }
            else
            {
                MessageBox.Show("veuillez entrer une ville et un nombre de jours");
            }
        }
        /// <summary>
        /// quand l'utilisateur veut ajouter une ville il utilise ce bouton,
        /// ce bouton vérifie que la ville entrée existe bien
        /// et qu'elle n'est pas déjà dans la liste déroulante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (Connection(tbxAjout.Text).fcst_day_0 != null)
            {
                bool doublon = false;
                foreach (string s in cbxLocalite.Items)
                {
                    if (tbxAjout.Text == s)
                    {
                        doublon = true;
                    }
                }
                if (!doublon)
                {
                    AjoutLocalite(tbxAjout.Text);
                    cbxLocalite.Items.Clear();
                    ChargementListeDeroulante();
                    MessageBox.Show("la ville a été correctement ajoutée");
                }
                else
                {
                    MessageBox.Show("la ville entrée existe déjà");
                }
            }
            else
            {
                MessageBox.Show("entrer une localite valide");
            }
        }

        /// <summary>
        /// reçoit en paramète une localité, la méthode essaie de ce connecter au web service de la météo avec la localité choisie
        /// si la localité existe et que la connection est fonctionnelle on renvoi un objet de type RootObject qui contient les informations météo voulus
        /// sinon on renvoit null
        /// </summary>
        /// <param name="localite"></param>
        /// <returns></returns>
        private Rootobject Connection(string localite)
        {
            try
            {
                string endPoint = @"http://www.prevision-meteo.ch/services/json/" + localite;

                var client = new RestClient(endPoint);
                var json = client.MakeRequest();

                object objResponse = JsonConvert.DeserializeObject(json, typeof(Rootobject));

                regionReponse = (Rootobject)objResponse;

                return regionReponse;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// la méthode est appelée quand il faut générer les champs après que l'utilisateur ait validé la localité et le nombre de jours
        /// la méthode créer les label et les pictureBox nécessaire et met le texte adéqua dedans
        /// pour l'instant pour savoir si l'on affiche le jour 1 le 2 ou autre on a reccour à un switch, des recherches sont à faire pour
        /// trouver une méthode de concaténation si possible
        /// </summary>
        /// <param name="iNbChamps"></param>
        /// <param name="infoVille"></param>
        private void GenernerChamp(int iNbChamps, Rootobject infoVille)
        {
            int iNbColonne = 4;
            List<string> lstEnTete = new List<string>();
            lstEnTete.Add("jour");
            lstEnTete.Add("photo");
            lstEnTete.Add("température minimum");
            lstEnTete.Add("températur maximum");

            tlpAffichage.ColumnStyles.Clear();
            tlpAffichage.Controls.Clear();
            tlpAffichage.ColumnCount = iNbColonne;
            tlpAffichage.RowCount = iNbChamps;


            for (int i = 0; i < iNbColonne; i++)
            {
                Label champ = new Label();
                champ.Text = lstEnTete[i];
                champ.Size = TextRenderer.MeasureText(champ.Text, champ.Font);
                tlpAffichage.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                tlpAffichage.Controls.Add(champ);
            }


            for (int i = 0; i < iNbChamps; i++)
            {
                Label champ = new Label();
                PictureBox image = new PictureBox();
                Label champ1 = new Label();
                Label champ2 = new Label();
                switch (i)
                {
                    case 0:
                        champ.Text = infoVille.fcst_day_0.day_short;
                        image.Load(infoVille.fcst_day_0.icon);
                        champ1.Text = Convert.ToString(infoVille.fcst_day_0.tmin);
                        champ2.Text = Convert.ToString(infoVille.fcst_day_0.tmax);

                        break;
                    case 1:
                        champ.Text = infoVille.fcst_day_1.day_short;
                        image.Load(infoVille.fcst_day_1.icon);
                        champ1.Text = Convert.ToString(infoVille.fcst_day_1.tmin);
                        champ2.Text = Convert.ToString(infoVille.fcst_day_1.tmax);
                        break;
                    case 2:
                        champ.Text = infoVille.fcst_day_2.day_short;
                        image.Load(infoVille.fcst_day_2.icon);
                        champ1.Text = Convert.ToString(infoVille.fcst_day_2.tmin);
                        champ2.Text = Convert.ToString(infoVille.fcst_day_2.tmax);
                        break;
                    case 3:
                        champ.Text = infoVille.fcst_day_3.day_short;
                        image.Load(infoVille.fcst_day_3.icon);
                        champ1.Text = Convert.ToString(infoVille.fcst_day_3.tmin);
                        champ2.Text = Convert.ToString(infoVille.fcst_day_3.tmax);
                        break;
                    case 4:
                        champ.Text = infoVille.fcst_day_4.day_short;
                        image.Load(infoVille.fcst_day_4.icon);
                        champ1.Text = Convert.ToString(infoVille.fcst_day_4.tmin);
                        champ2.Text = Convert.ToString(infoVille.fcst_day_4.tmax);
                        break;
                }
                champ.Size = TextRenderer.MeasureText(champ.Text, champ.Font);
                image.Size = new System.Drawing.Size(60, 60);
                champ1.Size = TextRenderer.MeasureText(champ1.Text, champ.Font);
                champ2.Size = TextRenderer.MeasureText(champ2.Text, champ.Font);

                tlpAffichage.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                tlpAffichage.Controls.Add(champ);
                tlpAffichage.Controls.Add(image);
                tlpAffichage.Controls.Add(champ1);
                tlpAffichage.Controls.Add(champ2);
            }
        }
        /// <summary>
        /// quand la localité est validé correct on a reccour a cette méthode pour l'ajouter dans le fichier texte
        /// </summary>
        /// <param name="localite"></param>
        private void AjoutLocalite(string localite)
        {

            string Chemin = "Source/localite.txt";
            string[] Lignes = System.IO.File.ReadAllLines(Chemin);
            List<string> l = Lignes.ToList<string>();
            l.Add(localite);
            Lignes = l.ToArray();
            System.IO.File.WriteAllLines(Chemin, Lignes);

        }
        /// <summary>
        /// quand le fichier text est modifié ou simplement au début du programme on va le lire pour mettre à jour les donnés dans la liste déroulante
        /// </summary>
        private void ChargementListeDeroulante()
        {
            string Chemin = "Source/localite.txt";

            string[] Lignes = System.IO.File.ReadAllLines(Chemin);

            List<string> l = Lignes.ToList<string>();
            foreach (string s in l)
            {
                cbxLocalite.Items.Add(s);
            }
        }

       
    }
}

