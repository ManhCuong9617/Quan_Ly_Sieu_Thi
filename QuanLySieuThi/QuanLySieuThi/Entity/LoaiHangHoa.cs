using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.Entity
{
    public class LoaiHangHoa
    {
        private string _MaLHH;
        private string _TenLHH;
        private string _GhiChu;
        private string _MaGH;

        public string MaLHH
        {
            get
            {
                return _MaLHH;
            }

            set
            {
                _MaLHH = value;
            }
        }

        public string TenLHH
        {
            get
            {
                return _TenLHH;
            }

            set
            {
                _TenLHH = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return _GhiChu;
            }

            set
            {
                _GhiChu = value;
            }
        }

        public string MaGH
        {
            get
            {
                return _MaGH;
            }

            set
            {
                _MaGH = value;
            }
        }
    }
}
