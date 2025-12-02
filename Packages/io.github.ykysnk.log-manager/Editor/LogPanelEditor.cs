using io.github.ykysnk.Localization.Editor;
using UnityEditor;

namespace io.github.ykysnk.LogManager.Editor;

[CustomEditor(typeof(LogPanel))]
internal class LogPanelEditor : LogManagerEditorBase
{
    private const string ContentTransformProp = "contentTransform";
    private const string LogInstancesPrefabProp = "logInstancesPrefab";
    private const string MaxLinesProp = "maxLines";
    private const string ScrollRectProp = "scrollRect";
    private const string VerticalLayoutGroupProp = "verticalLayoutGroup";
    private const string ContentSizeFitterProp = "contentSizeFitter";

    private SerializedProperty? _contentSizeFitterProperty;
    private SerializedProperty? _contentTransformProperty;
    private SerializedProperty? _logInstancesPrefabProperty;
    private SerializedProperty? _maxLinesProperty;
    private SerializedProperty? _scrollRectProperty;
    private SerializedProperty? _verticalLayoutGroupProperty;

    protected override void OnEnable()
    {
        _contentTransformProperty = serializedObject.FindProperty(ContentTransformProp);
        _logInstancesPrefabProperty = serializedObject.FindProperty(LogInstancesPrefabProp);
        _maxLinesProperty = serializedObject.FindProperty(MaxLinesProp);
        _scrollRectProperty = serializedObject.FindProperty(ScrollRectProp);
        _verticalLayoutGroupProperty = serializedObject.FindProperty(VerticalLayoutGroupProp);
        _contentSizeFitterProperty = serializedObject.FindProperty(ContentSizeFitterProp);
    }

    protected override void OnLogManagerInspectorGUI()
    {
        EditorGUILayout.PropertyField(_contentTransformProperty,
            "label.log_panel.content_transform".G(LocalizationID));
        if (_contentTransformProperty?.objectReferenceValue == null)
            EditorGUILayout.HelpBox("label.log_panel.content_transform.error".L(LocalizationID),
                MessageType.Error);

        EditorGUILayout.PropertyField(_verticalLayoutGroupProperty,
            "label.log_panel.vertical_layout_group".G(LocalizationID));
        EditorGUILayout.PropertyField(_contentSizeFitterProperty,
            "label.log_panel.content_size_fitter".G(LocalizationID));
        EditorGUILayout.PropertyField(_scrollRectProperty, "label.log_panel.scroll_rect".G(LocalizationID));

        EditorGUILayout.PropertyField(_logInstancesPrefabProperty,
            "label.log_panel.log_instances_prefab".G(LocalizationID));
        if (_logInstancesPrefabProperty?.objectReferenceValue == null)
            EditorGUILayout.HelpBox("label.log_panel.log_instances_prefab.error".L(LocalizationID),
                MessageType.Error);

        EditorGUILayout.PropertyField(_maxLinesProperty, "label.log_panel.max_lines".G(LocalizationID));

        var count = FindObjectsOfType<LogManager>().Length;

        switch (count)
        {
            case < 1:
                EditorGUILayout.HelpBox("label.log_panel.error".L(LocalizationID), MessageType.Error);
                break;
            case > 1:
                EditorGUILayout.HelpBox("label.log_panel.warning", MessageType.Warning);
                break;
        }

        EditorGUILayout.HelpBox("label.log_panel.info".L(LocalizationID), MessageType.Info);
    }
}