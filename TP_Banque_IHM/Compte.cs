  class Compte
    {
        // ATTRIBUTS
        private int _numero;
        private string _nom;
        protected double _solde;
        private bool _decouvertAutorise;
        private double _montantDecouvert;
        private static int _derniernumero = 0;
         
        // ACCESSEURS ET MUTATEURS
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public double Solde
        {
            get { return _solde; }
            set { _solde = value; }
        }
        public bool DecouvertAutorise
        {
            get { return _decouvertAutorise; }
            set { _decouvertAutorise = value; }
        }

        public double MontantDecouvert
        {
            get { return _montantDecouvert; }
            set { _montantDecouvert = value; }
        }

        // CONSTRUCTEURS
        public Compte()
        {

        }
        // constructeur compte avec autorisation de découvert
        public Compte(int p_numero, string p_nom,  double p_montantDecouvert)
        {
            _derniernumero++;
            _numero = p_numero;
            _nom = p_nom.ToUpper();
            _solde = 0;
            _montantDecouvert = p_montantDecouvert;
            _decouvertAutorise = true;
        }

        // constructeur compte sans autorisation de découvert
        public Compte(int p_numero, string p_nom)
        {
            _derniernumero++;
            _numero = p_numero;
            _nom = p_nom.ToUpper();
            _solde = 0;
            _montantDecouvert = 0;
            _decouvertAutorise = false;
        }
       

        // METHODES
        public virtual void Crediter(double p_montant)
        {
            _solde += p_montant;
        }
        public bool Debiter(double p_montant)
        {
            if (_decouvertAutorise)
            {
                if ((_solde - p_montant)>= (_montantDecouvert))
                {
                    _solde -= p_montant ;
                    return true;
                }
                else
                    return false;

            }
            if ((_solde - p_montant) >= 0)
            {
                _solde -= p_montant;
                return true;
            }
            else
                return false;

        }
        public bool Transferer(float p_montant, Compte p_compte)
        {
            if (this.Debiter(p_montant))
        {
            this.Debiter(p_montant);
            p_compte.Crediter(p_montant);
            return true;
        }
        
            return false;
        }
        public bool Superieur(Compte p_compte)
        {
            return false;
        }
       
        public override string ToString()
        {
            if (_decouvertAutorise)
            return "numéro : " + _numero + " ; intitule  : "+ _nom +"  ; solde de : " + _solde + "" +
                " découvert autorisé pour un montant de : " + _montantDecouvert;
            else
                return "numéro : " + _numero + " ; intitule  : " + _nom + "  ; solde de : " + _solde + "" +
                " découvert non autorisé ";
        }
        
    }