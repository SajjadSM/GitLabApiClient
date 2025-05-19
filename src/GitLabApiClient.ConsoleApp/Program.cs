using System;
using GitLabApiClient;

class Program
{
    static void Main(string[] args)
    {
        // Sample GitLab address and token
        string gitlabUrl = "https://gitlab.example.com";
        string privateToken = "your_private_token";

        // Initialize the GitLab client
        var client = new GitLabClient(gitlabUrl, privateToken);

        Console.WriteLine($"Initialized GitLabClient for {gitlabUrl}");
        // You can now use 'client' to interact with the GitLab API
    }
}
