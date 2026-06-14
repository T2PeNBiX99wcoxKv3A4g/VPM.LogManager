using UnityEditor;

namespace io.github.ykysnk.LogManager.Editor;

[CustomEditor(typeof(LogManager))]
internal class LogManagerEditor : LogManagerEditorBase
{
    protected override void OnLogManagerInspectorGUI()
    {
        var count = FindObjectsOfType<LogManager>().Length;

        if (count > 1)
            EditorGUILayout.HelpBox("label.log_manager.warning".S(), MessageType.Warning);

        var count2 = FindObjectsOfType<LogPanel>().Length;

        if (count2 < 1)
            EditorGUILayout.HelpBox("label.log_manager.error".S(), MessageType.Error);

        EditorGUILayout.HelpBox("label.log_manager.info".S(), MessageType.Info);
    }
}