namespace TP_Banque_IHM
{
    partial class frmBanque
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBanque = new System.Windows.Forms.ListBox();
            this.label_numero = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_solde = new System.Windows.Forms.Label();
            this.label_MontantDecouvert = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtSolde = new System.Windows.Forms.TextBox();
            this.TxtMontantDecouvert = new System.Windows.Forms.TextBox();
            this.checkBox_decouvert_auto = new System.Windows.Forms.CheckBox();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnDebiter = new System.Windows.Forms.Button();
            this.btnCrediter = new System.Windows.Forms.Button();
            this.label_crediter_debiter = new System.Windows.Forms.Label();
            this.textBox_crediter_debiter = new System.Windows.Forms.TextBox();
            this.button_supprimer_compte = new System.Windows.Forms.Button();
            this.button_modifier_compte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBanque
            // 
            this.lstBanque.FormattingEnabled = true;
            this.lstBanque.ItemHeight = 20;
            this.lstBanque.Location = new System.Drawing.Point(12, 27);
            this.lstBanque.Name = "lstBanque";
            this.lstBanque.Size = new System.Drawing.Size(832, 444);
            this.lstBanque.TabIndex = 0;
            this.lstBanque.SelectedIndexChanged += new System.EventHandler(this.lstBanque_SelectedIndexChanged);
            // 
            // label_numero
            // 
            this.label_numero.AutoSize = true;
            this.label_numero.Location = new System.Drawing.Point(880, 27);
            this.label_numero.Name = "label_numero";
            this.label_numero.Size = new System.Drawing.Size(65, 20);
            this.label_numero.TabIndex = 1;
            this.label_numero.Text = "Numéro";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(880, 83);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(119, 20);
            this.label_nom.TabIndex = 2;
            this.label_nom.Text = "Nom du titulaire";
            // 
            // label_solde
            // 
            this.label_solde.AutoSize = true;
            this.label_solde.Location = new System.Drawing.Point(880, 135);
            this.label_solde.Name = "label_solde";
            this.label_solde.Size = new System.Drawing.Size(129, 20);
            this.label_solde.TabIndex = 3;
            this.label_solde.Text = "Solde du compte";
            // 
            // label_MontantDecouvert
            // 
            this.label_MontantDecouvert.AutoSize = true;
            this.label_MontantDecouvert.Location = new System.Drawing.Point(880, 241);
            this.label_MontantDecouvert.Name = "label_MontantDecouvert";
            this.label_MontantDecouvert.Size = new System.Drawing.Size(142, 20);
            this.label_MontantDecouvert.TabIndex = 4;
            this.label_MontantDecouvert.Text = "Montant découvert";
            this.label_MontantDecouvert.Visible = false;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(1045, 24);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(100, 26);
            this.TxtNumero.TabIndex = 5;
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(1045, 80);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(100, 26);
            this.TxtNom.TabIndex = 6;
            // 
            // TxtSolde
            // 
            this.TxtSolde.Location = new System.Drawing.Point(1045, 132);
            this.TxtSolde.Name = "TxtSolde";
            this.TxtSolde.Size = new System.Drawing.Size(100, 26);
            this.TxtSolde.TabIndex = 7;
            // 
            // TxtMontantDecouvert
            // 
            this.TxtMontantDecouvert.Location = new System.Drawing.Point(1045, 238);
            this.TxtMontantDecouvert.Name = "TxtMontantDecouvert";
            this.TxtMontantDecouvert.Size = new System.Drawing.Size(100, 26);
            this.TxtMontantDecouvert.TabIndex = 8;
            this.TxtMontantDecouvert.Visible = false;
            // 
            // checkBox_decouvert_auto
            // 
            this.checkBox_decouvert_auto.AutoSize = true;
            this.checkBox_decouvert_auto.Location = new System.Drawing.Point(923, 188);
            this.checkBox_decouvert_auto.Name = "checkBox_decouvert_auto";
            this.checkBox_decouvert_auto.Size = new System.Drawing.Size(169, 24);
            this.checkBox_decouvert_auto.TabIndex = 9;
            this.checkBox_decouvert_auto.Text = "Découvert autorisé";
            this.checkBox_decouvert_auto.UseVisualStyleBackColor = true;
            this.checkBox_decouvert_auto.CheckedChanged += new System.EventHandler(this.checkBox_decouvert_auto_CheckedChanged);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(909, 303);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(72, 34);
            this.btnEffacer.TabIndex = 10;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(1071, 303);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(74, 34);
            this.btnCreer.TabIndex = 11;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnDebiter
            // 
            this.btnDebiter.Location = new System.Drawing.Point(909, 353);
            this.btnDebiter.Name = "btnDebiter";
            this.btnDebiter.Size = new System.Drawing.Size(72, 34);
            this.btnDebiter.TabIndex = 12;
            this.btnDebiter.Text = "Débiter";
            this.btnDebiter.UseVisualStyleBackColor = true;
            this.btnDebiter.Click += new System.EventHandler(this.btnDebiter_Click);
            // 
            // btnCrediter
            // 
            this.btnCrediter.Location = new System.Drawing.Point(1071, 353);
            this.btnCrediter.Name = "btnCrediter";
            this.btnCrediter.Size = new System.Drawing.Size(79, 34);
            this.btnCrediter.TabIndex = 13;
            this.btnCrediter.Text = "Créditer";
            this.btnCrediter.UseVisualStyleBackColor = true;
            this.btnCrediter.Click += new System.EventHandler(this.btnCrediter_Click);
            // 
            // label_crediter_debiter
            // 
            this.label_crediter_debiter.AutoSize = true;
            this.label_crediter_debiter.Location = new System.Drawing.Point(850, 466);
            this.label_crediter_debiter.Name = "label_crediter_debiter";
            this.label_crediter_debiter.Size = new System.Drawing.Size(199, 20);
            this.label_crediter_debiter.TabIndex = 14;
            this.label_crediter_debiter.Text = "Montant à débiter / créditer";
            // 
            // textBox_crediter_debiter
            // 
            this.textBox_crediter_debiter.Location = new System.Drawing.Point(1093, 463);
            this.textBox_crediter_debiter.Name = "textBox_crediter_debiter";
            this.textBox_crediter_debiter.Size = new System.Drawing.Size(100, 26);
            this.textBox_crediter_debiter.TabIndex = 15;
            // 
            // button_supprimer_compte
            // 
            this.button_supprimer_compte.Location = new System.Drawing.Point(909, 403);
            this.button_supprimer_compte.Name = "button_supprimer_compte";
            this.button_supprimer_compte.Size = new System.Drawing.Size(100, 34);
            this.button_supprimer_compte.TabIndex = 16;
            this.button_supprimer_compte.Text = "Supprimer";
            this.button_supprimer_compte.UseVisualStyleBackColor = true;
            this.button_supprimer_compte.Click += new System.EventHandler(this.button_supprimer_compte_Click);
            // 
            // button_modifier_compte
            // 
            this.button_modifier_compte.Location = new System.Drawing.Point(1071, 403);
            this.button_modifier_compte.Name = "button_modifier_compte";
            this.button_modifier_compte.Size = new System.Drawing.Size(100, 34);
            this.button_modifier_compte.TabIndex = 17;
            this.button_modifier_compte.Text = "Modifier";
            this.button_modifier_compte.UseVisualStyleBackColor = true;
            this.button_modifier_compte.Click += new System.EventHandler(this.button_modifier_compte_Click);
            // 
            // frmBanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 509);
            this.Controls.Add(this.button_modifier_compte);
            this.Controls.Add(this.button_supprimer_compte);
            this.Controls.Add(this.textBox_crediter_debiter);
            this.Controls.Add(this.label_crediter_debiter);
            this.Controls.Add(this.btnCrediter);
            this.Controls.Add(this.btnDebiter);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.checkBox_decouvert_auto);
            this.Controls.Add(this.TxtMontantDecouvert);
            this.Controls.Add(this.TxtSolde);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label_MontantDecouvert);
            this.Controls.Add(this.label_solde);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.label_numero);
            this.Controls.Add(this.lstBanque);
            this.Name = "frmBanque";
            this.Text = "Ma Banque";
            this.Load += new System.EventHandler(this.frmBanque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBanque;
        private System.Windows.Forms.Label label_numero;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_solde;
        private System.Windows.Forms.Label label_MontantDecouvert;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtSolde;
        private System.Windows.Forms.TextBox TxtMontantDecouvert;
        private System.Windows.Forms.CheckBox checkBox_decouvert_auto;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnDebiter;
        private System.Windows.Forms.Button btnCrediter;
        private System.Windows.Forms.Label label_crediter_debiter;
        private System.Windows.Forms.TextBox textBox_crediter_debiter;
        private System.Windows.Forms.Button button_supprimer_compte;
        private System.Windows.Forms.Button button_modifier_compte;
    }
}

