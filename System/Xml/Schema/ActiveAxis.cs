// Namespace: System.Xml.Schema
internal class ActiveAxis // TypeDefIndex: 1791
{
	// Fields
	private int currentDepth; // 0x10
	private bool isActive; // 0x14
	private Asttree axisTree; // 0x18
	private ArrayList axisStack; // 0x20

	// Properties
	public int CurrentDepth { get; }

	// Methods

	// RVA: 0x1A20370 Offset: 0x1A20471 VA: 0x1A20370
	public int get_CurrentDepth() { }

	// RVA: 0x1A20380 Offset: 0x1A20481 VA: 0x1A20380
	internal void Reactivate() { }

	// RVA: 0x1A203A0 Offset: 0x1A204A1 VA: 0x1A203A0
	internal void .ctor(Asttree axisTree) { }

	// RVA: 0x1A206B0 Offset: 0x1A207B1 VA: 0x1A206B0
	public bool MoveToStartElement(string localname, string URN) { }

	// RVA: 0x1A209F0 Offset: 0x1A20AF1 VA: 0x1A209F0 Slot: 4
	public virtual bool EndElement(string localname, string URN) { }

	// RVA: 0x1A20CD0 Offset: 0x1A20DD1 VA: 0x1A20CD0
	public bool MoveToAttribute(string localname, string URN) { }
}

