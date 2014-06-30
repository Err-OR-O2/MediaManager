using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;

namespace MediaManager
{
    public partial class frmStart : MetroForm
    {

        private Int32 IntTime = 0;

        public frmStart()
        {
            InitializeComponent();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (circularProgress.Value == 100)
            {
                IntTime++;
                circularProgress.Value = 0;
            }

            circularProgress.Value++;

            if (IntTime == 1)
            {
                this.Close();
            }
        }
    }
}
