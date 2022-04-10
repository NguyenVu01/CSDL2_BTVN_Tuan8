using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai2_QuanLyThueXe
{
    internal class XeKhach : Xe
    {
        public override double TinhTien()
        {
            return 250000 + 70000 * (this.SoGioThue - 1);
        }
    }
}
