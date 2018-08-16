using System;
using System.Collections.Generic;
using System.Text;

namespace BlogCore.EFWork.Entity
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }

        public string Body { get; set; }

        public Menus Menu { get; set; }

        public User User { get; set; }
        public Tag Tag { get; set; }

    }
}
