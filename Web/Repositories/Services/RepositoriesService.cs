using System.Diagnostics;
using System.Text;
using Renci.SshNet;
using Repositories.Bindings;
using Repositories.Payload;

namespace Repositories.Services;

public class CommandResult
{
    public bool IsSuccess { get; set; }
    public string Output { get; set; }
    public string Error { get; set; }
}

public class RepositoriesService(RepositoriesServiceBinding binding)
{
    public async Task<string> GetFileContent(Guid repositoryId, string branchName, string fileName,
        CancellationToken cancellationToken)
    {
        return await ExecuteSshCommandAsync(
            $"git --git-dir=/{binding.RepositoriesPath}/{repositoryId}.git show {branchName}:{fileName}",
            cancellationToken);
    }

    public async Task UpdateFileContent(Guid recipeId, string branchName, UpdateFilePayload payload,
        CancellationToken cancellationToken)
    {
        var repoUrl = $"{binding.SshUrl}:{binding.SshPort}/{binding.RepositoriesPath}/{recipeId}.git";
        var localPath = @"/Users/jeanpaul/Downloads/Repositories";

        CommandResult result;

        if (!Directory.Exists(localPath + "/" + recipeId))
            // Pull project from remote
            result = await ExecuteCommandAsync(
                "git",
                $"clone {repoUrl}",
                value => "Pa55w0rd!",
                localPath);

        return;

        localPath += "/" + recipeId;

        // Write to file
        // await using var fs = new FileStream(localPath + "/hello.txt", FileMode.Create, FileAccess.Write);
        // await using var writer = new StreamWriter(fs);
        // await writer.WriteAsync(payload.Content);

        // Commit new changes
        result = await ExecuteCommandAsync("git", "add .", workingDirectory: localPath);
        result = await ExecuteCommandAsync("git", "commit -m \"Some Example\"", workingDirectory: localPath);
        result = await ExecuteCommandAsync("git", "push", prompt => "Pa55w0rd!", localPath);

        // using (var repo = new Repository(localPath))
        // {
        //     // Step 3: Create a new branch
        //     Console.WriteLine($"Creating branch '{branchName}'...");
        //     var newBranch = repo.CreateBranch(branchName);
        //     Commands.Checkout(repo, newBranch);
        //     Console.WriteLine($"Checked out to branch '{branchName}'");
        //
        //     // Step 4: Make changes (e.g., create a new file)
        //     var filePath = Path.Combine(localPath, "newfile.txt");
        //     await File.WriteAllTextAsync(filePath, "Hello, Git!", cancellationToken);
        //
        //     // Step 5: Stage the file
        //     Commands.Stage(repo, "newfile.txt");
        //
        //     // Step 6: Create the commit
        //     var author = new Signature("Your Name", "youremail@example.com", DateTime.Now);
        //     var committer = author;
        //     var commit = repo.Commit("Add newfile.txt", author, committer);
        //     Console.WriteLine("New commit created: " + commit.Sha);
        //
        //     // Step 7: Push the branch to the remote
        //     Console.WriteLine($"Pushing branch '{branchName}' to remote...");
        //     var remote = repo.Network.Remotes["origin"];
        //     var pushRefSpec = $"refs/heads/{branchName}";
        //     repo.Network.Push(remote, pushRefSpec, new PushOptions
        //     {
        //         CredentialsProvider = (url, usernameFromUrl, types) =>
        //             new UsernamePasswordCredentials
        //             {
        //                 Username = "your-username", // Replace with your username
        //                 Password = "your-password" // Replace with your password or token
        //             }
        //     });
        //     Console.WriteLine("Push completed.");
        // }
    }

    private async Task CreateRepository(Guid recipeId, CancellationToken cancellationToken)
    {
        await ExecuteSshCommandAsync(
            $"cd /home/git && git init --bare {recipeId}.git && chown -R git:git /home/git/{recipeId}.git",
            cancellationToken);
    }

    private async Task<string> ExecuteSshCommandAsync(string command, CancellationToken cancellationToken)
    {
        return await Task.Run(() =>
        {
            var host = binding.SshUrl;
            var port = binding.SshPort;
            var username = binding.SshUserName;
            var password = binding.SshPassword;

            var sshClient = new SshClient(host, port, username, password);

            if (!sshClient.IsConnected) sshClient.Connect();

            if (cancellationToken.IsCancellationRequested)
                throw new TaskCanceledException();

            var cmd = sshClient.CreateCommand(command);

            var result = cmd.Execute();

            sshClient.Disconnect();

            return result;
        }, cancellationToken);
    }
}