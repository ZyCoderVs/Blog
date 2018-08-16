using System.Collections.Generic;

namespace BlogCore.EFWork.Entity
{
    public class Tag : BaseEntity
    {
        public string TagName { get; set; }

        public User User { get; set; }
        public virtual List<Article> Articles { get; set; }
    }
}
