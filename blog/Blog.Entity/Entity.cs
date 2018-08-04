using System.ComponentModel.DataAnnotations;

namespace Blog.Entity
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
