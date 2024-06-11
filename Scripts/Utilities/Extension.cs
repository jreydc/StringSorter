using System.Windows.Forms;

namespace StringSorter.Scripts.Utilities;

public static class Extension
{
    public static bool NullOrEmpty(this string value) => string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);

    public static void EnableControls(Control[] controls, bool status)
    {
        foreach (Control control in controls)
        {
            control.Enabled = status;
        }
    }

    public static void ClearControls(Control[] controls)
    {
        foreach (Control control in controls)
        {
            control.ResetText();
        }
    }
}
