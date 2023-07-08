/***************************************************/
/***************************************************/
/***************************************************/
/***************************************************/
/*********  BOSON-HIGGS | neutron.surge.sh  ********/
/***************************************************/
/***************************************************/
/***************************************************/
/***************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoGP
{
    public partial class AddRider : Form
    {
        public Records records;

        public AddRider(Records records)
        {
            InitializeComponent();
            this.records = records;
        }

        private void save_new_Click(object sender, EventArgs e)
        {
            try 
            {
                records.Add(textBox_fname.Text, textBox_sname.Text, Convert.ToInt16(numericUpDown.Value), textBox_team.Text, Convert.ToBoolean(checkBox_factory.CheckState));
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }
    }
}
