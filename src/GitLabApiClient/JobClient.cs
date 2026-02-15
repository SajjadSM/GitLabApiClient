using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Http;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Internal.Queries;
using GitLabApiClient.Internal.Utilities;
using GitLabApiClient.Models.Job.Requests;
using GitLabApiClient.Models.Job.Responses;
using GitLabApiClient.Models.Pipelines.Requests;
using GitLabApiClient.Models.Pipelines.Responses;

namespace GitLabApiClient
{
    public sealed class JobClient : IJobClient
    {
        private readonly GitLabHttpFacade _httpFacade;

        internal JobClient(GitLabHttpFacade httpFacade)
        {
            _httpFacade = httpFacade;
        }

        public async Task<Job> PlayAsync(ProjectId projectId, int jobId) =>
            await _httpFacade.Post<Job>($"projects/{projectId}/jobs/{jobId}/play");

        public async Task<Job> RetryAsync(ProjectId projectId, int jobId) =>
            await _httpFacade.Post<Job>($"projects/{projectId}/jobs/{jobId}/retry");

        public async Task<Job> CancelAsync(ProjectId projectId, int jobId) =>
            await _httpFacade.Post<Job>($"projects/{projectId}/jobs/{jobId}/cancel");

        public async Task<Stream> GetArtifactFile(ProjectId projectId, int jobId, string fileName) =>
            await _httpFacade.GetFileStream($"projects/{projectId}/jobs/{jobId}/artifacts/{fileName.UrlEncode()}");

        // public async Task<IList<ArtifactFile>> ListArtifactFiles(ProjectId projectId, int jobId) =>
        //     await _httpFacade.Get<IList<ArtifactFile>>($"projects/{projectId}/jobs/{jobId}/artifacts/tree");

    }
}
