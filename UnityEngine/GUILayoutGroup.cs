// Namespace: UnityEngine
[VisibleToOtherModulesAttribute] // RVA: 0x52D50 Offset: 0x52E51 VA: 0x52D50
internal class GUILayoutGroup : GUILayoutEntry // TypeDefIndex: 4174
{
	// Fields
	public List<GUILayoutEntry> entries; // 0x48
	public bool isVertical; // 0x50
	public bool resetCoords; // 0x51
	public float spacing; // 0x54
	public bool sameSize; // 0x58
	public bool isWindow; // 0x59
	public int windowID; // 0x5C
	private int m_Cursor; // 0x60
	protected int m_StretchableCountX; // 0x64
	protected int m_StretchableCountY; // 0x68
	protected bool m_UserSpecifiedWidth; // 0x6C
	protected bool m_UserSpecifiedHeight; // 0x6D
	protected float m_ChildMinWidth; // 0x70
	protected float m_ChildMaxWidth; // 0x74
	protected float m_ChildMinHeight; // 0x78
	protected float m_ChildMaxHeight; // 0x7C
	protected int m_MarginLeft; // 0x80
	protected int m_MarginRight; // 0x84
	protected int m_MarginTop; // 0x88
	protected int m_MarginBottom; // 0x8C
	private static readonly GUILayoutEntry none; // 0x0

	// Properties
	public override int marginLeft { get; }
	public override int marginRight { get; }
	public override int marginTop { get; }
	public override int marginBottom { get; }

	// Methods

	// RVA: 0x3C7D470 Offset: 0x3C7D571 VA: 0x3C7D470 Slot: 4
	public override int get_marginLeft() { }

	// RVA: 0x3C7D480 Offset: 0x3C7D581 VA: 0x3C7D480 Slot: 5
	public override int get_marginRight() { }

	// RVA: 0x3C7D490 Offset: 0x3C7D591 VA: 0x3C7D490 Slot: 6
	public override int get_marginTop() { }

	// RVA: 0x3C7D4A0 Offset: 0x3C7D5A1 VA: 0x3C7D4A0 Slot: 7
	public override int get_marginBottom() { }

	// RVA: 0x3C7D4B0 Offset: 0x3C7D5B1 VA: 0x3C7D4B0
	public void .ctor() { }

	// RVA: 0x3C7D5F0 Offset: 0x3C7D6F1 VA: 0x3C7D5F0 Slot: 13
	public override void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x3C7D720 Offset: 0x3C7D821 VA: 0x3C7D720 Slot: 12
	protected override void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x3C7D830 Offset: 0x3C7D931 VA: 0x3C7D830
	public void ResetCursor() { }

	// RVA: 0x3C7D840 Offset: 0x3C7D941 VA: 0x3C7D840
	public GUILayoutEntry GetNext() { }

	// RVA: 0x3C7DB90 Offset: 0x3C7DC91 VA: 0x3C7DB90
	public void Add(GUILayoutEntry e) { }

	// RVA: 0x3C7DBF0 Offset: 0x3C7DCF1 VA: 0x3C7DBF0 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x3C7E4B0 Offset: 0x3C7E5B1 VA: 0x3C7E4B0 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x3C7ED10 Offset: 0x3C7EE11 VA: 0x3C7ED10 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x3C7F490 Offset: 0x3C7F591 VA: 0x3C7F490 Slot: 11
	public override void SetVertical(float y, float height) { }

	// RVA: 0x3C7FCF0 Offset: 0x3C7FDF1 VA: 0x3C7FCF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3C80150 Offset: 0x3C80251 VA: 0x3C80150
	private static void .cctor() { }
}

