namespace OpenDCP.Framework.AdminActions.Models
{
    public class ActionDetailsResponse
    {
        /// <summary>
        /// ActionReasonCode.cs
        /// </summary>
        public byte ReasonCode { get; set; }
        /// <summary>
        /// ActionStatus.cs
        /// </summary>
        public byte Status { get; set; }
        /// <summary>
        /// ActionDetails.cs
        /// </summary>
        public string Details { get; set; }
    }
}
