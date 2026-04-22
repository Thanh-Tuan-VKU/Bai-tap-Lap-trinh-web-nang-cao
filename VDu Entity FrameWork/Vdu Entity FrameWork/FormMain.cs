using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSinhVienEF_New;

namespace QLSinhVienEF_New
{
    public partial class FormMain : Form
    {
        MyDbContext db = new MyDbContext();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dgv.DataSource = db.Students.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Ten = txtTen.Text;
            s.Tuoi = int.Parse(txtTuoi.Text);

            db.Students.Add(s);   
            db.SaveChanges();    

            dgv.DataSource = db.Students.ToList(); 
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTen.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTuoi.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgv.CurrentRow.Index;
            int index = dgv.CurrentRow.Index;
            var sv = db.Students.ToList()[index];

            db.Students.Remove(sv);
            db.SaveChanges();

            dgv.DataSource = db.Students.ToList();

            dgv.DataSource = null;
            dgv.DataSource = ds;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = dgv.CurrentRow.Index;

            int index = dgv.CurrentRow.Index;
            var sv = db.Students.ToList()[index];

            sv.Ten = txtTen.Text;
            sv.Tuoi = int.Parse(txtTuoi.Text);

            db.SaveChanges();

            dgv.DataSource = db.Students.ToList();

            dgv.DataSource = null;
            dgv.DataSource = ds;
        }
    }
}
