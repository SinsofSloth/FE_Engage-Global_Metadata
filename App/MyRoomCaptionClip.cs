// Namespace: App
[Serializable]
public abstract class MyRoomCaptionClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 11388
{
	// Fields
	[SerializeField] // RVA: 0x297D10 Offset: 0x297E11 VA: 0x297D10
	public MyRoomCaptionMID Template; // 0x18

	// Properties
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0x282A330 Offset: 0x282A431 VA: 0x282A330 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x282A340 Offset: 0x282A441 VA: 0x282A340 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x282A400 Offset: 0x282A501 VA: 0x282A400
	protected void .ctor() { }
}

