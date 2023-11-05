namespace DataEntryProject
{
    partial class FmrDataEntry
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
            this.components = new System.ComponentModel.Container();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.l5 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.tim = new System.Windows.Forms.Timer(this.components);
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.b2);
            this.gb1.Controls.Add(this.b1);
            this.gb1.Controls.Add(this.tb5);
            this.gb1.Controls.Add(this.tb4);
            this.gb1.Controls.Add(this.tb3);
            this.gb1.Controls.Add(this.tb2);
            this.gb1.Controls.Add(this.tb1);
            this.gb1.Controls.Add(this.l5);
            this.gb1.Controls.Add(this.l4);
            this.gb1.Controls.Add(this.l3);
            this.gb1.Controls.Add(this.l2);
            this.gb1.Controls.Add(this.l1);
            this.gb1.Location = new System.Drawing.Point(36, 50);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(302, 335);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Data Entry";
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(161, 281);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(111, 32);
            this.b2.TabIndex = 11;
            this.b2.Text = "&Clear";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            this.b2.MouseLeave += new System.EventHandler(this.btnAccept_Leave);
            this.b2.MouseHover += new System.EventHandler(this.btnAccept_Hover);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(16, 281);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(111, 32);
            this.b1.TabIndex = 10;
            this.b1.Text = "&Accept";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            this.b1.MouseLeave += new System.EventHandler(this.btnAccept_Leave);
            this.b1.MouseHover += new System.EventHandler(this.btnAccept_Hover);
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(90, 217);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(173, 22);
            this.tb5.TabIndex = 9;
            this.tb5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(90, 173);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(173, 22);
            this.tb4.TabIndex = 8;
            this.tb4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(90, 123);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(173, 22);
            this.tb3.TabIndex = 7;
            this.tb3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(90, 79);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(173, 22);
            this.tb2.TabIndex = 6;
            this.tb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(90, 37);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(173, 22);
            this.tb1.TabIndex = 5;
            this.tb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(13, 220);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(32, 16);
            this.l5.TabIndex = 4;
            this.l5.Text = "Zip :";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(13, 173);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(44, 16);
            this.l4.TabIndex = 3;
            this.l4.Text = "State :";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(13, 126);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(35, 16);
            this.l3.TabIndex = 2;
            this.l3.Text = "City :";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(13, 79);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(64, 16);
            this.l2.TabIndex = 1;
            this.l2.Text = "Address :";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(13, 37);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(50, 16);
            this.l1.TabIndex = 0;
            this.l1.Text = "Name :";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.b5);
            this.gb2.Controls.Add(this.b4);
            this.gb2.Controls.Add(this.b3);
            this.gb2.Controls.Add(this.tb6);
            this.gb2.Location = new System.Drawing.Point(354, 50);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(308, 335);
            this.gb2.TabIndex = 1;
            this.gb2.TabStop = false;
            this.gb2.Text = "Timer";
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(98, 281);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(111, 32);
            this.b5.TabIndex = 15;
            this.b5.Text = "&Exit";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(98, 166);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(111, 29);
            this.b4.TabIndex = 14;
            this.b4.Text = "&Pause";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(98, 123);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(111, 37);
            this.b3.TabIndex = 13;
            this.b3.Text = "&Start";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // tb6
            // 
            this.tb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb6.Location = new System.Drawing.Point(68, 37);
            this.tb6.Name = "tb6";
            this.tb6.ReadOnly = true;
            this.tb6.Size = new System.Drawing.Size(173, 34);
            this.tb6.TabIndex = 12;
            this.tb6.Text = "00:00:00";
            this.tb6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tim
            // 
            this.tim.Interval = 1000;
            this.tim.Tick += new System.EventHandler(this.tim_Tick);
            // 
            // FmrDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Name = "FmrDataEntry";
            this.Text = "Data Entry Form";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.Timer tim;
    }
}

