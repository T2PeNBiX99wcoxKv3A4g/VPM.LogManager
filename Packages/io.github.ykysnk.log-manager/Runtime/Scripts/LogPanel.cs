using System;
using io.github.ykysnk.CheatClientProtector;
using io.github.ykysnk.utils;
using JetBrains.Annotations;
using UdonSharp;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace io.github.ykysnk.LogManager
{
    [AddComponentMenu("yky/Log Manager/Log Panel")]
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    [PublicAPI]
    public class LogPanel : CheatClientProtectorBehaviour
    {
        private const string ErrorText = "<color=red>ERROR</color>";
        private const string AssertText = "<color=red>ASSERT</color>";
        private const string ExceptionText = "<color=red>EXCEPTION</color>";
        private const string WarningText = "<color=yellow>WARN</color>";
        private const string InfoText = "INFO";
        public RectTransform contentTransform;
        public GameObject logInstancesPrefab;
        public int maxLines = 200;
        public LogInstance[] logInstances;
        [SerializeField] private ScrollRect scrollRect;
        [SerializeField] private VerticalLayoutGroup verticalLayoutGroup;
        [SerializeField] private ContentSizeFitter contentSizeFitter;

        private int _currentLine = -1;
        private int _nowMaxLines;

#if !COMPILER_UDONSHARP && UNITY_EDITOR
        private void OnValidate()
        {
            var count = FindObjectsOfType<LogManager>().Length;

            if (!gameObject.scene.IsValid() || Utils.IsInPrefab() || count > 0) return;
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(
                AssetDatabase.GUIDToAssetPath("16f3fd2a273a9ab4c997d97e9da89336"));
            PrefabUtility.InstantiatePrefab(prefab);
            Utils.Log(nameof(LogPanel), "Created LogManager prefab");
        }
#endif

        internal void AddLog([NotNull] string prefixColor, [NotNull] string prefix, [CanBeNull] string message,
            LogType logType, int key)
        {
            if (!IsKeyCorrect(key) || !Utils.IsPlaying()) return;
            var time = DateTime.Now.ToString("HH:mm:ss");
            var newMessage = message;
            string logTypeText;

            switch (logType)
            {
                case LogType.Assert:
                    newMessage = $"<color=red>{message}</color>";
                    logTypeText = AssertText;
                    break;
                // Never gonna use I guess
                case LogType.Exception:
                    newMessage = $"<color=red>{message}</color>";
                    logTypeText = ExceptionText;
                    break;
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
                default:
                    Utils.LogError(nameof(LogPanel), $"Unknown log type: {logType}");
                    return;
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
            ToTheButton();
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

        private void ToTheButton()
        {
            if (!verticalLayoutGroup || !contentSizeFitter || !scrollRect) return;
            Canvas.ForceUpdateCanvases();
            verticalLayoutGroup.CalculateLayoutInputHorizontal();
            verticalLayoutGroup.CalculateLayoutInputVertical();
            contentSizeFitter.SetLayoutVertical();
            scrollRect.verticalNormalizedPosition = 0;
        }
    }
}