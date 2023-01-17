// Namespace: 
public struct ParticleSystem.MainModule // TypeDefIndex: 4793
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public float duration { get; }
	public bool loop { get; set; }
	public float startDelayMultiplier { get; set; }
	public float startLifetimeMultiplier { get; set; }
	public float startSpeedMultiplier { get; set; }
	[NativeNameAttribute] // RVA: 0x513B0 Offset: 0x514B1 VA: 0x513B0
	public float startSizeMultiplier { get; set; }
	[NativeNameAttribute] // RVA: 0x513F0 Offset: 0x514F1 VA: 0x513F0
	public ParticleSystem.MinMaxCurve startRotation { set; }
	[NativeNameAttribute] // RVA: 0x51430 Offset: 0x51531 VA: 0x51430
	public float startRotationMultiplier { get; set; }
	public float startRotationXMultiplier { get; set; }
	public float startRotationYMultiplier { get; set; }
	public float startRotationZMultiplier { get; set; }
	public ParticleSystem.MinMaxGradient startColor { get; set; }
	public float gravityModifierMultiplier { get; set; }
	public ParticleSystemSimulationSpace simulationSpace { get; set; }
	public float simulationSpeed { get; set; }
	public ParticleSystemScalingMode scalingMode { get; set; }
	public bool playOnAwake { get; set; }
	public int maxParticles { get; set; }
	public ParticleSystemStopAction stopAction { get; set; }
	public ParticleSystemCullingMode cullingMode { get; set; }

	// Methods

	// RVA: 0x1C33690 Offset: 0x1C33791 VA: 0x1C33690
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x1C2FF10 Offset: 0x1C30011 VA: 0x1C2FF10
	public float get_duration() { }

	// RVA: 0x1C2FC30 Offset: 0x1C2FD31 VA: 0x1C2FC30
	public bool get_loop() { }

	[NativeThrowsAttribute] // RVA: 0x50440 Offset: 0x50541 VA: 0x50440
	// RVA: 0x1C2FCF0 Offset: 0x1C2FDF1 VA: 0x1C2FCF0
	public void set_loop(bool value) { }

	// RVA: 0x1C2FAC0 Offset: 0x1C2FBC1 VA: 0x1C2FAC0
	public float get_startDelayMultiplier() { }

	[NativeThrowsAttribute] // RVA: 0x50450 Offset: 0x50551 VA: 0x50450
	// RVA: 0x1C2FB80 Offset: 0x1C2FC81 VA: 0x1C2FB80
	public void set_startDelayMultiplier(float value) { }

	// RVA: 0x1C31050 Offset: 0x1C31151 VA: 0x1C31050
	public float get_startLifetimeMultiplier() { }

	[NativeThrowsAttribute] // RVA: 0x50460 Offset: 0x50561 VA: 0x50460
	// RVA: 0x1C31110 Offset: 0x1C31211 VA: 0x1C31110
	public void set_startLifetimeMultiplier(float value) { }

	// RVA: 0x1C30510 Offset: 0x1C30611 VA: 0x1C30510
	public float get_startSpeedMultiplier() { }

	[NativeThrowsAttribute] // RVA: 0x50470 Offset: 0x50571 VA: 0x50470
	// RVA: 0x1C305D0 Offset: 0x1C306D1 VA: 0x1C305D0
	public void set_startSpeedMultiplier(float value) { }

	// RVA: 0x1C30680 Offset: 0x1C30781 VA: 0x1C30680
	public float get_startSizeMultiplier() { }

	[NativeThrowsAttribute] // RVA: 0x50480 Offset: 0x50581 VA: 0x50480
	// RVA: 0x1C30740 Offset: 0x1C30841 VA: 0x1C30740
	public void set_startSizeMultiplier(float value) { }

	[NativeThrowsAttribute] // RVA: 0x50490 Offset: 0x50591 VA: 0x50490
	// RVA: 0x1C36FD0 Offset: 0x1C370D1 VA: 0x1C36FD0
	public void set_startRotation(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C30B20 Offset: 0x1C30C21 VA: 0x1C30B20
	public float get_startRotationMultiplier() { }

	[NativeThrowsAttribute] // RVA: 0x504A0 Offset: 0x505A1 VA: 0x504A0
	// RVA: 0x1C30BE0 Offset: 0x1C30CE1 VA: 0x1C30BE0
	public void set_startRotationMultiplier(float value) { }

	// RVA: 0x1C30D30 Offset: 0x1C30E31 VA: 0x1C30D30
	public float get_startRotationXMultiplier() { }

	[NativeThrowsAttribute] // RVA: 0x504B0 Offset: 0x505B1 VA: 0x504B0
	// RVA: 0x1C30F00 Offset: 0x1C31001 VA: 0x1C30F00
	public void set_startRotationXMultiplier(float value) { }

	// RVA: 0x1C30D80 Offset: 0x1C30E81 VA: 0x1C30D80
	public float get_startRotationYMultiplier() { }

	[NativeThrowsAttribute] // RVA: 0x504C0 Offset: 0x505C1 VA: 0x504C0
	// RVA: 0x1C30F50 Offset: 0x1C31051 VA: 0x1C30F50
	public void set_startRotationYMultiplier(float value) { }

	// RVA: 0x1C30DD0 Offset: 0x1C30ED1 VA: 0x1C30DD0
	public float get_startRotationZMultiplier() { }

	[NativeThrowsAttribute] // RVA: 0x504D0 Offset: 0x505D1 VA: 0x504D0
	// RVA: 0x1C30FA0 Offset: 0x1C310A1 VA: 0x1C30FA0
	public void set_startRotationZMultiplier(float value) { }

	// RVA: 0x1C30810 Offset: 0x1C30911 VA: 0x1C30810
	public ParticleSystem.MinMaxGradient get_startColor() { }

	[NativeThrowsAttribute] // RVA: 0x504E0 Offset: 0x505E1 VA: 0x504E0
	// RVA: 0x1C30A70 Offset: 0x1C30B71 VA: 0x1C30A70
	public void set_startColor(ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x1C311C0 Offset: 0x1C312C1 VA: 0x1C311C0
	public float get_gravityModifierMultiplier() { }

	[NativeThrowsAttribute] // RVA: 0x504F0 Offset: 0x505F1 VA: 0x504F0
	// RVA: 0x1C31280 Offset: 0x1C31381 VA: 0x1C31280
	public void set_gravityModifierMultiplier(float value) { }

	// RVA: 0x1C314A0 Offset: 0x1C315A1 VA: 0x1C314A0
	public ParticleSystemSimulationSpace get_simulationSpace() { }

	[NativeThrowsAttribute] // RVA: 0x50500 Offset: 0x50601 VA: 0x50500
	// RVA: 0x1C31560 Offset: 0x1C31661 VA: 0x1C31560
	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	// RVA: 0x1C2FFC0 Offset: 0x1C300C1 VA: 0x1C2FFC0
	public float get_simulationSpeed() { }

	[NativeThrowsAttribute] // RVA: 0x50510 Offset: 0x50611 VA: 0x50510
	// RVA: 0x1C30080 Offset: 0x1C30181 VA: 0x1C30080
	public void set_simulationSpeed(float value) { }

	// RVA: 0x1C31610 Offset: 0x1C31711 VA: 0x1C31610
	public ParticleSystemScalingMode get_scalingMode() { }

	[NativeThrowsAttribute] // RVA: 0x50520 Offset: 0x50621 VA: 0x50520
	// RVA: 0x1C316D0 Offset: 0x1C317D1 VA: 0x1C316D0
	public void set_scalingMode(ParticleSystemScalingMode value) { }

	// RVA: 0x1C2FDA0 Offset: 0x1C2FEA1 VA: 0x1C2FDA0
	public bool get_playOnAwake() { }

	[NativeThrowsAttribute] // RVA: 0x50530 Offset: 0x50631 VA: 0x50530
	// RVA: 0x1C2FE60 Offset: 0x1C2FF61 VA: 0x1C2FE60
	public void set_playOnAwake(bool value) { }

	// RVA: 0x1C31330 Offset: 0x1C31431 VA: 0x1C31330
	public int get_maxParticles() { }

	[NativeThrowsAttribute] // RVA: 0x50540 Offset: 0x50641 VA: 0x50540
	// RVA: 0x1C313F0 Offset: 0x1C314F1 VA: 0x1C313F0
	public void set_maxParticles(int value) { }

	// RVA: 0x1C37750 Offset: 0x1C37851 VA: 0x1C37750
	public ParticleSystemStopAction get_stopAction() { }

	[NativeThrowsAttribute] // RVA: 0x50550 Offset: 0x50651 VA: 0x50550
	// RVA: 0x1C377F0 Offset: 0x1C378F1 VA: 0x1C377F0
	public void set_stopAction(ParticleSystemStopAction value) { }

	// RVA: 0x1C37890 Offset: 0x1C37991 VA: 0x1C37890
	public ParticleSystemCullingMode get_cullingMode() { }

	[NativeThrowsAttribute] // RVA: 0x50560 Offset: 0x50661 VA: 0x50560
	// RVA: 0x1C37930 Offset: 0x1C37A31 VA: 0x1C37930
	public void set_cullingMode(ParticleSystemCullingMode value) { }

	// RVA: 0x1C36C60 Offset: 0x1C36D61 VA: 0x1C36C60
	private static float get_duration_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C36CB0 Offset: 0x1C36DB1 VA: 0x1C36CB0
	private static bool get_loop_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C36D00 Offset: 0x1C36E01 VA: 0x1C36D00
	private static void set_loop_Injected(ref ParticleSystem.MainModule _unity_self, bool value) { }

	// RVA: 0x1C36D50 Offset: 0x1C36E51 VA: 0x1C36D50
	private static float get_startDelayMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C36DA0 Offset: 0x1C36EA1 VA: 0x1C36DA0
	private static void set_startDelayMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1C36DF0 Offset: 0x1C36EF1 VA: 0x1C36DF0
	private static float get_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C36E40 Offset: 0x1C36F41 VA: 0x1C36E40
	private static void set_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1C36E90 Offset: 0x1C36F91 VA: 0x1C36E90
	private static float get_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C36EE0 Offset: 0x1C36FE1 VA: 0x1C36EE0
	private static void set_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1C36F30 Offset: 0x1C37031 VA: 0x1C36F30
	private static float get_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C36F80 Offset: 0x1C37081 VA: 0x1C36F80
	private static void set_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1C37020 Offset: 0x1C37121 VA: 0x1C37020
	private static void set_startRotation_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C37070 Offset: 0x1C37171 VA: 0x1C37070
	private static float get_startRotationMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C370C0 Offset: 0x1C371C1 VA: 0x1C370C0
	private static void set_startRotationMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1C37110 Offset: 0x1C37211 VA: 0x1C37110
	private static float get_startRotationXMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C37160 Offset: 0x1C37261 VA: 0x1C37160
	private static void set_startRotationXMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1C371B0 Offset: 0x1C372B1 VA: 0x1C371B0
	private static float get_startRotationYMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C37200 Offset: 0x1C37301 VA: 0x1C37200
	private static void set_startRotationYMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1C37250 Offset: 0x1C37351 VA: 0x1C37250
	private static float get_startRotationZMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C372A0 Offset: 0x1C373A1 VA: 0x1C372A0
	private static void set_startRotationZMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1C372F0 Offset: 0x1C373F1 VA: 0x1C372F0
	private static void get_startColor_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxGradient ret) { }

	// RVA: 0x1C37340 Offset: 0x1C37441 VA: 0x1C37340
	private static void set_startColor_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxGradient value) { }

	// RVA: 0x1C37390 Offset: 0x1C37491 VA: 0x1C37390
	private static float get_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C373E0 Offset: 0x1C374E1 VA: 0x1C373E0
	private static void set_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1C37430 Offset: 0x1C37531 VA: 0x1C37430
	private static ParticleSystemSimulationSpace get_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C37480 Offset: 0x1C37581 VA: 0x1C37480
	private static void set_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemSimulationSpace value) { }

	// RVA: 0x1C374D0 Offset: 0x1C375D1 VA: 0x1C374D0
	private static float get_simulationSpeed_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C37520 Offset: 0x1C37621 VA: 0x1C37520
	private static void set_simulationSpeed_Injected(ref ParticleSystem.MainModule _unity_self, float value) { }

	// RVA: 0x1C37570 Offset: 0x1C37671 VA: 0x1C37570
	private static ParticleSystemScalingMode get_scalingMode_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C375C0 Offset: 0x1C376C1 VA: 0x1C375C0
	private static void set_scalingMode_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemScalingMode value) { }

	// RVA: 0x1C37610 Offset: 0x1C37711 VA: 0x1C37610
	private static bool get_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C37660 Offset: 0x1C37761 VA: 0x1C37660
	private static void set_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self, bool value) { }

	// RVA: 0x1C376B0 Offset: 0x1C377B1 VA: 0x1C376B0
	private static int get_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C37700 Offset: 0x1C37801 VA: 0x1C37700
	private static void set_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self, int value) { }

	// RVA: 0x1C377A0 Offset: 0x1C378A1 VA: 0x1C377A0
	private static ParticleSystemStopAction get_stopAction_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C37840 Offset: 0x1C37941 VA: 0x1C37840
	private static void set_stopAction_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemStopAction value) { }

	// RVA: 0x1C378E0 Offset: 0x1C379E1 VA: 0x1C378E0
	private static ParticleSystemCullingMode get_cullingMode_Injected(ref ParticleSystem.MainModule _unity_self) { }

	// RVA: 0x1C37980 Offset: 0x1C37A81 VA: 0x1C37980
	private static void set_cullingMode_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemCullingMode value) { }
}

// Namespace: 
public struct ParticleSystem.EmissionModule // TypeDefIndex: 4794
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public bool enabled { get; set; }
	public ParticleSystem.MinMaxCurve rateOverTime { set; }
	public float rateOverTimeMultiplier { get; }

	// Methods

	// RVA: 0x1C336A0 Offset: 0x1C337A1 VA: 0x1C336A0
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x1C30160 Offset: 0x1C30261 VA: 0x1C30160
	public bool get_enabled() { }

	[NativeThrowsAttribute] // RVA: 0x50570 Offset: 0x50671 VA: 0x50570
	// RVA: 0x1C30220 Offset: 0x1C30321 VA: 0x1C30220
	public void set_enabled(bool value) { }

	[NativeThrowsAttribute] // RVA: 0x50580 Offset: 0x50681 VA: 0x50580
	// RVA: 0x1C30460 Offset: 0x1C30561 VA: 0x1C30460
	public void set_rateOverTime(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C302D0 Offset: 0x1C303D1 VA: 0x1C302D0
	public float get_rateOverTimeMultiplier() { }

	// RVA: 0x1C36B20 Offset: 0x1C36C21 VA: 0x1C36B20
	private static bool get_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	// RVA: 0x1C36B70 Offset: 0x1C36C71 VA: 0x1C36B70
	private static void set_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self, bool value) { }

	// RVA: 0x1C36BC0 Offset: 0x1C36CC1 VA: 0x1C36BC0
	private static void set_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C36C10 Offset: 0x1C36D11 VA: 0x1C36C10
	private static float get_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self) { }
}

// Namespace: 
public struct ParticleSystem.ShapeModule // TypeDefIndex: 4795
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public bool enabled { set; }
	public ParticleSystemShapeType shapeType { set; }
	public SkinnedMeshRenderer skinnedMeshRenderer { get; set; }

	// Methods

	// RVA: 0x1C336E0 Offset: 0x1C337E1 VA: 0x1C336E0
	internal void .ctor(ParticleSystem particleSystem) { }

	[NativeThrowsAttribute] // RVA: 0x50590 Offset: 0x50691 VA: 0x50590
	// RVA: 0x1C37AE0 Offset: 0x1C37BE1 VA: 0x1C37AE0
	public void set_enabled(bool value) { }

	[NativeThrowsAttribute] // RVA: 0x505A0 Offset: 0x506A1 VA: 0x505A0
	// RVA: 0x1C37B80 Offset: 0x1C37C81 VA: 0x1C37B80
	public void set_shapeType(ParticleSystemShapeType value) { }

	// RVA: 0x1C37C20 Offset: 0x1C37D21 VA: 0x1C37C20
	public SkinnedMeshRenderer get_skinnedMeshRenderer() { }

	[NativeThrowsAttribute] // RVA: 0x505B0 Offset: 0x506B1 VA: 0x505B0
	// RVA: 0x1C37CC0 Offset: 0x1C37DC1 VA: 0x1C37CC0
	public void set_skinnedMeshRenderer(SkinnedMeshRenderer value) { }

	// RVA: 0x1C37B30 Offset: 0x1C37C31 VA: 0x1C37B30
	private static void set_enabled_Injected(ref ParticleSystem.ShapeModule _unity_self, bool value) { }

	// RVA: 0x1C37BD0 Offset: 0x1C37CD1 VA: 0x1C37BD0
	private static void set_shapeType_Injected(ref ParticleSystem.ShapeModule _unity_self, ParticleSystemShapeType value) { }

	// RVA: 0x1C37C70 Offset: 0x1C37D71 VA: 0x1C37C70
	private static SkinnedMeshRenderer get_skinnedMeshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self) { }

	// RVA: 0x1C37D10 Offset: 0x1C37E11 VA: 0x1C37D10
	private static void set_skinnedMeshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self, SkinnedMeshRenderer value) { }
}

// Namespace: 
public struct ParticleSystem.CollisionModule // TypeDefIndex: 4796
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33A60 Offset: 0x1C33B61 VA: 0x1C33A60
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.TriggerModule // TypeDefIndex: 4797
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33AA0 Offset: 0x1C33BA1 VA: 0x1C33AA0
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.SubEmittersModule // TypeDefIndex: 4798
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33AE0 Offset: 0x1C33BE1 VA: 0x1C33AE0
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.TextureSheetAnimationModule // TypeDefIndex: 4799
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33B20 Offset: 0x1C33C21 VA: 0x1C33B20
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
[RequiredByNativeCodeAttribute] // RVA: 0x4EF90 Offset: 0x4F091 VA: 0x4EF90
public struct ParticleSystem.Particle // TypeDefIndex: 4800
{
	// Fields
	private Vector3 m_Position; // 0x0
	private Vector3 m_Velocity; // 0xC
	private Vector3 m_AnimatedVelocity; // 0x18
	private Vector3 m_InitialVelocity; // 0x24
	private Vector3 m_AxisOfRotation; // 0x30
	private Vector3 m_Rotation; // 0x3C
	private Vector3 m_AngularVelocity; // 0x48
	private Vector3 m_StartSize; // 0x54
	private Color32 m_StartColor; // 0x60
	private uint m_RandomSeed; // 0x64
	private uint m_ParentRandomSeed; // 0x68
	private float m_Lifetime; // 0x6C
	private float m_StartLifetime; // 0x70
	private int m_MeshIndex; // 0x74
	private float m_EmitAccumulator0; // 0x78
	private float m_EmitAccumulator1; // 0x7C
	private uint m_Flags; // 0x80

	// Properties
	[ObsoleteAttribute] // RVA: 0x51470 Offset: 0x51571 VA: 0x51470
	public float lifetime { set; }
	public Vector3 position { set; }
	public Vector3 velocity { set; }
	public float remainingLifetime { set; }
	public float startLifetime { set; }
	public Color32 startColor { set; }
	public uint randomSeed { set; }
	public float startSize { set; }
	public float rotation { set; }
	public Vector3 rotation3D { set; }
	public Vector3 angularVelocity3D { set; }

	// Methods

	// RVA: 0x1C2F8C0 Offset: 0x1C2F9C1 VA: 0x1C2F8C0
	public void set_lifetime(float value) { }

	// RVA: 0x1C2F8A0 Offset: 0x1C2F9A1 VA: 0x1C2F8A0
	public void set_position(Vector3 value) { }

	// RVA: 0x1C2F8B0 Offset: 0x1C2F9B1 VA: 0x1C2F8B0
	public void set_velocity(Vector3 value) { }

	// RVA: 0x1C37AB0 Offset: 0x1C37BB1 VA: 0x1C37AB0
	public void set_remainingLifetime(float value) { }

	// RVA: 0x1C2F8D0 Offset: 0x1C2F9D1 VA: 0x1C2F8D0
	public void set_startLifetime(float value) { }

	// RVA: 0x1C2F970 Offset: 0x1C2FA71 VA: 0x1C2F970
	public void set_startColor(Color32 value) { }

	// RVA: 0x1C2F980 Offset: 0x1C2FA81 VA: 0x1C2F980
	public void set_randomSeed(uint value) { }

	// RVA: 0x1C2F8E0 Offset: 0x1C2F9E1 VA: 0x1C2F8E0
	public void set_startSize(float value) { }

	// RVA: 0x1C37AC0 Offset: 0x1C37BC1 VA: 0x1C37AC0
	public void set_rotation(float value) { }

	// RVA: 0x1C2F8F0 Offset: 0x1C2F9F1 VA: 0x1C2F8F0
	public void set_rotation3D(Vector3 value) { }

	// RVA: 0x1C2F930 Offset: 0x1C2FA31 VA: 0x1C2F930
	public void set_angularVelocity3D(Vector3 value) { }
}

// Namespace: 
[NativeTypeAttribute] // RVA: 0x4EFE0 Offset: 0x4F0E1 VA: 0x4EFE0
[Serializable]
public struct ParticleSystem.MinMaxCurve // TypeDefIndex: 4801
{
	// Fields
	[SerializeField] // RVA: 0x4F340 Offset: 0x4F441 VA: 0x4F340
	private ParticleSystemCurveMode m_Mode; // 0x0
	[SerializeField] // RVA: 0x4F350 Offset: 0x4F451 VA: 0x4F350
	private float m_CurveMultiplier; // 0x4
	[SerializeField] // RVA: 0x4F360 Offset: 0x4F461 VA: 0x4F360
	private AnimationCurve m_CurveMin; // 0x8
	[SerializeField] // RVA: 0x4F370 Offset: 0x4F471 VA: 0x4F370
	private AnimationCurve m_CurveMax; // 0x10
	[SerializeField] // RVA: 0x4F380 Offset: 0x4F481 VA: 0x4F380
	private float m_ConstantMin; // 0x18
	[SerializeField] // RVA: 0x4F390 Offset: 0x4F491 VA: 0x4F390
	private float m_ConstantMax; // 0x1C

	// Methods

	// RVA: 0x1C379D0 Offset: 0x1C37AD1 VA: 0x1C379D0
	public void .ctor(float constant) { }

	// RVA: 0x1C303E0 Offset: 0x1C304E1 VA: 0x1C303E0
	public static ParticleSystem.MinMaxCurve op_Implicit(float constant) { }
}

// Namespace: 
[NativeTypeAttribute] // RVA: 0x4F040 Offset: 0x4F141 VA: 0x4F040
[Serializable]
public struct ParticleSystem.MinMaxGradient // TypeDefIndex: 4802
{
	// Fields
	[SerializeField] // RVA: 0x4F3A0 Offset: 0x4F4A1 VA: 0x4F3A0
	private ParticleSystemGradientMode m_Mode; // 0x0
	[SerializeField] // RVA: 0x4F3B0 Offset: 0x4F4B1 VA: 0x4F3B0
	private Gradient m_GradientMin; // 0x8
	[SerializeField] // RVA: 0x4F3C0 Offset: 0x4F4C1 VA: 0x4F3C0
	private Gradient m_GradientMax; // 0x10
	[SerializeField] // RVA: 0x4F3D0 Offset: 0x4F4D1 VA: 0x4F3D0
	private Color m_ColorMin; // 0x18
	[SerializeField] // RVA: 0x4F3E0 Offset: 0x4F4E1 VA: 0x4F3E0
	private Color m_ColorMax; // 0x28

	// Properties
	public Color color { get; }

	// Methods

	// RVA: 0x1C37A20 Offset: 0x1C37B21 VA: 0x1C37A20
	public void .ctor(Color color) { }

	// RVA: 0x1C308A0 Offset: 0x1C309A1 VA: 0x1C308A0
	public Color get_color() { }

	// RVA: 0x1C309A0 Offset: 0x1C30AA1 VA: 0x1C309A0
	public static ParticleSystem.MinMaxGradient op_Implicit(Color color) { }
}

// Namespace: 
public struct ParticleSystem.EmitParams // TypeDefIndex: 4803
{
	// Fields
	[NativeNameAttribute] // RVA: 0x4F3F0 Offset: 0x4F4F1 VA: 0x4F3F0
	private ParticleSystem.Particle m_Particle; // 0x0
	[NativeNameAttribute] // RVA: 0x4F430 Offset: 0x4F531 VA: 0x4F430
	private bool m_PositionSet; // 0x84
	[NativeNameAttribute] // RVA: 0x4F470 Offset: 0x4F571 VA: 0x4F470
	private bool m_VelocitySet; // 0x85
	[NativeNameAttribute] // RVA: 0x4F4B0 Offset: 0x4F5B1 VA: 0x4F4B0
	private bool m_AxisOfRotationSet; // 0x86
	[NativeNameAttribute] // RVA: 0x4F4F0 Offset: 0x4F5F1 VA: 0x4F4F0
	private bool m_RotationSet; // 0x87
	[NativeNameAttribute] // RVA: 0x4F530 Offset: 0x4F631 VA: 0x4F530
	private bool m_AngularVelocitySet; // 0x88
	[NativeNameAttribute] // RVA: 0x4F570 Offset: 0x4F671 VA: 0x4F570
	private bool m_StartSizeSet; // 0x89
	[NativeNameAttribute] // RVA: 0x4F5B0 Offset: 0x4F6B1 VA: 0x4F5B0
	private bool m_StartColorSet; // 0x8A
	[NativeNameAttribute] // RVA: 0x4F5F0 Offset: 0x4F6F1 VA: 0x4F5F0
	private bool m_RandomSeedSet; // 0x8B
	[NativeNameAttribute] // RVA: 0x4F630 Offset: 0x4F731 VA: 0x4F630
	private bool m_StartLifetimeSet; // 0x8C
	[NativeNameAttribute] // RVA: 0x4F670 Offset: 0x4F771 VA: 0x4F670
	private bool m_MeshIndexSet; // 0x8D
	[NativeNameAttribute] // RVA: 0x4F6B0 Offset: 0x4F7B1 VA: 0x4F6B0
	private bool m_ApplyShapeToPosition; // 0x8E
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Seed // TypeDefIndex: 4804
{
	// Fields
	public uint x; // 0x0
	public uint y; // 0x4
	public uint z; // 0x8
	public uint w; // 0xC
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Seed4 // TypeDefIndex: 4805
{
	// Fields
	public ParticleSystem.PlaybackState.Seed x; // 0x0
	public ParticleSystem.PlaybackState.Seed y; // 0x10
	public ParticleSystem.PlaybackState.Seed z; // 0x20
	public ParticleSystem.PlaybackState.Seed w; // 0x30
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Emission // TypeDefIndex: 4806
{
	// Fields
	public float m_ParticleSpacing; // 0x0
	public float m_ToEmitAccumulator; // 0x4
	public ParticleSystem.PlaybackState.Seed m_Random; // 0x8
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Initial // TypeDefIndex: 4807
{
	// Fields
	public ParticleSystem.PlaybackState.Seed4 m_Random; // 0x0
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Shape // TypeDefIndex: 4808
{
	// Fields
	public ParticleSystem.PlaybackState.Seed4 m_Random; // 0x0
	public float m_RadiusTimer; // 0x40
	public float m_RadiusTimerPrev; // 0x44
	public float m_ArcTimer; // 0x48
	public float m_ArcTimerPrev; // 0x4C
	public float m_MeshSpawnTimer; // 0x50
	public float m_MeshSpawnTimerPrev; // 0x54
	public int m_OrderedMeshVertexIndex; // 0x58
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Force // TypeDefIndex: 4809
{
	// Fields
	public ParticleSystem.PlaybackState.Seed4 m_Random; // 0x0
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Collision // TypeDefIndex: 4810
{
	// Fields
	public ParticleSystem.PlaybackState.Seed4 m_Random; // 0x0
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Noise // TypeDefIndex: 4811
{
	// Fields
	public float m_ScrollOffset; // 0x0
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Lights // TypeDefIndex: 4812
{
	// Fields
	public ParticleSystem.PlaybackState.Seed m_Random; // 0x0
	public float m_ParticleEmissionCounter; // 0x10
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Trail // TypeDefIndex: 4813
{
	// Fields
	public float m_Timer; // 0x0
}

// Namespace: 
public struct ParticleSystem.PlaybackState // TypeDefIndex: 4814
{
	// Fields
	internal float m_AccumulatedDt; // 0x0
	internal float m_StartDelay; // 0x4
	internal float m_PlaybackTime; // 0x8
	internal int m_RingBufferIndex; // 0xC
	internal ParticleSystem.PlaybackState.Emission m_Emission; // 0x10
	internal ParticleSystem.PlaybackState.Initial m_Initial; // 0x28
	internal ParticleSystem.PlaybackState.Shape m_Shape; // 0x68
	internal ParticleSystem.PlaybackState.Force m_Force; // 0xC4
	internal ParticleSystem.PlaybackState.Collision m_Collision; // 0x104
	internal ParticleSystem.PlaybackState.Noise m_Noise; // 0x144
	internal ParticleSystem.PlaybackState.Lights m_Lights; // 0x148
	internal ParticleSystem.PlaybackState.Trail m_Trail; // 0x15C
}

// Namespace: 
[NativeTypeAttribute] // RVA: 0x4F0A0 Offset: 0x4F1A1 VA: 0x4F0A0
public struct ParticleSystem.Trails // TypeDefIndex: 4815
{
	// Fields
	internal List<Vector4> positions; // 0x0
	internal List<int> frontPositions; // 0x8
	internal List<int> backPositions; // 0x10
	internal List<int> positionCounts; // 0x18
	internal int maxTrailCount; // 0x20
	internal int maxPositionsPerTrailCount; // 0x24
}

// Namespace: 
public struct ParticleSystem.VelocityOverLifetimeModule // TypeDefIndex: 4816
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33720 Offset: 0x1C33821 VA: 0x1C33720
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.LimitVelocityOverLifetimeModule // TypeDefIndex: 4817
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33760 Offset: 0x1C33861 VA: 0x1C33760
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.InheritVelocityModule // TypeDefIndex: 4818
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C337A0 Offset: 0x1C338A1 VA: 0x1C337A0
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.LifetimeByEmitterSpeedModule // TypeDefIndex: 4819
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C337E0 Offset: 0x1C338E1 VA: 0x1C337E0
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.ForceOverLifetimeModule // TypeDefIndex: 4820
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33820 Offset: 0x1C33921 VA: 0x1C33820
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.ColorOverLifetimeModule // TypeDefIndex: 4821
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33860 Offset: 0x1C33961 VA: 0x1C33860
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.ColorBySpeedModule // TypeDefIndex: 4822
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C338A0 Offset: 0x1C339A1 VA: 0x1C338A0
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.SizeOverLifetimeModule // TypeDefIndex: 4823
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C338E0 Offset: 0x1C339E1 VA: 0x1C338E0
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.SizeBySpeedModule // TypeDefIndex: 4824
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33920 Offset: 0x1C33A21 VA: 0x1C33920
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.RotationOverLifetimeModule // TypeDefIndex: 4825
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33960 Offset: 0x1C33A61 VA: 0x1C33960
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.RotationBySpeedModule // TypeDefIndex: 4826
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C339A0 Offset: 0x1C33AA1 VA: 0x1C339A0
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.ExternalForcesModule // TypeDefIndex: 4827
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C339E0 Offset: 0x1C33AE1 VA: 0x1C339E0
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.NoiseModule // TypeDefIndex: 4828
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33A20 Offset: 0x1C33B21 VA: 0x1C33A20
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.LightsModule // TypeDefIndex: 4829
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33B60 Offset: 0x1C33C61 VA: 0x1C33B60
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.TrailModule // TypeDefIndex: 4830
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33BA0 Offset: 0x1C33CA1 VA: 0x1C33BA0
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.CustomDataModule // TypeDefIndex: 4831
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33BE0 Offset: 0x1C33CE1 VA: 0x1C33BE0
	internal void .ctor(ParticleSystem particleSystem) { }
}

