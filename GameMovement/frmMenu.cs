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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        void Setup()
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem Form1 đã tồn tại chưa
            Form1 existingForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            if (existingForm == null)
            {
                // Nếu chưa tồn tại thì mới tạo mới
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                // Nếu đã tồn tại thì đưa Form1 lên phía trước
                existingForm.Activate();
            }

            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Xác Nhận Thoát?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (rs == DialogResult.OK)
            {
                this.Close();
            } 
                
        }
    }
}
