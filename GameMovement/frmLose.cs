using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMovement
{
    public partial class frmLose : Form
    {

        private IResettableForm parentForm;
        public frmLose(IResettableForm form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            // Reset game và đóng form lose
            parentForm.ResetGame();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Tạo form menu
            frmMenu existingForm = Application.OpenForms.OfType<frmMenu>().FirstOrDefault();
            if (existingForm == null)
            {
                // Nếu chưa tồn tại thì mới tạo mới
                existingForm = new frmMenu();
                existingForm.Show();
            }
            else
            {
                // Nếu đã tồn tại thì đưa Form1 lên phía trước
                existingForm.Show();
            }

            // Đóng tất cả các form chính khác
            Form[] openForms = Application.OpenForms.Cast<Form>()
                .Where(form => form != existingForm && form != this)
                .ToArray();

            foreach (Form form in openForms)
            {
                form.Close();
            }
        }
    }
}
