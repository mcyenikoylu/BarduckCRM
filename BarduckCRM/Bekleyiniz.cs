using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;

namespace BarduckCRM
{
    public partial class Bekleyiniz : WaitForm
    {
        public Bekleyiniz()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Bekleyiniz_Load(object sender, EventArgs e)
        {

        }

        public enum WaitFormCommand
        {

        }

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
