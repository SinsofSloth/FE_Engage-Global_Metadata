// Namespace: App
public abstract class FishingFish : MonoBehaviour // TypeDefIndex: 10587
{
	// Fields
	private const float DefaultPerfectTime = 0.5;
	private FishingFish.FishState m_state; // 0x18
	private Vector3 m_LurePos; // 0x1C
	private List<ForecastFishData> m_ForecastList; // 0x28
	private int m_SelectedForecastNum; // 0x30
	public float m_SizeMult; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x292AE0 Offset: 0x292BE1 VA: 0x292AE0
	private SizeRank <FishRank>k__BackingField; // 0x38
	private FishingFishData m_Data; // 0x40
	private FishingConfig_Base m_ConfigBase; // 0x48
	private FishingConfig_WaitCatch m_ConfigWait; // 0x50
	private FishingConfig_Battle m_ConfigBattle; // 0x58
	private float m_HP; // 0x60
	private float m_LethalHP; // 0x64
	private float m_RecoveryHP; // 0x68
	private float m_EscapeSpeed; // 0x6C
	private float m_Timer; // 0x70
	private float m_PerfectTime; // 0x74
	private float m_CatchTime; // 0x78
	private float m_EffectTimer; // 0x7C
	private float m_ModelFadeTimer; // 0x80
	private float m_CounterTimer; // 0x84
	private float m_ForceTimer; // 0x88
	private float m_EscapeTimer; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x292AF0 Offset: 0x292BF1 VA: 0x292AF0
	private bool <IsPerfectStart>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x292B00 Offset: 0x292C01 VA: 0x292B00
	private bool <IsForceCounter>k__BackingField; // 0x91
	[CompilerGeneratedAttribute] // RVA: 0x292B10 Offset: 0x292C11 VA: 0x292B10
	private bool <IsLethal>k__BackingField; // 0x92
	[CompilerGeneratedAttribute] // RVA: 0x292B20 Offset: 0x292C21 VA: 0x292B20
	private bool <IsDrawFrame>k__BackingField; // 0x93
	[CompilerGeneratedAttribute] // RVA: 0x292B30 Offset: 0x292C31 VA: 0x292B30
	private bool <IsDamageFrame>k__BackingField; // 0x94
	private float m_ShadowDir; // 0x98
	private float m_TargetDir; // 0x9C
	private bool m_IsChanceDraw; // 0xA0
	private InterpolatorFloat m_DirInterp; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x292B40 Offset: 0x292C41 VA: 0x292B40
	private float <ShadowDistanceRate>k__BackingField; // 0xB0
	private float m_Power; // 0xB4
	private float m_AngleDiff; // 0xB8
	private GameObject m_LureObj; // 0xC0
	private GameObject m_RadarObj; // 0xC8
	private int m_FakeCount; // 0xD0
	private FishingBattleRader m_RadarScript; // 0xD8
	private float m_RadicalPower; // 0xE0
	private float m_RadicalRegene; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x292B50 Offset: 0x292C51 VA: 0x292B50
	private bool <FakeFlag>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x292B60 Offset: 0x292C61 VA: 0x292B60
	private bool <WaitAssistFlag>k__BackingField; // 0xE9
	[CompilerGeneratedAttribute] // RVA: 0x292B70 Offset: 0x292C71 VA: 0x292B70
	private bool <IsPlayCounterSplashSE>k__BackingField; // 0xEA
	[CompilerGeneratedAttribute] // RVA: 0x292B80 Offset: 0x292C81 VA: 0x292B80
	private bool <IsPlayOrdinalSplashSE>k__BackingField; // 0xEB
	[CompilerGeneratedAttribute] // RVA: 0x292B90 Offset: 0x292C91 VA: 0x292B90
	private bool <IsPlayLethalSplashSE>k__BackingField; // 0xEC

	// Properties
	public SizeRank FishRank { get; set; }
	public bool IsPerfectStart { get; set; }
	public bool IsCounter { get; }
	public bool IsForceCounter { get; set; }
	public bool IsDanger { get; }
	public bool IsLethal { get; set; }
	private bool IsDrawFrame { get; set; }
	private bool IsDamageFrame { get; set; }
	public float ShadowDistanceRate { get; set; }
	public bool FakeFlag { get; set; }
	public int RippleSize { get; }
	public bool WaitAssistFlag { get; set; }
	public bool IsCatching { get; }
	public bool IsEscape { get; }
	public bool IsDefeat { get; }
	public FishingFishData Data { get; }
	public float SizeMult { get; }
	public float HPRate { get; }
	public float LethalRate { get; }
	private bool IsPlayCounterSplashSE { get; set; }
	private bool IsPlayOrdinalSplashSE { get; set; }
	private bool IsPlayLethalSplashSE { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BF610 Offset: 0x2BF711 VA: 0x2BF610
	// RVA: 0x2EF6100 Offset: 0x2EF6201 VA: 0x2EF6100
	public SizeRank get_FishRank() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF620 Offset: 0x2BF721 VA: 0x2BF620
	// RVA: 0x2EF6110 Offset: 0x2EF6211 VA: 0x2EF6110
	private void set_FishRank(SizeRank value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF630 Offset: 0x2BF731 VA: 0x2BF630
	// RVA: 0x2EF6120 Offset: 0x2EF6221 VA: 0x2EF6120
	public bool get_IsPerfectStart() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF640 Offset: 0x2BF741 VA: 0x2BF640
	// RVA: 0x2EF6130 Offset: 0x2EF6231 VA: 0x2EF6130
	private void set_IsPerfectStart(bool value) { }

	// RVA: 0x2EF6140 Offset: 0x2EF6241 VA: 0x2EF6140
	public bool get_IsCounter() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF650 Offset: 0x2BF751 VA: 0x2BF650
	// RVA: 0x2EF6150 Offset: 0x2EF6251 VA: 0x2EF6150
	public bool get_IsForceCounter() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF660 Offset: 0x2BF761 VA: 0x2BF660
	// RVA: 0x2EF6160 Offset: 0x2EF6261 VA: 0x2EF6160
	public void set_IsForceCounter(bool value) { }

	// RVA: 0x2EF6170 Offset: 0x2EF6271 VA: 0x2EF6170
	public bool get_IsDanger() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF670 Offset: 0x2BF771 VA: 0x2BF670
	// RVA: 0x2EF6220 Offset: 0x2EF6321 VA: 0x2EF6220
	public bool get_IsLethal() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF680 Offset: 0x2BF781 VA: 0x2BF680
	// RVA: 0x2EF6230 Offset: 0x2EF6331 VA: 0x2EF6230
	private void set_IsLethal(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF690 Offset: 0x2BF791 VA: 0x2BF690
	// RVA: 0x2EF6240 Offset: 0x2EF6341 VA: 0x2EF6240
	private bool get_IsDrawFrame() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF6A0 Offset: 0x2BF7A1 VA: 0x2BF6A0
	// RVA: 0x2EF6250 Offset: 0x2EF6351 VA: 0x2EF6250
	private void set_IsDrawFrame(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF6B0 Offset: 0x2BF7B1 VA: 0x2BF6B0
	// RVA: 0x2EF6260 Offset: 0x2EF6361 VA: 0x2EF6260
	private bool get_IsDamageFrame() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF6C0 Offset: 0x2BF7C1 VA: 0x2BF6C0
	// RVA: 0x2EF6270 Offset: 0x2EF6371 VA: 0x2EF6270
	private void set_IsDamageFrame(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF6D0 Offset: 0x2BF7D1 VA: 0x2BF6D0
	// RVA: 0x2EF6280 Offset: 0x2EF6381 VA: 0x2EF6280
	public float get_ShadowDistanceRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF6E0 Offset: 0x2BF7E1 VA: 0x2BF6E0
	// RVA: 0x2EF6290 Offset: 0x2EF6391 VA: 0x2EF6290
	private void set_ShadowDistanceRate(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF6F0 Offset: 0x2BF7F1 VA: 0x2BF6F0
	// RVA: 0x2EF62A0 Offset: 0x2EF63A1 VA: 0x2EF62A0
	public bool get_FakeFlag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF700 Offset: 0x2BF801 VA: 0x2BF700
	// RVA: 0x2EF62B0 Offset: 0x2EF63B1 VA: 0x2EF62B0
	public void set_FakeFlag(bool value) { }

	// RVA: 0x2EF62C0 Offset: 0x2EF63C1 VA: 0x2EF62C0
	public int get_RippleSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF710 Offset: 0x2BF811 VA: 0x2BF710
	// RVA: 0x2EF62E0 Offset: 0x2EF63E1 VA: 0x2EF62E0
	public bool get_WaitAssistFlag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF720 Offset: 0x2BF821 VA: 0x2BF720
	// RVA: 0x2EF62F0 Offset: 0x2EF63F1 VA: 0x2EF62F0
	public void set_WaitAssistFlag(bool value) { }

	// RVA: 0x2EF6300 Offset: 0x2EF6401 VA: 0x2EF6300
	public bool get_IsCatching() { }

	// RVA: 0x2EF6310 Offset: 0x2EF6411 VA: 0x2EF6310
	public bool get_IsEscape() { }

	// RVA: 0x2EF6320 Offset: 0x2EF6421 VA: 0x2EF6320
	public bool get_IsDefeat() { }

	// RVA: 0x2EF6330 Offset: 0x2EF6431 VA: 0x2EF6330
	public FishingFishData get_Data() { }

	// RVA: 0x2EF6340 Offset: 0x2EF6441 VA: 0x2EF6340
	public float get_SizeMult() { }

	// RVA: 0x2EF63B0 Offset: 0x2EF64B1 VA: 0x2EF63B0
	public float get_HPRate() { }

	// RVA: 0x2EF63D0 Offset: 0x2EF64D1 VA: 0x2EF63D0
	public float get_LethalRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF730 Offset: 0x2BF831 VA: 0x2BF730
	// RVA: 0x2EF63F0 Offset: 0x2EF64F1 VA: 0x2EF63F0
	private bool get_IsPlayCounterSplashSE() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF740 Offset: 0x2BF841 VA: 0x2BF740
	// RVA: 0x2EF6400 Offset: 0x2EF6501 VA: 0x2EF6400
	private void set_IsPlayCounterSplashSE(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF750 Offset: 0x2BF851 VA: 0x2BF750
	// RVA: 0x2EF6410 Offset: 0x2EF6511 VA: 0x2EF6410
	private bool get_IsPlayOrdinalSplashSE() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF760 Offset: 0x2BF861 VA: 0x2BF760
	// RVA: 0x2EF6420 Offset: 0x2EF6521 VA: 0x2EF6420
	private void set_IsPlayOrdinalSplashSE(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF770 Offset: 0x2BF871 VA: 0x2BF770
	// RVA: 0x2EF6430 Offset: 0x2EF6531 VA: 0x2EF6430
	private bool get_IsPlayLethalSplashSE() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF780 Offset: 0x2BF881 VA: 0x2BF780
	// RVA: 0x2EF6440 Offset: 0x2EF6541 VA: 0x2EF6440
	private void set_IsPlayLethalSplashSE(bool value) { }

	// RVA: 0x2EF6450 Offset: 0x2EF6551 VA: 0x2EF6450
	private void Start() { }

	// RVA: 0x2EF6460 Offset: 0x2EF6561 VA: 0x2EF6460
	private void Update() { }

	// RVA: 0x2EF6F30 Offset: 0x2EF7031 VA: 0x2EF6F30
	public void InitFish() { }

	// RVA: 0x2EF7230 Offset: 0x2EF7331 VA: 0x2EF7230
	public void SetForecastData(List<ForecastFishData> set) { }

	// RVA: 0x2EF6F70 Offset: 0x2EF7071 VA: 0x2EF6F70
	private void SelectFish() { }

	// RVA: 0x2EF72A0 Offset: 0x2EF73A1 VA: 0x2EF72A0
	public void ResetFishData() { }

	// RVA: 0x2EF7310 Offset: 0x2EF7411 VA: 0x2EF7310
	public void SetConfigs(FishingConfig_Base baseConfig, FishingConfig_WaitCatch waitCatch, FishingConfig_Battle battle) { }

	// RVA: 0x2EF6640 Offset: 0x2EF6741 VA: 0x2EF6640
	private void TickWaitCatch() { }

	// RVA: 0x2EF6800 Offset: 0x2EF6901 VA: 0x2EF6800
	private void TickCatching() { }

	// RVA: 0x2EF68B0 Offset: 0x2EF69B1 VA: 0x2EF68B0
	private void TickWaitAssist() { }

	// RVA: 0x2EF7550 Offset: 0x2EF7651 VA: 0x2EF7550
	private void UpdateBattleEffect() { }

	// RVA: 0x2EF7810 Offset: 0x2EF7911 VA: 0x2EF7810
	private void UpdateLethalEffect() { }

	// RVA: 0x2EF79E0 Offset: 0x2EF7AE1 VA: 0x2EF79E0
	private void UpdateBattleCommon() { }

	// RVA: 0x2EF6940 Offset: 0x2EF6A41 VA: 0x2EF6940
	private void TickBattle() { }

	// RVA: 0x2EF6C50 Offset: 0x2EF6D51 VA: 0x2EF6C50
	private void TickWeak() { }

	// RVA: 0x2EF6EE0 Offset: 0x2EF6FE1 VA: 0x2EF6EE0
	private void TickLethal() { }

	// RVA: 0x2EF7FD0 Offset: 0x2EF80D1 VA: 0x2EF7FD0
	public void SetPerfectTimeAdd(float add) { }

	// RVA: 0x2EF7FF0 Offset: 0x2EF80F1 VA: 0x2EF7FF0
	public bool TryBattle(bool isAssist) { }

	// RVA: 0x2EF8150 Offset: 0x2EF8251 VA: 0x2EF8150
	public void UpdateLurePos(Vector3 pos) { }

	// RVA: 0x2EF8160 Offset: 0x2EF8261 VA: 0x2EF8160
	public void SetFirstPos() { }

	// RVA: 0x2EF8210 Offset: 0x2EF8311 VA: 0x2EF8210
	public void OverriteRadicalParam(float setPower, float setRegene) { }

	// RVA: 0x2EF8220 Offset: 0x2EF8321 VA: 0x2EF8220
	public void DrawFish(Vector2 stickVec) { }

	// RVA: 0x2EF85F0 Offset: 0x2EF86F1 VA: 0x2EF85F0
	public void Damage(float damage) { }

	// RVA: 0x2EF87D0 Offset: 0x2EF88D1 VA: 0x2EF87D0
	public void FirstDamage(float damageRate) { }

	// RVA: 0x2EF8810 Offset: 0x2EF8911 VA: 0x2EF8810
	public void LethalDamage() { }

	// RVA: 0x2EF7EF0 Offset: 0x2EF7FF1 VA: 0x2EF7EF0
	public void Recovery() { }

	// RVA: 0x2EF85E0 Offset: 0x2EF86E1 VA: 0x2EF85E0
	public void AddDamegeEffect() { }

	// RVA: 0x2EF8940 Offset: 0x2EF8A41 VA: 0x2EF8940
	public void RecoveryLethal() { }

	// RVA: 0x2EF7DE0 Offset: 0x2EF7EE1 VA: 0x2EF7DE0
	public void AddEscapeTimer() { }

	// RVA: 0x2EF7300 Offset: 0x2EF7401 VA: 0x2EF7300
	public void ResetEscapeTimer() { }

	// RVA: 0x2EF73B0 Offset: 0x2EF74B1 VA: 0x2EF73B0
	private void StartForceCounter() { }

	// RVA: 0x2EF8B20 Offset: 0x2EF8C21 VA: 0x2EF8B20
	public void SetRadar(FishingBattleRader radar) { }

	// RVA: 0x2EF80E0 Offset: 0x2EF81E1 VA: 0x2EF80E0
	public void EnableRadar_NoArea() { }

	// RVA: 0x2EF7360 Offset: 0x2EF7461 VA: 0x2EF7360
	public void EnableArea_Radar() { }

	// RVA: 0x2EF8B90 Offset: 0x2EF8C91 VA: 0x2EF8B90
	public bool IsEnableRadar() { }

	// RVA: 0x2EF8BA0 Offset: 0x2EF8CA1 VA: 0x2EF8BA0
	public void DisableRadar() { }

	// RVA: 0x2EF8C00 Offset: 0x2EF8D01 VA: 0x2EF8C00
	public bool CheckActiveUI() { }

	// RVA: 0x2EF8C50 Offset: 0x2EF8D51 VA: 0x2EF8C50
	public void SetLureObj(GameObject set) { }

	// RVA: 0x2EF8540 Offset: 0x2EF8641 VA: 0x2EF8540
	public Vector2 GetCounterVec() { }

	// RVA: 0x2EF8D00 Offset: 0x2EF8E01 VA: 0x2EF8D00
	public void AddCatchRipple(Vector3 addPos) { }

	// RVA: 0x2EF73D0 Offset: 0x2EF74D1 VA: 0x2EF73D0
	private void PlayCounterSE() { }

	// RVA: 0x2EF7BF0 Offset: 0x2EF7CF1 VA: 0x2EF7BF0
	private void StopCounterSE() { }

	// RVA: 0x2EF7D10 Offset: 0x2EF7E11 VA: 0x2EF7D10
	private void PlayOrdinalSE() { }

	// RVA: 0x2EF7F40 Offset: 0x2EF8041 VA: 0x2EF7F40
	private void StopOrdinalSE() { }

	// RVA: 0x2EF86F0 Offset: 0x2EF87F1 VA: 0x2EF86F0
	private void PlayLethalSE() { }

	// RVA: 0x2EF88B0 Offset: 0x2EF89B1 VA: 0x2EF88B0
	private void StopLethalSE() { }

	// RVA: 0x2EF8AA0 Offset: 0x2EF8BA1 VA: 0x2EF8AA0
	public void StopStunSE() { }

	// RVA: 0x2EF8E80 Offset: 0x2EF8F81 VA: 0x2EF8E80
	protected void .ctor() { }
}

