﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkPost
{
    public interface IMetrics
    {
        Task<IEnumerable<string>> ListDomains(object metricsSimpleQuery);
    }
}
