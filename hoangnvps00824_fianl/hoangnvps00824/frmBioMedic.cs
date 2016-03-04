using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PhungLV_Assig9
{
    public partial class frmBioMedic : Form
    {
        SqlConnection sqlcon;
        SqlDataAdapter sqlda;
        DataSet ds;
        public frmBioMedic()
        {
            InitializeComponent();
            sqlcon = new SqlConnection("Data Source=(local);Initial Catalog=hoangnvps00824;Integrated Security=True");
            
        }

        private void frmBioMedic_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            sqlda = new SqlDataAdapter("select S.MASP, S.TENSP, S.SOLUONG, S.DONGIA, L.TENLOAI AS LOAISANPHAM from SANPHAM AS S INNER JOIN LOAISANPHAM AS L ON S.MALOAISANPHAM = L.MALOAI", sqlcon);
            sqlda.Fill(ds);
            dgvSANPHAM.DataSource = ds.Tables[0];

            ds = new DataSet();
            sqlda = new SqlDataAdapter("SELECT MALOAI, TENLOAI FROM LOAISANPHAM", sqlcon);
            sqlda.Fill(ds);
            cboLoaiSP.DataSource = ds;
            cboLoaiSP.DisplayMember = "TENLOAI";
            cboLoaiSP.ValueMember = "MALOAI";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbCommand g = new System.Data.OleDb.OleDbCommand("Insert into SANPHAM VALUES(@MASP, @TENSP, @SOLUONG, @MALOAI, @DONGIA)");
            g.CommandType = CommandType.Text;
            sqlcon.Open();
            g.Parameters.Add("@MASP", int.Parse(txtADDMASP.Text));
            g.Parameters.Add("@TENSP", txtADDMASP.Text);
            g.Parameters.Add("@SOLUONG", int.Parse(txtADDMASP.Text));
            g.Parameters.Add("@MALOAI", int.Parse(txtADDMASP.Text));
            g.Parameters.Add("@DONGIA", int.Parse(txtADDMASP.Text));
            System.Data.OleDb.OleDbDataAdapter a = new System.Data.OleDb.OleDbDataAdapter();
            a.InsertCommand = g;
            dgvSANPHAM.Refresh();
            dgvSANPHAM.RefreshEdit();
        }

        
    }
}