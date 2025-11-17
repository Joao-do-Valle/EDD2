
using System;
using System.Windows.Forms;

public static class Program {
    [STAThread]
    static void Main() {
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmMenu());
    }
}
