﻿using Domain.Entity.ApplicationEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feature.Slides.Command.Create
{
    public record CreateSliderCommand(Slider Slider, bool Save = true) : IRequest<Guid>;
}
