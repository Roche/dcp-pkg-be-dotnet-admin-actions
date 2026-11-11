using System.Collections.Generic;

namespace OpenDCP.Framework.AdminActions.Models
{
    public class AdminActionDTO
    {
        public string Path { get; set; }
        public string DisplayText { get; set; }
        public List<string> Permissions { get; set; }
    }
}
