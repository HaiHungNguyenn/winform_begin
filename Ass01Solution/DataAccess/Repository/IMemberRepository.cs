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
        void Save(MemberObject member);
        void update(MemberObject member);
        void delete(MemberObject member);
        MemberObject findById(int memberId);
        List<MemberObject> findAll();
    }
}
