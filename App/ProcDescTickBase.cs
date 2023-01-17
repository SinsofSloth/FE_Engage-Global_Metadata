// Namespace: App
public abstract class ProcDescTickBase : ProcDesc // TypeDefIndex: 13871
{
	// Methods

	// RVA: 0x29E24B0 Offset: 0x29E25B1 VA: 0x29E24B0
	public void .ctor(ProcDesc.Type type) { }

	// RVA: 0x29E2A00 Offset: 0x29E2B01 VA: 0x29E2A00 Slot: 4
	public override ProcDesc.Result Execute(ProcInst inst) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void ExecuteImpl(ProcInst inst);
}

