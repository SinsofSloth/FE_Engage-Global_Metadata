// Namespace: App
[DefaultExecutionOrder] // RVA: 0x2770E0 Offset: 0x2771E1 VA: 0x2770E0
public abstract class HubEnv : MonoBehaviour // TypeDefIndex: 10678
{
	// Fields
	[SpaceAttribute] // RVA: 0x294380 Offset: 0x294481 VA: 0x294380
	[HeaderAttribute] // RVA: 0x294380 Offset: 0x294481 VA: 0x294380
	public bool m_EnableEditMode; // 0x18
	public HubUtil.TimezoneType m_editTimezoneType; // 0x1C
	[SpaceAttribute] // RVA: 0x2943D0 Offset: 0x2944D1 VA: 0x2943D0
	[HeaderAttribute] // RVA: 0x2943D0 Offset: 0x2944D1 VA: 0x2943D0
	public bool m_EnableMorning; // 0x20
	[ColorUsageAttribute] // RVA: 0x294420 Offset: 0x294521 VA: 0x294420
	[SerializeField] // RVA: 0x294420 Offset: 0x294521 VA: 0x294420
	public Color m_MorningAmbientSkyColor; // 0x24
	[ColorUsageAttribute] // RVA: 0x294460 Offset: 0x294561 VA: 0x294460
	[SerializeField] // RVA: 0x294460 Offset: 0x294561 VA: 0x294460
	public Color m_MorningAmbientEquatorColor; // 0x34
	[ColorUsageAttribute] // RVA: 0x2944A0 Offset: 0x2945A1 VA: 0x2944A0
	[SerializeField] // RVA: 0x2944A0 Offset: 0x2945A1 VA: 0x2944A0
	public Color m_MorningAmbientGroundColor; // 0x44
	public Color m_MorningFogColor; // 0x54
	[RangeAttribute] // RVA: 0x2944E0 Offset: 0x2945E1 VA: 0x2944E0
	public float m_MorningFogStart; // 0x64
	[RangeAttribute] // RVA: 0x294500 Offset: 0x294601 VA: 0x294500
	public float m_MorningFogEnd; // 0x68
	[HeaderAttribute] // RVA: 0x294520 Offset: 0x294621 VA: 0x294520
	[SpaceAttribute] // RVA: 0x294520 Offset: 0x294621 VA: 0x294520
	public bool m_EnableDay; // 0x6C
	[SerializeField] // RVA: 0x294570 Offset: 0x294671 VA: 0x294570
	[ColorUsageAttribute] // RVA: 0x294570 Offset: 0x294671 VA: 0x294570
	public Color m_DayAmbientSkyColor; // 0x70
	[ColorUsageAttribute] // RVA: 0x2945B0 Offset: 0x2946B1 VA: 0x2945B0
	[SerializeField] // RVA: 0x2945B0 Offset: 0x2946B1 VA: 0x2945B0
	public Color m_DayAmbientEquatorColor; // 0x80
	[ColorUsageAttribute] // RVA: 0x2945F0 Offset: 0x2946F1 VA: 0x2945F0
	[SerializeField] // RVA: 0x2945F0 Offset: 0x2946F1 VA: 0x2945F0
	public Color m_DayAmbientGroundColor; // 0x90
	public Color m_DayFogColor; // 0xA0
	[RangeAttribute] // RVA: 0x294630 Offset: 0x294731 VA: 0x294630
	public float m_DayFogStart; // 0xB0
	[RangeAttribute] // RVA: 0x294650 Offset: 0x294751 VA: 0x294650
	public float m_DayFogEnd; // 0xB4
	[HeaderAttribute] // RVA: 0x294670 Offset: 0x294771 VA: 0x294670
	[SpaceAttribute] // RVA: 0x294670 Offset: 0x294771 VA: 0x294670
	public bool m_EnableEvening; // 0xB8
	[SerializeField] // RVA: 0x2946C0 Offset: 0x2947C1 VA: 0x2946C0
	[ColorUsageAttribute] // RVA: 0x2946C0 Offset: 0x2947C1 VA: 0x2946C0
	public Color m_EveningAmbientSkyColor; // 0xBC
	[SerializeField] // RVA: 0x294700 Offset: 0x294801 VA: 0x294700
	[ColorUsageAttribute] // RVA: 0x294700 Offset: 0x294801 VA: 0x294700
	public Color m_EveningAmbientEquatorColor; // 0xCC
	[SerializeField] // RVA: 0x294740 Offset: 0x294841 VA: 0x294740
	[ColorUsageAttribute] // RVA: 0x294740 Offset: 0x294841 VA: 0x294740
	public Color m_EveningAmbientGroundColor; // 0xDC
	public Color m_EveningFogColor; // 0xEC
	[RangeAttribute] // RVA: 0x294780 Offset: 0x294881 VA: 0x294780
	public float m_EveningFogStart; // 0xFC
	[RangeAttribute] // RVA: 0x2947A0 Offset: 0x2948A1 VA: 0x2947A0
	public float m_EveningFogEnd; // 0x100
	[SpaceAttribute] // RVA: 0x2947C0 Offset: 0x2948C1 VA: 0x2947C0
	[HeaderAttribute] // RVA: 0x2947C0 Offset: 0x2948C1 VA: 0x2947C0
	public bool m_EnableNight; // 0x104
	[SerializeField] // RVA: 0x294810 Offset: 0x294911 VA: 0x294810
	[ColorUsageAttribute] // RVA: 0x294810 Offset: 0x294911 VA: 0x294810
	public Color m_NightAmbientSkyColor; // 0x108
	[ColorUsageAttribute] // RVA: 0x294850 Offset: 0x294951 VA: 0x294850
	[SerializeField] // RVA: 0x294850 Offset: 0x294951 VA: 0x294850
	public Color m_NightAmbientEquatorColor; // 0x118
	[ColorUsageAttribute] // RVA: 0x294890 Offset: 0x294991 VA: 0x294890
	[SerializeField] // RVA: 0x294890 Offset: 0x294991 VA: 0x294890
	public Color m_NightAmbientGroundColor; // 0x128
	public Color m_NightFogColor; // 0x138
	[RangeAttribute] // RVA: 0x2948D0 Offset: 0x2949D1 VA: 0x2948D0
	public float m_NightFogStart; // 0x148
	[RangeAttribute] // RVA: 0x2948F0 Offset: 0x2949F1 VA: 0x2948F0
	public float m_NightFogEnd; // 0x14C
	private string[] baseTimezoneName; // 0x150
	private string[] textureNames; // 0x158
	private List<ResourceHandle> resourceHandles; // 0x160
	private LightmapData[] m_lightmapData; // 0x168

	// Methods

	[IteratorStateMachineAttribute] // RVA: 0x2C0790 Offset: 0x2C0891 VA: 0x2C0790
	// RVA: 0x305C890 Offset: 0x305C991 VA: 0x305C890
	public IEnumerator Load(string sceneName, HubUtil.TimezoneType timezoneType) { }

	// RVA: 0x305C930 Offset: 0x305CA31 VA: 0x305C930
	public void Apply(HubUtil.TimezoneType timezoneType) { }

	// RVA: 0x305D1B0 Offset: 0x305D2B1 VA: 0x305D1B0
	private void OnDestroy() { }

	// RVA: 0x305D2F0 Offset: 0x305D3F1 VA: 0x305D2F0
	private bool IsLoading() { }

	// RVA: 0x305D1C0 Offset: 0x305D2C1 VA: 0x305D1C0
	private void ClearResources() { }

	// RVA: 0x305D450 Offset: 0x305D551 VA: 0x305D450
	protected void .ctor() { }
}

