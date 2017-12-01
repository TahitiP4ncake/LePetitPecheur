using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.Win32;
using System.Windows.Forms;

public class RegistryOperation : MonoBehaviour {

    public bool openAtStart;

    public void OpenApplicationAtStart()
    {
        RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        rk.SetValue("Pêcheur.exe", System.Windows.Forms.Application.ExecutablePath.ToString());

        openAtStart = true;
    }

    public void DontOpenApplicationAtStart()
    {
        RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        rk.DeleteSubKey("Pêcheur.exe");

        openAtStart = false;
    }
}
