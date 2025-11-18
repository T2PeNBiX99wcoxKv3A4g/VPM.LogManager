using io.github.ykysnk.utils.Editor;
using UnityEditor;

namespace io.github.ykysnk.LogManager.Editor;

[CustomEditor(typeof(LogPanel))]
public class LogPanelEditor : BasicEditor
{
    private const string ContentTransformProp = "contentTransform";
    private const string LogInstancesPrefabProp = "logInstancesPrefab";
    private const string MaxLines = "maxLines";

    private SerializedProperty? _contentTransformProperty;
    private SerializedProperty? _logInstancesPrefabProperty;
    private SerializedProperty? _maxLinesProperty;

    protected override void OnEnable()
    {
        _contentTransformProperty = serializedObject.FindProperty(ContentTransformProp);
        _logInstancesPrefabProperty = serializedObject.FindProperty(LogInstancesPrefabProp);
        _maxLinesProperty = serializedObject.FindProperty(MaxLines);
    }

    protected override void OnInspectorGUIDraw()
    {
        EditorGUILayout.PropertyField(_contentTransformProperty);
        if (_contentTransformProperty?.objectReferenceValue == null)
            EditorGUILayout.HelpBox("ContentTransform is required.", MessageType.Error);

        EditorGUILayout.PropertyField(_logInstancesPrefabProperty);
        if (_logInstancesPrefabProperty?.objectReferenceValue == null)
            EditorGUILayout.HelpBox("LogInstancesPrefab is required.", MessageType.Error);

        EditorGUILayout.PropertyField(_maxLinesProperty);

        var count = FindObjectsOfType<LogManager>().Length;

        switch (count)
        {
            case < 1:
                EditorGUILayout.HelpBox("No LogManager found in scene.", MessageType.Error);
                break;
            case > 1:
                EditorGUILayout.HelpBox("More than one LogManager found in scene.", MessageType.Warning);
                break;
        }

        EditorGUILayout.HelpBox("LogPanel will automatically generate 'LogInstance' in play mode.", MessageType.Info);
    }
}