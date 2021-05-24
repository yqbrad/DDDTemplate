﻿using DDD.Contracts._Base;
using Microsoft.Extensions.Configuration;

namespace DDD.EndPoints.API.Configuration
{
    public class UnitOfWorkConfig : IUnitOfWorkConfiguration
    {
        public UnitOfWorkConfig(IConfiguration config)
        {
            var section = config.GetSection(nameof(UnitOfWorkConfig));
            section.Bind(this);
        }
        
        public string SqlServerConnectionString { get; set; }
        public InitialData Seed { get; set; }
    }
}