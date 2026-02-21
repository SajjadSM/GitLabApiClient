using System;
using GitLabApiClient.Models.Commits.Responses;
using GitLabApiClient.Models.Pipelines.Responses;
using GitLabApiClient.Models.Users.Responses;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Pipelines.Responses
{
    public sealed class Bridge
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("stage")]
        public string Stage { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("started_at")]
        public DateTime? StartedAt { get; set; }

        [JsonProperty("finished_at")]
        public DateTime? FinishedAt { get; set; }

        [JsonProperty("duration")]
        public double? Duration { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("commit")]
        public Commit Commit { get; set; }

        [JsonProperty("pipeline")]
        public Pipeline Pipeline { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        [JsonProperty("downstream_pipeline")]
        public Pipeline DownstreamPipeline { get; set; }

        [JsonProperty("allow_failure")]
        public bool AllowFailure { get; set; }
    }
}
