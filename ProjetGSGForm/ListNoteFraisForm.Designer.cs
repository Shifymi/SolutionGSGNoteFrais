namespace ProjetGSGForm
{
    partial class ListNoteFraisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columndateNF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnestRembourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnmttARembourser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnnumRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnnbKm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnType,
            this.columnNumero,
            this.columndateNF,
            this.columnestRembourse,
            this.columnmttARembourser,
            this.columnnumRegion,
            this.columnnbKm});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(762, 286);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnType
            // 
            this.columnType.Text = "Type de Note de frais";
            // 
            // columnNumero
            // 
            this.columnNumero.Text = "Numéro";
            this.columnNumero.Width = 67;
            // 
            // columndateNF
            // 
            this.columndateNF.Text = "Date";
            this.columndateNF.Width = 107;
            // 
            // columnestRembourse
            // 
            this.columnestRembourse.Text = "Rembourse";
            this.columnestRembourse.Width = 113;
            // 
            // columnmttARembourser
            // 
            this.columnmttARembourser.Text = "Montant";
            this.columnmttARembourser.Width = 149;
            // 
            // columnnumRegion
            // 
            this.columnnumRegion.Text = "Numéro Region";
            this.columnnumRegion.Width = 137;
            // 
            // columnnbKm
            // 
            this.columnnbKm.Text = "Nombre de KM";
            this.columnnbKm.Width = 131;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(450, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visiteur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 81);
            this.button1.TabIndex = 3;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListNoteFraisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Name = "ListNoteFraisForm";
            this.Text = "ListNoteFrais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnNumero;
        private System.Windows.Forms.ColumnHeader columndateNF;
        private System.Windows.Forms.ColumnHeader columnestRembourse;
        private System.Windows.Forms.ColumnHeader columnmttARembourser;
        private System.Windows.Forms.ColumnHeader columnnumRegion;
        private System.Windows.Forms.ColumnHeader columnnbKm;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.Button button1;
    }
}