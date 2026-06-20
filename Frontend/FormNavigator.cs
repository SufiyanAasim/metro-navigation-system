using System.Windows.Forms;

namespace Metro_App.Frontend
{
    public static class FormNavigator
    {
        public static void ShowNext(Form currentForm, Form nextForm)
        {
            nextForm.Show();
            currentForm.Hide();
        }
    }
}
