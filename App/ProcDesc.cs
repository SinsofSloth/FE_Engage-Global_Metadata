// Namespace: App
public abstract class ProcDesc // TypeDefIndex: 13869
{
	// Fields
	protected ProcDesc.Type m_Type; // 0x10

	// Properties
	public ProcDesc.Type DescType { get; }
	public virtual int Label { get; }
	public virtual ProcVoidMethod Persistent { get; }

	// Methods

	// RVA: 0x29E1C00 Offset: 0x29E1D01 VA: 0x29E1C00
	public void .ctor(ProcDesc.Type type) { }

	// RVA: 0x29E1C30 Offset: 0x29E1D31 VA: 0x29E1C30 Slot: 4
	public virtual ProcDesc.Result Execute(ProcInst inst) { }

	// RVA: 0x29E1C40 Offset: 0x29E1D41 VA: 0x29E1C40
	public ProcDesc.Type get_DescType() { }

	// RVA: 0x29E1C50 Offset: 0x29E1D51 VA: 0x29E1C50 Slot: 5
	public virtual int get_Label() { }

	// RVA: 0x29E1C60 Offset: 0x29E1D61 VA: 0x29E1C60 Slot: 6
	public virtual ProcVoidMethod get_Persistent() { }
}

