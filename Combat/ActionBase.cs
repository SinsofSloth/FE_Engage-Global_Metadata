// Namespace: Combat
public abstract class ActionBase : State // TypeDefIndex: 8420
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27FDA0 Offset: 0x27FEA1 VA: 0x27FDA0
	private Character <CP>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x27FDB0 Offset: 0x27FEB1 VA: 0x27FDB0
	private Phase <m_Phase>k__BackingField; // 0x20

	// Properties
	protected Character CP { get; set; }
	protected Phase m_Phase { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A85F0 Offset: 0x2A86F1 VA: 0x2A85F0
	// RVA: 0x2EC4360 Offset: 0x2EC4461 VA: 0x2EC4360
	protected Character get_CP() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8600 Offset: 0x2A8701 VA: 0x2A8600
	// RVA: 0x2EC4370 Offset: 0x2EC4471 VA: 0x2EC4370
	private void set_CP(Character value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8610 Offset: 0x2A8711 VA: 0x2A8610
	// RVA: 0x2EC4380 Offset: 0x2EC4481 VA: 0x2EC4380
	protected Phase get_m_Phase() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8620 Offset: 0x2A8721 VA: 0x2A8620
	// RVA: 0x2EC4390 Offset: 0x2EC4491 VA: 0x2EC4390
	private void set_m_Phase(Phase value) { }

	// RVA: 0x2EC43A0 Offset: 0x2EC44A1 VA: 0x2EC43A0
	protected void .ctor(Character chr, Phase phase) { }

	// RVA: 0x2EC3DA0 Offset: 0x2EC3EA1 VA: 0x2EC3DA0
	protected void SetPhaseForRush(Phase phase) { }
}

