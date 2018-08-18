using BlogCore.EFWork.Entity;
using BlogCore.EFWork.Infrastructure;
using BlogCore.EFWork.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Blog.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            System.Console.WriteLine("123");
            using (BlogContext db=new BlogContext ())
            {
                var user = new User
                {
                    Name="张教主",
                    Account="1056805316@qq.com",
                    Pwd=Md5Helper.Md5("950729")
                };

                db.Add(user);
                db.SaveChanges();
               //   var user = db.Users.Include("Articles").FirstOrDefault();
                System.Console.ReadKey();
            }
        }
    }
}
