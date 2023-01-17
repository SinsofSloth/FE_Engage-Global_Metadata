// Namespace: UnityEngine.Rendering
[UsedByNativeCodeAttribute] // RVA: 0x4408F0 Offset: 0x4409F1 VA: 0x4408F0
public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor> // TypeDefIndex: 3898
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x444A20 Offset: 0x444B21 VA: 0x444A20
	[DebuggerBrowsableAttribute] // RVA: 0x444A20 Offset: 0x444B21 VA: 0x444A20
	private VertexAttribute <attribute>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x444A60 Offset: 0x444B61 VA: 0x444A60
	[DebuggerBrowsableAttribute] // RVA: 0x444A60 Offset: 0x444B61 VA: 0x444A60
	private VertexAttributeFormat <format>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x444AA0 Offset: 0x444BA1 VA: 0x444AA0
	[DebuggerBrowsableAttribute] // RVA: 0x444AA0 Offset: 0x444BA1 VA: 0x444AA0
	private int <dimension>k__BackingField; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x444AE0 Offset: 0x444BE1 VA: 0x444AE0
	[CompilerGeneratedAttribute] // RVA: 0x444AE0 Offset: 0x444BE1 VA: 0x444AE0
	private int <stream>k__BackingField; // 0xC

	// Properties
	public VertexAttribute attribute { get; set; }
	public VertexAttributeFormat format { get; set; }
	public int dimension { get; set; }
	public int stream { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x4530A0 Offset: 0x4531A1 VA: 0x4530A0
	[CompilerGeneratedAttribute] // RVA: 0x4530A0 Offset: 0x4531A1 VA: 0x4530A0
	// RVA: 0x3851610 Offset: 0x3851711 VA: 0x3851610
	public VertexAttribute get_attribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x4530E0 Offset: 0x4531E1 VA: 0x4530E0
	// RVA: 0x3851620 Offset: 0x3851721 VA: 0x3851620
	public void set_attribute(VertexAttribute value) { }

	[IsReadOnlyAttribute] // RVA: 0x4530F0 Offset: 0x4531F1 VA: 0x4530F0
	[CompilerGeneratedAttribute] // RVA: 0x4530F0 Offset: 0x4531F1 VA: 0x4530F0
	// RVA: 0x3851630 Offset: 0x3851731 VA: 0x3851630
	public VertexAttributeFormat get_format() { }

	[CompilerGeneratedAttribute] // RVA: 0x453130 Offset: 0x453231 VA: 0x453130
	// RVA: 0x3851640 Offset: 0x3851741 VA: 0x3851640
	public void set_format(VertexAttributeFormat value) { }

	[IsReadOnlyAttribute] // RVA: 0x453140 Offset: 0x453241 VA: 0x453140
	[CompilerGeneratedAttribute] // RVA: 0x453140 Offset: 0x453241 VA: 0x453140
	// RVA: 0x3851650 Offset: 0x3851751 VA: 0x3851650
	public int get_dimension() { }

	[CompilerGeneratedAttribute] // RVA: 0x453180 Offset: 0x453281 VA: 0x453180
	// RVA: 0x3851660 Offset: 0x3851761 VA: 0x3851660
	public void set_dimension(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x453190 Offset: 0x453291 VA: 0x453190
	[CompilerGeneratedAttribute] // RVA: 0x453190 Offset: 0x453291 VA: 0x453190
	// RVA: 0x3851670 Offset: 0x3851771 VA: 0x3851670
	public int get_stream() { }

	[CompilerGeneratedAttribute] // RVA: 0x4531D0 Offset: 0x4532D1 VA: 0x4531D0
	// RVA: 0x3851680 Offset: 0x3851781 VA: 0x3851680
	public void set_stream(int value) { }

	// RVA: 0x3851690 Offset: 0x3851791 VA: 0x3851690
	public void .ctor(VertexAttribute attribute = 0, VertexAttributeFormat format = 0, int dimension = 3, int stream = 0) { }

	// RVA: 0x38516A0 Offset: 0x38517A1 VA: 0x38516A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x38518B0 Offset: 0x38519B1 VA: 0x38518B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x38518E0 Offset: 0x38519E1 VA: 0x38518E0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x38519A0 Offset: 0x3851AA1 VA: 0x38519A0 Slot: 4
	public bool Equals(VertexAttributeDescriptor other) { }
}

