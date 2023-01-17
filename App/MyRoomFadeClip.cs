// Namespace: App
[Serializable]
public abstract class MyRoomFadeClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 11399
{
	// Fields
	[SerializeField] // RVA: 0x297D60 Offset: 0x297E61 VA: 0x297D60
	public MyRoomFadeColor Template; // 0x18

	// Properties
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0x282D860 Offset: 0x282D961 VA: 0x282D860 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x282D870 Offset: 0x282D971 VA: 0x282D870 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x282D930 Offset: 0x282DA31 VA: 0x282D930
	protected void .ctor() { }
}

