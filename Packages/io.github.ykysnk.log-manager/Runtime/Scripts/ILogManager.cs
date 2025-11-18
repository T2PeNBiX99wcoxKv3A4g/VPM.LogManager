using JetBrains.Annotations;

namespace io.github.ykysnk.LogManager
{
    [PublicAPI]
    public interface ILogManager
    {
        LogManager LogManager { get; set; }
    }
}