using System.Collections.Generic;

class Banque
    { // ATTRIBUTS
        private List<Compte> _lesComptes;

        // CONSTRUCTEURS
        public Banque()
        {
            _lesComptes = new List<Compte>();
        }
       public List<Compte> LesComptes
        {
            get { return _lesComptes; }
            set { _lesComptes = value; }
        }

    // METHODES
    public void Init()
        {
            Compte c1 = new Compte(12341, "Tuktirey", -500);
            Compte c2 = new Compte(45652, "Tsireya ", -1000);
            Compte c3 = new Compte(32343, "Sam Worthington",  -1500);
            Compte c4 = new Compte(12341, "Zoe Saldana", -500);
            Compte c5 = new Compte(45652, "Tsireya ", -1000);
            Compte c6 = new Compte(32343, "Sam Worthington", -1500);
            Compte c7 = new Compte(32343, "Jake Sully", -1500);
        
            this.AjouterCompte(c1);
            this.AjouterCompte(c2);
            this.AjouterCompte(c3);
            this.AjouterCompte(c4);
            this.AjouterCompte(c5);
            this.AjouterCompte(c6);
            this.AjouterCompte(c7);
    }

        public void AjouterCompte(Compte unCompte)
        {
            _lesComptes.Add(unCompte);
        }

        public void AjouterCompte(int n, string nom, float solde, float dec)
        {
               AjouterCompte(new Compte(n, nom, dec));
        }

        public int GetNbComptes()
        {
            return _lesComptes.Count;
        }

        public void AfficherComptes()
        {
            foreach(Compte unCompte in _lesComptes)
            {
                unCompte.ToString();
            }
        }

        public Compte CompteSup()
        {
            Compte c = new Compte();
            foreach (Compte unCompte in _lesComptes)
            {
                if (unCompte.Superieur(c))
                {
                    c = unCompte;
                }
            }
            return c;
        }

        public List<Compte> GetLesComptes()
        {
            return _lesComptes;
        }

        public Compte GetCompte(int i)
        {
            return _lesComptes[i];
        }

        public Compte RendreCompte(int num)
        {
            foreach (Compte Uncompte in _lesComptes)
                if (Uncompte.Numero == num)
                {
                    return Uncompte;
                }
            return null;
        }

        public float GetTotalSoldes()
        {
            float total = 0.0f;

            foreach (Compte c in _lesComptes)
            {
                total += float.Parse(c.Solde.ToString());
            }

            return total;
        }

        public void SupprimerCompte(int i)
        {
            _lesComptes.Remove(GetCompte(i));
        }

        public bool Transferer(int num1, int num2, float montant)
        {
            bool ok = false;

            Compte c1 = RendreCompte(num1);
            Compte c2 = RendreCompte(num2);

            if (c1 != null && c2 != null)
            {
                ok = c1.Transferer(montant, c2);
            }

            return ok;
        }

        public bool FermerCompte(int num)
        {
            Compte leCompte = RendreCompte(num);
            if (leCompte != null)
            {
                _lesComptes.Remove(leCompte);
                return true;
            }

            return false;
        }

        public List<Compte> GetComptesRemuneres()
        {
            List<Compte> lesComptesRemuneres = new List<Compte>();
            foreach (Compte leCompte in _lesComptes)
            {
                if (leCompte.GetType().ToString() == "COMPTEREMUNERE")
                {
                    lesComptesRemuneres.Add(leCompte);
                }
            }
            return lesComptesRemuneres;
        }

        public double GetSoldesLivretA()
        {
            double somme = 0;
            foreach (Compte leCompte in _lesComptes)
            {
                if (leCompte.GetType().ToString() == "COMPTEREMUNERE")
                {
                    somme += leCompte.Solde;
                }
            }
            return somme;
        }

        public double GetSoldesCompte()
        {
            double somme = 0;
            foreach (Compte leCompte in _lesComptes)
            {
                if (leCompte.GetType().ToString() == "COMPTE")
                {
                    somme += leCompte.Solde;
                }
            }
            return somme;
        }

        public override string ToString()
        {
            string affichage = "";
            foreach (Compte UnCompte in _lesComptes)
            {
                affichage += UnCompte.ToString() + "\n\t";
            }
            return "banque\ncomptes :" + affichage;
        }
    }