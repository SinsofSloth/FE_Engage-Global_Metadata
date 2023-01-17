// Namespace: 
[ObsoleteAttribute] // RVA: 0x272450 Offset: 0x272551 VA: 0x272450
public class AkEventPlayable : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 8019
{
	// Fields
	public Event akEvent; // 0x18
	[SerializeField] // RVA: 0x27EBB0 Offset: 0x27ECB1 VA: 0x27EBB0
	private AkCurveInterpolation blendInCurve; // 0x20
	[SerializeField] // RVA: 0x27EBC0 Offset: 0x27ECC1 VA: 0x27EBC0
	private AkCurveInterpolation blendOutCurve; // 0x24
	[SerializeField] // RVA: 0x27EBD0 Offset: 0x27ECD1 VA: 0x27EBD0
	private ExposedReference<GameObject> emitterObjectRef; // 0x28
	public float eventDurationMax; // 0x38
	public float eventDurationMin; // 0x3C
	public TimelineClip owningClip; // 0x40
	[SerializeField] // RVA: 0x27EBE0 Offset: 0x27ECE1 VA: 0x27EBE0
	private bool retriggerEvent; // 0x48
	public bool UseWwiseEventDuration; // 0x49
	[SerializeField] // RVA: 0x27EBF0 Offset: 0x27ECF1 VA: 0x27EBF0
	private bool StopEventAtClipEnd; // 0x4A

	// Properties
	private ClipCaps UnityEngine.Timeline.ITimelineClipAsset.clipCaps { get; }

	// Methods

	// RVA: 0x3172EC0 Offset: 0x3172FC1 VA: 0x3172EC0 Slot: 9
	private ClipCaps UnityEngine.Timeline.ITimelineClipAsset.get_clipCaps() { }

	// RVA: 0x3172ED0 Offset: 0x3172FD1 VA: 0x3172ED0 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x3173180 Offset: 0x3173281 VA: 0x3173180
	public void .ctor() { }
}

