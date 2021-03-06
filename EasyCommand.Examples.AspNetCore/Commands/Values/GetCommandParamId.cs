﻿using EasyCommand.AspNetCore;
using System.Threading.Tasks;

namespace EasyCommand.Examples.AspNetCore.Commands.Values
{
    public class GetCommandParamId : AsyncAspCommand<int, string>
    {
        protected override Task<string> ExecuteCommandAsync(int request)
        {
            return Task.FromResult("value");
        }
    }
}
