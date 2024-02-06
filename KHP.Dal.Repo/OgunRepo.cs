using KHP.Core;
using KHP.Dal.Context;
using KHP.Dal.IRepo;
using KHP.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Dal.Repo
{
    public class OgunRepo : BaseRepository<Ogun>, IOgunRepo
    {
        public OgunRepo(DbContext context = null) : base(context ?? new KHPDbContext())
        {
        }
    }
}
