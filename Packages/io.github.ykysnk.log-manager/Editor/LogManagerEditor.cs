using io.github.ykysnk.Localization.Editor;
using UnityEditor;

namespace io.github.ykysnk.LogManager.Editor;

[CustomEditor(typeof(LogManager))]
public class LogManagerEditor : LogManagerEditorBase
{
    protected override void OnLogManagerInspectorGUI()
    {
        var count = FindObjectsOfType<LogManager>().Length;

        if (count > 1)
            EditorGUILayout.HelpBox("label.log_manager.warning".L(EditorUtils.LocalizationID), MessageType.Warning);

        var count2 = FindObjectsOfType<LogPanel>().Length;

        if (count2 < 1)
            EditorGUILayout.HelpBox("label.log_manager.error".L(EditorUtils.LocalizationID), MessageType.Error);

        EditorGUILayout.HelpBox("label.log_manager.info".L(EditorUtils.LocalizationID), MessageType.Info);
    }
}