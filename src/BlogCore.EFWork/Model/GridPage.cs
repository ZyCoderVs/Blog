using System;
using System.Collections.Generic;
using System.Text;

namespace BlogCore.EFWork.Model
{
    public class GridPage
    {
        public int Page { get; set; } = 1;
        public int Rows { get; set; } = 10;

        public int Total
        {
            get
            {
                return Convert.ToInt32(Math.Ceiling((double)Records / Rows));
            }
        }

        public int Records { get; set; }

        public string Sidx { get; set; }

        public string Orde { get; set; }
    }
}
