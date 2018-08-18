namespace BlogCore.EFWork.Entity
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }

        public string Body { get; set; }

        public Menus Menu { get; set; }
        public int ? MenuId { get; set; }

        public User User { get; set; }
        public int ? UserId { get; set; }

        public Tag Tag { get; set; }
        public int ? TagId { get; set; }

    }
}
