using System;
using System.Collections.Generic;
using System.Linq;
using io.github.ykysnk.Localization.Editor;
using UdonSharp;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine.SceneManagement;
using VRC.SDKBase;
using Object = UnityEngine.Object;

namespace io.github.ykysnk.LogManager.Editor;

internal class LogManagerScenePostProcess : IProcessSceneWithReport
{
    private static LogManager? _logManager;
    private static List<LogPanel> _logPanels = new();

    public int callbackOrder => -100;

    public void OnProcessScene(Scene scene, BuildReport report)
    {
        var logManagers = Object.FindObjectsOfType<LogManager>().ToList();

        switch (logManagers.Count)
        {
            case < 1:
                return;
            case > 1:
                throw new("log.log_manager_scene_post_process.error".L(LogManagerEditorBase.LocalizationID));
        }

        _logManager = logManagers[0];
        _logPanels = Object.FindObjectsOfType<LogPanel>().ToList();
        AddLogPanel();
        CreateLogInstance();
        SetLogManager();
    }

    private static void AddLogPanel()
    {
        if (_logManager == null) return;
        _logManager.logPanels = _logPanels.ToArray();
    }

    private static void CreateLogInstance()
    {
        foreach (var logPanel in _logPanels)
        {
            var logInstanceList = new List<LogInstance>();

            for (var i = 0; i < logPanel.maxLines; i++)
            {
                var logInstanceObj = Object.Instantiate(logPanel.logInstancesPrefab, logPanel.contentTransform);
                logInstanceObj.name = $"LogInstance {i}";
                logInstanceObj.SetActive(false);
                var logInstance = logInstanceObj.GetComponent<LogInstance>();
                if (!Utilities.IsValid(logInstance))
                    throw new NullReferenceException(string.Format(
                        "log.log_manager_scene_post_process.null_reference_exception".L(LogManagerEditorBase
                            .LocalizationID), i));
                logInstanceList.Add(logInstance);
            }

            logPanel.logInstances = logInstanceList.ToArray();
        }
    }

    private static void SetLogManager()
    {
        foreach (var withLogManager in Object.FindObjectsOfType<UdonSharpBehaviour>(true).OfType<ILogManager>())
            withLogManager.LogManager = _logManager;
    }
}