﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JnB.BusinessLogic.DTOs
{
    public class AppSettings
    {
        public CosmosDBConnection? CosmosDBConnection { get; set; }
    }

    public class CosmosDBConnection
    {
        public string EndpointUri { get; set; }
        public string PrimaryKey { get; set; }

    }
}
