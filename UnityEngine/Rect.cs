// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43C0F0 Offset: 0x43C1F1 VA: 0x43C0F0
[RequiredByNativeCodeAttribute] // RVA: 0x43C0F0 Offset: 0x43C1F1 VA: 0x43C0F0
[NativeClassAttribute] // RVA: 0x43C0F0 Offset: 0x43C1F1 VA: 0x43C0F0
public struct Rect : IEquatable<Rect>, IFormattable // TypeDefIndex: 3430
{
	// Fields
	[NativeNameAttribute] // RVA: 0x442680 Offset: 0x442781 VA: 0x442680
	private float m_XMin; // 0x0
	[NativeNameAttribute] // RVA: 0x4426C0 Offset: 0x4427C1 VA: 0x4426C0
	private float m_YMin; // 0x4
	[NativeNameAttribute] // RVA: 0x442700 Offset: 0x442801 VA: 0x442700
	private float m_Width; // 0x8
	[NativeNameAttribute] // RVA: 0x442740 Offset: 0x442841 VA: 0x442740
	private float m_Height; // 0xC

	// Properties
	public static Rect zero { get; }
	public float x { get; set; }
	public float y { get; set; }
	public Vector2 position { get; set; }
	public Vector2 center { get; set; }
	public Vector2 min { get; }
	public Vector2 max { get; }
	public float width { get; set; }
	public float height { get; set; }
	public Vector2 size { get; }
	public float xMin { get; set; }
	public float yMin { get; set; }
	public float xMax { get; set; }
	public float yMax { get; set; }

	// Methods

	// RVA: 0x31D2B60 Offset: 0x31D2C61 VA: 0x31D2B60
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x31D2B80 Offset: 0x31D2C81 VA: 0x31D2B80
	public void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0x31D2BA0 Offset: 0x31D2CA1 VA: 0x31D2BA0
	public void .ctor(Rect source) { }

	// RVA: 0x31D2BC0 Offset: 0x31D2CC1 VA: 0x31D2BC0
	public static Rect get_zero() { }

	// RVA: 0x31D2BE0 Offset: 0x31D2CE1 VA: 0x31D2BE0
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	// RVA: 0x31D2BF0 Offset: 0x31D2CF1 VA: 0x31D2BF0
	public void Set(float x, float y, float width, float height) { }

	// RVA: 0x31D2C10 Offset: 0x31D2D11 VA: 0x31D2C10
	public float get_x() { }

	// RVA: 0x31D2C20 Offset: 0x31D2D21 VA: 0x31D2C20
	public void set_x(float value) { }

	// RVA: 0x31D2C30 Offset: 0x31D2D31 VA: 0x31D2C30
	public float get_y() { }

	// RVA: 0x31D2C40 Offset: 0x31D2D41 VA: 0x31D2C40
	public void set_y(float value) { }

	// RVA: 0x31D2C50 Offset: 0x31D2D51 VA: 0x31D2C50
	public Vector2 get_position() { }

	// RVA: 0x31D2C60 Offset: 0x31D2D61 VA: 0x31D2C60
	public void set_position(Vector2 value) { }

	// RVA: 0x31D2C70 Offset: 0x31D2D71 VA: 0x31D2C70
	public Vector2 get_center() { }

	// RVA: 0x31D2C90 Offset: 0x31D2D91 VA: 0x31D2C90
	public void set_center(Vector2 value) { }

	// RVA: 0x31D2CC0 Offset: 0x31D2DC1 VA: 0x31D2CC0
	public Vector2 get_min() { }

	// RVA: 0x31D2CF0 Offset: 0x31D2DF1 VA: 0x31D2CF0
	public Vector2 get_max() { }

	// RVA: 0x31D2D30 Offset: 0x31D2E31 VA: 0x31D2D30
	public float get_width() { }

	// RVA: 0x31D2D40 Offset: 0x31D2E41 VA: 0x31D2D40
	public void set_width(float value) { }

	// RVA: 0x31D2D50 Offset: 0x31D2E51 VA: 0x31D2D50
	public float get_height() { }

	// RVA: 0x31D2D60 Offset: 0x31D2E61 VA: 0x31D2D60
	public void set_height(float value) { }

	// RVA: 0x31D2D70 Offset: 0x31D2E71 VA: 0x31D2D70
	public Vector2 get_size() { }

	// RVA: 0x31D2CD0 Offset: 0x31D2DD1 VA: 0x31D2CD0
	public float get_xMin() { }

	// RVA: 0x31D2D80 Offset: 0x31D2E81 VA: 0x31D2D80
	public void set_xMin(float value) { }

	// RVA: 0x31D2CE0 Offset: 0x31D2DE1 VA: 0x31D2CE0
	public float get_yMin() { }

	// RVA: 0x31D2DA0 Offset: 0x31D2EA1 VA: 0x31D2DA0
	public void set_yMin(float value) { }

	// RVA: 0x31D2D10 Offset: 0x31D2E11 VA: 0x31D2D10
	public float get_xMax() { }

	// RVA: 0x31D2DC0 Offset: 0x31D2EC1 VA: 0x31D2DC0
	public void set_xMax(float value) { }

	// RVA: 0x31D2D20 Offset: 0x31D2E21 VA: 0x31D2D20
	public float get_yMax() { }

	// RVA: 0x31D2DD0 Offset: 0x31D2ED1 VA: 0x31D2DD0
	public void set_yMax(float value) { }

	// RVA: 0x31D2DE0 Offset: 0x31D2EE1 VA: 0x31D2DE0
	public bool Contains(Vector2 point) { }

	// RVA: 0x31D2E30 Offset: 0x31D2F31 VA: 0x31D2E30
	public bool Contains(Vector3 point) { }

	// RVA: 0x31D2E80 Offset: 0x31D2F81 VA: 0x31D2E80
	private static Rect OrderMinMax(Rect rect) { }

	// RVA: 0x31D2EB0 Offset: 0x31D2FB1 VA: 0x31D2EB0
	public bool Overlaps(Rect other) { }

	// RVA: 0x31D2F00 Offset: 0x31D3001 VA: 0x31D2F00
	public bool Overlaps(Rect other, bool allowInverse) { }

	// RVA: 0x31D2F90 Offset: 0x31D3091 VA: 0x31D2F90
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x31D2FC0 Offset: 0x31D30C1 VA: 0x31D2FC0
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x31D3000 Offset: 0x31D3101 VA: 0x31D3000 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x31D30A0 Offset: 0x31D31A1 VA: 0x31D30A0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x31D31A0 Offset: 0x31D32A1 VA: 0x31D31A0 Slot: 4
	public bool Equals(Rect other) { }

	// RVA: 0x31D3260 Offset: 0x31D3361 VA: 0x31D3260 Slot: 3
	public override string ToString() { }

	// RVA: 0x31D32F0 Offset: 0x31D33F1 VA: 0x31D32F0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

