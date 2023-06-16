using BusinessObject;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        void Save(MemberObject memberObject);
        void Update(MemberObject memberObject);
        void Delete(MemberObject memberObject);
        MemberObject FindById(int memberId);
        List<MemberObject> FindAll();

    }
}
