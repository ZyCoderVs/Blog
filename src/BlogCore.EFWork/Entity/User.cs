using System.Collections.Generic;

namespace BlogCore.EFWork.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string Account { get; set; }

        public string Pwd { get; set; }

        public int ? Age { get; set; }

        public int ? Sex { get; set; }

        public string School { get; set; }

        public string Address { get; set; }

        public string Company { get; set; }

        public string Skill { get; set; }

        public virtual List<Article> Articles { get; set; }

        public virtual List<Tag> Tags { get; set; }
    }
}
