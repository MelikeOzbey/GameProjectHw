using GameProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IMemberService
    {
        void Add(Member member);
        void Update(int Id);
        void Delete(int Id);

    }
}
