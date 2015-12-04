using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Alumini_Assignment.Models
{
    public class ProfileModels
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string NicNo { get; set; }
        public Image ProfilePicture { get; set; }
        public string CurrentAddress { get; set; }
        public string Occupation { get; set; }
    }

    public class ProposalDBContext : DbContext
    {
        public DbSet<ProfileModels> Movies { get; set; }
    }
}