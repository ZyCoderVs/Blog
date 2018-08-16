using System;

namespace BlogCore.EFWork.Entity
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime? CreateTime { get; set; }
        public BaseEntity()
        {
            this.CreateTime = DateTime.Now;
        }
    }
}
