﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Partials;

namespace WebApplication1.Models
{
    [ModelMetadataType(typeof(LocalMetadata))]
    public partial class Local
    {
    }
}
