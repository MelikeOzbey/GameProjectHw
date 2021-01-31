using GameProject.Abstract;
using GameProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class MemberValidationManager : IMemberValidation
    {
        public bool Verify(Member member)
        {

            return false;
        }
    }
}
