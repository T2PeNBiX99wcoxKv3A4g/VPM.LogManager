using io.github.ykysnk.Localization.Editor;
using io.github.ykysnk.utils.Editor;

namespace io.github.ykysnk.LogManager.Editor;

internal abstract class LogManagerEditorBase : BasicEditor
{
    internal const string LocalizationID = "io.github.ykysnk.log-manager";

    protected override void OnInspectorGUIDraw()
    {
        OnLogManagerInspectorGUI();
        GlobalLocalization.SelectLanguageGUI(LocalizationID);
    }

    protected abstract void OnLogManagerInspectorGUI();
}