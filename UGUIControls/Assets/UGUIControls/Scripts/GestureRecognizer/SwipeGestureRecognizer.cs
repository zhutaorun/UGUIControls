using UnityEngine;
using System.Collections;

public enum SwipeGestureRecognizerDirection
{
	/// <summary>
	/// The touch or touches swipe to the right. This direction is the default.
	/// </summary>
	Right,

	/// <summary>
	/// The touch or touches swipe to the left.
	/// </summary>
	Left,

	/// <summary>
	/// The touch or touches swipe upward.
	/// </summary>
	Up,
		
	/// <summary>
	/// he touch or touches swipe downward.
	/// </summary>
	Down,
}

public class SwipeGestureRecognizer : GestureRecognizer
{
	/// <summary>
	/// The permitted direction of the swipe for this gesture recognizer.
	/// </summary>
	public SwipeGestureRecognizerDirection direction = SwipeGestureRecognizerDirection.Right;

	/// <summary>
	/// The number of touches that must be present for the swipe gesture to be recognized.
	/// </summary>
	public int numberOfTouchesRequired = 1;



}
