// Namespace: UnityEngine.Timeline
public class TimelinePlayable : PlayableBehaviour // TypeDefIndex: 5692
{
	// Fields
	private IntervalTree<RuntimeElement> m_IntervalTree; // 0x10
	private List<RuntimeElement> m_ActiveClips; // 0x18
	private List<RuntimeElement> m_CurrentListOfActiveClips; // 0x20
	private int m_ActiveBit; // 0x28
	private List<ITimelineEvaluateCallback> m_EvaluateCallbacks; // 0x30
	private Dictionary<TrackAsset, Playable> m_PlayableCache; // 0x38
	internal static bool muteAudioScrubbing; // 0x0

	// Methods

	// RVA: 0x36ACCE0 Offset: 0x36ACDE1 VA: 0x36ACCE0
	public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs) { }

	// RVA: 0x36B0BD0 Offset: 0x36B0CD1 VA: 0x36B0BD0
	public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs) { }

	// RVA: 0x36B0E50 Offset: 0x36B0F51 VA: 0x36B0E50
	private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs) { }

	// RVA: 0x36B1AB0 Offset: 0x36B1BB1 VA: 0x36B1AB0
	private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port) { }

	// RVA: 0x36B2130 Offset: 0x36B2231 VA: 0x36B2130
	private void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput) { }

	// RVA: 0x36B21D0 Offset: 0x36B22D1 VA: 0x36B21D0
	private static Playable CreatePlayableGraph(PlayableGraph graph, TrackAsset asset, GameObject go, IntervalTree<RuntimeElement> tree, Playable timelinePlayable) { }

	// RVA: 0x36B1640 Offset: 0x36B1741 VA: 0x36B1640
	private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs) { }

	// RVA: 0x36B25F0 Offset: 0x36B26F1 VA: 0x36B25F0 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x36B2630 Offset: 0x36B2731 VA: 0x36B2630
	private void Evaluate(Playable playable, FrameData frameData) { }

	// RVA: 0x36B2570 Offset: 0x36B2671 VA: 0x36B2570
	private void CacheTrack(TrackAsset track, Playable playable, int port, Playable parent) { }

	// RVA: 0x36B2CE0 Offset: 0x36B2DE1 VA: 0x36B2CE0
	public void .ctor() { }

	// RVA: 0x36B2E70 Offset: 0x36B2F71 VA: 0x36B2E70
	private static void .cctor() { }
}

