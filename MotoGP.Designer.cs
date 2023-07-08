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
    partial class MotoGP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotoGP));
            this.list = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 15;
            this.list.Location = new System.Drawing.Point(12, 74);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(194, 274);
            this.list.TabIndex = 0;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged_1);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(252, 120);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(94, 42);
            this.add.TabIndex = 1;
            this.add.Text = "Add rider";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(252, 278);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(94, 42);
            this.remove.TabIndex = 2;
            this.remove.Text = "Remove rider";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(12, 12);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(94, 42);
            this.export.TabIndex = 3;
            this.export.Text = "Export to XML";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(112, 12);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(94, 42);
            this.import.TabIndex = 4;
            this.import.Text = "Import XML";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // MotoGP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(374, 377);
            this.Controls.Add(this.import);
            this.Controls.Add(this.export);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MotoGP";
            this.Text = "MotoGP";
            this.Load += new System.EventHandler(this.MotoGP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox list;
        private Button add;
        private Button remove;
        private Button export;
        private Button import;
    }
}