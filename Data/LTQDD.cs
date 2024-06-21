using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaiThiLai.Models;

    public class LTQDD : DbContext
    {
        public LTQDD (DbContextOptions<LTQDD> options)
            : base(options)
        {
        }

        public DbSet<BaiThiLai.Models.testktra> testktra { get; set; } = default!;

public DbSet<BaiThiLai.Models.NMD190Person> NMD190Person { get; set; } = default!;
    }
