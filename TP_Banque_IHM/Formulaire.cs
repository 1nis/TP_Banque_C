using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Banque_IHM
{
    public partial class frmBanque : Form
    {
        // déclarez un attribut de type Banque
        private Banque maBanque;
        Compte deuxcompte;
        public frmBanque()
        {
            InitializeComponent();
        }

        private void frmBanque_Load(object sender, EventArgs e)
        {
            // instanciez l’attribut maBanque
            maBanque = new Banque();
            // appeler la méthode Init() que
            maBanque.Init();
            // On affiche le premier compte de la banque dans une fenêtre
            // MessageBox.Show(maBanque.GetCompte(0).ToString());

            // parcours de la collection des comptes de la banque
            // TODO : à compléter
            foreach (Compte unCompte in maBanque.LesComptes)
            {
                // on ajoute le compte aux éléments (Items) de la liste listBanque
                lstBanque.Items.Add(unCompte.ToString());
            }

        }

        private void lstBanque_SelectedIndexChanged(object sender, EventArgs e)
        {
            // indice sélectionné
            int indice = lstBanque.SelectedIndex;

            TxtNumero.Text = maBanque.GetCompte(indice).Numero.ToString();
            TxtNom.Text = maBanque.GetCompte(indice).Nom.ToString();
            TxtSolde.Text = maBanque.GetCompte(indice).Solde.ToString();
            TxtMontantDecouvert.Text = maBanque.GetCompte(indice).MontantDecouvert.ToString();

            if (maBanque.GetCompte(indice).DecouvertAutorise is true)
            {
                checkBox_decouvert_auto.Checked = true;
            }

            else
            {
                checkBox_decouvert_auto.Checked = false;
            }

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            // TODO ; tous les champs de texte doivent être réinitialisés (vides)
            TxtNumero.Clear();
            TxtNom.Clear();
            TxtSolde.Clear();
            TxtMontantDecouvert.Clear();
            checkBox_decouvert_auto.Checked = false;
            // et la case « compte rémunéré » doit être décochée.
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            int indice = lstBanque.SelectedIndex;
            // Récupère ce qui est saisit dans le champ « numéro » et le convertit en int
            // TODO : continuer avec les autres champs de texte
            int numero = Convert.ToInt32(TxtNumero.Text);
            string nom = TxtNom.Text;
            float montant = Convert.ToInt32(TxtMontantDecouvert.Text);
            deuxcompte = new Compte(numero, nom);
            /*
             deuxcompte = new Compte(numero, nom, montant);
             bool areEqual = System.Object.ReferenceEquals(maBanque.GetCompte(indice).Nom.ToString(), numero);
            foreach (Compte unCompte in maBanque.LesComptes)
            {
                if (areEqual)
                {
                    MessageBox.Show("Probleme");
                }
                else
                {
                    maBanque.AjouterCompte(numero, nom, solde, montant);
                    break;
                }

            }
            lstBanque.Items.Clear();
            foreach (Compte unCompte in maBanque.LesComptes)
            {
                lstBanque.Items.Add(unCompte.ToString());
            }
            */
            if (checkBox_decouvert_auto.Checked)
            {
                maBanque.AjouterCompte(numero, nom, 0, montant);
            }
            else
            {
                maBanque.AjouterCompte(deuxcompte);
            }
            lstBanque.Items.Clear();
            foreach (Compte unCompte in maBanque.LesComptes)
            {
                lstBanque.Items.Add(unCompte.ToString());
            }
        }

        private void btnCrediter_Click(object sender, EventArgs e)
        {
            // indice sélectionné
            int indice = lstBanque.SelectedIndex;

            Compte compteselec = maBanque.GetCompte(indice);

             compteselec.Crediter(Convert.ToDouble(textBox_crediter_debiter.Text));

            lstBanque.Items.Clear();

            foreach (Compte unCompte in maBanque.LesComptes)
            {
                lstBanque.Items.Add(unCompte.ToString());
            }
            lstBanque.SelectedIndex = indice;
        }

        private void btnDebiter_Click(object sender, EventArgs e)
        {
            // indice sélectionné
            int indice = lstBanque.SelectedIndex;

            Compte compteselec = maBanque.GetCompte(indice);

            if (compteselec.Debiter(Convert.ToDouble(textBox_crediter_debiter.Text)))
            {
                lstBanque.Items.Clear();

                foreach (Compte unCompte in maBanque.LesComptes)
                {
                    lstBanque.Items.Add(unCompte.ToString());
                }
            }
            else
            {
                MessageBox.Show("Transaction impossible !");
            }

            lstBanque.SelectedIndex = indice;
        }

        private void button_supprimer_compte_Click(object sender, EventArgs e)
        {
            // indice sélectionné
            int indice = lstBanque.SelectedIndex;
            maBanque.SupprimerCompte(indice);

            lstBanque.Items.Clear();

            foreach (Compte unCompte in maBanque.LesComptes)
            {
                lstBanque.Items.Add(unCompte.ToString());
            }

        }

        private void button_modifier_compte_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_decouvert_auto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_decouvert_auto.Checked == true)
            {
                label_MontantDecouvert.Visible = true;
                TxtMontantDecouvert.Visible = true;
            }
            else
            {
                label_MontantDecouvert.Visible = false;
                TxtMontantDecouvert.Visible = false;
            }
        }
    }
}
