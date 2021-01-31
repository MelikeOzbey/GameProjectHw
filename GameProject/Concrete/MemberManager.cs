using GameProject.Abstract;
using GameProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class MemberManager : BaseMemberManager
    {
        IMemberValidation _memberValidation;

        public MemberManager(IMemberValidation memberValidation)
        {
            _memberValidation = memberValidation;
        }

        public override void Add(Member member)
        {
            if (_memberValidation.Verify(member))
            {
                base.Add(member);
            }
            else
            {
                Console.WriteLine("Lütfen girmiş olduğunuz Ad, Soyad, Doğum Yılı ve TC No bilgilerinin doğruluğunu kontrol ediniz..");
            }
        }

    }
}

