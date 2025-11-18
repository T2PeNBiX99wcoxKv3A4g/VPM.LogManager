using io.github.ykysnk.utils.Editor;
using UnityEditor;

namespace io.github.ykysnk.LogManager.Editor;

[CustomEditor(typeof(LogManager))]
public class LogManagerEditor : BasicEditor
{
    protected override void OnInspectorGUIDraw()
    {
        var count = FindObjectsOfType<LogManager>().Length;

        if (count > 1)
            EditorGUILayout.HelpBox("More than one LogManager found in scene.", MessageType.Warning);

        var count2 = FindObjectsOfType<LogPanel>().Length;

        if (count2 < 1)
            EditorGUILayout.HelpBox("No LogPanel found in scene.", MessageType.Error);

        EditorGUILayout.HelpBox("LogManager will automatically find all log panels", MessageType.Info);
    }
}