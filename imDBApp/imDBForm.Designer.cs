namespace imDBApp
{
    partial class imDBForm
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
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.gbInfos = new System.Windows.Forms.GroupBox();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.pb_spinner = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.RichTextBox();
            this.gbInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_spinner)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(28, 48);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(191, 26);
            this.tb_search.TabIndex = 0;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(235, 46);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(75, 30);
            this.bt_search.TabIndex = 1;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movies";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(16, 54);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(191, 26);
            this.tb_name.TabIndex = 3;
            // 
            // gbInfos
            // 
            this.gbInfos.Controls.Add(this.label3);
            this.gbInfos.Controls.Add(this.label2);
            this.gbInfos.Controls.Add(this.tb_description);
            this.gbInfos.Controls.Add(this.tb_name);
            this.gbInfos.Location = new System.Drawing.Point(12, 93);
            this.gbInfos.Name = "gbInfos";
            this.gbInfos.Size = new System.Drawing.Size(319, 319);
            this.gbInfos.TabIndex = 4;
            this.gbInfos.TabStop = false;
            this.gbInfos.Text = "Informations";
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(351, 30);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(245, 224);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 5;
            this.pb_image.TabStop = false;
            this.pb_image.Visible = false;
            // 
            // pb_spinner
            // 
            this.pb_spinner.Image = global::imDBApp.Properties.Resources.spinner1;
            this.pb_spinner.Location = new System.Drawing.Point(411, 286);
            this.pb_spinner.Name = "pb_spinner";
            this.pb_spinner.Size = new System.Drawing.Size(135, 126);
            this.pb_spinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_spinner.TabIndex = 5;
            this.pb_spinner.TabStop = false;
            this.pb_spinner.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(16, 110);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(282, 192);
            this.tb_description.TabIndex = 4;
            this.tb_description.Text = "";
            // 
            // imDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 424);
            this.Controls.Add(this.pb_spinner);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.gbInfos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tb_search);
            this.Name = "imDBForm";
            this.Text = "ImDBForm";
            this.gbInfos.ResumeLayout(false);
            this.gbInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_spinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.GroupBox gbInfos;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.PictureBox pb_spinner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tb_description;
    }
}

