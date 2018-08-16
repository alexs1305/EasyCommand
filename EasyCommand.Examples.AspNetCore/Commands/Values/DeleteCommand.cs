﻿using EasyCommand.AspNetCore;
using System.Threading.Tasks;

namespace EasyCommand.Examples.AspNetCore.Commands.Values
{
    public class DeleteCommand : AsyncAspCommandNoResult<int>
    {
        protected override Task<EmptyCommandResult> ExecuteAsync(int request)
        {
            return Task.FromResult(EmptyResult);
        }
    }
}
