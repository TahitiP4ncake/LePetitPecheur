using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.Win32;
using System.Windows.Forms;

public class AtStart : MonoBehaviour {

    void Awake()
    {
         RegistryKey rk = Registry.CurrentUser.OpenSubKey
        ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        rk.SetValue("Pêcheur.exe", System.Windows.Forms.Application.ExecutablePath.ToString());
    }
}
