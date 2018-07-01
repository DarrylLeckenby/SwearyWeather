using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwearyWeather.helpers
{
    class Windows
    {

        public static void LoadingState(bool isloading, Form formcontext) {

            if (isloading) {
                Cursor.Current = Cursors.WaitCursor;
            } else {
                Cursor.Current = Cursors.Default;
            }

            Application.DoEvents();

        }

        public static void OpenSettings() {

            SettingsForm f = new SettingsForm();
            f.ShowDialog();
         
        }

    }
}
