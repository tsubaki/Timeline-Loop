using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class LoopClip : PlayableAsset, ITimelineClipAsset
{
	public ClipCaps clipCaps {
		get { return ClipCaps.None; }
	}

	public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
	{
		var playable = ScriptPlayable<LoopBehaviour>.Create (graph);
		LoopBehaviour beheviour = playable.GetBehaviour ();
		beheviour.director = owner.GetComponent<PlayableDirector> ();
		beheviour.waitTimeline = owner.GetComponent<WaitTimeline> ();
		return playable;
	}
}
