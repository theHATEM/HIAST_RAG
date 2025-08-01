﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feature.Prges.Command.Delete
{
    public record DeleteLanguageCommand(Guid Id, bool save = true) : IRequest;
}
