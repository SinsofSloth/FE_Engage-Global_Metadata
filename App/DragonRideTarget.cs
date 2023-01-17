// Namespace: App
public abstract class DragonRideTarget : MonoBehaviour // TypeDefIndex: 10544
{
	// Fields
	private const string cUIRootPath = "UI/Hub/DragonRide/Prefabs/";
	private const string cUITargetScorePath = "PopupNum_Score";
	private double[] cBaseScoreList; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x28F510 Offset: 0x28F611 VA: 0x28F510
	private int <ChainTypeFlag>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28F520 Offset: 0x28F621 VA: 0x28F520
	private string <ChainRootID>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28F530 Offset: 0x28F631 VA: 0x28F530
	private bool <IsChainRoot>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28F540 Offset: 0x28F641 VA: 0x28F540
	private DragonRideTarget.TargetType <Type>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x28F550 Offset: 0x28F651 VA: 0x28F550
	private bool <IsHitSpecialShot>k__BackingField; // 0x38
	public float m_RouletteChangeSecond; // 0x3C
	private float m_RouletteChangeTimer; // 0x40
	private int m_RouletteColor; // 0x44
	private bool m_IsRoulette; // 0x48
	private float m_AppearTimer; // 0x4C
	private DragonRideTarget.TargetState m_targetState; // 0x50
	private bool m_IsHitAssistShot; // 0x54
	private GameObject[] m_TypeObjectArray; // 0x58
	private List<Material> m_UseMaterialList; // 0x60
	private DragonRideCamera m_CameraScript; // 0x68
	private DragonRideConfig m_Config; // 0x70
	private int m_ShaderColorID; // 0x78
	private TextMeshProUGUI m_DestroyText; // 0x80
	private TextMeshProUGUI m_DestroySubText; // 0x88

	// Properties
	public int ChainTypeFlag { get; set; }
	public string ChainRootID { get; set; }
	public bool IsChainRoot { get; set; }
	public DragonRideTarget.TargetType Type { get; set; }
	public bool IsHitSpecialShot { get; set; }
	public bool IsShowComplete { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BF1A0 Offset: 0x2BF2A1 VA: 0x2BF1A0
	// RVA: 0x2DD9670 Offset: 0x2DD9771 VA: 0x2DD9670
	public int get_ChainTypeFlag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF1B0 Offset: 0x2BF2B1 VA: 0x2BF1B0
	// RVA: 0x2DD9680 Offset: 0x2DD9781 VA: 0x2DD9680
	public void set_ChainTypeFlag(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF1C0 Offset: 0x2BF2C1 VA: 0x2BF1C0
	// RVA: 0x2DD9690 Offset: 0x2DD9791 VA: 0x2DD9690
	public string get_ChainRootID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF1D0 Offset: 0x2BF2D1 VA: 0x2BF1D0
	// RVA: 0x2DD96A0 Offset: 0x2DD97A1 VA: 0x2DD96A0
	public void set_ChainRootID(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF1E0 Offset: 0x2BF2E1 VA: 0x2BF1E0
	// RVA: 0x2DD96B0 Offset: 0x2DD97B1 VA: 0x2DD96B0
	public bool get_IsChainRoot() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF1F0 Offset: 0x2BF2F1 VA: 0x2BF1F0
	// RVA: 0x2DD96C0 Offset: 0x2DD97C1 VA: 0x2DD96C0
	private void set_IsChainRoot(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF200 Offset: 0x2BF301 VA: 0x2BF200
	// RVA: 0x2DD96D0 Offset: 0x2DD97D1 VA: 0x2DD96D0
	public DragonRideTarget.TargetType get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF210 Offset: 0x2BF311 VA: 0x2BF210
	// RVA: 0x2DD96E0 Offset: 0x2DD97E1 VA: 0x2DD96E0
	public void set_Type(DragonRideTarget.TargetType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF220 Offset: 0x2BF321 VA: 0x2BF220
	// RVA: 0x2DD96F0 Offset: 0x2DD97F1 VA: 0x2DD96F0
	public bool get_IsHitSpecialShot() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF230 Offset: 0x2BF331 VA: 0x2BF230
	// RVA: 0x2DD9700 Offset: 0x2DD9801 VA: 0x2DD9700
	private void set_IsHitSpecialShot(bool value) { }

	// RVA: 0x2DD9710 Offset: 0x2DD9811 VA: 0x2DD9710
	public bool get_IsShowComplete() { }

	// RVA: 0x2DD9720 Offset: 0x2DD9821 VA: 0x2DD9720
	private void Start() { }

	// RVA: 0x2DD9730 Offset: 0x2DD9831 VA: 0x2DD9730
	private void OnDestroy() { }

	// RVA: 0x2DD9970 Offset: 0x2DD9A71 VA: 0x2DD9970
	private void Update() { }

	// RVA: 0x2DD9CF0 Offset: 0x2DD9DF1 VA: 0x2DD9CF0
	private void SetTypeVisible(int set) { }

	// RVA: 0x2DD9D70 Offset: 0x2DD9E71 VA: 0x2DD9D70
	public void Initialize(ref DragonRideCamera cameraScript, ref DragonRideConfig config, float random) { }

	// RVA: 0x2DD7BE0 Offset: 0x2DD7CE1 VA: 0x2DD7BE0
	public void HitTarget(bool isAssist, bool isSpecial) { }

	// RVA: 0x2DDA9C0 Offset: 0x2DDAAC1 VA: 0x2DDA9C0
	public void Execute(int reasonFlag, string rootID) { }

	// RVA: 0x2DDA2E0 Offset: 0x2DDA3E1 VA: 0x2DDA2E0
	public void SetDestroy() { }

	// RVA: 0x2DDB100 Offset: 0x2DDB201 VA: 0x2DDB100
	public bool IsChainStart() { }

	// RVA: 0x2DDB110 Offset: 0x2DDB211 VA: 0x2DDB110
	public bool IsAlive() { }

	// RVA: 0x2DDB120 Offset: 0x2DDB221 VA: 0x2DDB120
	public void SetChainExecute() { }

	// RVA: 0x2DDA200 Offset: 0x2DDA301 VA: 0x2DDA200
	private void PlayHitSE() { }

	// RVA: 0x2DDAA40 Offset: 0x2DDAB41 VA: 0x2DDAA40
	private void AddDestroyEffect() { }

	// RVA: 0x2DDACC0 Offset: 0x2DDADC1 VA: 0x2DDACC0
	private void AddDestroyUI(int score) { }

	// RVA: 0x2DDB280 Offset: 0x2DDB381 VA: 0x2DDB280
	protected void .ctor() { }
}

