// Namespace: App
public abstract class ProcDescJumpFunc : ProcDesc // TypeDefIndex: 13895
{
	// Fields
	private int m_Label; // 0x14

	// Properties
	public override int Label { get; }

	// Methods

	// RVA: 0x29E2100 Offset: 0x29E2201 VA: 0x29E2100
	public void .ctor(int label) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool IsJump(ProcInst inst);

	// RVA: 0x29E2150 Offset: 0x29E2251 VA: 0x29E2150 Slot: 4
	public override ProcDesc.Result Execute(ProcInst inst) { }

	// RVA: 0x29E2180 Offset: 0x29E2281 VA: 0x29E2180 Slot: 5
	public override int get_Label() { }
}

