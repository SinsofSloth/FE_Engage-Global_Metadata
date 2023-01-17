// Namespace: UnityEngine
internal class GUILayoutEntry // TypeDefIndex: 4172
{
	// Fields
	public float minWidth; // 0x10
	public float maxWidth; // 0x14
	public float minHeight; // 0x18
	public float maxHeight; // 0x1C
	public Rect rect; // 0x20
	public int stretchWidth; // 0x30
	public int stretchHeight; // 0x34
	public bool consideredForMargin; // 0x38
	private GUIStyle m_Style; // 0x40
	internal static Rect kDummyRect; // 0x0
	protected static int indent; // 0x10

	// Properties
	public GUIStyle style { get; set; }
	public virtual int marginLeft { get; }
	public virtual int marginRight { get; }
	public virtual int marginTop { get; }
	public virtual int marginBottom { get; }
	public int marginHorizontal { get; }
	public int marginVertical { get; }

	// Methods

	// RVA: 0x3C7C0E0 Offset: 0x3C7C1E1 VA: 0x3C7C0E0
	public GUIStyle get_style() { }

	// RVA: 0x3C7C0F0 Offset: 0x3C7C1F1 VA: 0x3C7C0F0
	public void set_style(GUIStyle value) { }

	// RVA: 0x3C7C130 Offset: 0x3C7C231 VA: 0x3C7C130 Slot: 4
	public virtual int get_marginLeft() { }

	// RVA: 0x3C7C1F0 Offset: 0x3C7C2F1 VA: 0x3C7C1F0 Slot: 5
	public virtual int get_marginRight() { }

	// RVA: 0x3C7C2B0 Offset: 0x3C7C3B1 VA: 0x3C7C2B0 Slot: 6
	public virtual int get_marginTop() { }

	// RVA: 0x3C7C370 Offset: 0x3C7C471 VA: 0x3C7C370 Slot: 7
	public virtual int get_marginBottom() { }

	// RVA: 0x3C7C430 Offset: 0x3C7C531 VA: 0x3C7C430
	public int get_marginHorizontal() { }

	// RVA: 0x3C7C470 Offset: 0x3C7C571 VA: 0x3C7C470
	public int get_marginVertical() { }

	// RVA: 0x3C7C4B0 Offset: 0x3C7C5B1 VA: 0x3C7C4B0
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x3C7C5F0 Offset: 0x3C7C6F1 VA: 0x3C7C5F0
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x3C7C730 Offset: 0x3C7C831 VA: 0x3C7C730 Slot: 8
	public virtual void CalcWidth() { }

	// RVA: 0x3C7C740 Offset: 0x3C7C841 VA: 0x3C7C740 Slot: 9
	public virtual void CalcHeight() { }

	// RVA: 0x3C7C750 Offset: 0x3C7C851 VA: 0x3C7C750 Slot: 10
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x3C7C790 Offset: 0x3C7C891 VA: 0x3C7C790 Slot: 11
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x3C7C7D0 Offset: 0x3C7C8D1 VA: 0x3C7C7D0 Slot: 12
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x3C7C9A0 Offset: 0x3C7CAA1 VA: 0x3C7C9A0 Slot: 13
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x3C7CC90 Offset: 0x3C7CD91 VA: 0x3C7CC90 Slot: 3
	public override string ToString() { }

	// RVA: 0x3C7D3E0 Offset: 0x3C7D4E1 VA: 0x3C7D3E0
	private static void .cctor() { }
}

