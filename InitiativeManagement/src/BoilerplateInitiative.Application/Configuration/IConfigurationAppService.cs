﻿using System.Threading.Tasks;
using Abp.Application.Services;
using BoilerplateInitiative.Configuration.Dto;

namespace BoilerplateInitiative.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}