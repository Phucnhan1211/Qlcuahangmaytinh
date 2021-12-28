using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QLcuahangbanmaytinh
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }
        ConnectCSDL co = new ConnectCSDL();
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-R8G1IGO\SQLEXPRESS01;Initial Catalog=QLCuaHangMayTinh;Integrated Security=True");
            try
            {
                con.Open();
                string tk = txttendangnhap.Text;
                string mk = txtmatkhau.Text;
                string sql = "select * from DangNhap where TenDangNhap = '" + tk + "' and MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    this.Hide();
                    frmMenu frm = new frmMenu();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("không đúng tên người dùng / mật khẩu!!!", "Thông báo");
                    this.txttendangnhap.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
   