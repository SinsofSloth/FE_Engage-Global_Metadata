// Namespace: UnityEngine
internal sealed class GUIScrollGroup : GUILayoutGroup // TypeDefIndex: 4175
{
	// Fields
	public float calcMinWidth; // 0x90
	public float calcMaxWidth; // 0x94
	public float calcMinHeight; // 0x98
	public float calcMaxHeight; // 0x9C
	public float clientWidth; // 0xA0
	public float clientHeight; // 0xA4
	public bool allowHorizontalScroll; // 0xA8
	public bool allowVerticalScroll; // 0xA9
	public bool needsHorizontalScrollbar; // 0xAA
	public bool needsVerticalScrollbar; // 0xAB
	public GUIStyle horizontalScrollbar; // 0xB0
	public GUIStyle verticalScrollbar; // 0xB8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x54180 Offset: 0x54281 VA: 0x54180
	// RVA: 0x3C816A0 Offset: 0x3C817A1 VA: 0x3C816A0
	public void .ctor() { }

	// RVA: 0x3C81710 Offset: 0x3C81811 VA: 0x3C81710 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x3C817A0 Offset: 0x3C818A1 VA: 0x3C817A0 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x3C81960 Offset: 0x3C81A61 VA: 0x3C81960 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x3C81B00 Offset: 0x3C81C01 VA: 0x3C81B00 Slot: 11
	public override void SetVertical(float y, float height) { }
}

