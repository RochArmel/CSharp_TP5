using System;
using System.Data;
using System.Windows.Forms;

namespace TP5_Gestion
{
    /// <summary>
    /// Formulaire pour l'ajout de données via des TextBox, en utilisant un DataTable.
    /// </summary>
    public partial class frmForm2 : Form
    {
        // DataTable pour stocker les informations des personnes.
        DataTable table = new DataTable("Personne");

        public frmForm2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Charge le formulaire, initialise les colonnes de la DataTable et configure les liaisons de données.
        /// </summary>
        private void frmForm2_Load(object sender, EventArgs e)
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

        /// <summary>
        /// Ajoute une nouvelle personne à la DataTable à partir des informations saisies dans les TextBox.
        /// </summary>
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = table.NewRow();
                newRow["CIN"] = TxtCin.Text;
                newRow["Nom"] = TxtNom.Text;
                newRow["Prénom"] = TxtPrenom.Text;
                newRow["Ville"] = TxtVille.Text;
                newRow["Téléphone"] = TxtTel.Text;
                newRow["Age"] = int.Parse(TxtAge.Text);

                table.Rows.Add(newRow);

                TxtCin.Text = "";
                TxtNom.Text = "";
                TxtPrenom.Text = "";
                TxtVille.Text = "";
                TxtTel.Text = "";
                TxtAge.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de l'ajout : " + ex.Message);
            }
        }

        /// <summary>
        /// Affiche les détails de la personne sélectionnée dans une MessageBox.
        /// </summary>
        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current != null)
            {
                DataRowView currentRowView = (DataRowView)bindingSource1.Current;
                DataRow currentRow = currentRowView.Row;

                string details = "Détails de la personne :\n\n";
                details += "CIN : " + currentRow["CIN"] + "\n";
                details += "Nom : " + currentRow["Nom"] + "\n";
                details += "Prénom : " + currentRow["Prénom"] + "\n";
                details += "Ville : " + currentRow["Ville"] + "\n";
                details += "Téléphone : " + currentRow["Téléphone"] + "\n";
                details += "Age : " + currentRow["Age"];

                MessageBox.Show(details, "Détails", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aucune personne sélectionnée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // --- Menus ---
        /// <summary>
        /// Ferme l'application.
        /// </summary>
        private void Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Affiche le formulaire 1 et masque le formulaire actuel.
        /// </summary>
        private void Form1_Click(object sender, EventArgs e)
        {
            frmForm1 form1 = new frmForm1();
            form1.Show();
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
