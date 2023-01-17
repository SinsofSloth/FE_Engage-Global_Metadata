// Namespace: 
private sealed class EventDemoSequence.CmdFunc : MulticastDelegate // TypeDefIndex: 10199
{
	// Methods

	// RVA: 0x1F062E0 Offset: 0x1F063E1 VA: 0x1F062E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F06300 Offset: 0x1F06401 VA: 0x1F06300 Slot: 13
	public virtual EventDemoSequence.EventCmdResult Invoke(EventDemoSequence.CmdInfo cmdFuncInfo) { }

	// RVA: 0x1F06660 Offset: 0x1F06761 VA: 0x1F06660 Slot: 14
	public virtual IAsyncResult BeginInvoke(EventDemoSequence.CmdInfo cmdFuncInfo, AsyncCallback callback, object object) { }

	// RVA: 0x1F06690 Offset: 0x1F06791 VA: 0x1F06690 Slot: 15
	public virtual EventDemoSequence.EventCmdResult EndInvoke(IAsyncResult result) { }
}

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
public class EventDemoSequence.WeightFader // TypeDefIndex: 10201
{
	// Fields
	private float m_wgt; // 0x10
	private float m_wgtFrom; // 0x14
	private float m_wgtTo; // 0x18
	private float m_time; // 0x1C
	private float m_duration; // 0x20

	// Methods

	// RVA: 0x1F07CB0 Offset: 0x1F07DB1 VA: 0x1F07CB0
	public void .ctor() { }

	// RVA: 0x1F07CF0 Offset: 0x1F07DF1 VA: 0x1F07CF0
	public void Reset() { }

	// RVA: 0x1F07D10 Offset: 0x1F07E11 VA: 0x1F07D10
	public float Get() { }

	// RVA: 0x1F07D20 Offset: 0x1F07E21 VA: 0x1F07D20
	public void Set(float wgt, float msec) { }

	// RVA: 0x1F07D60 Offset: 0x1F07E61 VA: 0x1F07D60
	public float Tick() { }
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
private class EventDemoSequence.ColorFader // TypeDefIndex: 10203
{
	// Fields
	private Color m_color; // 0x10
	private Color m_colorFrom; // 0x20
	private Color m_colorTo; // 0x30
	private float m_time; // 0x40
	private float m_duration; // 0x44

	// Methods

	// RVA: 0x1F067C0 Offset: 0x1F068C1 VA: 0x1F067C0
	public void .ctor() { }

	// RVA: 0x1F06830 Offset: 0x1F06931 VA: 0x1F06830
	public void Reset() { }

	// RVA: 0x1F068A0 Offset: 0x1F069A1 VA: 0x1F068A0
	public Color Get() { }

	// RVA: 0x1F068B0 Offset: 0x1F069B1 VA: 0x1F068B0
	public void Set(Color color, float msec) { }

	// RVA: 0x1F06910 Offset: 0x1F06A11 VA: 0x1F06910
	public Color Tick() { }
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
private class EventDemoSequence.CharacterWork // TypeDefIndex: 10205
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28DAF0 Offset: 0x28DBF1 VA: 0x28DAF0
	private string <Pid>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x28DB00 Offset: 0x28DC01 VA: 0x28DB00
	private string <PidForCreate>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x28DB10 Offset: 0x28DC11 VA: 0x28DB10
	private Character <Character>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28DB20 Offset: 0x28DC21 VA: 0x28DB20
	private CharacterAppearance <Appearance>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28DB30 Offset: 0x28DC31 VA: 0x28DB30
	private GameObject <PositionLocater>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28DB40 Offset: 0x28DC41 VA: 0x28DB40
	private EventDemoSequence.RotateFader <RotateFader>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x28DB50 Offset: 0x28DC51 VA: 0x28DB50
	private float <RotateYTo>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x28DB60 Offset: 0x28DC61 VA: 0x28DB60
	private int <AnimStatehash>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x28DB70 Offset: 0x28DC71 VA: 0x28DB70
	private CharacterAsset <EquipWeaponAsset>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x28DB80 Offset: 0x28DC81 VA: 0x28DB80
	private IDisposable <DoLaterPlayMotion>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x28DB90 Offset: 0x28DC91 VA: 0x28DB90
	private IDisposable <DoLaterSetAngle>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x28DBA0 Offset: 0x28DCA1 VA: 0x28DBA0
	private IDisposable <DoLaterSetRotate>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x28DBB0 Offset: 0x28DCB1 VA: 0x28DBB0
	private ResourceHandle <AnimatorResourceHandle>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x28DBC0 Offset: 0x28DCC1 VA: 0x28DBC0
	private ResourceHandle <FishingRodResourceHandle>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x28DBD0 Offset: 0x28DCD1 VA: 0x28DBD0
	private GameObject <FishingRodObject>k__BackingField; // 0x78

	// Properties
	public string Pid { get; set; }
	public string PidForCreate { get; set; }
	public Character Character { get; set; }
	public CharacterAppearance Appearance { get; set; }
	public GameObject PositionLocater { get; set; }
	public EventDemoSequence.RotateFader RotateFader { get; set; }
	public float RotateYTo { get; set; }
	public int AnimStatehash { get; set; }
	public CharacterAsset EquipWeaponAsset { get; set; }
	public IDisposable DoLaterPlayMotion { get; set; }
	public IDisposable DoLaterSetAngle { get; set; }
	public IDisposable DoLaterSetRotate { get; set; }
	public ResourceHandle AnimatorResourceHandle { get; set; }
	public ResourceHandle FishingRodResourceHandle { get; set; }
	public GameObject FishingRodObject { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BD510 Offset: 0x2BD611 VA: 0x2BD510
	// RVA: 0x1F05EE0 Offset: 0x1F05FE1 VA: 0x1F05EE0
	public string get_Pid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD520 Offset: 0x2BD621 VA: 0x2BD520
	// RVA: 0x1F05EF0 Offset: 0x1F05FF1 VA: 0x1F05EF0
	private void set_Pid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD530 Offset: 0x2BD631 VA: 0x2BD530
	// RVA: 0x1F05F00 Offset: 0x1F06001 VA: 0x1F05F00
	public string get_PidForCreate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD540 Offset: 0x2BD641 VA: 0x2BD540
	// RVA: 0x1F05F10 Offset: 0x1F06011 VA: 0x1F05F10
	private void set_PidForCreate(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD550 Offset: 0x2BD651 VA: 0x2BD550
	// RVA: 0x1F05F20 Offset: 0x1F06021 VA: 0x1F05F20
	public Character get_Character() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD560 Offset: 0x2BD661 VA: 0x2BD560
	// RVA: 0x1F05F30 Offset: 0x1F06031 VA: 0x1F05F30
	public void set_Character(Character value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD570 Offset: 0x2BD671 VA: 0x2BD570
	// RVA: 0x1F05F40 Offset: 0x1F06041 VA: 0x1F05F40
	public CharacterAppearance get_Appearance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD580 Offset: 0x2BD681 VA: 0x2BD580
	// RVA: 0x1F05F50 Offset: 0x1F06051 VA: 0x1F05F50
	private void set_Appearance(CharacterAppearance value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD590 Offset: 0x2BD691 VA: 0x2BD590
	// RVA: 0x1F05F60 Offset: 0x1F06061 VA: 0x1F05F60
	public GameObject get_PositionLocater() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD5A0 Offset: 0x2BD6A1 VA: 0x2BD5A0
	// RVA: 0x1F05F70 Offset: 0x1F06071 VA: 0x1F05F70
	public void set_PositionLocater(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD5B0 Offset: 0x2BD6B1 VA: 0x2BD5B0
	// RVA: 0x1F05F80 Offset: 0x1F06081 VA: 0x1F05F80
	public EventDemoSequence.RotateFader get_RotateFader() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD5C0 Offset: 0x2BD6C1 VA: 0x2BD5C0
	// RVA: 0x1F05F90 Offset: 0x1F06091 VA: 0x1F05F90
	public void set_RotateFader(EventDemoSequence.RotateFader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD5D0 Offset: 0x2BD6D1 VA: 0x2BD5D0
	// RVA: 0x1F05FA0 Offset: 0x1F060A1 VA: 0x1F05FA0
	public float get_RotateYTo() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD5E0 Offset: 0x2BD6E1 VA: 0x2BD5E0
	// RVA: 0x1F05FB0 Offset: 0x1F060B1 VA: 0x1F05FB0
	public void set_RotateYTo(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD5F0 Offset: 0x2BD6F1 VA: 0x2BD5F0
	// RVA: 0x1F05FC0 Offset: 0x1F060C1 VA: 0x1F05FC0
	public int get_AnimStatehash() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD600 Offset: 0x2BD701 VA: 0x2BD600
	// RVA: 0x1F05FD0 Offset: 0x1F060D1 VA: 0x1F05FD0
	public void set_AnimStatehash(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD610 Offset: 0x2BD711 VA: 0x2BD610
	// RVA: 0x1F05FE0 Offset: 0x1F060E1 VA: 0x1F05FE0
	public CharacterAsset get_EquipWeaponAsset() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD620 Offset: 0x2BD721 VA: 0x2BD620
	// RVA: 0x1F05FF0 Offset: 0x1F060F1 VA: 0x1F05FF0
	public void set_EquipWeaponAsset(CharacterAsset value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD630 Offset: 0x2BD731 VA: 0x2BD630
	// RVA: 0x1F06000 Offset: 0x1F06101 VA: 0x1F06000
	public IDisposable get_DoLaterPlayMotion() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD640 Offset: 0x2BD741 VA: 0x2BD640
	// RVA: 0x1F06010 Offset: 0x1F06111 VA: 0x1F06010
	public void set_DoLaterPlayMotion(IDisposable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD650 Offset: 0x2BD751 VA: 0x2BD650
	// RVA: 0x1F06020 Offset: 0x1F06121 VA: 0x1F06020
	public IDisposable get_DoLaterSetAngle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD660 Offset: 0x2BD761 VA: 0x2BD660
	// RVA: 0x1F06030 Offset: 0x1F06131 VA: 0x1F06030
	public void set_DoLaterSetAngle(IDisposable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD670 Offset: 0x2BD771 VA: 0x2BD670
	// RVA: 0x1F06040 Offset: 0x1F06141 VA: 0x1F06040
	public IDisposable get_DoLaterSetRotate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD680 Offset: 0x2BD781 VA: 0x2BD680
	// RVA: 0x1F06050 Offset: 0x1F06151 VA: 0x1F06050
	public void set_DoLaterSetRotate(IDisposable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD690 Offset: 0x2BD791 VA: 0x2BD690
	// RVA: 0x1F06060 Offset: 0x1F06161 VA: 0x1F06060
	public ResourceHandle get_AnimatorResourceHandle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD6A0 Offset: 0x2BD7A1 VA: 0x2BD6A0
	// RVA: 0x1F06070 Offset: 0x1F06171 VA: 0x1F06070
	public void set_AnimatorResourceHandle(ResourceHandle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD6B0 Offset: 0x2BD7B1 VA: 0x2BD6B0
	// RVA: 0x1F06080 Offset: 0x1F06181 VA: 0x1F06080
	public ResourceHandle get_FishingRodResourceHandle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD6C0 Offset: 0x2BD7C1 VA: 0x2BD6C0
	// RVA: 0x1F06090 Offset: 0x1F06191 VA: 0x1F06090
	public void set_FishingRodResourceHandle(ResourceHandle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD6D0 Offset: 0x2BD7D1 VA: 0x2BD6D0
	// RVA: 0x1F060A0 Offset: 0x1F061A1 VA: 0x1F060A0
	public GameObject get_FishingRodObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD6E0 Offset: 0x2BD7E1 VA: 0x2BD6E0
	// RVA: 0x1F060B0 Offset: 0x1F061B1 VA: 0x1F060B0
	public void set_FishingRodObject(GameObject value) { }

	// RVA: 0x1F060C0 Offset: 0x1F061C1 VA: 0x1F060C0
	public void .ctor(string pid, string pidForCreate, CharacterAppearance appearance) { }

	// RVA: 0x1F06130 Offset: 0x1F06231 VA: 0x1F06130
	public void Tick() { }
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
private class EventDemoSequence.EffectWork // TypeDefIndex: 10207
{
	// Fields
	private ResourceObject m_effectResourceObject; // 0x10

	// Methods

	// RVA: 0x1F06A50 Offset: 0x1F06B51 VA: 0x1F06A50
	public void .ctor(string effectPath, Transform parentTrans) { }

	// RVA: 0x1F06A90 Offset: 0x1F06B91 VA: 0x1F06A90
	private void LoadEffect(string effectPath, Transform parentTrans) { }

	// RVA: 0x1F06B90 Offset: 0x1F06C91 VA: 0x1F06B90
	private static void SetupAfterLoad(GameObject effectPrefabObject) { }

	// RVA: 0x1F06C20 Offset: 0x1F06D21 VA: 0x1F06C20
	public void DeleteEffect() { }
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
private enum EventDemoSequence.EventCmdResult // TypeDefIndex: 10209
{
	// Fields
	public int value__; // 0x0
	public const EventDemoSequence.EventCmdResult Continue = 0;
	public const EventDemoSequence.EventCmdResult ContinueNextFrame = 1;
	public const EventDemoSequence.EventCmdResult Retry = 2;
	public const EventDemoSequence.EventCmdResult RetryNextFrame = 3;
	public const EventDemoSequence.EventCmdResult CmdNotFound = 4;
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
[Serializable]
private class EventDemoSequence.SoundEnv.EventNameData // TypeDefIndex: 10211
{
	// Fields
	public string m_MaterialName; // 0x10
	public string m_EventName; // 0x18

	// Methods

	// RVA: 0x1DC8E50 Offset: 0x1DC8F51 VA: 0x1DC8E50
	public void .ctor() { }
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
[CompilerGeneratedAttribute] // RVA: 0x276760 Offset: 0x276861 VA: 0x276760
private sealed class EventDemoSequence.<>c__DisplayClass11_0 // TypeDefIndex: 10213
{
	// Fields
	public string skyBoxMaterialName; // 0x10

	// Methods

	// RVA: 0x1F053D0 Offset: 0x1F054D1 VA: 0x1F053D0
	public void .ctor() { }

	// RVA: 0x1F053E0 Offset: 0x1F054E1 VA: 0x1F053E0
	internal void <SetBackGround>b__0(Material material) { }
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
[CompilerGeneratedAttribute] // RVA: 0x276780 Offset: 0x276881 VA: 0x276780
private sealed class EventDemoSequence.<>c__DisplayClass20_0 // TypeDefIndex: 10215
{
	// Fields
	public string srcCameraName; // 0x10
	public Camera srcCamera; // 0x18

	// Methods

	// RVA: 0x1F05720 Offset: 0x1F05821 VA: 0x1F05720
	public void .ctor() { }

	// RVA: 0x1F05730 Offset: 0x1F05831 VA: 0x1F05730
	internal void <GetSrcCamera>b__0(Camera camera) { }
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
[CompilerGeneratedAttribute] // RVA: 0x2767A0 Offset: 0x2768A1 VA: 0x2767A0
private sealed class EventDemoSequence.<>c__DisplayClass28_0 // TypeDefIndex: 10217
{
	// Fields
	public EventDemoSequence <>4__this; // 0x10
	public EventDemoSequence.CmdInfo cmdInfo; // 0x18

	// Methods

	// RVA: 0x1F057B0 Offset: 0x1F058B1 VA: 0x1F057B0
	public void .ctor() { }

	// RVA: 0x1F057C0 Offset: 0x1F058C1 VA: 0x1F057C0
	internal void <FuncCameraSetSceneCamera>b__0() { }
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
[CompilerGeneratedAttribute] // RVA: 0x2767C0 Offset: 0x2768C1 VA: 0x2767C0
private sealed class EventDemoSequence.<>c__DisplayClass62_0 // TypeDefIndex: 10219
{
	// Fields
	public EventDemoSequence <>4__this; // 0x10
	public string pid; // 0x18
	public string pidForCreate; // 0x20
	public string facialAnimName; // 0x28
	public string bodyAnimName; // 0x30
	public int rotateY; // 0x38
	public Character character; // 0x40

	// Methods

	// RVA: 0x1F05840 Offset: 0x1F05941 VA: 0x1F05840
	public void .ctor() { }

	// RVA: 0x1F05850 Offset: 0x1F05951 VA: 0x1F05850
	internal void <FuncCharacterCreate>b__0() { }
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
[CompilerGeneratedAttribute] // RVA: 0x2767E0 Offset: 0x2768E1 VA: 0x2767E0
private sealed class EventDemoSequence.<>c__DisplayClass67_0 // TypeDefIndex: 10221
{
	// Fields
	public EventDemoSequence <>4__this; // 0x10
	public Character character; // 0x18
	public string facialAnimName; // 0x20
	public string bodyAnimName; // 0x28
	public float duration; // 0x30

	// Methods

	// RVA: 0x1F05BB0 Offset: 0x1F05CB1 VA: 0x1F05BB0
	public void .ctor() { }

	// RVA: 0x1F05BC0 Offset: 0x1F05CC1 VA: 0x1F05BC0
	internal void <FuncCharacterPlayMotion>b__0() { }
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
[CompilerGeneratedAttribute] // RVA: 0x276800 Offset: 0x276901 VA: 0x276800
private sealed class EventDemoSequence.<>c__DisplayClass73_0 // TypeDefIndex: 10223
{
	// Fields
	public EventDemoSequence <>4__this; // 0x10
	public Character character; // 0x18
	public EventDemoSequence.CharacterWork characterWork; // 0x20
	public float sec; // 0x28

	// Methods

	// RVA: 0x1F05C10 Offset: 0x1F05D11 VA: 0x1F05C10
	public void .ctor() { }

	// RVA: 0x1F05C20 Offset: 0x1F05D21 VA: 0x1F05C20
	internal void <FuncCharacterSetRotate>b__0() { }
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

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276820 Offset: 0x276921 VA: 0x276820
private sealed class EventDemoSequence.<>c__DisplayClass77_0 // TypeDefIndex: 10225
{
	// Fields
	public EventDemoSequence.CharacterWork characterWork; // 0x10
	public Character character; // 0x18

	// Methods

	// RVA: 0x1F05D70 Offset: 0x1F05E71 VA: 0x1F05D70
	public void .ctor() { }

	// RVA: 0x1F05D80 Offset: 0x1F05E81 VA: 0x1F05D80
	internal void <FuncCharacterEquipFishingRod>b__0(GameObject gameObject) { }
}

