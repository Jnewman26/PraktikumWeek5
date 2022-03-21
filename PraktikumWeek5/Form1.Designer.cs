namespace PraktikumWeek5
{
    partial class Form1
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
            this.listBoxKoleksi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.radioButtonMerah = new System.Windows.Forms.RadioButton();
            this.radioButtonBiru = new System.Windows.Forms.RadioButton();
            this.checkBoxAktif = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBoxKoleksi
            // 
            this.listBoxKoleksi.FormattingEnabled = true;
            this.listBoxKoleksi.ItemHeight = 25;
            this.listBoxKoleksi.Location = new System.Drawing.Point(28, 196);
            this.listBoxKoleksi.Name = "listBoxKoleksi";
            this.listBoxKoleksi.Size = new System.Drawing.Size(392, 379);
            this.listBoxKoleksi.TabIndex = 0;
            this.listBoxKoleksi.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Koleksi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data :";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(116, 29);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(507, 31);
            this.textBoxInput.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(655, 23);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(103, 42);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Setting :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output :";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(492, 520);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(446, 54);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(616, 343);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 85);
            this.labelOutput.TabIndex = 10;
            // 
            // radioButtonMerah
            // 
            this.radioButtonMerah.AutoSize = true;
            this.radioButtonMerah.Location = new System.Drawing.Point(602, 137);
            this.radioButtonMerah.Name = "radioButtonMerah";
            this.radioButtonMerah.Size = new System.Drawing.Size(173, 29);
            this.radioButtonMerah.TabIndex = 11;
            this.radioButtonMerah.TabStop = true;
            this.radioButtonMerah.Text = "Warna Merah";
            this.radioButtonMerah.UseVisualStyleBackColor = true;
            this.radioButtonMerah.CheckedChanged += new System.EventHandler(this.radioButtonMerah_CheckedChanged);
            // 
            // radioButtonBiru
            // 
            this.radioButtonBiru.AutoSize = true;
            this.radioButtonBiru.Location = new System.Drawing.Point(602, 196);
            this.radioButtonBiru.Name = "radioButtonBiru";
            this.radioButtonBiru.Size = new System.Drawing.Size(150, 29);
            this.radioButtonBiru.TabIndex = 12;
            this.radioButtonBiru.TabStop = true;
            this.radioButtonBiru.Text = "Warna Biru";
            this.radioButtonBiru.UseVisualStyleBackColor = true;
            this.radioButtonBiru.CheckedChanged += new System.EventHandler(this.radioButtonBiru_CheckedChanged);
            // 
            // checkBoxAktif
            // 
            this.checkBoxAktif.AutoSize = true;
            this.checkBoxAktif.Location = new System.Drawing.Point(602, 87);
            this.checkBoxAktif.Name = "checkBoxAktif";
            this.checkBoxAktif.Size = new System.Drawing.Size(86, 29);
            this.checkBoxAktif.TabIndex = 13;
            this.checkBoxAktif.Text = "Aktif";
            this.checkBoxAktif.UseVisualStyleBackColor = true;
            this.checkBoxAktif.CheckedChanged += new System.EventHandler(this.checkBoxAktif_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 593);
            this.Controls.Add(this.checkBoxAktif);
            this.Controls.Add(this.radioButtonBiru);
            this.Controls.Add(this.radioButtonMerah);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxKoleksi);
            this.Name = "Form1";
            this.Text = "Form Materi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKoleksi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.RadioButton radioButtonMerah;
        private System.Windows.Forms.RadioButton radioButtonBiru;
        private System.Windows.Forms.CheckBox checkBoxAktif;
    }
}

