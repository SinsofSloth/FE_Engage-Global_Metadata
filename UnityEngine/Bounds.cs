// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43BFB0 Offset: 0x43C0B1 VA: 0x43BFB0
[NativeHeaderAttribute] // RVA: 0x43BFB0 Offset: 0x43C0B1 VA: 0x43BFB0
[NativeTypeAttribute] // RVA: 0x43BFB0 Offset: 0x43C0B1 VA: 0x43BFB0
[RequiredByNativeCodeAttribute] // RVA: 0x43BFB0 Offset: 0x43C0B1 VA: 0x43BFB0
[NativeClassAttribute] // RVA: 0x43BFB0 Offset: 0x43C0B1 VA: 0x43BFB0
[NativeHeaderAttribute] // RVA: 0x43BFB0 Offset: 0x43C0B1 VA: 0x43BFB0
[NativeHeaderAttribute] // RVA: 0x43BFB0 Offset: 0x43C0B1 VA: 0x43BFB0
public struct Bounds : IEquatable<Bounds>, IFormattable // TypeDefIndex: 3426
{
	// Fields
	private Vector3 m_Center; // 0x0
	[NativeNameAttribute] // RVA: 0x442640 Offset: 0x442741 VA: 0x442640
	private Vector3 m_Extents; // 0xC

	// Properties
	public Vector3 center { get; set; }
	public Vector3 size { get; set; }
	public Vector3 extents { get; set; }
	public Vector3 min { get; set; }
	public Vector3 max { get; set; }

	// Methods

	// RVA: 0x2F0C7B0 Offset: 0x2F0C8B1 VA: 0x2F0C7B0
	public void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0x2F0C7E0 Offset: 0x2F0C8E1 VA: 0x2F0C7E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F0C870 Offset: 0x2F0C971 VA: 0x2F0C870 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2F0C960 Offset: 0x2F0CA61 VA: 0x2F0C960 Slot: 4
	public bool Equals(Bounds other) { }

	// RVA: 0x2F0C850 Offset: 0x2F0C951 VA: 0x2F0C850
	public Vector3 get_center() { }

	// RVA: 0x2F0C9E0 Offset: 0x2F0CAE1 VA: 0x2F0C9E0
	public void set_center(Vector3 value) { }

	// RVA: 0x2F0C9F0 Offset: 0x2F0CAF1 VA: 0x2F0C9F0
	public Vector3 get_size() { }

	// RVA: 0x2F0CA10 Offset: 0x2F0CB11 VA: 0x2F0CA10
	public void set_size(Vector3 value) { }

	// RVA: 0x2F0C860 Offset: 0x2F0C961 VA: 0x2F0C860
	public Vector3 get_extents() { }

	// RVA: 0x2F0CA30 Offset: 0x2F0CB31 VA: 0x2F0CA30
	public void set_extents(Vector3 value) { }

	// RVA: 0x2F0CA40 Offset: 0x2F0CB41 VA: 0x2F0CA40
	public Vector3 get_min() { }

	// RVA: 0x2F0CA60 Offset: 0x2F0CB61 VA: 0x2F0CA60
	public void set_min(Vector3 value) { }

	// RVA: 0x2F0CAC0 Offset: 0x2F0CBC1 VA: 0x2F0CAC0
	public Vector3 get_max() { }

	// RVA: 0x2F0CB30 Offset: 0x2F0CC31 VA: 0x2F0CB30
	public void set_max(Vector3 value) { }

	// RVA: 0x2F0CB90 Offset: 0x2F0CC91 VA: 0x2F0CB90
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x2F0CBF0 Offset: 0x2F0CCF1 VA: 0x2F0CBF0
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x2F0CAE0 Offset: 0x2F0CBE1 VA: 0x2F0CAE0
	public void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0x2F0CC70 Offset: 0x2F0CD71 VA: 0x2F0CC70
	public void Encapsulate(Vector3 point) { }

	// RVA: 0x2F0CDA0 Offset: 0x2F0CEA1 VA: 0x2F0CDA0
	public void Encapsulate(Bounds bounds) { }

	// RVA: 0x2F0CE00 Offset: 0x2F0CF01 VA: 0x2F0CE00
	public bool Intersects(Bounds bounds) { }

	// RVA: 0x2F0CE90 Offset: 0x2F0CF91 VA: 0x2F0CE90 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F0CF20 Offset: 0x2F0D021 VA: 0x2F0CF20 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

