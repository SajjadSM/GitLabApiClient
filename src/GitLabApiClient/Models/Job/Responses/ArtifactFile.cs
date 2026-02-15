using Newtonsoft.Json;

namespace GitLabApiClient.Models.Job.Responses
{
    public sealed class ArtifactFile
    {
        /// <summary>
        /// File or directory name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Full path in the artifacts archive. Directories include a trailing slash.
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// Type of entry. Possible values: file, directory.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// File size in bytes. Only present for files.
        /// </summary>
        [JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Unix file mode in octal format. For example, 100644 for files or 040755 for directories.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }
}
