using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Alumini_Assignment.Models
{
    public class Proposal
    {

        public int proposalID { get; set; }
        public string memberID { get; set; }        
        public string title { get; set; }
        public string overview { get; set; }
        public DateTime deadline { get; set; }

    }

    public class ProposalDBContext : DbContext
    {
        public DbSet<Proposal> Proposals { get; set; }
    }
}