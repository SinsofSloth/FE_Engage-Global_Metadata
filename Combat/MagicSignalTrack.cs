// Namespace: Combat
[Serializable]
public sealed class MagicSignalTrack // TypeDefIndex: 8786
{
	// Fields
	private string m_Title; // 0x10
	private string m_Help; // 0x18
	private bool m_IsSubBullet; // 0x20
	public List<MagicSignal> Signals; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x284510 Offset: 0x284611 VA: 0x284510
	private float <EndTime>k__BackingField; // 0x30

	// Properties
	public float EndTime { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2ACC00 Offset: 0x2ACD01 VA: 0x2ACC00
	// RVA: 0x1F97360 Offset: 0x1F97461 VA: 0x1F97360
	public float get_EndTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACC10 Offset: 0x2ACD11 VA: 0x2ACC10
	// RVA: 0x1F97370 Offset: 0x1F97471 VA: 0x1F97370
	private void set_EndTime(float value) { }

	// RVA: 0x1F94570 Offset: 0x1F94671 VA: 0x1F94570
	public void .ctor(string title, string help, bool isSubBullet) { }

	// RVA: 0x1F97380 Offset: 0x1F97481 VA: 0x1F97380
	public MagicSignal Find(MagicCommand cmd) { }
}

