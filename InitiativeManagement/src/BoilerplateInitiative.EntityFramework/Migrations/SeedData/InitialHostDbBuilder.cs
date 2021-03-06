﻿using BoilerplateInitiative.EntityFramework;
using EntityFramework.DynamicFilters;

namespace BoilerplateInitiative.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly BoilerplateInitiativeDbContext _context;

        public InitialHostDbBuilder(BoilerplateInitiativeDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
