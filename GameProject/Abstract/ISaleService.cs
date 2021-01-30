using GameProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void Buy(Sale sale, Member member);
      
    }
}
