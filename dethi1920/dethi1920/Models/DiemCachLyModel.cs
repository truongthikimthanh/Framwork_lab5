using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dethi1920.Models
{
    public class DiemCachLyModel
    {
        private string maDiemCachLy;
        private string tenDiemCachLy;
        private string diaChi;
        public string MaDiemCachLy 
        { 
            get { return maDiemCachLy; }
            set { maDiemCachLy = value; }
            }
        public string TenDiemCachLy
        {
            get { return tenDiemCachLy; }
            set { tenDiemCachLy = value; }

        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
    }
}
