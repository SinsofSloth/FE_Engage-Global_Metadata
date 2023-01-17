// Namespace: App
public class CommonRewardMenuContent : BasicMenuContent // TypeDefIndex: 12593
{
	// Fields
	private const string PrefabPath = "UI/Network/Challenge/Prefabs/ExpRoot";
	[SerializeField] // RVA: 0x29B090 Offset: 0x29B191 VA: 0x29B090
	[HeaderAttribute] // RVA: 0x29B090 Offset: 0x29B191 VA: 0x29B090
	private int m_GaugeSpeedDefault; // 0xE8
	[HeaderAttribute] // RVA: 0x29B0E0 Offset: 0x29B1E1 VA: 0x29B0E0
	[SerializeField] // RVA: 0x29B0E0 Offset: 0x29B1E1 VA: 0x29B0E0
	private int m_GaugeSpeedSkip; // 0xEC
	[SerializeField] // RVA: 0x29B130 Offset: 0x29B231 VA: 0x29B130
	[HeaderAttribute] // RVA: 0x29B130 Offset: 0x29B231 VA: 0x29B130
	private int m_ScrollStart; // 0xF0
	[RangeAttribute] // RVA: 0x29B180 Offset: 0x29B281 VA: 0x29B180
	[HeaderAttribute] // RVA: 0x29B180 Offset: 0x29B281 VA: 0x29B180
	[SerializeField] // RVA: 0x29B180 Offset: 0x29B281 VA: 0x29B180
	private float m_WaitTimeStart; // 0xF4
	[HeaderAttribute] // RVA: 0x29B1F0 Offset: 0x29B2F1 VA: 0x29B1F0
	[RangeAttribute] // RVA: 0x29B1F0 Offset: 0x29B2F1 VA: 0x29B1F0
	[SerializeField] // RVA: 0x29B1F0 Offset: 0x29B2F1 VA: 0x29B1F0
	private float m_WaitTimeEnd; // 0xF8

	// Properties
	public int GaugeSpeedDefault { get; }
	public int GaugeSpeedSkip { get; }
	public int ScrollStart { get; }
	public float WaitTimeStart { get; }
	public float WaitTimeEnd { get; }

	// Methods

	// RVA: 0x257D430 Offset: 0x257D531 VA: 0x257D430
	public int get_GaugeSpeedDefault() { }

	// RVA: 0x257D440 Offset: 0x257D541 VA: 0x257D440
	public int get_GaugeSpeedSkip() { }

	// RVA: 0x257D450 Offset: 0x257D551 VA: 0x257D450
	public int get_ScrollStart() { }

	// RVA: 0x257D460 Offset: 0x257D561 VA: 0x257D460
	public float get_WaitTimeStart() { }

	// RVA: 0x257D470 Offset: 0x257D571 VA: 0x257D470
	public float get_WaitTimeEnd() { }

	// RVA: 0x257D480 Offset: 0x257D581 VA: 0x257D480
	public static void LoadPrefabAsync() { }

	// RVA: 0x257D520 Offset: 0x257D621 VA: 0x257D520
	public static bool IsLoadingPrefab() { }

	// RVA: 0x257D5A0 Offset: 0x257D6A1 VA: 0x257D5A0
	public static void UnloadPrefab() { }

	// RVA: 0x257C4F0 Offset: 0x257C5F1 VA: 0x257C4F0
	public static CommonRewardMenuContent Create() { }

	// RVA: 0x257D620 Offset: 0x257D721 VA: 0x257D620 Slot: 27
	public override void AfterBuild() { }

	// RVA: 0x257D700 Offset: 0x257D801 VA: 0x257D700
	public void .ctor() { }
}

