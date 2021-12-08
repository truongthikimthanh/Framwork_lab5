using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dethi1920.Models
{
    public class CNTCModel
    {
        private string maCongNhan;
        private string maTrieuChung;
        public string MaCongNhan
        {
            get { return maCongNhan; }
            set { maCongNhan = value; }
        }
        public string MaTrieuChung
        {
            get { return maTrieuChung; }
            set { maTrieuChung = value; }
        }
    }
}
