// Namespace: System
[CLSCompliantAttribute] // RVA: 0x470D40 Offset: 0x470E41 VA: 0x470D40
[ComVisibleAttribute] // RVA: 0x470D40 Offset: 0x470E41 VA: 0x470D40
public struct TypedReference // TypeDefIndex: 326
{
	// Fields
	private RuntimeTypeHandle type; // 0x0
	private IntPtr Value; // 0x8
	private IntPtr Type; // 0x10

	// Properties
	internal bool IsNull { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0x47AD20 Offset: 0x47AE21 VA: 0x47AD20
	// RVA: 0x3645F50 Offset: 0x3646051 VA: 0x3645F50
	public static TypedReference MakeTypedReference(object target, FieldInfo[] flds) { }

	// RVA: 0x3646350 Offset: 0x3646451 VA: 0x3646350
	private static TypedReference MakeTypedReferenceInternal(object target, FieldInfo[] fields) { }

	// RVA: 0x3646370 Offset: 0x3646471 VA: 0x3646370 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3646480 Offset: 0x3646581 VA: 0x3646480 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x36464E0 Offset: 0x36465E1 VA: 0x36464E0
	internal bool get_IsNull() { }

	[CLSCompliantAttribute] // RVA: 0x47AD40 Offset: 0x47AE41 VA: 0x47AD40
	// RVA: 0x3646530 Offset: 0x3646631 VA: 0x3646530
	public static void SetTypedReference(TypedReference target, object value) { }
}

