// Namespace: 
public class HableCurve.Segment // TypeDefIndex: 4627
{
	// Fields
	public float offsetX; // 0x10
	public float offsetY; // 0x14
	public float scaleX; // 0x18
	public float scaleY; // 0x1C
	public float lnA; // 0x20
	public float B; // 0x24

	// Methods

	// RVA: 0x3552980 Offset: 0x3552A81 VA: 0x3552980
	public float Eval(float x) { }

	// RVA: 0x35529F0 Offset: 0x3552AF1 VA: 0x35529F0
	public void .ctor() { }
}

// Namespace: 
private struct HableCurve.DirectParams // TypeDefIndex: 4628
{
	// Fields
	internal float x0; // 0x0
	internal float y0; // 0x4
	internal float x1; // 0x8
	internal float y1; // 0xC
	internal float W; // 0x10
	internal float overshootX; // 0x14
	internal float overshootY; // 0x18
	internal float gamma; // 0x1C
}

// Namespace: 
public class HableCurve.Uniforms // TypeDefIndex: 4629
{
	// Fields
	private HableCurve parent; // 0x10

	// Properties
	public Vector4 curve { get; }
	public Vector4 toeSegmentA { get; }
	public Vector4 toeSegmentB { get; }
	public Vector4 midSegmentA { get; }
	public Vector4 midSegmentB { get; }
	public Vector4 shoSegmentA { get; }
	public Vector4 shoSegmentB { get; }

	// Methods

	// RVA: 0x3552A00 Offset: 0x3552B01 VA: 0x3552A00
	internal void .ctor(HableCurve parent) { }

	// RVA: 0x3552A40 Offset: 0x3552B41 VA: 0x3552A40
	public Vector4 get_curve() { }

	// RVA: 0x3552A80 Offset: 0x3552B81 VA: 0x3552A80
	public Vector4 get_toeSegmentA() { }

	// RVA: 0x3552AE0 Offset: 0x3552BE1 VA: 0x3552AE0
	public Vector4 get_toeSegmentB() { }

	// RVA: 0x3552B40 Offset: 0x3552C41 VA: 0x3552B40
	public Vector4 get_midSegmentA() { }

	// RVA: 0x3552BA0 Offset: 0x3552CA1 VA: 0x3552BA0
	public Vector4 get_midSegmentB() { }

	// RVA: 0x3552C00 Offset: 0x3552D01 VA: 0x3552C00
	public Vector4 get_shoSegmentA() { }

	// RVA: 0x3552C60 Offset: 0x3552D61 VA: 0x3552C60
	public Vector4 get_shoSegmentB() { }
}

