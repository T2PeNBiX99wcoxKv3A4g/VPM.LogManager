using io.github.ykysnk.CheatClientProtector;
using JetBrains.Annotations;
using UdonSharp;
using UnityEngine;

namespace io.github.ykysnk.LogManager
{
    [AddComponentMenu("yky/Log Manager/Log Manager")]
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    [PublicAPI]
    public class LogManager : CheatClientProtectorBehaviour
    {
        public LogPanel[] logPanels;

        public void AddLog(string prefixColor, string prefix, string message, LogType logType, int key)
        {
            if (!IsKeyCorrect(key)) return;
            foreach (var logPanel in logPanels)
                logPanel.AddLog(prefixColor, prefix, message, logType, logPanel.RandomKey);
        }

        public void Log(string prefixColor, string prefix, string message, int key)
        {
            if (!IsKeyCorrect(key)) return;
            AddLog(prefixColor, prefix, message, LogType.Log, RandomKey);
        }

        public void LogWarning(string prefixColor, string prefix, string message, int key)
        {
            if (!IsKeyCorrect(key)) return;
            AddLog(prefixColor, prefix, message, LogType.Warning, RandomKey);
        }

        public void LogError(string prefixColor, string prefix, string message, int key)
        {
            if (!IsKeyCorrect(key)) return;
            AddLog(prefixColor, prefix, message, LogType.Error, RandomKey);
        }

        public void LogAssertion(string prefixColor, string prefix, string message, int key)
        {
            if (!IsKeyCorrect(key)) return;
            AddLog(prefixColor, prefix, message, LogType.Assert, RandomKey);
        }
    }
}