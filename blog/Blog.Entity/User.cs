namespace Blog.Entity
{
    public class User : Entity
    {
        public string UserName { get; set; }

        public string Pwd { get; set; }

        public string Address { get; set; }

        public string School { get; set; }

        public string Account { get; set; }

        public int ? Sex { get; set; }

        public int ? Age { get; set; }

        public string Company { get; set; }

        public string Desc { get; set; }
    }
}
