using System;
using System.Collections.Generic;
using System.Linq;
using UdonSharp;
using UnityEditor.Callbacks;
using VRC.SDKBase;
using Object = UnityEngine.Object;

namespace io.github.ykysnk.LogManager.Editor;

public static class LogManagerScenePostProcess
{
    private static LogManager? _logManager;
    private static List<LogPanel> _logPanels = new();

    [PostProcessScene(-100)]
    public static void ScenePostProcess()
    {
        var logManagers = Object.FindObjectsOfType<LogManager>().ToList();

        switch (logManagers.Count)
        {
            case < 1:
                return;
            case > 1:
                throw new("More than one LogManager found in scene.");
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
                    throw new NullReferenceException($"Log Instance {i} is not a valid LogInstance");
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