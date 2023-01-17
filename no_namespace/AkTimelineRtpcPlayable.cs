// Namespace: 
public class AkTimelineRtpcPlayable : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 7981
{
	// Fields
	public RTPC RTPC; // 0x18
	public bool setGlobally; // 0x20
	public AkTimelineRtpcPlayableBehaviour template; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x27E5C0 Offset: 0x27E6C1 VA: 0x27E5C0
	private TimelineClip <owningClip>k__BackingField; // 0x30

	// Properties
	public TimelineClip owningClip { get; set; }
	private ClipCaps UnityEngine.Timeline.ITimelineClipAsset.clipCaps { get; }

	// Methods

	// RVA: 0x20DCAE0 Offset: 0x20DCBE1 VA: 0x20DCAE0
	public void SetupClipDisplay() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7160 Offset: 0x2A7261 VA: 0x2A7160
	// RVA: 0x20DCAF0 Offset: 0x20DCBF1 VA: 0x20DCAF0
	public TimelineClip get_owningClip() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7170 Offset: 0x2A7271 VA: 0x2A7170
	// RVA: 0x20DCB00 Offset: 0x20DCC01 VA: 0x20DCB00
	public void set_owningClip(TimelineClip value) { }

	// RVA: 0x20DCB10 Offset: 0x20DCC11 VA: 0x20DCB10 Slot: 9
	private ClipCaps UnityEngine.Timeline.ITimelineClipAsset.get_clipCaps() { }

	// RVA: 0x20DCB20 Offset: 0x20DCC21 VA: 0x20DCB20 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject) { }

	// RVA: 0x20DCC50 Offset: 0x20DCD51 VA: 0x20DCC50
	public void .ctor() { }
}

