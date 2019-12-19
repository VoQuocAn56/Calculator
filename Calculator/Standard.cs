using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Standard
    {
        private string ThuTu;

        public Queue<string> DoiPhepToan(Queue<string> DanhSachPhepToan, string PhepToanMoi) {
            if (DanhSachPhepToan.Peek() != PhepToanMoi)
            {
                DanhSachPhepToan.Dequeue();
                DanhSachPhepToan.Enqueue(PhepToanMoi);
            }
            else {
                DanhSachPhepToan.Dequeue();
            }

            return DanhSachPhepToan;
        }

        public Stack<double> ketQuaPhepTinh(Stack<double> DanhSachSo, Queue<string> DanhSachPhepToan) {
            if (DanhSachPhepToan.Count != 1) {
                double kq = ThucHienPhepToan(DanhSachSo, DanhSachPhepToan);
                DanhSachSo.Push(kq);
            }
            return DanhSachSo;
        }

        public double ThucHienPhepToan(Stack<double> So, Queue<string> pheptoan)
        {
            if (So.Count == 2)
            {
                string pt = pheptoan.Dequeue();
                double a = So.Pop();
                double b = So.Pop();
                double KetQua;
                switch (pt)
                {
                    case "+":
                        KetQua = Cong(a, b);
                        return KetQua;

                    case "-":
                        KetQua = Tru(a, b);
                        return KetQua;

                    case "*":
                        KetQua = Nhan(a, b);          
                        return KetQua;

                    case "/":
                        KetQua = ChiaLayPhanNguyen(a, b);
                        return KetQua;

                    case "%":
                        KetQua = ChiaLayPhanDu(a, b);
                        return KetQua;
                }

            }
            return 0;
        }

        private double Cong(double SoA, double SoB)
        {
            return SoA + SoB;
        }

        private double Tru(double SoA, double SoB)
        {
            return SoB - SoA;
        }

        private double Nhan(double SoA, double SoB)
        {
            return SoA * SoB;
        }

        private double ChiaLayPhanNguyen(double SoA, double SoB)
        {
            return SoB / SoA;
        }

        private double ChiaLayPhanDu(double SoA, double SoB)
        {
            return SoB % SoA;
        }

        private double CanBacHai(double SoA) {
            double kq = SoA > 0 ? Math.Sqrt(SoA) : -1;
            return kq;
        }
     
        public string HienThiThuTuPhepTinh(Stack<double> DanhSachSo, string PhepTinh) {
            if (DanhSachSo.Count >= 1)
            {
                ThuTu = ThuTu + " " + Math.Abs(DanhSachSo.Peek()).ToString() + " " + PhepTinh;
                //SoNhap = "";
            }
            return ThuTu;
        }

        //ThuTu
        public void GanThuTu(string _ThuTu) {
            this.ThuTu = _ThuTu;
        }
    }
}
