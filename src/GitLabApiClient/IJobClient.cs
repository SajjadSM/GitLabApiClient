using System;
using System.Collections.Generic;
using GitLabApiClient.Models.Files.Responses;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Models.Job.Requests;
using GitLabApiClient.Models.Job.Responses;
using GitLabApiClient.Models.Milestones.Requests;
using GitLabApiClient.Models.Milestones.Responses;
using GitLabApiClient.Models.Projects.Requests;
using GitLabApiClient.Models.Projects.Responses;
using GitLabApiClient.Models.Runners.Responses;
using GitLabApiClient.Models.Users.Responses;
using GitLabApiClient.Models.Variables.Request;
using GitLabApiClient.Models.Variables.Response;
using System.IO;

namespace GitLabApiClient
{
    public interface IJobClient
    {
        /// <summary>
        /// Starts a manual job by its id <see cref="Project"/>.
        /// </summary>
        /// <param name="projectId">The ID, path or <see cref="Project"/> of the project.</param>
        /// <param name="jobId">The id of the job</param>
        Task<Job> PlayAsync(ProjectId projectId, int jobId);

        /// <summary>
        /// Starts a manual job by its id <see cref="Project"/>.
        /// </summary>
        /// <param name="projectId">The ID, path or <see cref="Project"/> of the project.</param>
        /// <param name="jobId">The id of the job</param>
        Task<Job> RetryAsync(ProjectId projectId, int jobId);

        /// <summary>
        /// Cancels a job by its id <see cref="Project"/>.
        /// </summary>
        /// <param name="projectId">The ID, path or <see cref="Project"/> of the project.</param>
        /// <param name="jobId">The id of the job</param>
        Task<Job> CancelAsync(ProjectId projectId, int jobId);

        /// <summary>
        /// Gets an artifact file for a job by its id <see cref="Project"/>.
        /// </summary>
        /// <param name="projectId">The ID, path or <see cref="Project"/> of the project.</param>
        /// <param name="jobId">The id of the job</param>
        /// <param name="fileName">The artifact file name to download</param>
        Task<Stream> GetArtifactFile(ProjectId projectId, int jobId, string fileName);

        /// <summary>
        /// Lists artifact files for a job by its id <see cref="Project"/>.
        /// </summary>
        /// <param name="projectId">The ID, path or <see cref="Project"/> of the project.</param>
        /// <param name="jobId">The id of the job</param>
        // Task<IList<ArtifactFile>> ListArtifactFiles(ProjectId projectId, int jobId);
    }
}
