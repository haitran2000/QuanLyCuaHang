using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanQuyen_DTO
    {
        private int maQuyen;

        public int MaQuyen
        {
            get { return maQuyen; }
            set { maQuyen = value; }
        }
        public PhanQuyen_DTO()
        {
        }
        public PhanQuyen_DTO(int _maQuyen)
        {
            this.maQuyen = _maQuyen;
        }
    }
}
