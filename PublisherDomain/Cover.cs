using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherDomain
{
    public class Cover
    {
        public int Id { get; set; }
        public string DesignIdeas { get; set; } = null!;
        public bool DigitalOnly { get; set; }
        public List<Artist> Artists { get; set; } = [];
    }
}
