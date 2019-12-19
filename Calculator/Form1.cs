﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Queue<string> DanhSachPhepToan = new Queue<string>();
        Stack<double> DanhSachSo = new Stack<double>();
        Standard standard = new Standard();
        int dem = 0;

        string SoNhap = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;     
            try
            {
                //nhập số
                int a = int.Parse(button.Text.ToString());

                //Nhập số lớn hơn 1 chữ số
                SoNhap = SoNhap + a.ToString();
                //Gán số lên txbKetQua

                txbKetQua.Text = SoNhap;

                dem = 0;
            }
            catch {
                string pheptinh = button.Text.ToString();

                try {
                    int s = int.Parse(SoNhap);
                    DanhSachSo.Push(s);
                }
                catch{
                    if (dem == 0) {
                        DanhSachSo.Push(int.Parse(txbKetQua.Text.ToString()));
                    } 
                }

                dem = dem + 1;
                if (DanhSachSo.Count >= (dem + DanhSachPhepToan.Count)) {
          
                    //Thêm phép toán vào Queue
                    DanhSachPhepToan.Enqueue(pheptinh);

                    //Hiển thị thứ tự thực hiện.
                    string ThuTu = standard.HienThiThuTuPhepTinh(DanhSachSo, pheptinh);
                    SoNhap = "";

                    //Tính kết quả phép tính và đưa vào stack 
                    DanhSachSo = standard.ketQuaPhepTinh(DanhSachSo, DanhSachPhepToan);

                    //Gán txbThuTuPhepToan = thu tu để hiển thị quá trình tính ra.
                    txbThuTuPhepToan.Text = ThuTu;
                }

                //----
                txbKetQua.Text = DanhSachSo.Peek().ToString();              
            }
        }

        private void BtnBang_Click(object sender, EventArgs e)
        {
        
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            txbKetQua.Text = "0";
            txbThuTuPhepToan.Text = "";
            standard.GanThuTu("");
            DanhSachPhepToan.Clear();
            DanhSachSo.Clear();
        }
    }
}
