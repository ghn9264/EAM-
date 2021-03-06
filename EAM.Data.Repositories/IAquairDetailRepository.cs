﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EAM.Data.Comm;
using EAM.Data.Domain;
using NPoco;

namespace EAM.Data.Repositories
{
    public interface IAquairDetailRepository : IRepository<AquairDetailAttribute, int>
    {
        List<AquairDetailAttribute> QueryDto(int acquireId);
    }

}