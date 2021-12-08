using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dethi1920.Models
{
    public class CongNhanModel
    {
        private string maCongNhan;
        private string tenCongNhan;
        private int gioiTinh;
        private int namSinh;
        private string nuocVe;
        private string maDiemCachLy;
        public string MaCongNhan
        {
            get { return maCongNhan;}
            set { maCongNhan = value; }
        }
        public string TenCongNhan
        {
            get { return tenCongNhan; }
            set { tenCongNhan = value; }
        }
       public int GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }
        public string NuocVe
        {
            get { return nuocVe; }
            set { nuocVe = value; }
        }
        public string MaDiemCachLy
        {
            get { return maDiemCachLy; }
            set { maDiemCachLy = value; }
        }
    }
}
