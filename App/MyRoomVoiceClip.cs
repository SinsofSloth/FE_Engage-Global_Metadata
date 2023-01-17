// Namespace: App
[Serializable]
public abstract class MyRoomVoiceClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 11408
{
	// Fields
	[SerializeField] // RVA: 0x297D70 Offset: 0x297E71 VA: 0x297D70
	public GameSound.WakeupVoiceSituation VoiceSituation; // 0x18

	// Properties
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0x28407F0 Offset: 0x28408F1 VA: 0x28407F0 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x2840800 Offset: 0x2840901 VA: 0x2840800 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x2840900 Offset: 0x2840A01 VA: 0x2840900
	protected void .ctor() { }
}

