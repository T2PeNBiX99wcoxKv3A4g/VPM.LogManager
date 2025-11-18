using System;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using VRC.SDKBase;
using Object = UnityEngine.Object;

namespace io.github.ykysnk.LogManager.Editor;

public static class LogManagerScenePostProcess
{
    private static LogManager[] _logManagers =
    {
    };

    [PostProcessScene(-100)]
    public static void ScenePostProcess()
    {
        _logManagers = Object.FindObjectsOfType<LogManager>();
        SetLogManager();
    }

    private static void SetLogManager()
    {
        foreach (var logManager in _logManagers)
        {
            var logInstanceList = new List<LogInstance>();

            for (var i = 0; i < logManager.maxLines; i++)
            {
                var logInstanceObj = Object.Instantiate(logManager.logInstancesPrefab, logManager.contentTransform);
                logInstanceObj.name = $"LogInstance {i}";
                logInstanceObj.SetActive(false);
                var logInstance = logInstanceObj.GetComponent<LogInstance>();
                if (!Utilities.IsValid(logInstance))
                    throw new NullReferenceException($"Log Instance {i} is not a valid LogInstance");
                logInstanceList.Add(logInstance);
            }

            logManager.logInstances = logInstanceList.ToArray();
        }
    }
}