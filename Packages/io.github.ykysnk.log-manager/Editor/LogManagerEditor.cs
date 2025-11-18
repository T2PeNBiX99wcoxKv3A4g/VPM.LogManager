using io.github.ykysnk.utils.Editor;
using UnityEditor;

namespace io.github.ykysnk.LogManager.Editor;

[CustomEditor(typeof(LogManager))]
public class LogManagerEditor : BasicEditor
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
        EditorGUILayout.PropertyField(_logInstancesPrefabProperty);
        EditorGUILayout.PropertyField(_maxLinesProperty);
        EditorGUILayout.HelpBox("LogManager will automatically generate 'LogInstance' in play mode.", MessageType.Info);
    }
}