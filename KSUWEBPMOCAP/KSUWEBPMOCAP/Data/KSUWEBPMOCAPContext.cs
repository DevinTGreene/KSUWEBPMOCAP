using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KSUWEBPMOCAP.Data;

    public class KSUWEBPMOCAPContext : DbContext
    {
        public KSUWEBPMOCAPContext (DbContextOptions<KSUWEBPMOCAPContext> options)
            : base(options)
        {
        }

        public DbSet<KSUWEBPMOCAP.Data.Assignment> Assignment { get; set; }

        public DbSet<KSUWEBPMOCAP.Data.Department> Department { get; set; }

        public DbSet<KSUWEBPMOCAP.Data.Faculty> Faculty { get; set; }

        public DbSet<KSUWEBPMOCAP.Data.PDFFILE> PDFFILE { get; set; }

        public DbSet<KSUWEBPMOCAP.Data.Project> Project { get; set; }

        public DbSet<KSUWEBPMOCAP.Data.Proposal> Proposal { get; set; }

        public DbSet<KSUWEBPMOCAP.Data.RegUser> RegUser { get; set; }

        public DbSet<KSUWEBPMOCAP.Data.Sponsor> Sponsor { get; set; }

        public DbSet<KSUWEBPMOCAP.Data.Student> Student { get; set; }

        public DbSet<KSUWEBPMOCAP.Data.TblFile> TblFile { get; set; }
    }
