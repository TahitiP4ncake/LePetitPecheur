using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;



public class TestPrinting : MonoBehaviour {

	// Use this for initialization
	void Start () {

        PrintTextBoxContent();


    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void PrintTextBoxContent()
    {
        #region Printer Selection
        //PrintDialog printDlg = new PrintDialog();
        #endregion

        #region Create Document
        PrintDocument printDoc = new PrintDocument();
        printDoc.PrintController = new System.Drawing.Printing.StandardPrintController();
        printDoc.DocumentName = "Print Document";
        printDoc.PrintPage += printDoc_PrintPage;
        //printDlg.Document = printDoc;
        #endregion
        printDoc.Print();
        //if (printDlg.ShowDialog() == DialogResult.OK)
            
    }

    void printDoc_PrintPage(object sender, PrintPageEventArgs e)
    {
        e.Graphics.DrawString("Hello, I work", new System.Drawing.Font("Arial", 20), Brushes.Black, 10, 25);
    }
}
