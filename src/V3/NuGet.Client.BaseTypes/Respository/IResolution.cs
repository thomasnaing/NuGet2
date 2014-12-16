﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.Client
{
    public interface IResolution
    {
        PackageIdentity ResolvePackage(string id, string version);
    }
}