using System.Threading;
using System.Threading.Tasks;
using Emby.Server.Implementations;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Server.Migrations.PreStartupRoutines;

/// <inheritdoc />
[JellyfinMigration("2025-04-20T02:00:00", nameof(MigrateMusicBrainzTimeout), "A6DCACF4-C057-4Ef9-80D3-61CEF9DDB4F0", Stage = Stages.JellyfinMigrationStageTypes.PreInitialisation)]
public class MigrateMusicBrainzTimeout : IAsyncMigrationRoutine
{
    /// <summary>Initializes a new instance of <see cref="MigrateMusicBrainzTimeout"/>.</summary>
    public MigrateMusicBrainzTimeout(ServerApplicationPaths applicationPaths, ILoggerFactory loggerFactory)
    {
    }

    /// <inheritdoc />
    public Task PerformAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}
