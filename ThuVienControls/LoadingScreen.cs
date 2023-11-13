using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class LoadingScreen : Krypton.Toolkit.KryptonForm
    {
        public LoadingScreen()
        {
            InitializeComponent();

            Palette = kryptonPalette1;
        }
        //Delegate for cross thread call to close
        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        private static LoadingScreen form;

        static public void ShowSplashScreen()
        {
            // Make sure it is only launched once.    
            if (form != null) return;
            form = new LoadingScreen();
            Thread thread = new Thread(new ThreadStart(LoadingScreen.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void ShowForm()
        {
            if (form != null) 
                Application.Run(form);
        }

        static public void CloseForm()
        {
            form?.Invoke(new CloseDelegate(LoadingScreen.CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            if (form != null)
            {
                form.Close();
                form = null;
            };
        }
    }
}
