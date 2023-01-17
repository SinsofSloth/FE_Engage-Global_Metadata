// Namespace: System
[AttributeUsageAttribute] // RVA: 0x470740 Offset: 0x470841 VA: 0x470740
[ComVisibleAttribute] // RVA: 0x470740 Offset: 0x470841 VA: 0x470740
[Serializable]
public sealed class ObsoleteAttribute : Attribute // TypeDefIndex: 284
{
	// Fields
	private string _message; // 0x10
	private bool _error; // 0x18

	// Properties
	public string Message { get; }

	// Methods

	// RVA: 0x38105C0 Offset: 0x38106C1 VA: 0x38105C0
	public void .ctor() { }

	// RVA: 0x3810600 Offset: 0x3810701 VA: 0x3810600
	public void .ctor(string message) { }

	// RVA: 0x3810640 Offset: 0x3810741 VA: 0x3810640
	public void .ctor(string message, bool error) { }

	// RVA: 0x3810690 Offset: 0x3810791 VA: 0x3810690
	public string get_Message() { }
}

