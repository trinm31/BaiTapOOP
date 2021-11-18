using System;

namespace BT1
{
    public class PhanSo
    {
        private int _mauSo;
        public int TuSo { get; set; }
        public int MauSo { 
            get => _mauSo; 
            set => _mauSo = value != 0 ? value : 1; 
        }

        public PhanSo()
        {
            
        }

        public PhanSo(int tu, int mau)
        {
            this.TuSo = tu;
            this.MauSo = mau;
        }

        public PhanSo Cong(PhanSo another)
        {
            PhanSo result = new PhanSo();
            
            result.TuSo = TuSo * another.MauSo + MauSo * another.TuSo;
            result.MauSo = MauSo * another.MauSo;
            
            return result;
        }

        public string Display()
        {
            return $"{TuSo}/{MauSo}";
        } 
    }
}