// Namespace: 
public enum MapTerrainInfoAlignment.Type // TypeDefIndex: 12491
{
	// Fields
	public int value__; // 0x0
	public const MapTerrainInfoAlignment.Type Left = 0;
	public const MapTerrainInfoAlignment.Type Right = 1;
}

// Namespace: 
private enum MapTerrainInfoAlignment.AlignMember.Type // TypeDefIndex: 12492
{
	// Fields
	public int value__; // 0x0
	public const MapTerrainInfoAlignment.AlignMember.Type Text = 0;
	public const MapTerrainInfoAlignment.AlignMember.Type Value = 1;
	public const MapTerrainInfoAlignment.AlignMember.Type Icon = 2;
}

// Namespace: 
private class MapTerrainInfoAlignment.AlignMember // TypeDefIndex: 12493
{
	// Fields
	private GameObject m_Root; // 0x10
	private RectTransform m_RootRect; // 0x18
	private TextMeshProUGUI m_RootText; // 0x20
	private MapTerrainInfoAlignmentMember m_AlingMenber; // 0x28
	private GameObject m_TitleObj; // 0x30
	private RectTransform m_TitleRect; // 0x38
	private TextMeshProUGUI m_TitleText; // 0x40
	private GameObject m_ValueObj; // 0x48
	private RectTransform m_ValueRect; // 0x50
	private TextMeshProUGUI m_ValueText; // 0x58
	private MapTerrainInfoAlignment.AlignMember.Type m_Type; // 0x60

	// Methods

	// RVA: 0x2144200 Offset: 0x2144301 VA: 0x2144200
	public void .ctor(GameObject root) { }

	// RVA: 0x2144580 Offset: 0x2144681 VA: 0x2144580
	public bool IsActive() { }

	// RVA: 0x2144620 Offset: 0x2144721 VA: 0x2144620
	public void SetPosX(float posX) { }

	// RVA: 0x21446E0 Offset: 0x21447E1 VA: 0x21446E0
	public float Alignment(out float fixedWidth, float rate, float defaultWidth = 0) { }
}

// Namespace: 
private class MapTerrainInfoAlignment.AlignParent // TypeDefIndex: 12494
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29A790 Offset: 0x29A891 VA: 0x29A790
	private RectTransform <rectTransform>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29A7A0 Offset: 0x29A8A1 VA: 0x29A7A0
	private MapTerrainInfoAlignmentMember <script>k__BackingField; // 0x18

	// Properties
	public RectTransform rectTransform { get; set; }
	public MapTerrainInfoAlignmentMember script { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C9660 Offset: 0x2C9761 VA: 0x2C9660
	// RVA: 0x21448B0 Offset: 0x21449B1 VA: 0x21448B0
	public RectTransform get_rectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9670 Offset: 0x2C9771 VA: 0x2C9670
	// RVA: 0x21448C0 Offset: 0x21449C1 VA: 0x21448C0
	private void set_rectTransform(RectTransform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9680 Offset: 0x2C9781 VA: 0x2C9680
	// RVA: 0x21448D0 Offset: 0x21449D1 VA: 0x21448D0
	public MapTerrainInfoAlignmentMember get_script() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9690 Offset: 0x2C9791 VA: 0x2C9690
	// RVA: 0x21448E0 Offset: 0x21449E1 VA: 0x21448E0
	private void set_script(MapTerrainInfoAlignmentMember value) { }

	// RVA: 0x21448F0 Offset: 0x21449F1 VA: 0x21448F0
	public void .ctor(GameObject root) { }

	// RVA: 0x21449F0 Offset: 0x2144AF1 VA: 0x21449F0
	public float GetLeft() { }

	// RVA: 0x2144A00 Offset: 0x2144B01 VA: 0x2144A00
	public float GetRight() { }

	// RVA: 0x2144A10 Offset: 0x2144B11 VA: 0x2144A10
	public float GetTop() { }

	// RVA: 0x2144A20 Offset: 0x2144B21 VA: 0x2144A20
	public float GetBottom() { }

	// RVA: 0x2144A30 Offset: 0x2144B31 VA: 0x2144A30
	public float GetSpacing() { }

	// RVA: 0x2144A40 Offset: 0x2144B41 VA: 0x2144A40
	public void SetPos(Vector2 pos) { }

	// RVA: 0x2144A50 Offset: 0x2144B51 VA: 0x2144A50
	public void SetSize(Vector2 size) { }

	// RVA: 0x2144A60 Offset: 0x2144B61 VA: 0x2144A60
	public Vector2 GetSize() { }
}

// Namespace: 
private class MapTerrainInfoAlignment.InversionMember // TypeDefIndex: 12495
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29A7B0 Offset: 0x29A8B1 VA: 0x29A7B0
	private RectTransform <rectTransform>k__BackingField; // 0x10

	// Properties
	public RectTransform rectTransform { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C96A0 Offset: 0x2C97A1 VA: 0x2C96A0
	// RVA: 0x2144A70 Offset: 0x2144B71 VA: 0x2144A70
	public RectTransform get_rectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C96B0 Offset: 0x2C97B1 VA: 0x2C96B0
	// RVA: 0x2144A80 Offset: 0x2144B81 VA: 0x2144A80
	private void set_rectTransform(RectTransform value) { }

	// RVA: 0x2144A90 Offset: 0x2144B91 VA: 0x2144A90
	public void .ctor(GameObject root) { }

	// RVA: 0x2144B60 Offset: 0x2144C61 VA: 0x2144B60
	public void Inversion() { }
}

