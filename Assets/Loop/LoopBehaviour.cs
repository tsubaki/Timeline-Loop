using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class LoopBehaviour : PlayableBehaviour
{
	public PlayableDirector director { get; set; }

	public WaitTimeline waitTimeline { get; set; }

	public override void OnBehaviourPause (Playable playable, FrameData info)
	{
		if (waitTimeline.trigger == true) {
			waitTimeline.trigger = false;
			return;
		}

		Debug.Log (waitTimeline.trigger);
		director.time -= playable.GetDuration ();
	}
}
