using System.Windows.Forms;

namespace CapaVista
{
    public static class CVControlsKeyPressEvents
    {
        public static bool OnlyNumbers(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar) | char.ToString(e.KeyChar) == ",") e.Handled = false;
            else e.Handled = true;
            return e.Handled;
        }
        public static bool OnlyLetters(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) | char.IsControl(e.KeyChar) | char.IsWhiteSpace(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
            return e.Handled;
        }
    }
}
