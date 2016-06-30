using System;
using System.Collections.Generic;
using DDDSyd2016.IdentityServer.Models;

namespace DDDSyd2016.IdentityServer
{
    public interface IDapperRepo
    {
       
        IEnumerable<Scope> GetAllScopes();
        IEnumerable<ScopeClaim> GetAllScopeClaims();
        IEnumerable<ScopeSecret> GetAllScopeSecrets();
        User GetUserById(long id);
        User GetUserByLoginId(string loginId);
       
    }
}