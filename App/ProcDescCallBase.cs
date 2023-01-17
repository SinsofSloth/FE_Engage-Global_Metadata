// Namespace: App
public abstract class ProcDescCallBase : ProcDesc // TypeDefIndex: 13870
{
	// Methods

	// RVA: 0x29E1C70 Offset: 0x29E1D71 VA: 0x29E1C70
	public void .ctor(ProcDesc.Type type) { }

	// RVA: 0x29E2070 Offset: 0x29E2171 VA: 0x29E2070 Slot: 4
	public override ProcDesc.Result Execute(ProcInst inst) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void ExecuteImpl(ProcInst inst);
}

