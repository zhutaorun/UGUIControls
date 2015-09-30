using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Collections;

namespace UGUIControls
{
	public class LongPressGestureRecognizer : GestureRecognizer, IPointerDownHandler, IPointerUpHandler, IDragHandler
	{
		/// <summary>
		/// The minimum period fingers must press on the view for the gesture to be recognized.
		/// </summary>
		public float minimumPressDuration = 0.5f;
		/// <summary>
		/// The number of fingers that must be pressed on the view for the gesture to be recognized.
		/// </summary>
		public int numberOfTouchesRequired = 1;
		/// <summary>
		/// The number of taps on the view required for the gesture to be recognized.
		/// </summary>
		public int numberOfTapsRequired = 0;
		/// <summary>
		/// The maximum movement of the fingers on the view before the gesture fails.
		/// </summary>
		public float allowableMovement = 10;
		bool isPressed;

		IEnumerator DelayLongPress ()
		{
			yield return new WaitForSeconds (minimumPressDuration);
			if (isPressed) {
				if (HandleGesture != null) {
					HandleGesture (this);
				}
			}
		}

		public void OnPointerDown (PointerEventData eventData)
		{
			isPressed = true;
			StartCoroutine (DelayLongPress ());

		}
	
		public void OnPointerUp (PointerEventData eventData)
		{
			isPressed = false;
			state = GestureRecognizerState.Possible;
		}

		public void OnDrag (PointerEventData eventData)
		{
			if (isPressed) {
				if ((eventData.pressPosition - eventData.position).magnitude > allowableMovement) {
					isPressed = false;
				}
			}
		}
	}
}
