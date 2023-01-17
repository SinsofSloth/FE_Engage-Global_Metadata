// Namespace: App
public class JobIntroStatus : SingletonProcInst<JobIntroStatus> // TypeDefIndex: 11875
{
	// Fields
	private const string TitlePrefabPath = "Telop/JobIntroduction/Prefabs/JobIntroduction";
	private const string InfoPrefabPath = "UI/Title/JobIntroduction/Prefabs/JobIntroductionRoot";
	private TResourceHandle<GameObject> m_TitlePrefabHandle; // 0x78
	private GameObject m_TitleGameObject; // 0x80
	private JobIntroTitleSetter m_TitleSetter; // 0x88
	private TResourceHandle<GameObject> m_InfoPrefabHandle; // 0x90
	private GameObject m_InfoGameObject; // 0x98
	private JobIntroInfoSetter m_InfoSetter; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x2999C0 Offset: 0x299AC1 VA: 0x2999C0
	private static float <ReadyTime1>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x2999D0 Offset: 0x299AD1 VA: 0x2999D0
	private static float <ReadyTime2>k__BackingField; // 0x4

	// Properties
	public static float ReadyTime1 { get; set; }
	public static float ReadyTime2 { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C6FD0 Offset: 0x2C70D1 VA: 0x2C6FD0
	// RVA: 0x24656D0 Offset: 0x24657D1 VA: 0x24656D0
	public static float get_ReadyTime1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6FE0 Offset: 0x2C70E1 VA: 0x2C6FE0
	// RVA: 0x2465720 Offset: 0x2465821 VA: 0x2465720
	public static void set_ReadyTime1(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6FF0 Offset: 0x2C70F1 VA: 0x2C6FF0
	// RVA: 0x2465780 Offset: 0x2465881 VA: 0x2465780
	public static float get_ReadyTime2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7000 Offset: 0x2C7101 VA: 0x2C7000
	// RVA: 0x24657D0 Offset: 0x24658D1 VA: 0x24657D0
	public static void set_ReadyTime2(float value) { }

	// RVA: 0x2464CD0 Offset: 0x2464DD1 VA: 0x2464CD0
	public static void CreateAsync(ProcInst super) { }

	// RVA: 0x24658B0 Offset: 0x24659B1 VA: 0x24658B0
	private static void CreateImpl(ProcInst super, JobIntroStatus p) { }

	// RVA: 0x24658F0 Offset: 0x24659F1 VA: 0x24658F0
	private static ProcDesc[] CreateDescs(JobIntroStatus p) { }

	// RVA: 0x2465B60 Offset: 0x2465C61 VA: 0x2465B60
	public void CreateAsync() { }

	// RVA: 0x2465CC0 Offset: 0x2465DC1 VA: 0x2465CC0
	public bool IsCreating() { }

	// RVA: 0x2465D40 Offset: 0x2465E41 VA: 0x2465D40
	public void Tick() { }

	// RVA: 0x2465D60 Offset: 0x2465E61 VA: 0x2465D60
	public static void StartJobIntro(Unit unit) { }

	// RVA: 0x2465E10 Offset: 0x2465F11 VA: 0x2465E10
	public void StartJobIntroImpl(Unit unit) { }

	// RVA: 0x2465120 Offset: 0x2465221 VA: 0x2465120
	public static void Destroy() { }

	// RVA: 0x2465830 Offset: 0x2465931 VA: 0x2465830
	public void .ctor() { }
}

