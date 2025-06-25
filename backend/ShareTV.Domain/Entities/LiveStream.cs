using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareTV.Domain.Entities
{
    public class LiveStream
    {
        public int Id { get; set; }
        public string StreamKey { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsLive { get; set; } = false;

    }
}