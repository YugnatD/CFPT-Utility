using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class StartConfig : Form
    {
        public StartConfig()
        {
            InitializeComponent();
        }

        public bool HorsLigne
        {
            get { return chkbHorsLigne.Checked; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        
        private void StartConfig_Load(object sender, EventArgs e)
        {
            tebName.Text= Environment.UserName;
            if(tebName.Text=="epreuve")
            {
                chkbHorsLigne.Checked = true;
                chkbHorsLigne.Enabled = false;
            }
        }
    }
}
