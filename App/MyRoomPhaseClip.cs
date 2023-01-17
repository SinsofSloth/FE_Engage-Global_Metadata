// Namespace: App
[Serializable]
public abstract class MyRoomPhaseClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 11404
{
	// Fields
	public GameSound.WakeupVoiceSituation Situation; // 0x18

	// Properties
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0x28309A0 Offset: 0x2830AA1 VA: 0x28309A0 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x28309B0 Offset: 0x2830AB1 VA: 0x28309B0 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x2830AA0 Offset: 0x2830BA1 VA: 0x2830AA0
	protected void .ctor() { }
}

