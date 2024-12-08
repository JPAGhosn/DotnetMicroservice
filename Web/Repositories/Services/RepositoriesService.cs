using Renci.SshNet;
using Repositories.Bindings;

namespace Repositories.Services;

public class RepositoriesService(RepositoriesServiceBinding binding)
{
    public async Task<string> GetFileContent(Guid repositoryId, string branchName, string fileName,
        CancellationToken cancellationToken)
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

            var command = $"git --git-dir=/home/repositories/{repositoryId}.git show {branchName}:{fileName}";
            var cmd = sshClient.CreateCommand(command);

            var result = cmd.Execute();

            sshClient.Disconnect();

            return result;
        }, cancellationToken);
    }
}