using AdPoc.Core.Entities;
using System.Collections.Generic;

namespace AdPoc.Core.Entities
{
    public class Context : BaseEntity
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
