using System;

namespace TripleJPMVPLibrary.Model
{
    internal class Administrator
    {
        // kini sakto rani nga PascalCase pero wala a lang an underscore kay naming convention violation na sa properties
        public Guid Uuid { get; set; }
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
