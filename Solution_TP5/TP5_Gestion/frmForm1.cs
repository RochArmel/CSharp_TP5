using System;
using System.Data;
using System.Windows.Forms;

namespace TP5_Gestion
{
    /// <summary>
    /// Formulaire principal pour l'ajout direct de données dans un DataGridView via un DataTable.
    /// </summary>
    public partial class frmForm1 : Form
    {
        // DataTable pour stocker les informations des personnes.
        DataTable table = new DataTable("Personne");

        public frmForm1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Charge le formulaire, initialise les colonnes de la DataTable et configure les liaisons de données.
        /// </summary>
        private void frmForm1_Load(object sender, EventArgs e)
        {
            // Créer les colonnes de la DataTable
            table.Columns.Add("CIN", typeof(string));
            table.Columns.Add("Nom", typeof(string));
            table.Columns.Add("Prénom", typeof(string));
            table.Columns.Add("Ville", typeof(string));
            table.Columns.Add("Téléphone", typeof(string));
            table.Columns.Add("Age", typeof(int));

            // Configurer les liaisons de données
            bindingSource1.DataSource = table;
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
        }

        // --- Menus "Fichier" ---

        /// <summary>
        /// Efface toutes les données de la table.
        /// </summary>
        private void Nouveau_Click(object sender, EventArgs e)
        {
            table.Clear();
        }

        /// <summary>
        /// Ouvre un fichier XML et charge ses données dans la table.
        /// </summary>
        private void Ouvrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                table.ReadXml(openFileDialog1.FileName);
            }
        }

        /// <summary>
        /// Enregistre les données de la table dans un fichier XML.
        /// </summary>
        private void EnregistrerSous_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                table.WriteXml(saveFileDialog1.FileName);
            }
        }

        /// <summary>
        /// Ferme l'application.
        /// </summary>
        private void Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --- Menus "Aller à" ---

        /// <summary>
        /// Affiche le formulaire 2 et masque le formulaire actuel.
        /// </summary>
        private void Form2_Click(object sender, EventArgs e)
        {
            frmForm2 form2 = new frmForm2();
            form2.Show();
            this.Hide();
        }

        /// <summary>
        /// Affiche le formulaire 3 et masque le formulaire actuel.
        /// </summary>
        private void Form3_Click(object sender, EventArgs e)
        {
            frmForm3 form3 = new frmForm3();
            form3.Show();
            this.Hide();
        }
    }
}
