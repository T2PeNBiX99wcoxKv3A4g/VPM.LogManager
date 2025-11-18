using System;
using System.Diagnostics.CodeAnalysis;
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
        private const string ErrorText = "<color=red>ERROR</color>";
        private const string WarningText = "<color=yellow>WARN</color>";
        private const string InfoText = "INFO";
        public RectTransform contentTransform;
        public GameObject logInstancesPrefab;
        public int maxLines = 200;
        [HideInInspector] public LogInstance[] logInstances;

        private int _currentLine = -1;
        private int _nowMaxLines;

        [SuppressMessage("ReSharper", "SwitchStatementHandlesSomeKnownEnumValuesWithDefault")]
        public void AddLog(string prefixColor, string prefix, string message, LogType logType, int key)
        {
            if (!IsKeyCorrect(key)) return;
            var time = DateTime.Now.ToString("HH:mm:ss");
            var newMessage = message;
            var logTypeText = "LogType";

            switch (logType)
            {
                case LogType.Error:
                    newMessage = $"<color=red>{message}</color>";
                    logTypeText = ErrorText;
                    break;
                case LogType.Warning:
                    newMessage = $"<color=yellow>{message}</color>";
                    logTypeText = WarningText;
                    break;
                case LogType.Log:
                    logTypeText = InfoText;
                    break;
            }

            var newLog =
                $"[<color=black>{time}</color>] [{logTypeText}] [<color={prefixColor}>{prefix}</color>] {newMessage}";

            _currentLine++;
            _nowMaxLines++;

            if (_nowMaxLines > maxLines)
                MoveLogsUp();

            var logInstance = logInstances[_currentLine];

            logInstance.Text = newLog;
            if (!logInstance.gameObject.activeSelf)
                logInstance.gameObject.SetActive(true);
        }

        public void Log(string prefixColor, string prefix, string message, int key)
        {
            if (!IsPublicKeyCorrect(key)) return;
            AddLog(prefixColor, prefix, message, LogType.Log, RandomKey);
        }

        public void LogWarning(string prefixColor, string prefix, string message, int key)
        {
            if (!IsPublicKeyCorrect(key)) return;
            AddLog(prefixColor, prefix, message, LogType.Warning, RandomKey);
        }

        public void LogError(string prefixColor, string prefix, string message, int key)
        {
            if (!IsPublicKeyCorrect(key)) return;
            AddLog(prefixColor, prefix, message, LogType.Error, RandomKey);
        }

        private void MoveLogsUp()
        {
            for (var i = 1; i < logInstances.Length; i++)
            {
                var lastLog = logInstances[i - 1];
                var log = logInstances[i];
                lastLog.Text = log.Text;
            }

            _currentLine--;
            _nowMaxLines--;
        }
    }

    public enum LogType
    {
        Error,
        Warning,
        Log
    }
}