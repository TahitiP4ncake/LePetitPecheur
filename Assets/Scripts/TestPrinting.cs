using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


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
        PrintDialog printDlg = new PrintDialog();
        #endregion

        #region Create Document
        PrintDocument printDoc = new PrintDocument();
        printDoc.DocumentName = "Print Document";
        printDoc.PrintPage += printDoc_PrintPage;
        printDlg.Document = printDoc;
        #endregion

        if (printDlg.ShowDialog() == DialogResult.OK)
            printDoc.Print();
    }

    void printDoc_PrintPage(object sender, PrintPageEventArgs e)
    {
        e.Graphics.DrawString(this.textBox1.Text, this.textBox1.Font, Brushes.Black, 10, 25);
    }
}
