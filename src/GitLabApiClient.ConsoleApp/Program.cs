using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using GitLabApiClient;
using GitLabApiClient.Models.Projects.Requests;

class Program
{
    static async Task Main(string[] args)
    {
        // Build configuration
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        string? gitlabUrl = config["GitLab:Url"];
        string? privateToken = config["GitLab:PrivateToken"];

        if (string.IsNullOrWhiteSpace(gitlabUrl) || string.IsNullOrWhiteSpace(privateToken))
        {
            Console.WriteLine("GitLab URL or PrivateToken is missing in appsettings.json");
            return;
        }

        // Initialize the GitLab client
        var client = new GitLabClient(gitlabUrl, privateToken);

        Console.WriteLine($"Initialized GitLabClient for {gitlabUrl}");

        try
        {
            // var proj = await client.Projects.GetAsync(3798);
            // Console.WriteLine($"Retrieved {proj.Name} project.");

            // get list of projects
            // var projs = await client.Projects.GetAsync();

            // var proj = await client.Projects.GetAsync(16820);
            // Console.WriteLine($"Retrieved {proj.Name} project.");

            var jobs = await client.Pipelines.GetBridgesAsync(17038, 206093);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine($"Full exception: {ex}");
        }
    }
}
