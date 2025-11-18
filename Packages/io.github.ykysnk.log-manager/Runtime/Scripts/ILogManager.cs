using JetBrains.Annotations;

namespace io.github.ykysnk.LogManager
{
    /// <summary>
    ///     Interface for managing a centralized logging system.
    /// </summary>
    /// <remarks>
    ///     Classes implementing this interface integrate with a log management system,
    ///     providing mechanisms for setting and accessing log behavior configurations.
    /// </remarks>
    [PublicAPI]
    public interface ILogManager
    {
        LogManager LogManager { get; set; }
    }
}