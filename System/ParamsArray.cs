// Namespace: System
[DefaultMemberAttribute] // RVA: 0x470840 Offset: 0x470941 VA: 0x470840
internal struct ParamsArray // TypeDefIndex: 289
{
	// Fields
	private static readonly object[] oneArgArray; // 0x0
	private static readonly object[] twoArgArray; // 0x8
	private static readonly object[] threeArgArray; // 0x10
	private readonly object arg0; // 0x0
	private readonly object arg1; // 0x8
	private readonly object arg2; // 0x10
	private readonly object[] args; // 0x18

	// Properties
	public int Length { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x3819B80 Offset: 0x3819C81 VA: 0x3819B80
	public void .ctor(object arg0) { }

	// RVA: 0x3819C30 Offset: 0x3819D31 VA: 0x3819C30
	public void .ctor(object arg0, object arg1) { }

	// RVA: 0x3819CF0 Offset: 0x3819DF1 VA: 0x3819CF0
	public void .ctor(object arg0, object arg1, object arg2) { }

	// RVA: 0x3819DB0 Offset: 0x3819EB1 VA: 0x3819DB0
	public void .ctor(object[] args) { }

	// RVA: 0x3819E80 Offset: 0x3819F81 VA: 0x3819E80
	public int get_Length() { }

	// RVA: 0x3819E90 Offset: 0x3819F91 VA: 0x3819E90
	public object get_Item(int index) { }

	// RVA: 0x3819F00 Offset: 0x381A001 VA: 0x3819F00
	private object GetAtSlow(int index) { }

	// RVA: 0x3819F70 Offset: 0x381A071 VA: 0x3819F70
	private static void .cctor() { }
}

