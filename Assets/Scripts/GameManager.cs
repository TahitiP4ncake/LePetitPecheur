using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //public GameObject pecheur;

	private Vector2 lastPosition;

    private List<string> messages = new List<string>();

	// Use this for initialization
	void Start () {

		Application.runInBackground = true;

        messages = CSVReader.Read("Messages");

    }
	
	// Update is called once per frame
	void Update () {

		if ( Input.GetKeyDown(KeyCode.Escape) )
		{
			Application.Quit();
		}
}



}
