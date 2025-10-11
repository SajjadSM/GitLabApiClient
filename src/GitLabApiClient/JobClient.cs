using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Http;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Internal.Queries;
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
    }
}
