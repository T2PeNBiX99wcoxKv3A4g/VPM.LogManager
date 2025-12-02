using io.github.ykysnk.Localization.Editor;
using io.github.ykysnk.utils.Editor;

namespace io.github.ykysnk.LogManager.Editor;

public abstract class LogManagerEditorBase : BasicEditor
{
    protected override void OnInspectorGUIDraw()
    {
        OnLogManagerInspectorGUI();
        GlobalLocalization.SelectLanguageGUI(EditorUtils.LocalizationID);
    }

    protected abstract void OnLogManagerInspectorGUI();
}