﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feature.Specializations.Command.Delete
{
    public record DeleteSpecializationCommand(Guid Id, bool save = true) : IRequest;
}
