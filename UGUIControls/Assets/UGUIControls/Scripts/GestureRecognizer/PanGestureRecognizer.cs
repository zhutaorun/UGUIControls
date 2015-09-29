using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Collections;

public class PanGestureRecognizer : GestureRecognizer ,IBeginDragHandler, IDragHandler, IEndDragHandler
{
	/// <summary>
	/// The maximum number of fingers that can be touching the view for this gesture to be recognized.
	/// </summary>
	public int maximumNumberOfTouches = int.MaxValue;

	/// <summary>
	/// The minimum number of fingers that can be touching the view for this gesture to be recognized.
	/// </summary>
	public int minimumNumberOfTouches = 1;

	public void OnBeginDrag (PointerEventData eventData)
	{
		if (HandleGesture != null) {
			HandleGesture (this);
		}
	}
	
	public void OnDrag (PointerEventData eventData)
	{
		if (HandleGesture != null) {
			HandleGesture (this);
		}
	}
	
	public void OnEndDrag (PointerEventData eventData)
	{
		if (HandleGesture != null) {
			HandleGesture (this);
		}
	}
	

}
