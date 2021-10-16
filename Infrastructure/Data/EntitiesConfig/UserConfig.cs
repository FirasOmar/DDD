using Domain.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.EntitiesConfig
{
    class UserConfig
    {
        public UserConfig(EntityTypeBuilder<User> entity)
        {
            entity.HasIndex(e => e.Id).IsUnique();
        }
      
    }
}
