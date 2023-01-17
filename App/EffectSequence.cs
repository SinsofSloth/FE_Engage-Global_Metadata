// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x276100 Offset: 0x276201 VA: 0x276100
public class EffectSequence : StructData<EffectSequence> // TypeDefIndex: 9883
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x289FE0 Offset: 0x28A0E1 VA: 0x289FE0
	private string <Sequence>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x289FF0 Offset: 0x28A0F1 VA: 0x289FF0
	private string <Active>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28A000 Offset: 0x28A101 VA: 0x28A000
	private string <Shoot>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28A010 Offset: 0x28A111 VA: 0x28A010
	private string <Hit>k__BackingField; // 0x38
	private EffectData[] m_Effects; // 0x40

	// Properties
	public string Sequence { get; set; }
	public string Active { get; set; }
	public string Shoot { get; set; }
	public string Hit { get; set; }

	// Methods

	// RVA: 0x25F3370 Offset: 0x25F3471 VA: 0x25F3370
	public static void Load() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5E60 Offset: 0x2B5F61 VA: 0x2B5E60
	// RVA: 0x25F3420 Offset: 0x25F3521 VA: 0x25F3420
	public string get_Sequence() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5E70 Offset: 0x2B5F71 VA: 0x2B5E70
	// RVA: 0x25F3430 Offset: 0x25F3531 VA: 0x25F3430
	private void set_Sequence(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5E80 Offset: 0x2B5F81 VA: 0x2B5E80
	// RVA: 0x25F3440 Offset: 0x25F3541 VA: 0x25F3440
	public string get_Active() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5E90 Offset: 0x2B5F91 VA: 0x2B5E90
	// RVA: 0x25F3450 Offset: 0x25F3551 VA: 0x25F3450
	private void set_Active(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5EA0 Offset: 0x2B5FA1 VA: 0x2B5EA0
	// RVA: 0x25F3460 Offset: 0x25F3561 VA: 0x25F3460
	public string get_Shoot() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5EB0 Offset: 0x2B5FB1 VA: 0x2B5EB0
	// RVA: 0x25F3470 Offset: 0x25F3571 VA: 0x25F3470
	private void set_Shoot(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5EC0 Offset: 0x2B5FC1 VA: 0x2B5EC0
	// RVA: 0x25F3480 Offset: 0x25F3581 VA: 0x25F3480
	public string get_Hit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B5ED0 Offset: 0x2B5FD1 VA: 0x2B5ED0
	// RVA: 0x25F3490 Offset: 0x25F3591 VA: 0x25F3490
	private void set_Hit(string value) { }

	// RVA: 0x25F34A0 Offset: 0x25F35A1 VA: 0x25F34A0
	public EffectData GetData(EffectSequence.Kind kind) { }

	// RVA: 0x25F34E0 Offset: 0x25F35E1 VA: 0x25F34E0
	public void PlaySequence(EffectData.Modes mode, GameObject parent, Vector3 position) { }

	// RVA: 0x25F3570 Offset: 0x25F3671 VA: 0x25F3570
	public void PlaySequence(EffectData.Modes mode, GameObject parent, Vector3 position, Quaternion rotation) { }

	// RVA: 0x25F3800 Offset: 0x25F3901 VA: 0x25F3800
	public void PlayShoot(EffectData.Modes mode, GameObject parent) { }

	// RVA: 0x25F3770 Offset: 0x25F3871 VA: 0x25F3770
	private ResourceObject PlayImpl(EffectSequence.Kind kind, EffectData.Modes mode, GameObject parent, ref float delayTime) { }

	// RVA: 0x25F38E0 Offset: 0x25F39E1 VA: 0x25F38E0
	private EffectData TryGetData(string name) { }

	// RVA: 0x25F3980 Offset: 0x25F3A81 VA: 0x25F3980 Slot: 4
	public override void OnBuild() { }

	// RVA: 0x25F3C70 Offset: 0x25F3D71 VA: 0x25F3C70
	public void .ctor() { }
}

