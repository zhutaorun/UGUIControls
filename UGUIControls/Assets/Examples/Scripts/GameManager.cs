using UnityEngine;
using System;
using System.Collections;
using UGUIControls;

public class GameManager : MonoBehaviour
{
	public TapGestureRecognizer tapGestureRecognizer;
	public PanGestureRecognizer panGestureRecognizer;
	public LongPressGestureRecognizer longPressGestureRecognizer;
	public SwipeGestureRecognizer swipeGestureRecognizer;
	public PinchGestureRecognizer pinchGestureRecognizer;
	public RotateGestureRecognizer rotateGestureRecognizer;

	// Use this for initialization
	void Start ()
	{
		if (tapGestureRecognizer != null) {
			tapGestureRecognizer.HandleGesture = (GestureRecognizer sender) => {
				Debug.Log ("Tap!");
			};
		}

		if (panGestureRecognizer != null) {
			panGestureRecognizer.HandleGesture = (GestureRecognizer sender) => {
				switch (sender.state) { 
				case GestureRecognizerState.Began:
					Debug.Log ("Pan Began");
					break;
				case GestureRecognizerState.Changed:
					Debug.Log ("Pan Changed");
					break;
				case GestureRecognizerState.Ended:
					Debug.Log ("Pan Ended");
					break;
				case GestureRecognizerState.Cancelled:
					break;
				}
			};
		}

		if (longPressGestureRecognizer != null) {
			longPressGestureRecognizer.HandleGesture = (GestureRecognizer sender) => {
				Debug.Log ("Long Pressed");
			};
		}

		if (swipeGestureRecognizer != null) {
			swipeGestureRecognizer.HandleGesture = (GestureRecognizer sender) => {
				SwipeGestureRecognizer swipe = sender as SwipeGestureRecognizer;
				switch(swipe.direction){
				case SwipeGestureRecognizerDirection.Left:
					Debug.Log("Swipe Left");
					break;
				case SwipeGestureRecognizerDirection.Right:
					Debug.Log("Swipe Right");
					break;
				case SwipeGestureRecognizerDirection.Up:
					Debug.Log("Swipe Up");
					break;
				case SwipeGestureRecognizerDirection.Down:
					Debug.Log("Swipe Down");
					break;
				}
			};
		}

		if (pinchGestureRecognizer != null) {
			pinchGestureRecognizer.HandleGesture = (GestureRecognizer sender) => {
			};
		}

		if (rotateGestureRecognizer != null) {
			rotateGestureRecognizer.HandleGesture = (GestureRecognizer sender) => {
			};
		}


	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
