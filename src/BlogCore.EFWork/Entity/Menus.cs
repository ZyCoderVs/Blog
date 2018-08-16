using System.Collections.Generic;

namespace BlogCore.EFWork.Entity
{
    public class Menus:BaseEntity
    {
        public string MenuName { get; set; }

        public string MenuDesc { get; set; }

        public int ? IsDelete { get; set; }

        public virtual List<Article> Articles { get; set; }
    }
}
