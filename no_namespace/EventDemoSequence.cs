// Namespace: 
private class EventDemoSequence.CmdInfo // TypeDefIndex: 10200
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28DA80 Offset: 0x28DB81 VA: 0x28DA80
	private EventDemoSequence.CmdFunc <Func>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x28DA90 Offset: 0x28DB91 VA: 0x28DA90
	private string <CmdName>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x28DAA0 Offset: 0x28DBA1 VA: 0x28DAA0
	private string[] <Args>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28DAB0 Offset: 0x28DBB1 VA: 0x28DAB0
	private int <RepeatCounter>k__BackingField; // 0x28

	// Properties
	public EventDemoSequence.CmdFunc Func { get; set; }
	public string CmdName { get; set; }
	public string[] Args { get; set; }
	public int RepeatCounter { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BD430 Offset: 0x2BD531 VA: 0x2BD430
	// RVA: 0x1F066C0 Offset: 0x1F067C1 VA: 0x1F066C0
	public EventDemoSequence.CmdFunc get_Func() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD440 Offset: 0x2BD541 VA: 0x2BD440
	// RVA: 0x1F066D0 Offset: 0x1F067D1 VA: 0x1F066D0
	private void set_Func(EventDemoSequence.CmdFunc value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD450 Offset: 0x2BD551 VA: 0x2BD450
	// RVA: 0x1F066E0 Offset: 0x1F067E1 VA: 0x1F066E0
	public string get_CmdName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD460 Offset: 0x2BD561 VA: 0x2BD460
	// RVA: 0x1F066F0 Offset: 0x1F067F1 VA: 0x1F066F0
	private void set_CmdName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD470 Offset: 0x2BD571 VA: 0x2BD470
	// RVA: 0x1F06700 Offset: 0x1F06801 VA: 0x1F06700
	public string[] get_Args() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD480 Offset: 0x2BD581 VA: 0x2BD480
	// RVA: 0x1F06710 Offset: 0x1F06811 VA: 0x1F06710
	private void set_Args(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD490 Offset: 0x2BD591 VA: 0x2BD490
	// RVA: 0x1F06720 Offset: 0x1F06821 VA: 0x1F06720
	public int get_RepeatCounter() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD4A0 Offset: 0x2BD5A1 VA: 0x2BD4A0
	// RVA: 0x1F06730 Offset: 0x1F06831 VA: 0x1F06730
	private void set_RepeatCounter(int value) { }

	// RVA: 0x1F06740 Offset: 0x1F06841 VA: 0x1F06740
	public void .ctor(EventDemoSequence.CmdFunc func, string cmdName, string[] args) { }

	// RVA: 0x1F067B0 Offset: 0x1F068B1 VA: 0x1F067B0
	public void IncRepetCounter() { }
}

// Namespace: 
private class EventDemoSequence.LightSetupInfo // TypeDefIndex: 10202
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28DAC0 Offset: 0x28DBC1 VA: 0x28DAC0
	private string <LightName>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x28DAD0 Offset: 0x28DBD1 VA: 0x28DAD0
	private Vector3 <RotOffset>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x28DAE0 Offset: 0x28DBE1 VA: 0x28DAE0
	private GameObject <ParentCameraObject>k__BackingField; // 0x28

	// Properties
	public string LightName { get; set; }
	public Vector3 RotOffset { get; set; }
	public GameObject ParentCameraObject { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BD4B0 Offset: 0x2BD5B1 VA: 0x2BD4B0
	// RVA: 0x1F06CD0 Offset: 0x1F06DD1 VA: 0x1F06CD0
	public string get_LightName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD4C0 Offset: 0x2BD5C1 VA: 0x2BD4C0
	// RVA: 0x1F06CE0 Offset: 0x1F06DE1 VA: 0x1F06CE0
	public void set_LightName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD4D0 Offset: 0x2BD5D1 VA: 0x2BD4D0
	// RVA: 0x1F06CF0 Offset: 0x1F06DF1 VA: 0x1F06CF0
	public Vector3 get_RotOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD4E0 Offset: 0x2BD5E1 VA: 0x2BD4E0
	// RVA: 0x1F06D00 Offset: 0x1F06E01 VA: 0x1F06D00
	public void set_RotOffset(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD4F0 Offset: 0x2BD5F1 VA: 0x2BD4F0
	// RVA: 0x1F06D10 Offset: 0x1F06E11 VA: 0x1F06D10
	public GameObject get_ParentCameraObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD500 Offset: 0x2BD601 VA: 0x2BD500
	// RVA: 0x1F06D20 Offset: 0x1F06E21 VA: 0x1F06D20
	public void set_ParentCameraObject(GameObject value) { }

	// RVA: 0x1F06D30 Offset: 0x1F06E31 VA: 0x1F06D30
	public void .ctor() { }
}

// Namespace: 
private class EventDemoSequence.RotateFader // TypeDefIndex: 10204
{
	// Fields
	private float m_rot; // 0x10
	private float m_rotFrom; // 0x14
	private float m_rotTo; // 0x18
	private float m_time; // 0x1C
	private float m_duration; // 0x20

	// Methods

	// RVA: 0x1F05A90 Offset: 0x1F05B91 VA: 0x1F05A90
	public void .ctor() { }

	// RVA: 0x1F06DA0 Offset: 0x1F06EA1 VA: 0x1F06DA0
	public void Reset() { }

	// RVA: 0x1F06DB0 Offset: 0x1F06EB1 VA: 0x1F06DB0
	public float Get() { }

	// RVA: 0x1F05AC0 Offset: 0x1F05BC1 VA: 0x1F05AC0
	public void Set(float rot, float msec) { }

	// RVA: 0x1F06210 Offset: 0x1F06311 VA: 0x1F06210
	public float Tick() { }
}

// Namespace: 
private class EventDemoSequence.SplitViewWork // TypeDefIndex: 10206
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28DBE0 Offset: 0x28DCE1 VA: 0x28DBE0
	private bool <IsInitialized>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x28DBF0 Offset: 0x28DCF1 VA: 0x28DBF0
	private bool <IsUVRectForGpuBoostMode>k__BackingField; // 0x11
	[CompilerGeneratedAttribute] // RVA: 0x28DC00 Offset: 0x28DD01 VA: 0x28DC00
	private string <SplitViewName>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x28DC10 Offset: 0x28DD11 VA: 0x28DC10
	private RawImage <SplitViewImage>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28DC20 Offset: 0x28DD21 VA: 0x28DC20
	private RawImage <RenderImage>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28DC30 Offset: 0x28DD31 VA: 0x28DC30
	private RenderTexture <RenderTexture>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28DC40 Offset: 0x28DD41 VA: 0x28DC40
	private Camera <Camera>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x28DC50 Offset: 0x28DD51 VA: 0x28DC50
	private EventDemoSequence.ColorFader <ColorFader>k__BackingField; // 0x40
	private ResourceHandle m_renderTextureHandle; // 0x48

	// Properties
	public bool IsInitialized { get; set; }
	public bool IsUVRectForGpuBoostMode { get; set; }
	public string SplitViewName { get; set; }
	public RawImage SplitViewImage { get; set; }
	public RawImage RenderImage { get; set; }
	public RenderTexture RenderTexture { get; set; }
	public Camera Camera { get; set; }
	public EventDemoSequence.ColorFader ColorFader { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BD6F0 Offset: 0x2BD7F1 VA: 0x2BD6F0
	// RVA: 0x1F07110 Offset: 0x1F07211 VA: 0x1F07110
	public bool get_IsInitialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD700 Offset: 0x2BD801 VA: 0x2BD700
	// RVA: 0x1F07120 Offset: 0x1F07221 VA: 0x1F07120
	private void set_IsInitialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD710 Offset: 0x2BD811 VA: 0x2BD710
	// RVA: 0x1F07130 Offset: 0x1F07231 VA: 0x1F07130
	public bool get_IsUVRectForGpuBoostMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD720 Offset: 0x2BD821 VA: 0x2BD720
	// RVA: 0x1F07140 Offset: 0x1F07241 VA: 0x1F07140
	private void set_IsUVRectForGpuBoostMode(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD730 Offset: 0x2BD831 VA: 0x2BD730
	// RVA: 0x1F07150 Offset: 0x1F07251 VA: 0x1F07150
	public string get_SplitViewName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD740 Offset: 0x2BD841 VA: 0x2BD740
	// RVA: 0x1F07160 Offset: 0x1F07261 VA: 0x1F07160
	private void set_SplitViewName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD750 Offset: 0x2BD851 VA: 0x2BD750
	// RVA: 0x1F07170 Offset: 0x1F07271 VA: 0x1F07170
	public RawImage get_SplitViewImage() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD760 Offset: 0x2BD861 VA: 0x2BD760
	// RVA: 0x1F07180 Offset: 0x1F07281 VA: 0x1F07180
	private void set_SplitViewImage(RawImage value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD770 Offset: 0x2BD871 VA: 0x2BD770
	// RVA: 0x1F07190 Offset: 0x1F07291 VA: 0x1F07190
	public RawImage get_RenderImage() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD780 Offset: 0x2BD881 VA: 0x2BD780
	// RVA: 0x1F071A0 Offset: 0x1F072A1 VA: 0x1F071A0
	private void set_RenderImage(RawImage value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD790 Offset: 0x2BD891 VA: 0x2BD790
	// RVA: 0x1F071B0 Offset: 0x1F072B1 VA: 0x1F071B0
	public RenderTexture get_RenderTexture() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD7A0 Offset: 0x2BD8A1 VA: 0x2BD7A0
	// RVA: 0x1F071C0 Offset: 0x1F072C1 VA: 0x1F071C0
	private void set_RenderTexture(RenderTexture value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD7B0 Offset: 0x2BD8B1 VA: 0x2BD7B0
	// RVA: 0x1F071D0 Offset: 0x1F072D1 VA: 0x1F071D0
	public Camera get_Camera() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD7C0 Offset: 0x2BD8C1 VA: 0x2BD7C0
	// RVA: 0x1F071E0 Offset: 0x1F072E1 VA: 0x1F071E0
	private void set_Camera(Camera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD7D0 Offset: 0x2BD8D1 VA: 0x2BD7D0
	// RVA: 0x1F071F0 Offset: 0x1F072F1 VA: 0x1F071F0
	public EventDemoSequence.ColorFader get_ColorFader() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD7E0 Offset: 0x2BD8E1 VA: 0x2BD7E0
	// RVA: 0x1F07200 Offset: 0x1F07301 VA: 0x1F07200
	private void set_ColorFader(EventDemoSequence.ColorFader value) { }

	// RVA: 0x1F07210 Offset: 0x1F07311 VA: 0x1F07210
	public void .ctor(string splitViewName, string renderTextureName) { }

	// RVA: 0x1F07350 Offset: 0x1F07451 VA: 0x1F07350
	private void InitSplitViewImage(string splitViewName) { }

	// RVA: 0x1F075A0 Offset: 0x1F076A1 VA: 0x1F075A0
	private void LoadRenderTexture(string renderTextureName) { }

	// RVA: 0x1F076F0 Offset: 0x1F077F1 VA: 0x1F076F0
	public void SetActive(bool isActive) { }

	// RVA: 0x1F076C0 Offset: 0x1F077C1 VA: 0x1F076C0
	public void SetRenderImageUVRectWH(bool isGPUBoost) { }

	// RVA: 0x1F07780 Offset: 0x1F07881 VA: 0x1F07780
	private void SetRenderImageUVRectWH(float width, float height) { }

	// RVA: 0x1F07860 Offset: 0x1F07961 VA: 0x1F07860
	public void SetCamera(Camera camera) { }

	// RVA: 0x1F07970 Offset: 0x1F07A71 VA: 0x1F07970
	public void DisableCamera() { }

	// RVA: 0x1F07A60 Offset: 0x1F07B61 VA: 0x1F07A60
	public void Tick() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD7F0 Offset: 0x2BD8F1 VA: 0x2BD7F0
	// RVA: 0x1F07BF0 Offset: 0x1F07CF1 VA: 0x1F07BF0
	private void <LoadRenderTexture>b__35_0(RenderTexture texture) { }
}

// Namespace: 
private enum EventDemoSequence.EventCmdSeq // TypeDefIndex: 10208
{
	// Fields
	public int value__; // 0x0
	public const EventDemoSequence.EventCmdSeq BeforeTalk = 0;
	public const EventDemoSequence.EventCmdSeq Talk = 1;
	public const EventDemoSequence.EventCmdSeq AfterTalk = 2;
}

// Namespace: 
private enum EventDemoSequence.ClothType // TypeDefIndex: 10210
{
	// Fields
	public int value__; // 0x0
	public const EventDemoSequence.ClothType Normal = 0;
	public const EventDemoSequence.ClothType DefaultJob = 1;
	public const EventDemoSequence.ClothType Plain = 2;
}

// Namespace: 
public class EventDemoSequence.SoundEnv : MonoBehaviour // TypeDefIndex: 10212
{
	// Fields
	[SerializeField] // RVA: 0x28DC60 Offset: 0x28DD61 VA: 0x28DC60
	private List<EventDemoSequence.SoundEnv.EventNameData> m_EventNameDataList; // 0x18
	private Dictionary<string, string> m_EventNameDictionary; // 0x20
	private string m_SoundEventName; // 0x28

	// Methods

	// RVA: 0x1F06DC0 Offset: 0x1F06EC1 VA: 0x1F06DC0
	public void Awake() { }

	// RVA: 0x1F06EF0 Offset: 0x1F06FF1 VA: 0x1F06EF0
	public void OnDestroy() { }

	// RVA: 0x1F06FB0 Offset: 0x1F070B1 VA: 0x1F06FB0
	private string GetEventName(string materialName) { }

	// RVA: 0x1F05610 Offset: 0x1F05711 VA: 0x1F05610
	public void PlayEnv(string materialName) { }

	// RVA: 0x1F06F00 Offset: 0x1F07001 VA: 0x1F06F00
	private void StopCurrentEnv() { }

	// RVA: 0x1F07030 Offset: 0x1F07131 VA: 0x1F07030
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276770 Offset: 0x276871 VA: 0x276770
[Serializable]
private sealed class EventDemoSequence.<>c // TypeDefIndex: 10214
{
	// Fields
	public static readonly EventDemoSequence.<>c <>9; // 0x0
	public static Action<Camera> <>9__17_0; // 0x8
	public static Action<Light> <>9__45_0; // 0x10

	// Methods

	// RVA: 0x1F05330 Offset: 0x1F05431 VA: 0x1F05330
	private static void .cctor() { }

	// RVA: 0x1F053A0 Offset: 0x1F054A1 VA: 0x1F053A0
	public void .ctor() { }

	// RVA: 0x1F053B0 Offset: 0x1F054B1 VA: 0x1F053B0
	internal void <DisableCameras>b__17_0(Camera cam) { }

	// RVA: 0x1F053C0 Offset: 0x1F054C1 VA: 0x1F053C0
	internal void <DisableLights>b__45_0(Light light) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276790 Offset: 0x276891 VA: 0x276790
private sealed class EventDemoSequence.<>c__DisplayClass26_0 // TypeDefIndex: 10216
{
	// Fields
	public EventDemoSequence <>4__this; // 0x10
	public EventDemoSequence.CmdInfo cmdInfo; // 0x18

	// Methods

	// RVA: 0x1F05790 Offset: 0x1F05891 VA: 0x1F05790
	public void .ctor() { }

	// RVA: 0x1F057A0 Offset: 0x1F058A1 VA: 0x1F057A0
	internal void <FuncCameraSetCharaCamera>b__0() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2767B0 Offset: 0x2768B1 VA: 0x2767B0
private sealed class EventDemoSequence.<>c__DisplayClass46_0 // TypeDefIndex: 10218
{
	// Fields
	public EventDemoSequence.LightSetupInfo lightSetupInfo; // 0x10
	public Light activeLight; // 0x18

	// Methods

	// RVA: 0x1F057D0 Offset: 0x1F058D1 VA: 0x1F057D0
	public void .ctor() { }

	// RVA: 0x1F057E0 Offset: 0x1F058E1 VA: 0x1F057E0
	internal void <SetupLight>b__0(Light light) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2767D0 Offset: 0x2768D1 VA: 0x2767D0
private sealed class EventDemoSequence.<>c__DisplayClass66_0 // TypeDefIndex: 10220
{
	// Fields
	public Character character; // 0x10

	// Methods

	// RVA: 0x1F05B00 Offset: 0x1F05C01 VA: 0x1F05B00
	public void .ctor() { }

	// RVA: 0x1F05B10 Offset: 0x1F05C11 VA: 0x1F05B10
	internal void <FuncCharacterSetAnimator>b__0(RuntimeAnimatorController animatorController) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2767F0 Offset: 0x2768F1 VA: 0x2767F0
private sealed class EventDemoSequence.<>c__DisplayClass70_0 // TypeDefIndex: 10222
{
	// Fields
	public EventDemoSequence <>4__this; // 0x10
	public string selfPid; // 0x18
	public string eyeTargetPid; // 0x20
	public string headTargetPid; // 0x28

	// Methods

	// RVA: 0x1F05BE0 Offset: 0x1F05CE1 VA: 0x1F05BE0
	public void .ctor() { }

	// RVA: 0x1F05BF0 Offset: 0x1F05CF1 VA: 0x1F05BF0
	internal void <FuncCharacterSetAngle>b__0() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276810 Offset: 0x276911 VA: 0x276810
private sealed class EventDemoSequence.<>c__DisplayClass75_0 // TypeDefIndex: 10224
{
	// Fields
	public CharacterAsset charaAsset; // 0x10
	public Character character; // 0x18
	public bool isLeftHand; // 0x20

	// Methods

	// RVA: 0x1F05C40 Offset: 0x1F05D41 VA: 0x1F05C40
	public void .ctor() { }

	// RVA: 0x1F05C50 Offset: 0x1F05D51 VA: 0x1F05C50
	internal void <FuncCharacterEquipWeapon>b__0() { }
}

