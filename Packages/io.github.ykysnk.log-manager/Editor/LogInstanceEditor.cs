using io.github.ykysnk.utils.Editor;
using TMPro;
using UnityEditor;

namespace io.github.ykysnk.LogManager.Editor;

[CustomEditor(typeof(LogInstance))]
public class LogInstanceEditor : BasicEditor
{
    private const string InputFieldProp = "inputField";

    private SerializedProperty? _inputFieldProperty;

    protected override void OnEnable()
    {
        _inputFieldProperty = serializedObject.FindProperty(InputFieldProp);
    }

    protected override void OnInspectorGUIDraw()
    {
        var component = (LogInstance)target;
        var inputFieldComponent = component.GetComponent<TMP_InputField>();

        if (_inputFieldProperty?.objectReferenceValue == null ||
            _inputFieldProperty?.objectReferenceValue != inputFieldComponent)
            EditorGUILayout.PropertyField(_inputFieldProperty);

        EditorGUILayout.HelpBox("This is helper class to change text of input field.", MessageType.Info);
    }
}