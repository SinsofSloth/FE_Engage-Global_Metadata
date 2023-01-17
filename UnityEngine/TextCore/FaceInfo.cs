// Namespace: UnityEngine.TextCore
[UsedByNativeCodeAttribute] // RVA: 0x61210 Offset: 0x61311 VA: 0x61210
[Serializable]
public struct FaceInfo // TypeDefIndex: 5706
{
	// Fields
	[SerializeField] // RVA: 0x61380 Offset: 0x61481 VA: 0x61380
	[NativeNameAttribute] // RVA: 0x61380 Offset: 0x61481 VA: 0x61380
	private int m_FaceIndex; // 0x0
	[SerializeField] // RVA: 0x613D0 Offset: 0x614D1 VA: 0x613D0
	[NativeNameAttribute] // RVA: 0x613D0 Offset: 0x614D1 VA: 0x613D0
	private string m_FamilyName; // 0x8
	[NativeNameAttribute] // RVA: 0x61420 Offset: 0x61521 VA: 0x61420
	[SerializeField] // RVA: 0x61420 Offset: 0x61521 VA: 0x61420
	private string m_StyleName; // 0x10
	[NativeNameAttribute] // RVA: 0x61470 Offset: 0x61571 VA: 0x61470
	[SerializeField] // RVA: 0x61470 Offset: 0x61571 VA: 0x61470
	private int m_PointSize; // 0x18
	[SerializeField] // RVA: 0x614C0 Offset: 0x615C1 VA: 0x614C0
	[NativeNameAttribute] // RVA: 0x614C0 Offset: 0x615C1 VA: 0x614C0
	private float m_Scale; // 0x1C
	[SerializeField] // RVA: 0x61510 Offset: 0x61611 VA: 0x61510
	[NativeNameAttribute] // RVA: 0x61510 Offset: 0x61611 VA: 0x61510
	private float m_LineHeight; // 0x20
	[NativeNameAttribute] // RVA: 0x61560 Offset: 0x61661 VA: 0x61560
	[SerializeField] // RVA: 0x61560 Offset: 0x61661 VA: 0x61560
	private float m_AscentLine; // 0x24
	[NativeNameAttribute] // RVA: 0x615B0 Offset: 0x616B1 VA: 0x615B0
	[SerializeField] // RVA: 0x615B0 Offset: 0x616B1 VA: 0x615B0
	private float m_CapLine; // 0x28
	[NativeNameAttribute] // RVA: 0x61600 Offset: 0x61701 VA: 0x61600
	[SerializeField] // RVA: 0x61600 Offset: 0x61701 VA: 0x61600
	private float m_MeanLine; // 0x2C
	[SerializeField] // RVA: 0x61650 Offset: 0x61751 VA: 0x61650
	[NativeNameAttribute] // RVA: 0x61650 Offset: 0x61751 VA: 0x61650
	private float m_Baseline; // 0x30
	[SerializeField] // RVA: 0x616A0 Offset: 0x617A1 VA: 0x616A0
	[NativeNameAttribute] // RVA: 0x616A0 Offset: 0x617A1 VA: 0x616A0
	private float m_DescentLine; // 0x34
	[NativeNameAttribute] // RVA: 0x616F0 Offset: 0x617F1 VA: 0x616F0
	[SerializeField] // RVA: 0x616F0 Offset: 0x617F1 VA: 0x616F0
	private float m_SuperscriptOffset; // 0x38
	[SerializeField] // RVA: 0x61740 Offset: 0x61841 VA: 0x61740
	[NativeNameAttribute] // RVA: 0x61740 Offset: 0x61841 VA: 0x61740
	private float m_SuperscriptSize; // 0x3C
	[SerializeField] // RVA: 0x61790 Offset: 0x61891 VA: 0x61790
	[NativeNameAttribute] // RVA: 0x61790 Offset: 0x61891 VA: 0x61790
	private float m_SubscriptOffset; // 0x40
	[NativeNameAttribute] // RVA: 0x617E0 Offset: 0x618E1 VA: 0x617E0
	[SerializeField] // RVA: 0x617E0 Offset: 0x618E1 VA: 0x617E0
	private float m_SubscriptSize; // 0x44
	[NativeNameAttribute] // RVA: 0x61830 Offset: 0x61931 VA: 0x61830
	[SerializeField] // RVA: 0x61830 Offset: 0x61931 VA: 0x61830
	private float m_UnderlineOffset; // 0x48
	[NativeNameAttribute] // RVA: 0x61880 Offset: 0x61981 VA: 0x61880
	[SerializeField] // RVA: 0x61880 Offset: 0x61981 VA: 0x61880
	private float m_UnderlineThickness; // 0x4C
	[NativeNameAttribute] // RVA: 0x618D0 Offset: 0x619D1 VA: 0x618D0
	[SerializeField] // RVA: 0x618D0 Offset: 0x619D1 VA: 0x618D0
	private float m_StrikethroughOffset; // 0x50
	[SerializeField] // RVA: 0x61920 Offset: 0x61A21 VA: 0x61920
	[NativeNameAttribute] // RVA: 0x61920 Offset: 0x61A21 VA: 0x61920
	private float m_StrikethroughThickness; // 0x54
	[NativeNameAttribute] // RVA: 0x61970 Offset: 0x61A71 VA: 0x61970
	[SerializeField] // RVA: 0x61970 Offset: 0x61A71 VA: 0x61970
	private float m_TabWidth; // 0x58

	// Properties
	public string familyName { set; }
	public string styleName { set; }
	public int pointSize { get; set; }
	public float scale { get; set; }
	public float lineHeight { get; set; }
	public float ascentLine { get; set; }
	public float capLine { get; set; }
	public float meanLine { get; set; }
	public float baseline { get; set; }
	public float descentLine { get; set; }
	public float superscriptOffset { get; set; }
	public float superscriptSize { get; set; }
	public float subscriptOffset { get; set; }
	public float subscriptSize { get; set; }
	public float underlineOffset { get; set; }
	public float underlineThickness { get; set; }
	public float strikethroughOffset { get; set; }
	public float strikethroughThickness { set; }
	public float tabWidth { get; set; }

	// Methods

	// RVA: 0x1C58370 Offset: 0x1C58471 VA: 0x1C58370
	public void set_familyName(string value) { }

	// RVA: 0x1C58380 Offset: 0x1C58481 VA: 0x1C58380
	public void set_styleName(string value) { }

	// RVA: 0x1C58390 Offset: 0x1C58491 VA: 0x1C58390
	public int get_pointSize() { }

	// RVA: 0x1C583A0 Offset: 0x1C584A1 VA: 0x1C583A0
	public void set_pointSize(int value) { }

	// RVA: 0x1C583B0 Offset: 0x1C584B1 VA: 0x1C583B0
	public float get_scale() { }

	// RVA: 0x1C583C0 Offset: 0x1C584C1 VA: 0x1C583C0
	public void set_scale(float value) { }

	// RVA: 0x1C583D0 Offset: 0x1C584D1 VA: 0x1C583D0
	public float get_lineHeight() { }

	// RVA: 0x1C583E0 Offset: 0x1C584E1 VA: 0x1C583E0
	public void set_lineHeight(float value) { }

	// RVA: 0x1C583F0 Offset: 0x1C584F1 VA: 0x1C583F0
	public float get_ascentLine() { }

	// RVA: 0x1C58400 Offset: 0x1C58501 VA: 0x1C58400
	public void set_ascentLine(float value) { }

	// RVA: 0x1C58410 Offset: 0x1C58511 VA: 0x1C58410
	public float get_capLine() { }

	// RVA: 0x1C58420 Offset: 0x1C58521 VA: 0x1C58420
	public void set_capLine(float value) { }

	// RVA: 0x1C58430 Offset: 0x1C58531 VA: 0x1C58430
	public float get_meanLine() { }

	// RVA: 0x1C58440 Offset: 0x1C58541 VA: 0x1C58440
	public void set_meanLine(float value) { }

	// RVA: 0x1C58450 Offset: 0x1C58551 VA: 0x1C58450
	public float get_baseline() { }

	// RVA: 0x1C58460 Offset: 0x1C58561 VA: 0x1C58460
	public void set_baseline(float value) { }

	// RVA: 0x1C58470 Offset: 0x1C58571 VA: 0x1C58470
	public float get_descentLine() { }

	// RVA: 0x1C58480 Offset: 0x1C58581 VA: 0x1C58480
	public void set_descentLine(float value) { }

	// RVA: 0x1C58490 Offset: 0x1C58591 VA: 0x1C58490
	public float get_superscriptOffset() { }

	// RVA: 0x1C584A0 Offset: 0x1C585A1 VA: 0x1C584A0
	public void set_superscriptOffset(float value) { }

	// RVA: 0x1C584B0 Offset: 0x1C585B1 VA: 0x1C584B0
	public float get_superscriptSize() { }

	// RVA: 0x1C584C0 Offset: 0x1C585C1 VA: 0x1C584C0
	public void set_superscriptSize(float value) { }

	// RVA: 0x1C584D0 Offset: 0x1C585D1 VA: 0x1C584D0
	public float get_subscriptOffset() { }

	// RVA: 0x1C584E0 Offset: 0x1C585E1 VA: 0x1C584E0
	public void set_subscriptOffset(float value) { }

	// RVA: 0x1C584F0 Offset: 0x1C585F1 VA: 0x1C584F0
	public float get_subscriptSize() { }

	// RVA: 0x1C58500 Offset: 0x1C58601 VA: 0x1C58500
	public void set_subscriptSize(float value) { }

	// RVA: 0x1C58510 Offset: 0x1C58611 VA: 0x1C58510
	public float get_underlineOffset() { }

	// RVA: 0x1C58520 Offset: 0x1C58621 VA: 0x1C58520
	public void set_underlineOffset(float value) { }

	// RVA: 0x1C58530 Offset: 0x1C58631 VA: 0x1C58530
	public float get_underlineThickness() { }

	// RVA: 0x1C58540 Offset: 0x1C58641 VA: 0x1C58540
	public void set_underlineThickness(float value) { }

	// RVA: 0x1C58550 Offset: 0x1C58651 VA: 0x1C58550
	public float get_strikethroughOffset() { }

	// RVA: 0x1C58560 Offset: 0x1C58661 VA: 0x1C58560
	public void set_strikethroughOffset(float value) { }

	// RVA: 0x1C58570 Offset: 0x1C58671 VA: 0x1C58570
	public void set_strikethroughThickness(float value) { }

	// RVA: 0x1C58580 Offset: 0x1C58681 VA: 0x1C58580
	public float get_tabWidth() { }

	// RVA: 0x1C58590 Offset: 0x1C58691 VA: 0x1C58590
	public void set_tabWidth(float value) { }
}

