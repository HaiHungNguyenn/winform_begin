using BusinessObject;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private List<MemberObject> memberList;

        public MemberRepository()
        {
            memberList = new List<MemberObject>();
        }

        public void Delete(MemberObject memberObject)
        {
            memberList.Remove(memberObject);
        }

        public List<MemberObject> FindAll()
        {
            return new List<MemberObject>(memberList);
        }

        public MemberObject FindById(int memberId)
        {
            return memberList.Find(x => x.MemberID == memberId);
        }

        public void Save(MemberObject memberObject)
        {
            memberList.Add(memberObject);
        }

        public void Update(MemberObject memberObject)
        {
            MemberObject existingMember = memberList.Find(m => m.MemberID == memberObject.MemberID);
            if (existingMember != null)
            {
                existingMember.MemberName = memberObject.MemberName;
                existingMember.Email = memberObject.Email;
                existingMember.Password = memberObject.Password;
                existingMember.City = memberObject.City;
                existingMember.Country = memberObject.Country;

                Console.WriteLine("Member updated: " + existingMember.ToString());
            }
            else
            {
                Console.WriteLine("Member not found!");
            }
        }
    }
}
