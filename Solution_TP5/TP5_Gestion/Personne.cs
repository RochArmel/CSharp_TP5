using System;

namespace TP5_Gestion
{
    /// <summary>
    /// Représente une personne avec ses informations personnelles.
    /// </summary>
    public class Personne
    {
        /// <summary>
        /// Obtient ou définit le numéro de la carte d'identité nationale.
        /// </summary>
        public string cin { get; set; }
        /// <summary>
        /// Obtient ou définit le nom de la personne.
        /// </summary>
        public string nom { get; set; }
        /// <summary>
        /// Obtient ou définit le prénom de la personne.
        /// </summary>
        public string prenom { get; set; }
        /// <summary>
        /// Obtient ou définit la ville de résidence.
        /// </summary>
        public string ville { get; set; }
        /// <summary>
        /// Obtient ou définit le numéro de téléphone.
        /// </summary>
        public string tel { get; set; }
        /// <summary>
        /// Obtient ou définit l'âge de la personne.
        /// </summary>
        public int age { get; set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Personne.
        /// </summary>
        public Personne() { }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Personne avec les informations spécifiées.
        /// </summary>
        /// <param name="c">Le numéro de CIN.</param>
        /// <param name="n">Le nom.</param>
        /// <param name="p">Le prénom.</param>
        /// <param name="v">La ville.</param>
        /// <param name="t">Le numéro de téléphone.</param>
        /// <param name="a">L'âge.</param>
        public Personne(string c, string n, string p, string v, string t, int a)
        {
            this.cin = c;
            this.nom = n;
            this.prenom = p;
            this.ville = v;
            this.tel = t;
            this.age = a;
        }
    }
}
