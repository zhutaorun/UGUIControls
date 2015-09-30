using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Collections;

namespace UGUIControls
{
	public class TapGestureRecognizer : GestureRecognizer , IPointerClickHandler
	{
		/// <summary>
		/// The number of taps for the gesture to be recognized.
		/// </summary>
		public int numberOfTapsRequired = 1;

		/// <summary>
		/// The number of fingers required to tap for the gesture to be recognized.
		/// </summary>
		public int numberOfTouchesRequired = 1;

		public void OnPointerClick (PointerEventData eventData)
		{
			if (HandleGesture != null) {
				HandleGesture (this);
			}
		}
	}

}
