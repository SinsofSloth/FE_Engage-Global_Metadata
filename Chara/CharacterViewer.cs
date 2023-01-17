// Namespace: Chara
public class CharacterViewer : MonoBehaviour // TypeDefIndex: 8384
{
	// Fields
	[HideInInspector] // RVA: 0x27FAF0 Offset: 0x27FBF1 VA: 0x27FAF0
	public CharacterViewerSettings EditorSetting; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x27FB00 Offset: 0x27FC01 VA: 0x27FB00
	private static CharacterViewer <Instance>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x27FB10 Offset: 0x27FC11 VA: 0x27FB10
	private bool <IsReloading>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x27FB20 Offset: 0x27FC21 VA: 0x27FB20
	private int <CharaViewWaitTime>k__BackingField; // 0x24
	[MinAttribute] // RVA: 0x27FB30 Offset: 0x27FC31 VA: 0x27FB30
	[HeaderAttribute] // RVA: 0x27FB30 Offset: 0x27FC31 VA: 0x27FB30
	public int LeftWindowSize; // 0x28
	[HeaderAttribute] // RVA: 0x27FB90 Offset: 0x27FC91 VA: 0x27FB90
	[MinAttribute] // RVA: 0x27FB90 Offset: 0x27FC91 VA: 0x27FB90
	public int RightWindowSize; // 0x2C
	[HeaderAttribute] // RVA: 0x27FBF0 Offset: 0x27FCF1 VA: 0x27FBF0
	public float PositionSlip; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x27FC30 Offset: 0x27FD31 VA: 0x27FC30
	private bool <HideEffect>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x27FC40 Offset: 0x27FD41 VA: 0x27FC40
	private bool <TimeChanger>k__BackingField; // 0x35
	[CompilerGeneratedAttribute] // RVA: 0x27FC50 Offset: 0x27FD51 VA: 0x27FC50
	private float <WorldTime>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x27FC60 Offset: 0x27FD61 VA: 0x27FC60
	private float <HeavinessFactor>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x27FC70 Offset: 0x27FD71 VA: 0x27FC70
	private float <AgilityFactor>k__BackingField; // 0x40
	private CharacterBuilder m_Builder; // 0x48
	private Character[] m_Chara; // 0x50
	private CameraManager m_CameraManager; // 0x58
	private Transform m_LightSet; // 0x60
	private IDisposable m_Coroutine; // 0x68
	private CharacterProportion m_CharaProp; // 0x70
	private LookAtIK m_LookAt; // 0x78
	private ResourceHandle m_MapHandle; // 0x80
	private CharacterViewerLookTarget m_LookTarget; // 0x88
	private float[] m_CharacterPosition; // 0x90
	private float m_CharacterRotate; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x27FC80 Offset: 0x27FD81 VA: 0x27FC80
	private float <AnimTime>k__BackingField; // 0x9C
	[CompilerGeneratedAttribute] // RVA: 0x27FC90 Offset: 0x27FD91 VA: 0x27FC90
	private string <PlayingAnimName>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x27FCA0 Offset: 0x27FDA1 VA: 0x27FCA0
	private Animator <BodyAnimator>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x27FCB0 Offset: 0x27FDB1 VA: 0x27FCB0
	private Animator <RideAnimator>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x27FCC0 Offset: 0x27FDC1 VA: 0x27FCC0
	private Animator <FaceAnimator>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x27FCD0 Offset: 0x27FDD1 VA: 0x27FCD0
	private bool <IsStopping>k__BackingField; // 0xC0
	private int Selecting; // 0xC4
	private int AnimSelecting; // 0xC8
	private ViewerSetting[] m_Settings; // 0xD0
	private ViewerSetting[] m_AnimSetting; // 0xD8
	private CameraControllerUnitDetail m_UnitCam1; // 0xE0
	private CameraControllerUnitDetail m_UnitCam2; // 0xE8

	// Properties
	public static CharacterViewer Instance { get; set; }
	public bool IsReloading { get; set; }
	public int CharaViewWaitTime { get; set; }
	public Character Character { get; }
	private bool HideEffect { get; set; }
	private bool TimeChanger { get; set; }
	private float WorldTime { get; set; }
	private float HeavinessFactor { get; set; }
	private float AgilityFactor { get; set; }
	private float AnimTime { get; set; }
	private string PlayingAnimName { get; set; }
	private Animator BodyAnimator { get; set; }
	private Animator RideAnimator { get; set; }
	private Animator FaceAnimator { get; set; }
	private bool IsStopping { get; set; }
	public bool IsCheckModel { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A7C30 Offset: 0x2A7D31 VA: 0x2A7C30
	// RVA: 0x29BFFE0 Offset: 0x29C00E1 VA: 0x29BFFE0
	public static CharacterViewer get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7C40 Offset: 0x2A7D41 VA: 0x2A7C40
	// RVA: 0x29C0050 Offset: 0x29C0151 VA: 0x29C0050
	private static void set_Instance(CharacterViewer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7C50 Offset: 0x2A7D51 VA: 0x2A7C50
	// RVA: 0x29C00D0 Offset: 0x29C01D1 VA: 0x29C00D0
	public bool get_IsReloading() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7C60 Offset: 0x2A7D61 VA: 0x2A7C60
	// RVA: 0x29C00E0 Offset: 0x29C01E1 VA: 0x29C00E0
	private void set_IsReloading(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7C70 Offset: 0x2A7D71 VA: 0x2A7C70
	// RVA: 0x29C00F0 Offset: 0x29C01F1 VA: 0x29C00F0
	public int get_CharaViewWaitTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7C80 Offset: 0x2A7D81 VA: 0x2A7C80
	// RVA: 0x29C0100 Offset: 0x29C0201 VA: 0x29C0100
	public void set_CharaViewWaitTime(int value) { }

	// RVA: 0x29C0110 Offset: 0x29C0211 VA: 0x29C0110
	public Character get_Character() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7C90 Offset: 0x2A7D91 VA: 0x2A7C90
	// RVA: 0x29C0170 Offset: 0x29C0271 VA: 0x29C0170
	private bool get_HideEffect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7CA0 Offset: 0x2A7DA1 VA: 0x2A7CA0
	// RVA: 0x29C0180 Offset: 0x29C0281 VA: 0x29C0180
	private void set_HideEffect(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7CB0 Offset: 0x2A7DB1 VA: 0x2A7CB0
	// RVA: 0x29C0190 Offset: 0x29C0291 VA: 0x29C0190
	private bool get_TimeChanger() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7CC0 Offset: 0x2A7DC1 VA: 0x2A7CC0
	// RVA: 0x29C01A0 Offset: 0x29C02A1 VA: 0x29C01A0
	private void set_TimeChanger(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7CD0 Offset: 0x2A7DD1 VA: 0x2A7CD0
	// RVA: 0x29C01B0 Offset: 0x29C02B1 VA: 0x29C01B0
	private float get_WorldTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7CE0 Offset: 0x2A7DE1 VA: 0x2A7CE0
	// RVA: 0x29C01C0 Offset: 0x29C02C1 VA: 0x29C01C0
	private void set_WorldTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7CF0 Offset: 0x2A7DF1 VA: 0x2A7CF0
	// RVA: 0x29C01D0 Offset: 0x29C02D1 VA: 0x29C01D0
	private float get_HeavinessFactor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7D00 Offset: 0x2A7E01 VA: 0x2A7D00
	// RVA: 0x29C01E0 Offset: 0x29C02E1 VA: 0x29C01E0
	private void set_HeavinessFactor(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7D10 Offset: 0x2A7E11 VA: 0x2A7D10
	// RVA: 0x29C01F0 Offset: 0x29C02F1 VA: 0x29C01F0
	private float get_AgilityFactor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7D20 Offset: 0x2A7E21 VA: 0x2A7D20
	// RVA: 0x29C0200 Offset: 0x29C0301 VA: 0x29C0200
	private void set_AgilityFactor(float value) { }

	// RVA: 0x29C0210 Offset: 0x29C0311 VA: 0x29C0210
	private void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0x2A7D30 Offset: 0x2A7E31 VA: 0x2A7D30
	// RVA: 0x29C0340 Offset: 0x29C0441 VA: 0x29C0340
	private IEnumerator Initialize() { }

	// RVA: 0x29C03C0 Offset: 0x29C04C1 VA: 0x29C03C0
	private ViewerSetting CreateMainMenuElementList() { }

	// RVA: 0x29C2980 Offset: 0x29C2A81 VA: 0x29C2980
	private void OnDestroy() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7DA0 Offset: 0x2A7EA1 VA: 0x2A7DA0
	// RVA: 0x29C2AC0 Offset: 0x29C2BC1 VA: 0x29C2AC0
	private float get_AnimTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7DB0 Offset: 0x2A7EB1 VA: 0x2A7DB0
	// RVA: 0x29C2AD0 Offset: 0x29C2BD1 VA: 0x29C2AD0
	private void set_AnimTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7DC0 Offset: 0x2A7EC1 VA: 0x2A7DC0
	// RVA: 0x29C2AE0 Offset: 0x29C2BE1 VA: 0x29C2AE0
	private string get_PlayingAnimName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7DD0 Offset: 0x2A7ED1 VA: 0x2A7DD0
	// RVA: 0x29C2AF0 Offset: 0x29C2BF1 VA: 0x29C2AF0
	private void set_PlayingAnimName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7DE0 Offset: 0x2A7EE1 VA: 0x2A7DE0
	// RVA: 0x29C2B00 Offset: 0x29C2C01 VA: 0x29C2B00
	private Animator get_BodyAnimator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7DF0 Offset: 0x2A7EF1 VA: 0x2A7DF0
	// RVA: 0x29C2B10 Offset: 0x29C2C11 VA: 0x29C2B10
	private void set_BodyAnimator(Animator value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7E00 Offset: 0x2A7F01 VA: 0x2A7E00
	// RVA: 0x29C2B20 Offset: 0x29C2C21 VA: 0x29C2B20
	private Animator get_RideAnimator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7E10 Offset: 0x2A7F11 VA: 0x2A7E10
	// RVA: 0x29C2B30 Offset: 0x29C2C31 VA: 0x29C2B30
	private void set_RideAnimator(Animator value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7E20 Offset: 0x2A7F21 VA: 0x2A7E20
	// RVA: 0x29C2B40 Offset: 0x29C2C41 VA: 0x29C2B40
	private Animator get_FaceAnimator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7E30 Offset: 0x2A7F31 VA: 0x2A7E30
	// RVA: 0x29C2B50 Offset: 0x29C2C51 VA: 0x29C2B50
	private void set_FaceAnimator(Animator value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7E40 Offset: 0x2A7F41 VA: 0x2A7E40
	// RVA: 0x29C2B60 Offset: 0x29C2C61 VA: 0x29C2B60
	private bool get_IsStopping() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7E50 Offset: 0x2A7F51 VA: 0x2A7E50
	// RVA: 0x29C2B70 Offset: 0x29C2C71 VA: 0x29C2B70
	private void set_IsStopping(bool value) { }

	// RVA: 0x29C2B80 Offset: 0x29C2C81 VA: 0x29C2B80
	public bool get_IsCheckModel() { }

	// RVA: 0x29C2BE0 Offset: 0x29C2CE1 VA: 0x29C2BE0
	private void MyUpdate() { }

	// RVA: 0x29C4B00 Offset: 0x29C4C01 VA: 0x29C4B00
	private void OnGUI() { }

	// RVA: 0x29C4A50 Offset: 0x29C4B51 VA: 0x29C4A50
	private void Refresh() { }

	// RVA: 0x29C5A40 Offset: 0x29C5B41 VA: 0x29C5A40
	private void UpdateAOC() { }

	// RVA: 0x29C5BC0 Offset: 0x29C5CC1 VA: 0x29C5BC0
	private void UpdateWeaponAndAccessory() { }

	// RVA: 0x29C5D40 Offset: 0x29C5E41 VA: 0x29C5D40
	private void UpdateColor() { }

	// RVA: 0x29C5F90 Offset: 0x29C6091 VA: 0x29C5F90
	private void UpdateScale() { }

	// RVA: 0x29C6F30 Offset: 0x29C7031 VA: 0x29C6F30
	private void LoadPreset(string presetName) { }

	// RVA: 0x29C6320 Offset: 0x29C6421 VA: 0x29C6320
	private void ReloadCharacter() { }

	// RVA: 0x29C7AE0 Offset: 0x29C7BE1 VA: 0x29C7AE0
	private void AfterReload() { }

	// RVA: 0x29C8EC0 Offset: 0x29C8FC1 VA: 0x29C8EC0
	private List<string> GetAllBodyAnimNames() { }

	// RVA: 0x29C8C40 Offset: 0x29C8D41 VA: 0x29C8C40
	private List<string> GetAnimNameList(GameObject go) { }

	// RVA: 0x29C2890 Offset: 0x29C2991 VA: 0x29C2890
	private Action<string> SetBodyAnim(int bodyNum) { }

	// RVA: 0x29C9370 Offset: 0x29C9471 VA: 0x29C9370
	private void SetBodyAnimImpl(int bodyNum, string animName) { }

	// RVA: 0x29C9460 Offset: 0x29C9561 VA: 0x29C9460
	private void SetWeapon(string weaponName) { }

	// RVA: 0x29C9E90 Offset: 0x29C9F91 VA: 0x29C9E90
	private void SetDress(string dressName) { }

	// RVA: 0x29C2630 Offset: 0x29C2731 VA: 0x29C2630
	private Action<string> SetAccessory(int accseId) { }

	// RVA: 0x29C9D40 Offset: 0x29C9E41 VA: 0x29C9D40
	private void SetAccessoryImpl(int accseId, string accessoryName, bool reload) { }

	// RVA: 0x29C9EC0 Offset: 0x29C9FC1 VA: 0x29C9EC0
	private void UpdateColor(string targetName, Color color) { }

	// RVA: 0x29CA000 Offset: 0x29CA101 VA: 0x29CA000
	private void UpdateScale(string name, float value) { }

	// RVA: 0x29CA110 Offset: 0x29CA211 VA: 0x29CA110
	private void ApplyPresetColor(string presetName) { }

	// RVA: 0x29CA4B0 Offset: 0x29CA5B1 VA: 0x29CA4B0
	private void ChangeCameraType(string typeName) { }

	// RVA: 0x29CA670 Offset: 0x29CA771 VA: 0x29CA670
	private void ChangeMap(string mapName) { }

	// RVA: 0x29CAA10 Offset: 0x29CAB11 VA: 0x29CAA10
	private float[] MovePosition(string name, float[] newAxis) { }

	// RVA: 0x29CA8E0 Offset: 0x29CA9E1 VA: 0x29CA8E0
	private float[] MovePosition(float[] newAxis) { }

	// RVA: 0x29CAA20 Offset: 0x29CAB21 VA: 0x29CAA20
	private void RotateChara(string name, float value) { }

	// RVA: 0x29C9040 Offset: 0x29C9141 VA: 0x29C9040
	private void SetLookAt(string target) { }

	// RVA: 0x29CAAF0 Offset: 0x29CABF1 VA: 0x29CAAF0
	private Action<string> UpdateAsset(AssetType type) { }

	// RVA: 0x29CAC00 Offset: 0x29CAD01 VA: 0x29CAC00
	private void PlayAnimation(string animName) { }

	// RVA: 0x29CAF20 Offset: 0x29CB021 VA: 0x29CAF20
	private void PlayFacial(string animName) { }

	[IteratorStateMachineAttribute] // RVA: 0x2A7E60 Offset: 0x2A7F61 VA: 0x2A7E60
	// RVA: 0x29CB2B0 Offset: 0x29CB3B1 VA: 0x29CB2B0
	public IEnumerator StartCharaView() { }

	// RVA: 0x29CB330 Offset: 0x29CB431 VA: 0x29CB330
	public void .ctor() { }

	// RVA: 0x29CB3D0 Offset: 0x29CB4D1 VA: 0x29CB3D0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7ED0 Offset: 0x2A7FD1 VA: 0x2A7ED0
	// RVA: 0x29CB3E0 Offset: 0x29CB4E1 VA: 0x29CB3E0
	private void <Initialize>b__50_0(Unit _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7EE0 Offset: 0x2A7FE1 VA: 0x2A7EE0
	// RVA: 0x29CB3F0 Offset: 0x29CB4F1 VA: 0x29CB3F0
	private void <CreateMainMenuElementList>b__51_0(int i) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7EF0 Offset: 0x2A7FF1 VA: 0x2A7EF0
	// RVA: 0x29CB480 Offset: 0x29CB581 VA: 0x29CB480
	private void <CreateMainMenuElementList>b__51_1(int i) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7F00 Offset: 0x2A8001 VA: 0x2A7F00
	// RVA: 0x29CB490 Offset: 0x29CB591 VA: 0x29CB490
	private void <CreateMainMenuElementList>b__51_2(int i) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7F10 Offset: 0x2A8011 VA: 0x2A7F10
	// RVA: 0x29CB4A0 Offset: 0x29CB5A1 VA: 0x29CB4A0
	private void <AfterReload>b__94_0(Character chr) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7F20 Offset: 0x2A8021 VA: 0x2A7F20
	// RVA: 0x29CB630 Offset: 0x29CB731 VA: 0x29CB630
	private void <AfterReload>b__94_2(Character chr) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7F30 Offset: 0x2A8031 VA: 0x2A7F30
	// RVA: 0x29CB670 Offset: 0x29CB771 VA: 0x29CB670
	private void <AfterReload>b__94_3(Character chr) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7F40 Offset: 0x2A8041 VA: 0x2A7F40
	// RVA: 0x29CB6C0 Offset: 0x29CB7C1 VA: 0x29CB6C0
	private void <AfterReload>b__94_4(Character _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7F50 Offset: 0x2A8051 VA: 0x2A7F50
	// RVA: 0x29CB6D0 Offset: 0x29CB7D1 VA: 0x29CB6D0
	private void <AfterReload>b__94_5(Character chr) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7F60 Offset: 0x2A8061 VA: 0x2A7F60
	// RVA: 0x29CB720 Offset: 0x29CB821 VA: 0x29CB720
	private void <AfterReload>b__94_6(Character _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7F70 Offset: 0x2A8071 VA: 0x2A7F70
	// RVA: 0x29CB140 Offset: 0x29CB241 VA: 0x29CB140
	internal static void <PlayFacial>g__SetLip|114_0(string chr, ref CharacterViewer.<>c__DisplayClass114_0 , ref CharacterViewer.<>c__DisplayClass114_1 ) { }
}

