using System;
using System.Runtime.InteropServices;
using UnityEngine;
using System.Collections.Generic;
using System.Diagnostics;



public class TransparentWindow : MonoBehaviour
{

    private struct MARGINS
    {
        public int CxLeftWidth;
        public int CxRightWidth;
        public int CyTopHeight;
        public int CyBottomHeight;
    }

    public int Width = 400;
    public int Height = 400;

    public Material Material;

    //public TextMesh Text;

    private static readonly System.IntPtr HWND_TOPMOST = new System.IntPtr(-1);
    private static readonly System.IntPtr HWND_NOT_TOPMOST = new System.IntPtr(-2);
    private static readonly System.UInt32 SWP_SHOWWINDOW = 0x0040;

    // Definitions of window styles
    private static int GWL_STYLE = -16;
    private static uint WS_POPUP = 0x80000000;
    private static uint WS_VISIBLE = 0x10000000;
            
    private static int GWL_EXSTYLE = -20;
    private static uint WS_EX_LAYERED = 0x80000;
    private static uint WS_EX_TRANSPARENT = 0x20;

    private int XPosition = 0;
    private int YPosition = 0;

    private Vector2 lastPosition;
    private Vector2 offset;

    // Define function signatures to import from Windows APIs
    [DllImport("user32.dll")]
    private static extern IntPtr GetActiveWindow();

    [DllImport("user32.dll")]
    private static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

    [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
    private static extern bool SetWindowPos(IntPtr hwnd, IntPtr hWndInsertAfter, int x, int Y, int cx, int cy, uint wFlags);

    [DllImport("Dwmapi.dll")]
    private static extern uint DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS margins);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern System.IntPtr FindWindow(String lpClassName, String lpWindowName);
    
    private void Start()
    {
        Resolution resolution = Screen.resolutions[Screen.resolutions.Length - 1];

        this.XPosition = resolution.width - this.Width * 2;
        this.YPosition = resolution.height - this.Height * 2;

#if !UNITY_EDITOR
        this.SetWindowStats();
        this.SetWindowPosition();
#endif
    }

    private void SetWindowStats()
    {
        var margins = new MARGINS() { CxLeftWidth = -1 };
 
        IntPtr hwnd = TransparentWindow.GetActiveWindow();
        
        TransparentWindow.SetWindowLong(hwnd, GWL_STYLE, WS_POPUP | WS_VISIBLE);
        ////TransparentWindow.SetWindowLong(hwnd, GWL_EXSTYLE, WS_EX_LAYERED | WS_EX_TRANSPARENT);

        TransparentWindow.DwmExtendFrameIntoClientArea(hwnd, ref margins);
    }

    private void SetWindowPosition()
    {
        IntPtr hwnd = TransparentWindow.GetActiveWindow();

        Resolution resolution = Screen.resolutions[Screen.resolutions.Length - 1];

        int x = this.XPosition + this.Width;
        int relativeWidth = (Mathf.RoundToInt(x / resolution.width) + 1) * resolution.width - this.Width;
        if (relativeWidth - 10 < x && x < relativeWidth + 10)
        {
            this.offset.x = x - relativeWidth;
            x = relativeWidth;
        }

        int y = this.YPosition + this.Height;
        int relativeHeight = resolution.height - this.Height;
        if (relativeHeight - 10 < y && y < relativeHeight + 10)
        {
            this.offset.y = relativeHeight - y;
            y = relativeHeight;
        }
        else
        {
            relativeHeight -= 30;
            if (relativeHeight - 10 < y && y < relativeHeight + 10)
            {
                this.offset.y = relativeHeight - y;
                y = relativeHeight;
            }
        }

        //this.Text.text = "(" + relativeWidth + ";" + relativeHeight + ") => (" + x + ";" + y + ")";

        TransparentWindow.SetWindowPos(hwnd, HWND_TOPMOST, x, y, this.Width, this.Height, SWP_SHOWWINDOW);
    }

#if !UNITY_EDITOR
    private void OnRenderImage(RenderTexture from, RenderTexture to)
    {
        UnityEngine.Graphics.Blit(from, to, this.Material);
    }  
#endif

    private void LateUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            float xDifference = Input.mousePosition.x - this.lastPosition.x;
            float yDifference = Input.mousePosition.y - this.lastPosition.y;

            this.XPosition += Mathf.RoundToInt(xDifference - this.offset.x);
            this.YPosition -= Mathf.RoundToInt(yDifference - this.offset.y);

            this.offset.x -= xDifference;
            this.offset.y -= yDifference;

#if !UNITY_EDITOR
            this.SetWindowPosition();
#endif
        }

        this.lastPosition = Input.mousePosition;
    }

}