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
            
            if (member.FirstName == "Melike" && member.LastName == "Özbey" && member.BirthYear==1994 && member.IdentityNumber == "11111111111")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
