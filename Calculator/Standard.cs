/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Standard
    {
        private string ThuTu;
        private List<string> DanhSachThuTu;

        public Standard() {
            this.DanhSachThuTu = new List<string>();
        }

        public Queue<string> DoiPhepToan(Queue<string> DanhSachPhepToan, string PhepToanMoi) {

            if (DanhSachPhepToan.Count > 0) {

                if (DanhSachPhepToan.Peek() != PhepToanMoi)
                {
                    DanhSachPhepToan.Dequeue();
                    DanhSachPhepToan.Enqueue(PhepToanMoi);
                }
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
     
        public List<string> HienThiThuTuPhepTinh(Queue<string> DanhSachPhepToan, Stack<double> DanhSachSo, string PhepTinh) {

            Queue<string> DanhSachPhepToanMon = DoiPhepToan(DanhSachPhepToan, PhepTinh);

            if (DanhSachSo.Count >= 1)
            {
                int i = DanhSachThuTu.Count - 1;
                this.DanhSachThuTu.Add(Math.Abs(DanhSachSo.Peek()).ToString());
                this.DanhSachThuTu.Add(PhepTinh);
                
            }
            return DanhSachThuTu;
        }

        //ThuTu
        public void GanThuTu(string _ThuTu) {
            this.ThuTu = _ThuTu;
        }
    }
}
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Standard
    {
        private Stack<string> DanhSachThuTu;

        public Standard() {
            DanhSachThuTu = new Stack<string>();
        }

        public Queue<string> DoiPhepToanTrongHamDoi(Queue<string> DanhSachPhepToan, string PhepToanMoi)
        {
            if (DanhSachPhepToan.Peek() != PhepToanMoi)
            {
                DanhSachPhepToan.Dequeue();
                DanhSachPhepToan.Enqueue(PhepToanMoi);
            }
            return DanhSachPhepToan;
        }

        public Stack<double> ketQuaPhepTinh(Stack<double> DanhSachSo, Queue<string> DanhSachPhepToan)
        {
            if (DanhSachPhepToan.Count != 1)
            {
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

        private double CanBacHai(double SoA)
        {
            double kq = SoA > 0 ? Math.Sqrt(SoA) : -1;
            return kq;
        }

        public Stack<string> ThemThuTuPhepTinh(Stack<double> DanhSachSo, string PhepTinh)
        {
            if (DanhSachSo.Count >= 1)
            {
                DanhSachThuTu.Push(Math.Abs(DanhSachSo.Peek()).ToString());
                DanhSachThuTu.Push(PhepTinh);
            }
            return DanhSachThuTu;
        }

        public Stack<string> DoiPhepToanTrongDanhSachThuTu(string PhepTinhMoi)
        {
            if (DanhSachThuTu.Peek() != PhepTinhMoi)
            {
                DanhSachThuTu.Pop();
                DanhSachThuTu.Push(PhepTinhMoi);
            }

            return DanhSachThuTu;
        }

        public string HienThiThuTuPhepTinh(){
            List<string> DanhSach = DanhSachThuTu.ToList();
            DanhSach.Reverse();

            string thutu = "";
            foreach (var item in DanhSach)
            {
                thutu = thutu + " " + item;
            }
            return thutu;
        }

    }
}