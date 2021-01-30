using GameProject.Abstract;
using GameProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class MemberManager : IMemberService
    {
        public void Add(Member member)
        {
            Console.WriteLine("Üye Kaydedildi.");
        }

        public void Delete(int Id)
        {
            Console.WriteLine("Üye silindi.");
        }

        public void Update(int Id)
        {
            Console.WriteLine("Üye güncellendi.");
        }
    }
}
