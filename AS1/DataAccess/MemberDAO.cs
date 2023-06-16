using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        private IMemberRepository memberRepository;
        public MemberDAO(IMemberRepository memberRepository) { 
            this.memberRepository = memberRepository;
        }
        public void saveMember(MemberObject memberObject) { 
            memberRepository.Save(memberObject);
        }
        public void UpdateMember(MemberObject memberObject) {
            memberRepository.Update(memberObject);
        }
        public void DeleteMember(MemberObject memberObject)
        {
            memberRepository.Delete(memberObject);
        }
        public MemberObject FindMemberByID(int memberID) { 
            return memberRepository.FindById(memberID);
        }
        public List<MemberObject> FindAllMembers()
        {
            return memberRepository.FindAll();
        }
    }
}
