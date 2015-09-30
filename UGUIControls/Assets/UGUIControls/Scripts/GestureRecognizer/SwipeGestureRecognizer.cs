using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Collections;

namespace UGUIControls
{
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

	public class SwipeGestureRecognizer : GestureRecognizer,IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		/// <summary>
		/// The permitted direction of the swipe for this gesture recognizer.
		/// </summary>
		public SwipeGestureRecognizerDirection direction = SwipeGestureRecognizerDirection.Right;
	
		/// <summary>
		/// The number of touches that must be present for the swipe gesture to be recognized.
		/// </summary>
		public int numberOfTouchesRequired = 1;

		public void OnBeginDrag (PointerEventData eventData)
		{
			state = GestureRecognizerState.Began;
			
		}
		
		public void OnDrag (PointerEventData eventData)
		{
			state = GestureRecognizerState.Changed;
			
		}
		
		public void OnEndDrag (PointerEventData eventData)
		{
			state = GestureRecognizerState.Ended;			

			float deltaX = eventData.position.x - eventData.pressPosition.x;
			float deltaY = eventData.position.y - eventData.pressPosition.y;

			float absX = Math.Abs (deltaX);
			float absY = Math.Abs (deltaY);

			if (absX > absY) {
				if (deltaX > 0) {
					direction = SwipeGestureRecognizerDirection.Right;
				} else {
					direction = SwipeGestureRecognizerDirection.Left;
				}
			} else {
				if (deltaY > 0) {
					direction = SwipeGestureRecognizerDirection.Up;
				} else {
					direction = SwipeGestureRecognizerDirection.Down;
				}
			}

			if (HandleGesture != null) {
				HandleGesture(this);
			}
			state = GestureRecognizerState.Possible;
		}
	}
}
