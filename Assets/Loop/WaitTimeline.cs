using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitTimeline : MonoBehaviour
{
	private bool _trigger;

	public bool trigger {
		get {
			#if UNITY_EDITOR
			if (UnityEditor.EditorApplication.isPlayingOrWillChangePlaymode == false)
				return true;
			#endif
			return _trigger;
		}
		set {
			_trigger = value;
		}
	}
}
