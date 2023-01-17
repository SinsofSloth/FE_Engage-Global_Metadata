// Namespace: App
public abstract class HubEnvSub : MonoBehaviour // TypeDefIndex: 10679
{
	// Fields
	[HeaderAttribute] // RVA: 0x294910 Offset: 0x294A11 VA: 0x294910
	[SpaceAttribute] // RVA: 0x294910 Offset: 0x294A11 VA: 0x294910
	public HubUtil.TimezoneType m_EditTimezoneType; // 0x18
	[HeaderAttribute] // RVA: 0x294960 Offset: 0x294A61 VA: 0x294960
	[SpaceAttribute] // RVA: 0x294960 Offset: 0x294A61 VA: 0x294960
	public Color m_MorningFogColor; // 0x1C
	[RangeAttribute] // RVA: 0x2949B0 Offset: 0x294AB1 VA: 0x2949B0
	public float m_MorningFogStart; // 0x2C
	[RangeAttribute] // RVA: 0x2949D0 Offset: 0x294AD1 VA: 0x2949D0
	public float m_MorningFogEnd; // 0x30
	[SpaceAttribute] // RVA: 0x2949F0 Offset: 0x294AF1 VA: 0x2949F0
	[HeaderAttribute] // RVA: 0x2949F0 Offset: 0x294AF1 VA: 0x2949F0
	public Color m_DayFogColor; // 0x34
	[RangeAttribute] // RVA: 0x294A40 Offset: 0x294B41 VA: 0x294A40
	public float m_DayFogStart; // 0x44
	[RangeAttribute] // RVA: 0x294A60 Offset: 0x294B61 VA: 0x294A60
	public float m_DayFogEnd; // 0x48
	[HeaderAttribute] // RVA: 0x294A80 Offset: 0x294B81 VA: 0x294A80
	[SpaceAttribute] // RVA: 0x294A80 Offset: 0x294B81 VA: 0x294A80
	public Color m_EveningFogColor; // 0x4C
	[RangeAttribute] // RVA: 0x294AD0 Offset: 0x294BD1 VA: 0x294AD0
	public float m_EveningFogStart; // 0x5C
	[RangeAttribute] // RVA: 0x294AF0 Offset: 0x294BF1 VA: 0x294AF0
	public float m_EveningFogEnd; // 0x60
	[HeaderAttribute] // RVA: 0x294B10 Offset: 0x294C11 VA: 0x294B10
	[SpaceAttribute] // RVA: 0x294B10 Offset: 0x294C11 VA: 0x294B10
	public Color m_NightFogColor; // 0x64
	[RangeAttribute] // RVA: 0x294B60 Offset: 0x294C61 VA: 0x294B60
	public float m_NightFogStart; // 0x74
	[RangeAttribute] // RVA: 0x294B80 Offset: 0x294C81 VA: 0x294B80
	public float m_NightFogEnd; // 0x78
	private GameObject m_Morning; // 0x80
	private GameObject m_Day; // 0x88
	private GameObject m_Evening; // 0x90
	private GameObject m_Night; // 0x98
	private HubUtil.TimezoneType m_TimezoneType; // 0xA0
	private int m_PrevDepth; // 0xA4
	private Color m_PrevFogColor; // 0xA8
	private float m_PrevFogStart; // 0xB8
	private float m_PrevFogEnd; // 0xBC

	// Properties
	private GameObject Morning { get; }
	private GameObject Day { get; }
	private GameObject Evening { get; }
	private GameObject Night { get; }

	// Methods

	// RVA: 0x305DBD0 Offset: 0x305DCD1 VA: 0x305DBD0
	private GameObject get_Morning() { }

	// RVA: 0x305DCD0 Offset: 0x305DDD1 VA: 0x305DCD0
	private GameObject get_Day() { }

	// RVA: 0x305DDD0 Offset: 0x305DED1 VA: 0x305DDD0
	private GameObject get_Evening() { }

	// RVA: 0x305DED0 Offset: 0x305DFD1 VA: 0x305DED0
	private GameObject get_Night() { }

	// RVA: 0x305DFD0 Offset: 0x305E0D1 VA: 0x305DFD0
	public void PushParams(HubUtil.TimezoneType timezoneType) { }

	// RVA: 0x305E3A0 Offset: 0x305E4A1 VA: 0x305E3A0
	public void PopParams() { }

	// RVA: 0x305E220 Offset: 0x305E321 VA: 0x305E220
	public void ApplyFog() { }

	// RVA: 0x305E210 Offset: 0x305E311 VA: 0x305E210
	private bool SupportFogStack() { }

	// RVA: 0x305E300 Offset: 0x305E401 VA: 0x305E300
	private void SetPostProcessActive(GameObject obj, bool value) { }

	// RVA: 0x305E5A0 Offset: 0x305E6A1 VA: 0x305E5A0
	protected void .ctor() { }
}

