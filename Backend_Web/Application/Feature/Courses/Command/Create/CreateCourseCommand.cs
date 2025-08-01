﻿using Domain.Entity.ApplicationEntity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Feature.Courses.Command.Create
{
    public record CreateCourseCommand(Course Course, bool Save = true) : IRequest<Guid>;
}
