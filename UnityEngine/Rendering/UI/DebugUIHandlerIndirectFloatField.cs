// Namespace: UnityEngine.Rendering.UI
public class DebugUIHandlerIndirectFloatField : DebugUIHandlerWidget // TypeDefIndex: 4712
{
	// Fields
	public Text nameLabel; // 0x58
	public Text valueLabel; // 0x60
	public Func<float> getter; // 0x68
	public Action<float> setter; // 0x70
	public Func<float> incStepGetter; // 0x78
	public Func<float> incStepMultGetter; // 0x80
	public Func<float> decimalsGetter; // 0x88

	// Methods

	// RVA: 0x1A0A1C0 Offset: 0x1A0A2C1 VA: 0x1A0A1C0
	public void Init() { }

	// RVA: 0x1A0A2F0 Offset: 0x1A0A3F1 VA: 0x1A0A2F0 Slot: 6
	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	// RVA: 0x1A0A350 Offset: 0x1A0A451 VA: 0x1A0A350 Slot: 7
	public override void OnDeselection() { }

	// RVA: 0x1A0A3A0 Offset: 0x1A0A4A1 VA: 0x1A0A3A0 Slot: 9
	public override void OnIncrement(bool fast) { }

	// RVA: 0x1A0A480 Offset: 0x1A0A581 VA: 0x1A0A480 Slot: 10
	public override void OnDecrement(bool fast) { }

	// RVA: 0x1A0A3B0 Offset: 0x1A0A4B1 VA: 0x1A0A3B0
	private void ChangeValue(bool fast, float multiplier) { }

	// RVA: 0x1A0A1D0 Offset: 0x1A0A2D1 VA: 0x1A0A1D0
	private void UpdateValueLabel() { }

	// RVA: 0x1A0A490 Offset: 0x1A0A591 VA: 0x1A0A490
	public void .ctor() { }
}

