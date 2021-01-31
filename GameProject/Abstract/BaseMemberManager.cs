using GameProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseMemberManager : IMemberService
    {
        public virtual void Add(Member member)
        {
            Console.WriteLine(member.FirstName+" "+member.LastName+" İsimli Üye Kaydedildi");
        }

        public void Delete(int Id)
        {
            Console.WriteLine("Üye Silindi");
        }

        public void Update(int Id)
        {
            Console.WriteLine("Üye Güncellendi");
        }
    }
}
