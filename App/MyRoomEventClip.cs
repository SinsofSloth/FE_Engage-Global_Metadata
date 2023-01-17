// Namespace: App
[Serializable]
public abstract class MyRoomEventClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 11395
{
	// Fields
	[SerializeField] // RVA: 0x297D20 Offset: 0x297E21 VA: 0x297D20
	public MyRoomEventClip.EventClipType eventType; // 0x18
	[SerializeField] // RVA: 0x297D30 Offset: 0x297E31 VA: 0x297D30
	public MyRoomEventClip.EventClipLayer eventLayer; // 0x1C
	[SerializeField] // RVA: 0x297D40 Offset: 0x297E41 VA: 0x297D40
	public string eventName; // 0x20
	[SerializeField] // RVA: 0x297D50 Offset: 0x297E51 VA: 0x297D50
	public bool isOut; // 0x28

	// Properties
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0x282C5F0 Offset: 0x282C6F1 VA: 0x282C5F0 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x282C600 Offset: 0x282C701 VA: 0x282C600 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x282C720 Offset: 0x282C821 VA: 0x282C720
	protected void .ctor() { }
}

