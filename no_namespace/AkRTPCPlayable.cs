// Namespace: 
[ObsoleteAttribute] // RVA: 0x2726D0 Offset: 0x2727D1 VA: 0x2726D0
[Serializable]
public class AkRTPCPlayable : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 8034
{
	// Fields
	public bool overrideTrackObject; // 0x18
	public ExposedReference<GameObject> RTPCObject; // 0x20
	public bool setRTPCGlobally; // 0x30
	public AkRTPCPlayableBehaviour template; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x27EDD0 Offset: 0x27EED1 VA: 0x27EDD0
	private RTPC <Parameter>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x27EDE0 Offset: 0x27EEE1 VA: 0x27EDE0
	private TimelineClip <OwningClip>k__BackingField; // 0x48

	// Properties
	public RTPC Parameter { get; set; }
	public TimelineClip OwningClip { get; set; }
	private ClipCaps UnityEngine.Timeline.ITimelineClipAsset.clipCaps { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A72E0 Offset: 0x2A73E1 VA: 0x2A72E0
	// RVA: 0x3187660 Offset: 0x3187761 VA: 0x3187660
	public RTPC get_Parameter() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A72F0 Offset: 0x2A73F1 VA: 0x2A72F0
	// RVA: 0x3187670 Offset: 0x3187771 VA: 0x3187670
	public void set_Parameter(RTPC value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7300 Offset: 0x2A7401 VA: 0x2A7300
	// RVA: 0x3187680 Offset: 0x3187781 VA: 0x3187680
	public TimelineClip get_OwningClip() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7310 Offset: 0x2A7411 VA: 0x2A7310
	// RVA: 0x3187690 Offset: 0x3187791 VA: 0x3187690
	public void set_OwningClip(TimelineClip value) { }

	// RVA: 0x31876A0 Offset: 0x31877A1 VA: 0x31876A0 Slot: 9
	private ClipCaps UnityEngine.Timeline.ITimelineClipAsset.get_clipCaps() { }

	// RVA: 0x31876B0 Offset: 0x31877B1 VA: 0x31876B0 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x3187850 Offset: 0x3187951 VA: 0x3187850
	public void .ctor() { }
}

