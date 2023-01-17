// Namespace: App
[Serializable]
public class MyRoomVoiceBehaviour : PlayableBehaviour // TypeDefIndex: 11410
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x297D80 Offset: 0x297E81 VA: 0x297D80
	private GameSound.WakeupVoiceSituation <VoiceSituation>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x297D90 Offset: 0x297E91 VA: 0x297D90
	private string <EventName>k__BackingField; // 0x18

	// Properties
	public GameSound.WakeupVoiceSituation VoiceSituation { get; set; }
	private RelianceData.Level Level { get; }
	private GameSound.WakeupVoicePattern Pattern { get; }
	private Character Character { get; }
	private string VoiceID { get; }
	private string EventName { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C5710 Offset: 0x2C5811 VA: 0x2C5710
	// RVA: 0x283FE80 Offset: 0x283FF81 VA: 0x283FE80
	public GameSound.WakeupVoiceSituation get_VoiceSituation() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5720 Offset: 0x2C5821 VA: 0x2C5720
	// RVA: 0x283FE90 Offset: 0x283FF91 VA: 0x283FE90
	public void set_VoiceSituation(GameSound.WakeupVoiceSituation value) { }

	// RVA: 0x283FEA0 Offset: 0x283FFA1 VA: 0x283FEA0
	private RelianceData.Level get_Level() { }

	// RVA: 0x283FF20 Offset: 0x2840021 VA: 0x283FF20
	private GameSound.WakeupVoicePattern get_Pattern() { }

	// RVA: 0x283FFA0 Offset: 0x28400A1 VA: 0x283FFA0
	private Character get_Character() { }

	// RVA: 0x2840020 Offset: 0x2840121 VA: 0x2840020
	private string get_VoiceID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5730 Offset: 0x2C5831 VA: 0x2C5730
	// RVA: 0x28400E0 Offset: 0x28401E1 VA: 0x28400E0
	private string get_EventName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5740 Offset: 0x2C5841 VA: 0x2C5740
	// RVA: 0x28400F0 Offset: 0x28401F1 VA: 0x28400F0
	private void set_EventName(string value) { }

	// RVA: 0x2840100 Offset: 0x2840201 VA: 0x2840100 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x2840550 Offset: 0x2840651 VA: 0x2840550 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x28407E0 Offset: 0x28408E1 VA: 0x28407E0
	public void .ctor() { }
}

