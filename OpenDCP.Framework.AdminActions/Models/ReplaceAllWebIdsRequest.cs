using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDCP.Framework.AdminActions.Models
{
    public class ReplaceAllWebIdsRequest
    {
        //ToDo check if this can be renamed to WebIds only as it should be connection type agnostic
        [JsonPropertyName("PIWebIds")]
        public Dictionary<string, string> WebIds { get; set; }
        public string Reason { get; set; }
        public int SiteId { get; set; }
    }

}
