using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Collections;

namespace UGUIControls
{
	/// <summary>
	/// Gesture recognizers recognize a discrete event such as a tap or a swipe but don’t report changes within the gesture. In other words, discrete gestures don’t transition through the Began and Changed states and they can’t fail or be cancelled.
	/// </summary>
	public enum GestureRecognizerState
	{
		/// <summary>
		/// The gesture recognizer has not yet recognized its gesture, but may be evaluating touch events. This is the default state.
		/// </summary>
		Possible,
		/// <summary>
		/// The gesture recognizer has received touch objects recognized as a continuous gesture. It sends its action message (or messages) at the next cycle of the run loop.
		/// </summary>
		Began,
		/// <summary>
		/// The gesture recognizer has received touches recognized as a change to a continuous gesture. It sends its action message (or messages) at the next cycle of the run loop.
		/// </summary>
		Changed,
		/// <summary>
		/// The gesture recognizer has received touches recognized as the end of a continuous gesture. It sends its action message (or messages) at the next cycle of the run loop and resets its state to GestureRecognizerStatePossible.
		/// </summary>
		Ended,
		/// <summary>
		/// The gesture recognizer has received touches resulting in the cancellation of a continuous gesture. It sends its action message (or messages) at the next cycle of the run loop and resets its state to GestureRecognizerStatePossible.
		/// </summary>
		Cancelled,
		/// <summary>
		/// The gesture recognizer has received a multi-touch sequence that it cannot recognize as its gesture. No action message is sent and the gesture recognizer is reset to GestureRecognizerStatePossible.
		/// </summary>
		Failed,
	}
	
	public class GestureRecognizer : MonoBehaviour
	{
		public Action<GestureRecognizer> HandleGesture;
		
		/// <summary>
		/// The current state of the gesture recognizer. (read-only)
		/// </summary>
		public GestureRecognizerState state;
	}

}

