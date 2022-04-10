using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai2_QuanLyThueXe
{
    internal class XeTai : Xe
    {
        public override double TinhTien()
        {
            return 220000 + 85000 * (this.SoGioThue - 1);
        }
    }
}
