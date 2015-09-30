using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Collections;

namespace UGUIControls
{
	public class RotateGestureRecognizer : GestureRecognizer
	{
		/// <summary>
		/// The rotation of the gesture in radians.
		/// </summary>
		public float rotation;

		/// <summary>
		/// The velocity of the rotation gesture in radians per second. (read-only)
		/// </summary>
		public float velocity;
	}
}
