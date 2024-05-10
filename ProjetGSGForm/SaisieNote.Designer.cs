namespace ProjetGSGForm
{
    partial class SaisieNote
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.textBoxnbkm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxmttmidi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxmttnuitee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxregion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employée :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type de note";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Items.AddRange(new object[] {
            "Notes de Transport",
            "Notes de repas de midi",
            "Notes de nuitée"});
            this.comboBox2.Location = new System.Drawing.Point(168, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(285, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2024, 5, 6, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(62, 188);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(133, 16);
            this.label.TabIndex = 6;
            this.label.Text = "Nombre de kilometre";
            // 
            // textBoxnbkm
            // 
            this.textBoxnbkm.Location = new System.Drawing.Point(225, 188);
            this.textBoxnbkm.Name = "textBoxnbkm";
            this.textBoxnbkm.Size = new System.Drawing.Size(344, 22);
            this.textBoxnbkm.TabIndex = 7;
            this.textBoxnbkm.TextChanged += new System.EventHandler(this.textBoxnbkm_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Montant Repas Midi";
            // 
            // textBoxmttmidi
            // 
            this.textBoxmttmidi.Location = new System.Drawing.Point(225, 233);
            this.textBoxmttmidi.Name = "textBoxmttmidi";
            this.textBoxmttmidi.Size = new System.Drawing.Size(344, 22);
            this.textBoxmttmidi.TabIndex = 9;
            this.textBoxmttmidi.TextChanged += new System.EventHandler(this.textBoxmttmidi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Montant Nuitee";
            // 
            // textBoxmttnuitee
            // 
            this.textBoxmttnuitee.Location = new System.Drawing.Point(225, 279);
            this.textBoxmttnuitee.Name = "textBoxmttnuitee";
            this.textBoxmttnuitee.Size = new System.Drawing.Size(344, 22);
            this.textBoxmttnuitee.TabIndex = 11;
            this.textBoxmttnuitee.TextChanged += new System.EventHandler(this.textBoxmttnuitee_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Region";
            // 
            // textBoxregion
            // 
            this.textBoxregion.Location = new System.Drawing.Point(225, 331);
            this.textBoxregion.Name = "textBoxregion";
            this.textBoxregion.Size = new System.Drawing.Size(344, 22);
            this.textBoxregion.TabIndex = 13;
            this.textBoxregion.TextChanged += new System.EventHandler(this.textBoxregion_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 69);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ajouter Note de Frais";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 69);
            this.button2.TabIndex = 15;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaisieNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxregion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxmttnuitee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxmttmidi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxnbkm);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "SaisieNote";
            this.Text = "SaisieNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxnbkm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxmttmidi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxmttnuitee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxregion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}