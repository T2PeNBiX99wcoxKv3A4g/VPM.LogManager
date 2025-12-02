using io.github.ykysnk.Localization.Editor;
using TMPro;
using UnityEditor;

namespace io.github.ykysnk.LogManager.Editor;

[CustomEditor(typeof(LogInstance))]
public class LogInstanceEditor : LogManagerEditorBase
{
    private const string InputFieldProp = "inputField";

    private SerializedProperty? _inputFieldProperty;

    protected override void OnEnable()
    {
        _inputFieldProperty = serializedObject.FindProperty(InputFieldProp);
    }

    protected override void OnLogManagerInspectorGUI()
    {
        var component = (LogInstance)target;
        var inputFieldComponent = component.GetComponent<TMP_InputField>();

        if (_inputFieldProperty?.objectReferenceValue == null ||
            _inputFieldProperty?.objectReferenceValue != inputFieldComponent)
            EditorGUILayout.PropertyField(_inputFieldProperty,
                "label.log_instance.input_field".G(EditorUtils.LocalizationID));

        EditorGUILayout.HelpBox("label.log_instance.info".L(EditorUtils.LocalizationID), MessageType.Info);
    }
}