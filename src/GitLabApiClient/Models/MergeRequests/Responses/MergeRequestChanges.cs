using System.Collections.Generic;
using GitLabApiClient.Models.Commits.Responses;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.MergeRequests.Responses
{
    public sealed class MergeRequestChanges : MergeRequest
    {
        [JsonProperty("changes")]
        public List<Diff> Changes { get; set; } = new List<Diff>();
    }
}
