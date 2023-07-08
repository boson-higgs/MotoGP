/***************************************************/
/***************************************************/
/***************************************************/
/***************************************************/
/*********  BOSON-HIGGS | neutron.surge.sh  ********/
/***************************************************/
/***************************************************/
/***************************************************/
/***************************************************/

namespace MotoGP
{
    partial class AddRider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRider));
            this.save_new = new System.Windows.Forms.Button();
            this.checkBox_factory = new System.Windows.Forms.CheckBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBox_team = new System.Windows.Forms.TextBox();
            this.textBox_sname = new System.Windows.Forms.TextBox();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // save_new
            // 
            this.save_new.BackColor = System.Drawing.Color.Black;
            this.save_new.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save_new.ForeColor = System.Drawing.Color.Lime;
            this.save_new.Location = new System.Drawing.Point(106, 252);
            this.save_new.Name = "save_new";
            this.save_new.Size = new System.Drawing.Size(93, 37);
            this.save_new.TabIndex = 10;
            this.save_new.Text = "Save";
            this.save_new.UseVisualStyleBackColor = false;
            this.save_new.Click += new System.EventHandler(this.save_new_Click);
            // 
            // checkBox_factory
            // 
            this.checkBox_factory.AutoSize = true;
            this.checkBox_factory.Location = new System.Drawing.Point(226, 190);
            this.checkBox_factory.Name = "checkBox_factory";
            this.checkBox_factory.Size = new System.Drawing.Size(95, 19);
            this.checkBox_factory.TabIndex = 28;
            this.checkBox_factory.Text = "Factory team";
            this.checkBox_factory.UseVisualStyleBackColor = true;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(109, 148);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(100, 23);
            this.numericUpDown.TabIndex = 27;
            // 
            // textBox_team
            // 
            this.textBox_team.Location = new System.Drawing.Point(109, 186);
            this.textBox_team.Name = "textBox_team";
            this.textBox_team.Size = new System.Drawing.Size(100, 23);
            this.textBox_team.TabIndex = 26;
            // 
            // textBox_sname
            // 
            this.textBox_sname.Location = new System.Drawing.Point(109, 85);
            this.textBox_sname.Name = "textBox_sname";
            this.textBox_sname.Size = new System.Drawing.Size(100, 23);
            this.textBox_sname.TabIndex = 25;
            // 
            // textBox_fname
            // 
            this.textBox_fname.Location = new System.Drawing.Point(109, 40);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(100, 23);
            this.textBox_fname.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Racing Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Racing number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "First name";
            // 
            // AddRider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 308);
            this.Controls.Add(this.checkBox_factory);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.textBox_team);
            this.Controls.Add(this.textBox_sname);
            this.Controls.Add(this.textBox_fname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_new);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRider";
            this.Text = "Add Rider";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button save_new;
        private CheckBox checkBox_factory;
        private NumericUpDown numericUpDown;
        private TextBox textBox_team;
        private TextBox textBox_sname;
        private TextBox textBox_fname;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}