using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class CSVReader
{

	static string LINE_SPLIT_RE = @"\n"; // new line || new tab
    
	public static List<string> Read( string file )
	{
        // The final list empty
        List<string> list = new List<string>();

        // Transform the file (string) into a data (TextAsset) file
        TextAsset data = Resources.Load (file) as TextAsset;

        // Split the text into a array of string depenting of LINE_SPLIT_RE
        string[] lines = Regex.Split (data.text, LINE_SPLIT_RE);

        foreach(string _line in lines)
        {
            list.Add(_line);
        }

		return list;
	}
}