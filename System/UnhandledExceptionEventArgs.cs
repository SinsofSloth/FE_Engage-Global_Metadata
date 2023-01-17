// Namespace: System
[ComVisibleAttribute] // RVA: 0x470EA0 Offset: 0x470FA1 VA: 0x470EA0
[Serializable]
public class UnhandledExceptionEventArgs : EventArgs // TypeDefIndex: 333
{
	// Fields
	private object _Exception; // 0x10
	private bool _IsTerminating; // 0x18

	// Properties
	public object ExceptionObject { get; }
	public bool IsTerminating { get; }

	// Methods

	// RVA: 0x36519A0 Offset: 0x3651AA1 VA: 0x36519A0
	public void .ctor(object exception, bool isTerminating) { }

	[ReliabilityContractAttribute] // RVA: 0x47AF00 Offset: 0x47B001 VA: 0x47AF00
	// RVA: 0x3651A40 Offset: 0x3651B41 VA: 0x3651A40
	public object get_ExceptionObject() { }

	[ReliabilityContractAttribute] // RVA: 0x47AF20 Offset: 0x47B021 VA: 0x47AF20
	// RVA: 0x3651A50 Offset: 0x3651B51 VA: 0x3651A50
	public bool get_IsTerminating() { }
}

