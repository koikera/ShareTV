using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareTV.Application.DTOs
{
    public class CreateLiveDto
    {
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }

    }
}