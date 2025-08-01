﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feature.Posts.Command.Delete
{
    public record DeletePostCommand(Guid Id, bool save = true) : IRequest;
}
