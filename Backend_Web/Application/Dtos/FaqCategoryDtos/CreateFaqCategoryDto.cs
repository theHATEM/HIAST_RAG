﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.FaqCategoryDtos
{
    public class CreateFaqCategoryDto
    {
        public IList<CreateFaqCategoryTranslationDto> Translations { get; set; }
    }
}
