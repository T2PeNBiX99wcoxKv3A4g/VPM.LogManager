using io.github.ykysnk.CheatClientProtector;
using JetBrains.Annotations;
using UdonSharp;
using UnityEngine;

namespace io.github.ykysnk.LogManager
{
    /// <summary>
    ///     Manages logging functionalities, allowing messages to be added or displayed in various formats across multiple log
    ///     panels.
    /// </summary>
    /// <remarks>
    ///     This class coordinates log messages across one or more configured log panels.
    ///     Messages can be logged at different levels (e.g., standard log, warning, error, assertion) with specified prefixes
    ///     and colors.
    /// </remarks>
    [AddComponentMenu("yky/Log Manager/Log Manager")]
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    [PublicAPI]
    public class LogManager : CheatClientProtectorBehaviour
    {
        public LogPanel[] logPanels;

        /// <summary>
        ///     Adds a log entry to all associated log panels if the provided key is correct.
        /// </summary>
        /// <param name="prefixColor">The color code for the log's prefix text.</param>
        /// <param name="prefix">The prefix text identifying the source or type of the log entry.</param>
        /// <param name="message">The actual log message to be displayed or recorded.</param>
        /// <param name="logType">The type of the log (e.g., Log, Warning, Error, Assertion).</param>
        /// <param name="key">The security key used to validate the operation.</param>
        public void AddLog([NotNull] string prefixColor, [NotNull] string prefix, [CanBeNull] string message,
            LogType logType, int key)
        {
            if (!IsKeyCorrect(key)) return;
            foreach (var logPanel in logPanels)
                logPanel.AddLog(prefixColor, prefix, message, logType, logPanel.RandomKey);
        }

        /// <summary>
        ///     Logs a message with the specified prefix and color if the provided key is valid.
        /// </summary>
        /// <param name="prefixColor">The color code for the log's prefix text.</param>
        /// <param name="prefix">The prefix text identifying the source or type of the log entry.</param>
        /// <param name="message">The actual log message to be displayed or recorded.</param>
        /// <param name="key">The security key used to validate the operation.</param>
        public void Log([NotNull] string prefixColor, [NotNull] string prefix, [CanBeNull] string message, int key)
        {
            if (!IsKeyCorrect(key)) return;
            AddLog(prefixColor, prefix, message, LogType.Log, RandomKey);
        }

        /// <summary>
        ///     Logs a warning message to all associated log panels if the provided key is valid.
        /// </summary>
        /// <param name="prefixColor">The color code for the prefix text associated with the warning message.</param>
        /// <param name="prefix">The prefix text indicating the source or context of the warning message.</param>
        /// <param name="message">The content of the warning message to be logged.</param>
        /// <param name="key">The security key used to authorize the logging operation.</param>
        public void LogWarning([NotNull] string prefixColor, [NotNull] string prefix, [CanBeNull] string message, int key)
        {
            if (!IsKeyCorrect(key)) return;
            AddLog(prefixColor, prefix, message, LogType.Warning, RandomKey);
        }

        /// <summary>
        ///     Logs an error message to all associated log panels if the provided key is correct.
        /// </summary>
        /// <param name="prefixColor">The color code for the log's prefix text.</param>
        /// <param name="prefix">The prefix text identifying the source or type of the error log entry.</param>
        /// <param name="message">The actual error message to be displayed or recorded.</param>
        /// <param name="key">The security key used to validate the operation.</param>
        public void LogError([NotNull] string prefixColor, [NotNull] string prefix, [CanBeNull] string message, int key)
        {
            if (!IsKeyCorrect(key)) return;
            AddLog(prefixColor, prefix, message, LogType.Error, RandomKey);
        }

        /// <summary>
        ///     Logs an assertion-level message to all associated log panels if the provided key is valid.
        /// </summary>
        /// <param name="prefixColor">The color code for the prefix text of the log message.</param>
        /// <param name="prefix">The prefix text identifying the source or category of the log assertion.</param>
        /// <param name="message">The assertion message to be logged and displayed.</param>
        /// <param name="key">The security key used to authenticate this logging operation.</param>
        public void LogAssertion([NotNull] string prefixColor, [NotNull] string prefix, [CanBeNull] string message,
            int key)
        {
            if (!IsKeyCorrect(key)) return;
            AddLog(prefixColor, prefix, message, LogType.Assert, RandomKey);
        }
    }
}