// Namespace: App
public class FishingResultUI // TypeDefIndex: 10609
{
	// Fields
	private Sprite[] m_Sprites; // 0x10
	private const string cTextureRootPath = "UI/Hub/Fishing/Textures/Fishing";
	private const string cResultTextureGold = "SizeBaseGold";
	private const string cResultTextureSilver = "SizeBaseSilver";
	private const string cResultTextureBronze = "SizeBaseBronze";
	private GameObject m_Root; // 0x18
	private FishingResultData m_Data; // 0x20
	private double m_Timer; // 0x28
	private float m_TimeLimit; // 0x30
	private bool m_IsNewRecord; // 0x34
	private FishingResultUI.ResultPhase m_Phase; // 0x38

	// Properties
	public bool IsReady { get; }
	public bool IsFinish { get; }

	// Methods

	// RVA: 0x29F1FF0 Offset: 0x29F20F1 VA: 0x29F1FF0
	public bool get_IsReady() { }

	// RVA: 0x29F2000 Offset: 0x29F2101 VA: 0x29F2000
	public bool get_IsFinish() { }

	// RVA: 0x29F2010 Offset: 0x29F2111 VA: 0x29F2010
	public void .ctor() { }

	// RVA: 0x29F2120 Offset: 0x29F2221 VA: 0x29F2120
	public void Init(GameObject rootObj, FishingResultData setData, float timeLimit) { }

	// RVA: 0x29F3670 Offset: 0x29F3771 VA: 0x29F3670
	public void OverwriteUserData() { }

	// RVA: 0x29F3C50 Offset: 0x29F3D51 VA: 0x29F3C50
	private void NextPhase() { }

	// RVA: 0x29F3C70 Offset: 0x29F3D71 VA: 0x29F3C70
	public void Start() { }

	// RVA: 0x29F3D40 Offset: 0x29F3E41 VA: 0x29F3D40
	public void Tick() { }

	// RVA: 0x29F3DF0 Offset: 0x29F3EF1 VA: 0x29F3DF0
	public void DestroyResult() { }

	// RVA: 0x29F3F40 Offset: 0x29F4041 VA: 0x29F3F40
	public void CloseResult() { }

	// RVA: 0x29F4040 Offset: 0x29F4141 VA: 0x29F4040
	public bool IsClosedResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFD90 Offset: 0x2BFE91 VA: 0x2BFD90
	// RVA: 0x29F3580 Offset: 0x29F3681 VA: 0x29F3580
	internal static string <Init>g__GetNearBondData|12_0(int count) { }
}

