// Namespace: 
public class AkTimelineEventPlayable : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 7978
{
	// Fields
	public Event akEvent; // 0x18
	[SerializeField] // RVA: 0x27E540 Offset: 0x27E641 VA: 0x27E540
	private AkCurveInterpolation blendInCurve; // 0x20
	[SerializeField] // RVA: 0x27E550 Offset: 0x27E651 VA: 0x27E550
	private AkCurveInterpolation blendOutCurve; // 0x24
	public float eventDurationMax; // 0x28
	public float eventDurationMin; // 0x2C
	public TimelineClip owningClip; // 0x30
	[SerializeField] // RVA: 0x27E560 Offset: 0x27E661 VA: 0x27E560
	private bool retriggerEvent; // 0x38
	public bool UseWwiseEventDuration; // 0x39
	public bool PrintDebugInformation; // 0x3A
	[SerializeField] // RVA: 0x27E570 Offset: 0x27E671 VA: 0x27E570
	private bool StopEventAtClipEnd; // 0x3B

	// Properties
	private ClipCaps UnityEngine.Timeline.ITimelineClipAsset.clipCaps { get; }

	// Methods

	// RVA: 0x20DA7E0 Offset: 0x20DA8E1 VA: 0x20DA7E0 Slot: 9
	private ClipCaps UnityEngine.Timeline.ITimelineClipAsset.get_clipCaps() { }

	// RVA: 0x20DA7F0 Offset: 0x20DA8F1 VA: 0x20DA7F0 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x20DAA00 Offset: 0x20DAB01 VA: 0x20DAA00
	public void .ctor() { }
}

