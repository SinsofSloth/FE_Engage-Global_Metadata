// Namespace: Combat
public abstract class ActionDisposerHolder : ActionBase // TypeDefIndex: 8421
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27FDC0 Offset: 0x27FEC1 VA: 0x27FDC0
	private CompositeDisposable <m_ActionDisposer>k__BackingField; // 0x28

	// Properties
	protected CompositeDisposable m_ActionDisposer { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A8630 Offset: 0x2A8731 VA: 0x2A8630
	// RVA: 0x2EC4D80 Offset: 0x2EC4E81 VA: 0x2EC4D80
	protected CompositeDisposable get_m_ActionDisposer() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8640 Offset: 0x2A8741 VA: 0x2A8640
	// RVA: 0x2EC4D90 Offset: 0x2EC4E91 VA: 0x2EC4D90
	private void set_m_ActionDisposer(CompositeDisposable value) { }

	// RVA: 0x2EC4DA0 Offset: 0x2EC4EA1 VA: 0x2EC4DA0
	protected void .ctor(Character chr, Phase phase) { }

	// RVA: 0x2EC4E50 Offset: 0x2EC4F51 VA: 0x2EC4E50 Slot: 9
	public override void OnExit() { }

	// RVA: 0x2EC4E60 Offset: 0x2EC4F61 VA: 0x2EC4E60 Slot: 10
	public override void Dispose() { }
}

