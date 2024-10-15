using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AccountDAO : SingletonBase<AccountDAO>
    {
        public AccountMember GetAccountById (string accountID)
        {
            AccountMember  member = new AccountMember();
            if (accountID.Equals("admin"))
            {
                member.MemberId = accountID;
                member.MemberPassword = "admin";
                member.MemberRole = 1; 
            }
            else
            {
                return null;
            }
            return member;
        }
    }
}
