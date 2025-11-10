using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP5_Gestion
{
    /// <summary>
    /// Formulaire pour l'ajout de données via des TextBox, en utilisant une List&lt;Personne&gt;.
    /// </summary>
    public partial class frmForm3 : Form
    {
        // Liste pour stocker les objets Personne.
        List<Personne> listPersonnes = new List<Personne>();

        public frmForm3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Charge le formulaire et configure les liaisons de données avec la liste de personnes.
        /// </summary>
        private void frmForm3_Load(object sender, EventArgs e)
        {
            // Configurer les liaisons de données
            bindingSource1.DataSource = listPersonnes;
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
        }

        /// <summary>
        /// Ajoute un nouvel objet Personne à la liste à partir des informations saisies et rafraîchit la liaison de données.
        /// </summary>
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                Personne p = new Personne(
                    TxtCin.Text,
                    TxtNom.Text,
                    TxtPrenom.Text,
                    TxtVille.Text,
                    TxtTel.Text,
                    int.Parse(TxtAge.Text)
                );

                listPersonnes.Add(p);

                bindingSource1.DataSource = null;
                bindingSource1.DataSource = listPersonnes;

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
                Personne currentPersonne = (Personne)bindingSource1.Current;

                string details = "Détails de la personne :\n\n";
                details += "CIN : " + currentPersonne.cin + "\n";
                details += "Nom : " + currentPersonne.nom + "\n";
                details += "Prénom : " + currentPersonne.prenom + "\n";
                details += "Ville : " + currentPersonne.ville + "\n";
                details += "Téléphone : " + currentPersonne.tel + "\n";
                details += "Age : " + currentPersonne.age;

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
        /// Affiche le formulaire 2 et masque le formulaire actuel.
        /// </summary>
        private void Form2_Click(object sender, EventArgs e)
        {
            frmForm2 form2 = new frmForm2();
            form2.Show();
            this.Hide();
        }
    }
}
