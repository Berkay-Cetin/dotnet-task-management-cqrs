﻿using Arfware.ArfBlocks.Core;
using Arfware.ArfBlocks.Core.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Infrastructure.Services;

namespace TaskManager.Application.RequestHandlers.Assignments.Commands.NewAssignment;

public class PostHandler : IPostRequestHandler
{
    private readonly Logger _logger;
    private readonly CurrentUserService _currentUserService;

    public PostHandler(ArfBlocksDependencyProvider dependencyProvider, object dataAccess)
    {
        _logger = dependencyProvider.GetInstance<Logger>();
        _currentUserService = dependencyProvider.GetInstance<CurrentUserService>();
    }

    public async Task Handle(IRequestModel payload, ArfBlocksRequestResult response, CancellationToken cancellationToken)
    {
        var requestPayload = (RequestModel)payload;

        if (response.HasError)
            await _logger.Error("Error: '{@payload}' {1}", requestPayload, response.Error.Message);
        else
            await _logger.Information("'{@payload}', yeni bir task ekledi.", _currentUserService.GetCurrentUser().Name);
    }
}