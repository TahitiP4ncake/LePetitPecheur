using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public Transform HorizontallyRotatedItem;
	public Transform VerticallyRotatedItem;

	public float MinX, MaxX;
	public float SensitivityX, SensitivityY;

	private Vector2 lastPosition;


	// Use this for initialization
	void Start () {
		Application.runInBackground = true;

	}
	
	// Update is called once per frame
	void Update () {

		if ( Input.GetKeyDown(KeyCode.Escape) )
		{
			Application.Quit();
		}

		if ( Input.GetMouseButton(2) )
		{
			UpdateCamera();
		}

		lastPosition = Input.mousePosition;
	}


	private void UpdateCamera( )
	{
		// X
		float xDifference = Input.mousePosition.x - this.lastPosition.x;
		this.VerticallyRotatedItem.eulerAngles += Vector3.up * xDifference * this.SensitivityX;

		// Y
		float yDifference = Input.mousePosition.y - this.lastPosition.y;
		float angle = this.HorizontallyRotatedItem.localEulerAngles.x;
		if ( angle > 180 )
		{
			angle -= 360;
		}

		angle += yDifference * this.SensitivityY;
		angle = Mathf.Clamp(angle, this.MinX, this.MaxX);

		this.HorizontallyRotatedItem.localEulerAngles = new Vector3(angle, 0, 0);
	}

}
