// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x43C180 Offset: 0x43C281 VA: 0x43C180
public struct RectInt : IEquatable<RectInt>, IFormattable // TypeDefIndex: 3431
{
	// Fields
	private int m_XMin; // 0x0
	private int m_YMin; // 0x4
	private int m_Width; // 0x8
	private int m_Height; // 0xC

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public int width { get; set; }
	public int height { get; set; }

	// Methods

	// RVA: 0x31D3520 Offset: 0x31D3621 VA: 0x31D3520
	public int get_x() { }

	// RVA: 0x31D3530 Offset: 0x31D3631 VA: 0x31D3530
	public void set_x(int value) { }

	// RVA: 0x31D3540 Offset: 0x31D3641 VA: 0x31D3540
	public int get_y() { }

	// RVA: 0x31D3550 Offset: 0x31D3651 VA: 0x31D3550
	public void set_y(int value) { }

	// RVA: 0x31D3560 Offset: 0x31D3661 VA: 0x31D3560
	public int get_width() { }

	// RVA: 0x31D3570 Offset: 0x31D3671 VA: 0x31D3570
	public void set_width(int value) { }

	// RVA: 0x31D3580 Offset: 0x31D3681 VA: 0x31D3580
	public int get_height() { }

	// RVA: 0x31D3590 Offset: 0x31D3691 VA: 0x31D3590
	public void set_height(int value) { }

	// RVA: 0x31D35A0 Offset: 0x31D36A1 VA: 0x31D35A0
	public void .ctor(int xMin, int yMin, int width, int height) { }

	// RVA: 0x31D35B0 Offset: 0x31D36B1 VA: 0x31D35B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x31D3640 Offset: 0x31D3741 VA: 0x31D3640 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x31D3840 Offset: 0x31D3941 VA: 0x31D3840 Slot: 4
	public bool Equals(RectInt other) { }
}

