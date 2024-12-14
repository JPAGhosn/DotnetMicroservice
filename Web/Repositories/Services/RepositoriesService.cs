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
    /// <summary>
    ///     Executes a command asynchronously and captures its output.
    /// </summary>
    /// <param name="command">The command to execute (e.g., "ping").</param>
    /// <param name="arguments">Arguments for the command (e.g., "google.com").</param>
    /// <returns>A Task containing the CommandResult.</returns>
    /// <summary>
    ///     Executes a command asynchronously, captures its output, and provides input when required.
    /// </summary>
    /// <param name="command">The command to execute (e.g., "cmd").</param>
    /// <param name="arguments">Arguments for the command (e.g., "/C" for cmd).</param>
    /// <param name="inputProvider">A function that provides input when prompted.</param>
    /// <param name="timeoutMilliseconds">Optional timeout in milliseconds (default is 15000).</param>
    /// <returns>A Task containing the CommandResult.</returns>
    /// <summary>
    ///     Executes a command asynchronously, captures its output, and provides input when required.
    /// </summary>
    /// <param name="command">The command to execute (e.g., "cmd").</param>
    /// <param name="arguments">Arguments for the command (e.g., "/C" for cmd).</param>
    /// <param name="inputProvider">A function that provides input when prompted.</param>
    /// <param name="workingDirectory">The directory in which to execute the command.</param>
    /// <param name="timeoutMilliseconds">Optional timeout in milliseconds (default is 15000).</param>
    /// <returns>A Task containing the CommandResult.</returns>
    public async Task<CommandResult> ExecuteCommandAsync(
        string command,
        string arguments,
        Func<string, string>? inputProvider = null,
        string workingDirectory = null,
        int timeoutMilliseconds = 15000)
    {
        var result = new CommandResult();

        // Validate the working directory if provided
        // if (!string.IsNullOrEmpty(workingDirectory) && !Directory.Exists(workingDirectory))
        //     await ExecuteCommandAsync("mkdir", workingDirectory);

        using (var process = new Process())
        {
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = command;
            process.StartInfo.Arguments = arguments;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardInput =
                inputProvider != null; // Redirect stdin only if inputProvider is provided
            process.StartInfo.UseShellExecute = false; // Required for redirection
            process.StartInfo.CreateNoWindow = true;

            // Set the working directory if provided
            if (!string.IsNullOrEmpty(workingDirectory)) process.StartInfo.WorkingDirectory = workingDirectory;

            var outputBuilder = new StringBuilder();
            var errorBuilder = new StringBuilder();

            // Event handlers for capturing output and error data
            process.OutputDataReceived += (sender, e) => { Console.WriteLine("Success: " + e.Data); };

            process.ErrorDataReceived += (sender, e) =>
            {
                Console.WriteLine("Error: " + e.Data);

                if (e.Data != null)
                {
                    outputBuilder.AppendLine(e.Data);
                    // Optionally, detect prompts and provide input
                    if (inputProvider != null && e.Data.Contains("password:"))
                    {
                        // Provide input based on the prompt
                        var input = inputProvider("password:");
                        if (input != null) process.StandardInput.WriteLine(input);
                    }
                }

                if (e.Data != null) errorBuilder.AppendLine(e.Data + "\n");
            };

            try
            {
                // Start the process
                var started = process.Start();
                if (!started)
                {
                    result.IsSuccess = false;
                    result.Error = "Failed to start process.";
                    return result;
                }

                // Begin asynchronous read
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                // If inputProvider is provided, handle writing to stdin
                if (inputProvider != null)
                {
                    // Example: Write input based on prompts detected in the output
                    // This simplistic approach assumes that the prompt is detected in OutputDataReceived
                    // For more complex scenarios, consider more robust handling
                }

                // Create a task to wait for exit
                var waitForExit = Task.Run(() => process.WaitForExit());

                // Create a delay task for the timeout
                var timeoutTask = Task.Delay(timeoutMilliseconds);

                // Wait for either the process to exit or the timeout
                var completedTask = await Task.WhenAny(waitForExit, timeoutTask);

                if (completedTask == waitForExit)
                {
                    // Process completed within timeout
                    result.Output = outputBuilder.ToString();
                    result.Error = errorBuilder.ToString();
                    result.IsSuccess = process.ExitCode == 0;
                }
                else
                {
                    // Timeout
                    try
                    {
                        process.Kill();
                    }
                    catch
                    {
                        // Ignore exceptions if the process is already terminated
                    }

                    result.IsSuccess = false;
                    result.Error = "Process timed out.";
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., command not found)
                result.IsSuccess = false;
                result.Error = ex.Message;
            }
        }

        return result;
    }

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