// Namespace: App
public class EachInspector : MapInspector // TypeDefIndex: 12133
{
	// Fields
	protected int m_FromPerson; // 0x30
	protected int m_FromForce; // 0x34
	protected int m_ToPerson; // 0x38
	protected int m_ToForce; // 0x3C
	protected bool m_Both; // 0x40

	// Methods

	// RVA: 0x25EF270 Offset: 0x25EF371 VA: 0x25EF270
	public void .ctor(MapInspector.Kind kind, DynValue[] args) { }

	// RVA: 0x25EF3E0 Offset: 0x25EF4E1 VA: 0x25EF3E0
	protected bool IsEach(int fromPerson, int fromForce, int toPerson, int toForce) { }

	// RVA: 0x25EF4F0 Offset: 0x25EF5F1 VA: 0x25EF4F0 Slot: 9
	public override bool IsEanble(int fromPerson, int fromForce, int toPerson, int toForce) { }
}

