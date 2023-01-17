// Namespace: 
private class MainMenuSequence.AlphaFader // TypeDefIndex: 13023
{
	// Fields
	private float m_alpha; // 0x10
	private float m_alphaFrom; // 0x14
	private float m_alphaTo; // 0x18
	private float m_time; // 0x1C
	private float m_duration; // 0x20

	// Methods

	// RVA: 0x2231FB0 Offset: 0x22320B1 VA: 0x2231FB0
	public void .ctor() { }

	// RVA: 0x2231FE0 Offset: 0x22320E1 VA: 0x2231FE0
	public void Reset() { }

	// RVA: 0x2231FF0 Offset: 0x22320F1 VA: 0x2231FF0
	public float Get() { }

	// RVA: 0x2232000 Offset: 0x2232101 VA: 0x2232000
	public void Set(float rot, float msec) { }

	// RVA: 0x2232040 Offset: 0x2232141 VA: 0x2232040
	public float Tick() { }
}

// Namespace: 
private class MainMenuSequence.CharacterWork // TypeDefIndex: 13024
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29B920 Offset: 0x29BA21 VA: 0x29B920
	private string <Pid>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29B930 Offset: 0x29BA31 VA: 0x29B930
	private Character <Character>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x29B940 Offset: 0x29BA41 VA: 0x29B940
	private CharacterAppearance <Appearance>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x29B950 Offset: 0x29BA51 VA: 0x29B950
	private Animator <RootAnimator>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x29B960 Offset: 0x29BA61 VA: 0x29B960
	private EventCharacterLookAtController <LookAtController>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x29B970 Offset: 0x29BA71 VA: 0x29B970
	private GameObject <LookAtTarget>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x29B980 Offset: 0x29BA81 VA: 0x29B980
	private MainMenuSequence.AlphaFader <AlphaFader>k__BackingField; // 0x40

	// Properties
	private string Pid { get; set; }
	private Character Character { get; set; }
	private CharacterAppearance Appearance { get; set; }
	private Animator RootAnimator { get; set; }
	private EventCharacterLookAtController LookAtController { get; set; }
	private GameObject LookAtTarget { get; set; }
	private MainMenuSequence.AlphaFader AlphaFader { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB0F0 Offset: 0x2CB1F1 VA: 0x2CB0F0
	// RVA: 0x22323C0 Offset: 0x22324C1 VA: 0x22323C0
	private string get_Pid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB100 Offset: 0x2CB201 VA: 0x2CB100
	// RVA: 0x22323D0 Offset: 0x22324D1 VA: 0x22323D0
	private void set_Pid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB110 Offset: 0x2CB211 VA: 0x2CB110
	// RVA: 0x22323E0 Offset: 0x22324E1 VA: 0x22323E0
	private Character get_Character() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB120 Offset: 0x2CB221 VA: 0x2CB120
	// RVA: 0x22323F0 Offset: 0x22324F1 VA: 0x22323F0
	private void set_Character(Character value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB130 Offset: 0x2CB231 VA: 0x2CB130
	// RVA: 0x2232400 Offset: 0x2232501 VA: 0x2232400
	private CharacterAppearance get_Appearance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB140 Offset: 0x2CB241 VA: 0x2CB140
	// RVA: 0x2232410 Offset: 0x2232511 VA: 0x2232410
	private void set_Appearance(CharacterAppearance value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB150 Offset: 0x2CB251 VA: 0x2CB150
	// RVA: 0x2232420 Offset: 0x2232521 VA: 0x2232420
	private Animator get_RootAnimator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB160 Offset: 0x2CB261 VA: 0x2CB160
	// RVA: 0x2232430 Offset: 0x2232531 VA: 0x2232430
	private void set_RootAnimator(Animator value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB170 Offset: 0x2CB271 VA: 0x2CB170
	// RVA: 0x2232440 Offset: 0x2232541 VA: 0x2232440
	private EventCharacterLookAtController get_LookAtController() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB180 Offset: 0x2CB281 VA: 0x2CB180
	// RVA: 0x2232450 Offset: 0x2232551 VA: 0x2232450
	private void set_LookAtController(EventCharacterLookAtController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB190 Offset: 0x2CB291 VA: 0x2CB190
	// RVA: 0x2232460 Offset: 0x2232561 VA: 0x2232460
	private GameObject get_LookAtTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB1A0 Offset: 0x2CB2A1 VA: 0x2CB1A0
	// RVA: 0x2232470 Offset: 0x2232571 VA: 0x2232470
	private void set_LookAtTarget(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB1B0 Offset: 0x2CB2B1 VA: 0x2CB1B0
	// RVA: 0x2232480 Offset: 0x2232581 VA: 0x2232480
	private MainMenuSequence.AlphaFader get_AlphaFader() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB1C0 Offset: 0x2CB2C1 VA: 0x2CB1C0
	// RVA: 0x2232490 Offset: 0x2232591 VA: 0x2232490
	private void set_AlphaFader(MainMenuSequence.AlphaFader value) { }

	// RVA: 0x22324A0 Offset: 0x22325A1 VA: 0x22324A0
	public void .ctor(string pid, CharacterAppearance appearance) { }

	// RVA: 0x2231ED0 Offset: 0x2231FD1 VA: 0x2231ED0
	public void SetupByCharacter(Character character) { }

	// RVA: 0x2232570 Offset: 0x2232671 VA: 0x2232570
	public void Tick() { }

	// RVA: 0x22325D0 Offset: 0x22326D1 VA: 0x22325D0
	public bool IsLoading() { }

	// RVA: 0x2232660 Offset: 0x2232761 VA: 0x2232660
	public void SetPosByLocatorName(string posLocatorName) { }

	// RVA: 0x22327D0 Offset: 0x22328D1 VA: 0x22327D0
	public void PlayBodyAnim(string bodyAnimName, float transitionDuration) { }

	// RVA: 0x22328B0 Offset: 0x22329B1 VA: 0x22328B0
	public void PlayFacialAnim(string facialAnimName) { }

	// RVA: 0x2232960 Offset: 0x2232A61 VA: 0x2232960
	public void SetLookAt(GameObject target) { }

	// RVA: 0x2232A00 Offset: 0x2232B01 VA: 0x2232A00
	public void FadeIn() { }

	// RVA: 0x2232A20 Offset: 0x2232B21 VA: 0x2232A20
	public void FadeOut() { }

	// RVA: 0x2232A40 Offset: 0x2232B41 VA: 0x2232A40
	public void ToDefault() { }

	// RVA: 0x2232B70 Offset: 0x2232C71 VA: 0x2232B70
	public void ToActive() { }

	// RVA: 0x2232D00 Offset: 0x2232E01 VA: 0x2232D00
	public void ToInactive() { }

	// RVA: 0x2232E80 Offset: 0x2232F81 VA: 0x2232E80
	public void ToDecide() { }

	// RVA: 0x2231E00 Offset: 0x2231F01 VA: 0x2231E00
	public void ToNotDecide() { }

	// RVA: 0x2232EA0 Offset: 0x2232FA1 VA: 0x2232EA0
	public void ToGameStart() { }
}

// Namespace: 
private class MainMenuSequence.CameraWork // TypeDefIndex: 13025
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29B990 Offset: 0x29BA91 VA: 0x29B990
	private Camera <Camera>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29B9A0 Offset: 0x29BAA1 VA: 0x29B9A0
	private Animator <Animator>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x29B9B0 Offset: 0x29BAB1 VA: 0x29B9B0
	private GameObject <LookAtTarget>k__BackingField; // 0x20

	// Properties
	public Camera Camera { get; set; }
	public Animator Animator { get; set; }
	public GameObject LookAtTarget { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB1D0 Offset: 0x2CB2D1 VA: 0x2CB1D0
	// RVA: 0x2232110 Offset: 0x2232211 VA: 0x2232110
	public Camera get_Camera() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB1E0 Offset: 0x2CB2E1 VA: 0x2CB1E0
	// RVA: 0x2232120 Offset: 0x2232221 VA: 0x2232120
	public void set_Camera(Camera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB1F0 Offset: 0x2CB2F1 VA: 0x2CB1F0
	// RVA: 0x2232130 Offset: 0x2232231 VA: 0x2232130
	public Animator get_Animator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB200 Offset: 0x2CB301 VA: 0x2CB200
	// RVA: 0x2232140 Offset: 0x2232241 VA: 0x2232140
	public void set_Animator(Animator value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB210 Offset: 0x2CB311 VA: 0x2CB210
	// RVA: 0x2232150 Offset: 0x2232251 VA: 0x2232150
	public GameObject get_LookAtTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB220 Offset: 0x2CB321 VA: 0x2CB220
	// RVA: 0x2232160 Offset: 0x2232261 VA: 0x2232160
	public void set_LookAtTarget(GameObject value) { }

	// RVA: 0x2232170 Offset: 0x2232271 VA: 0x2232170
	public void .ctor(Camera camera, Animator animator, GameObject lookAtTarget) { }

	// RVA: 0x22321E0 Offset: 0x22322E1 VA: 0x22321E0
	public bool IsPlayingAnim(string animName) { }

	// RVA: 0x22322C0 Offset: 0x22323C1 VA: 0x22322C0
	public void PlayAnim(string animName, int durationMsec = 0) { }
}

// Namespace: 
private enum MainMenuSequence.Label // TypeDefIndex: 13026
{
	// Fields
	public int value__; // 0x0
	public const MainMenuSequence.Label None = -1;
	public const MainMenuSequence.Label Start = 0;
	public const MainMenuSequence.Label DLCNews = 1;
	public const MainMenuSequence.Label TopMenu = 2;
	public const MainMenuSequence.Label ChangeSceneToGameStart = 3;
	public const MainMenuSequence.Label ChangeSceneToTitle = 4;
	public const MainMenuSequence.Label InitGameStart = 5;
	public const MainMenuSequence.Label PlayerGenderSelect = 6;
	public const MainMenuSequence.Label CameraZoomInToPlayer = 7;
	public const MainMenuSequence.Label CameraZoomOutFromPlayer = 8;
	public const MainMenuSequence.Label PlayerNameInput = 9;
	public const MainMenuSequence.Label PlayerBirthdayInput = 10;
	public const MainMenuSequence.Label DifficultySelect = 11;
	public const MainMenuSequence.Label GameModeSelect = 12;
	public const MainMenuSequence.Label GrowModeSelect = 13;
	public const MainMenuSequence.Label NetworkServiceSelect = 14;
	public const MainMenuSequence.Label NetworkLogin = 15;
	public const MainMenuSequence.Label FinalConfirm = 16;
	public const MainMenuSequence.Label ExecuteGameStart = 17;
	public const MainMenuSequence.Label Continue = 18;
	public const MainMenuSequence.Label Option = 19;
	public const MainMenuSequence.Label SaveDataCopy = 20;
	public const MainMenuSequence.Label SaveDataDelete = 21;
	public const MainMenuSequence.Label LanguageSetting = 22;
	public const MainMenuSequence.Label LanguageReload = 23;
	public const MainMenuSequence.Label DLCBegin = 24;
	public const MainMenuSequence.Label DLCShop = 25;
	public const MainMenuSequence.Label DLCEnd = 26;
	public const MainMenuSequence.Label ToTitleLoop = 27;
	public const MainMenuSequence.Label ToStartGame = 28;
	public const MainMenuSequence.Label ToContinueGame = 29;
	public const MainMenuSequence.Label End = 30;
}

// Namespace: 
public abstract class MainMenuSequence.MenuSequenceBase : ProcInst // TypeDefIndex: 13027
{
	// Fields
	protected GameObject m_LayoutPrefab; // 0x70

	// Methods

	// RVA: 0x2234590 Offset: 0x2234691 VA: 0x2234590 Slot: 18
	protected virtual string GetLayoutPrefabPath() { }

	// RVA: 0x22345E0 Offset: 0x22346E1 VA: 0x22345E0 Slot: 19
	protected virtual bool IsTitleBarEnable() { }

	// RVA: 0x22345F0 Offset: 0x22346F1 VA: 0x22345F0 Slot: 20
	protected virtual string GetTitleBarName() { }

	// RVA: 0x2234640 Offset: 0x2234741 VA: 0x2234640 Slot: 21
	protected virtual string GetTitleBarHelp() { }

	// RVA: 0x2234690 Offset: 0x2234791 VA: 0x2234690 Slot: 22
	protected virtual string GetTitleBarKeyHelpId() { }

	// RVA: 0x22346E0 Offset: 0x22347E1 VA: 0x22346E0
	protected void LoadLayoutPrefabAsync() { }

	// RVA: 0x2234780 Offset: 0x2234881 VA: 0x2234780
	protected void UnloadLayoutPrefab() { }

	// RVA: 0x2234810 Offset: 0x2234911 VA: 0x2234810
	protected bool IsLoadingLayoutPrefab() { }

	// RVA: 0x22348A0 Offset: 0x22349A1 VA: 0x22348A0
	protected void CreateLayoutPrefab() { }

	// RVA: 0x2234950 Offset: 0x2234A51 VA: 0x2234950
	protected void DestroyLayoutPrefab() { }

	// RVA: 0x2234A10 Offset: 0x2234B11 VA: 0x2234A10
	protected void SetTitleBarValue() { }

	// RVA: 0x2234B60 Offset: 0x2234C61 VA: 0x2234B60
	protected void OpenTitleBar() { }

	// RVA: 0x2234B70 Offset: 0x2234C71 VA: 0x2234B70 Slot: 23
	protected virtual void CreateMenuBind(ProcInst super) { }

	// RVA: 0x2234B80 Offset: 0x2234C81 VA: 0x2234B80 Slot: 24
	protected virtual ProcDesc[] GetProcDesc() { }

	// RVA: 0x22332B0 Offset: 0x22333B1 VA: 0x22332B0
	protected void .ctor() { }
}

// Namespace: 
public abstract class MainMenuSequence.TopMenuSequence.Menu.MenuItem : BasicMenuItem // TypeDefIndex: 13028
{
	// Methods

	// RVA: 0x2D7C310 Offset: 0x2D7C411 VA: 0x2D7C310 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2D7A3C0 Offset: 0x2D7A4C1 VA: 0x2D7A3C0
	protected void .ctor() { }
}

// Namespace: 
private class MainMenuSequence.TopMenuSequence.Menu.StartMenuItem : MainMenuSequence.TopMenuSequence.Menu.MenuItem // TypeDefIndex: 13029
{
	// Methods

	// RVA: 0x2D7C740 Offset: 0x2D7C841 VA: 0x2D7C740 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D7C7C0 Offset: 0x2D7C8C1 VA: 0x2D7C7C0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D7C7D0 Offset: 0x2D7C8D1 VA: 0x2D7C7D0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D7C870 Offset: 0x2D7C971 VA: 0x2D7C870
	public void .ctor() { }
}

// Namespace: 
private class MainMenuSequence.TopMenuSequence.Menu.ContinueMenuItem : MainMenuSequence.TopMenuSequence.Menu.MenuItem // TypeDefIndex: 13030
{
	// Methods

	// RVA: 0x2D7C150 Offset: 0x2D7C251 VA: 0x2D7C150 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D7C1D0 Offset: 0x2D7C2D1 VA: 0x2D7C1D0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D7C1E0 Offset: 0x2D7C2E1 VA: 0x2D7C1E0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D7C280 Offset: 0x2D7C381 VA: 0x2D7C280
	public void .ctor() { }
}

// Namespace: 
private class MainMenuSequence.TopMenuSequence.Menu.OptionMenuItem : MainMenuSequence.TopMenuSequence.Menu.MenuItem // TypeDefIndex: 13031
{
	// Methods

	// RVA: 0x2D7C5F0 Offset: 0x2D7C6F1 VA: 0x2D7C5F0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D7C670 Offset: 0x2D7C771 VA: 0x2D7C670 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D7C680 Offset: 0x2D7C781 VA: 0x2D7C680 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D7C730 Offset: 0x2D7C831 VA: 0x2D7C730
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.TopMenuSequence.Menu.MenuContent : BasicMenuContent // TypeDefIndex: 13032
{
	// Methods

	// RVA: 0x2D7C290 Offset: 0x2D7C391 VA: 0x2D7C290 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2D7C2A0 Offset: 0x2D7C3A1 VA: 0x2D7C2A0
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.TopMenuSequence.Menu.MenuItemContent : BasicMenuItemContent // TypeDefIndex: 13033
{
	// Fields
	private TextMeshProUGUI m_NameText; // 0x48

	// Methods

	// RVA: 0x2D7C390 Offset: 0x2D7C491 VA: 0x2D7C390 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x2D7C500 Offset: 0x2D7C601 VA: 0x2D7C500 Slot: 10
	public override void BuildText() { }

	// RVA: 0x2D7C490 Offset: 0x2D7C591 VA: 0x2D7C490
	public void SetupByMenuItem(MainMenuSequence.TopMenuSequence.Menu.MenuItem menuItem) { }

	// RVA: 0x2D7C5E0 Offset: 0x2D7C6E1 VA: 0x2D7C5E0
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.TopMenuSequence.Menu : BasicMenu // TypeDefIndex: 13034
{
	// Methods

	// RVA: 0x1DD41D0 Offset: 0x1DD42D1 VA: 0x1DD41D0
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent) { }

	// RVA: 0x1DD41E0 Offset: 0x1DD42E1 VA: 0x1DD41E0 Slot: 32
	public override int GetShowRowMax() { }

	// RVA: 0x1DD41F0 Offset: 0x1DD42F1 VA: 0x1DD41F0 Slot: 26
	public override void OnClose() { }

	// RVA: 0x1DD4200 Offset: 0x1DD4301 VA: 0x1DD4200
	public static void CreateMenuBind(ProcInst super, MainMenuSequence.TopMenuSequence.Menu.MenuContent menuContent) { }
}

// Namespace: 
public class MainMenuSequence.TopMenuSequence : MainMenuSequence.MenuSequenceBase // TypeDefIndex: 13035
{
	// Methods

	// RVA: 0x2237D00 Offset: 0x2237E01 VA: 0x2237D00 Slot: 18
	protected override string GetLayoutPrefabPath() { }

	// RVA: 0x2237D50 Offset: 0x2237E51 VA: 0x2237D50 Slot: 19
	protected override bool IsTitleBarEnable() { }

	// RVA: 0x2237D60 Offset: 0x2237E61 VA: 0x2237D60 Slot: 20
	protected override string GetTitleBarName() { }

	// RVA: 0x2237DE0 Offset: 0x2237EE1 VA: 0x2237DE0 Slot: 21
	protected override string GetTitleBarHelp() { }

	// RVA: 0x2237E60 Offset: 0x2237F61 VA: 0x2237E60 Slot: 22
	protected override string GetTitleBarKeyHelpId() { }

	// RVA: 0x2237EB0 Offset: 0x2237FB1 VA: 0x2237EB0 Slot: 23
	protected override void CreateMenuBind(ProcInst super) { }

	// RVA: 0x2237F50 Offset: 0x2238051 VA: 0x2237F50
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2237FE0 Offset: 0x22380E1 VA: 0x2237FE0
	public void .ctor() { }
}

// Namespace: 
public abstract class MainMenuSequence.OptionMenuSequence.Menu.MenuItem : MainMenuSequence.TopMenuSequence.Menu.MenuItem // TypeDefIndex: 13036
{
	// Methods

	// RVA: 0x2D7A340 Offset: 0x2D7A441 VA: 0x2D7A340 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2D7A090 Offset: 0x2D7A191 VA: 0x2D7A090
	protected void .ctor() { }
}

// Namespace: 
private class MainMenuSequence.OptionMenuSequence.Menu.CopyMenuItem : MainMenuSequence.OptionMenuSequence.Menu.MenuItem // TypeDefIndex: 13037
{
	// Methods

	// RVA: 0x2D79F40 Offset: 0x2D7A041 VA: 0x2D79F40 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D79FC0 Offset: 0x2D7A0C1 VA: 0x2D79FC0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D79FD0 Offset: 0x2D7A0D1 VA: 0x2D79FD0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D7A080 Offset: 0x2D7A181 VA: 0x2D7A080
	public void .ctor() { }
}

// Namespace: 
private class MainMenuSequence.OptionMenuSequence.Menu.DeleteMenuItem : MainMenuSequence.OptionMenuSequence.Menu.MenuItem // TypeDefIndex: 13038
{
	// Methods

	// RVA: 0x2D7A0A0 Offset: 0x2D7A1A1 VA: 0x2D7A0A0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D7A120 Offset: 0x2D7A221 VA: 0x2D7A120 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D7A130 Offset: 0x2D7A231 VA: 0x2D7A130 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D7A1E0 Offset: 0x2D7A2E1 VA: 0x2D7A1E0
	public void .ctor() { }
}

// Namespace: 
private class MainMenuSequence.OptionMenuSequence.Menu.LanguageSettingMenuItem : MainMenuSequence.OptionMenuSequence.Menu.MenuItem // TypeDefIndex: 13039
{
	// Methods

	// RVA: 0x2D7A1F0 Offset: 0x2D7A2F1 VA: 0x2D7A1F0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D7A270 Offset: 0x2D7A371 VA: 0x2D7A270 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D7A280 Offset: 0x2D7A381 VA: 0x2D7A280 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D7A330 Offset: 0x2D7A431 VA: 0x2D7A330
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.OptionMenuSequence.Menu : BasicMenu // TypeDefIndex: 13040
{
	// Methods

	// RVA: 0x1DD3BB0 Offset: 0x1DD3CB1 VA: 0x1DD3BB0
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent) { }

	// RVA: 0x1DD3BC0 Offset: 0x1DD3CC1 VA: 0x1DD3BC0 Slot: 32
	public override int GetShowRowMax() { }

	// RVA: 0x1DD3BD0 Offset: 0x1DD3CD1 VA: 0x1DD3BD0 Slot: 26
	public override void OnClose() { }

	// RVA: 0x1DD3BE0 Offset: 0x1DD3CE1 VA: 0x1DD3BE0
	public static void CreateMenuBind(ProcInst super, BasicMenuContent menuContent) { }
}

// Namespace: 
public class MainMenuSequence.OptionMenuSequence : MainMenuSequence.MenuSequenceBase // TypeDefIndex: 13041
{
	// Methods

	// RVA: 0x22356B0 Offset: 0x22357B1 VA: 0x22356B0 Slot: 18
	protected override string GetLayoutPrefabPath() { }

	// RVA: 0x2235700 Offset: 0x2235801 VA: 0x2235700 Slot: 19
	protected override bool IsTitleBarEnable() { }

	// RVA: 0x2235710 Offset: 0x2235811 VA: 0x2235710 Slot: 20
	protected override string GetTitleBarName() { }

	// RVA: 0x2235790 Offset: 0x2235891 VA: 0x2235790 Slot: 21
	protected override string GetTitleBarHelp() { }

	// RVA: 0x2235810 Offset: 0x2235911 VA: 0x2235810 Slot: 22
	protected override string GetTitleBarKeyHelpId() { }

	// RVA: 0x2235860 Offset: 0x2235961 VA: 0x2235860 Slot: 23
	protected override void CreateMenuBind(ProcInst super) { }

	// RVA: 0x2235900 Offset: 0x2235A01 VA: 0x2235900
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2235990 Offset: 0x2235A91 VA: 0x2235990
	public void .ctor() { }
}

// Namespace: 
private class MainMenuSequence.LanguageSettingMenuSequence.Menu.ConfirmDialog.YesDialogItem : BasicDialogItemYes // TypeDefIndex: 13042
{
	// Methods

	// RVA: 0x2D779F0 Offset: 0x2D77AF1 VA: 0x2D779F0
	public void .ctor() { }

	// RVA: 0x2D7F420 Offset: 0x2D7F521 VA: 0x2D7F420 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class MainMenuSequence.LanguageSettingMenuSequence.Menu.ConfirmDialog.NoDialogItem : BasicDialogItemNo // TypeDefIndex: 13043
{
	// Methods

	// RVA: 0x2D7F390 Offset: 0x2D7F491 VA: 0x2D7F390 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D7F410 Offset: 0x2D7F511 VA: 0x2D7F410 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D77A80 Offset: 0x2D77B81 VA: 0x2D77A80
	public void .ctor() { }
}

// Namespace: 
private class MainMenuSequence.LanguageSettingMenuSequence.Menu.ConfirmDialog : YesNoDialog // TypeDefIndex: 13044
{
	// Methods

	// RVA: 0x2D77870 Offset: 0x2D77971 VA: 0x2D77870
	private void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent dialogContent) { }

	// RVA: 0x2D77880 Offset: 0x2D77981 VA: 0x2D77880
	public static void CreateBind(ProcInst super) { }
}

// Namespace: 
public abstract class MainMenuSequence.LanguageSettingMenuSequence.Menu.MenuItem : BasicMenuItem // TypeDefIndex: 13045
{
	// Methods

	// RVA: 0x2D77F70 Offset: 0x2D78071 VA: 0x2D77F70 Slot: 27
	public virtual string GetParamName() { }

	// RVA: 0x2D77FC0 Offset: 0x2D780C1 VA: 0x2D77FC0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2D78080 Offset: 0x2D78181 VA: 0x2D78080
	protected void .ctor() { }
}

// Namespace: 
private class MainMenuSequence.LanguageSettingMenuSequence.Menu.MessMenuItem : MainMenuSequence.LanguageSettingMenuSequence.Menu.MenuItem // TypeDefIndex: 13046
{
	// Methods

	// RVA: 0x2D78530 Offset: 0x2D78631 VA: 0x2D78530 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D785B0 Offset: 0x2D786B1 VA: 0x2D785B0 Slot: 27
	public override string GetParamName() { }

	// RVA: 0x2D786C0 Offset: 0x2D787C1 VA: 0x2D786C0 Slot: 17
	public override BasicMenu.Result KeyCall() { }

	// RVA: 0x2D78F30 Offset: 0x2D79031 VA: 0x2D78F30
	public void .ctor() { }
}

// Namespace: 
private class MainMenuSequence.LanguageSettingMenuSequence.Menu.VoiceMenuItem : MainMenuSequence.LanguageSettingMenuSequence.Menu.MenuItem // TypeDefIndex: 13047
{
	// Methods

	// RVA: 0x2D78F40 Offset: 0x2D79041 VA: 0x2D78F40 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D78FC0 Offset: 0x2D790C1 VA: 0x2D78FC0 Slot: 27
	public override string GetParamName() { }

	// RVA: 0x2D790D0 Offset: 0x2D791D1 VA: 0x2D790D0 Slot: 17
	public override BasicMenu.Result KeyCall() { }

	// RVA: 0x2D79940 Offset: 0x2D79A41 VA: 0x2D79940
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.LanguageSettingMenuSequence.Menu.MenuContent : BasicMenuContent // TypeDefIndex: 13048
{
	// Methods

	// RVA: 0x2D77A90 Offset: 0x2D77B91 VA: 0x2D77A90 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2D77AA0 Offset: 0x2D77BA1 VA: 0x2D77AA0 Slot: 14
	public override void SetCursorColor(Color c) { }

	// RVA: 0x2D77F00 Offset: 0x2D78001 VA: 0x2D77F00
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.LanguageSettingMenuSequence.Menu.MenuItemContent : BasicMenuItemContent // TypeDefIndex: 13049
{
	// Fields
	private TextMeshProUGUI m_NameText; // 0x48
	private TextMeshProUGUI m_ParamText; // 0x50

	// Methods

	// RVA: 0x2D78090 Offset: 0x2D78191 VA: 0x2D78090 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x2D78270 Offset: 0x2D78371 VA: 0x2D78270 Slot: 10
	public override void BuildText() { }

	// RVA: 0x2D781C0 Offset: 0x2D782C1 VA: 0x2D781C0
	public void SetupByMenuItem(MainMenuSequence.LanguageSettingMenuSequence.Menu.MenuItem menuItem) { }

	// RVA: 0x2D783C0 Offset: 0x2D784C1 VA: 0x2D783C0 Slot: 11
	public override void BuildTextColor() { }

	// RVA: 0x2D78490 Offset: 0x2D78591 VA: 0x2D78490 Slot: 7
	protected override void UpdateTextColor() { }

	// RVA: 0x2D78520 Offset: 0x2D78621 VA: 0x2D78520
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.LanguageSettingMenuSequence.Menu : BasicMenu // TypeDefIndex: 13050
{
	// Fields
	private static readonly Language.Langs[] LanguageMessTable; // 0x0
	private static readonly Language.Voices[] LanguageVoiceTable; // 0x8
	private int m_LangMessIndexOld; // 0xC4
	private int m_LangVoiceIndexOld; // 0xC8
	private int m_LangMessIndex; // 0xCC
	private int m_LangVoiceIndex; // 0xD0

	// Methods

	// RVA: 0x1DD3230 Offset: 0x1DD3331 VA: 0x1DD3230 Slot: 32
	public override int GetShowRowMax() { }

	// RVA: 0x1DD3240 Offset: 0x1DD3341 VA: 0x1DD3240 Slot: 26
	public override void OnClose() { }

	// RVA: 0x1DD3320 Offset: 0x1DD3421 VA: 0x1DD3320
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent) { }

	// RVA: 0x1DD3590 Offset: 0x1DD3691 VA: 0x1DD3590
	public static void CreateMenuBind(ProcInst super, BasicMenuContent menuContent) { }

	// RVA: 0x1DD3780 Offset: 0x1DD3881 VA: 0x1DD3780
	private static void .cctor() { }
}

// Namespace: 
public class MainMenuSequence.LanguageSettingMenuSequence : MainMenuSequence.MenuSequenceBase // TypeDefIndex: 13051
{
	// Methods

	// RVA: 0x2234280 Offset: 0x2234381 VA: 0x2234280 Slot: 18
	protected override string GetLayoutPrefabPath() { }

	// RVA: 0x22342D0 Offset: 0x22343D1 VA: 0x22342D0 Slot: 20
	protected override string GetTitleBarName() { }

	// RVA: 0x2234350 Offset: 0x2234451 VA: 0x2234350 Slot: 21
	protected override string GetTitleBarHelp() { }

	// RVA: 0x22343D0 Offset: 0x22344D1 VA: 0x22343D0 Slot: 22
	protected override string GetTitleBarKeyHelpId() { }

	// RVA: 0x2234420 Offset: 0x2234521 VA: 0x2234420 Slot: 23
	protected override void CreateMenuBind(ProcInst super) { }

	// RVA: 0x22344F0 Offset: 0x22345F1 VA: 0x22344F0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2234580 Offset: 0x2234681 VA: 0x2234580
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.HistoryInfo.Window // TypeDefIndex: 13052
{
	// Fields
	private GameObject m_RootObject; // 0x10
	private CanvasGroup m_CanvasGroup; // 0x18
	private TextMeshProUGUI m_HistoryText; // 0x20
	private MainMenuSequence.HistoryInfo.InfoKind m_InfoKind; // 0x28

	// Methods

	// RVA: 0x1DD2EB0 Offset: 0x1DD2FB1 VA: 0x1DD2EB0
	public void .ctor(GameObject rootObject, MainMenuSequence.HistoryInfo.InfoKind infoKind) { }

	// RVA: 0x1DD2FE0 Offset: 0x1DD30E1 VA: 0x1DD2FE0
	public void Disable() { }

	// RVA: 0x1DD2FF0 Offset: 0x1DD30F1 VA: 0x1DD2FF0
	public void Show() { }

	// RVA: 0x1DD30B0 Offset: 0x1DD31B1 VA: 0x1DD30B0
	public void Hide() { }

	// RVA: 0x1DD3170 Offset: 0x1DD3271 VA: 0x1DD3170
	public void SetHistoryText(string text) { }

	// RVA: 0x1DD3190 Offset: 0x1DD3291 VA: 0x1DD3190
	public void ClearHistoryText() { }
}

// Namespace: 
public enum MainMenuSequence.HistoryInfo.InfoKind // TypeDefIndex: 13053
{
	// Fields
	public int value__; // 0x0
	public const MainMenuSequence.HistoryInfo.InfoKind PlayerName = 0;
	public const MainMenuSequence.HistoryInfo.InfoKind Birthday = 1;
	public const MainMenuSequence.HistoryInfo.InfoKind Difficulty = 2;
	public const MainMenuSequence.HistoryInfo.InfoKind GrowMode = 3;
	public const MainMenuSequence.HistoryInfo.InfoKind NetworkService = 4;
	public const MainMenuSequence.HistoryInfo.InfoKind GameMode = 5;
	public const MainMenuSequence.HistoryInfo.InfoKind Max = 6;
}

// Namespace: 
public class MainMenuSequence.HistoryInfo // TypeDefIndex: 13054
{
	// Fields
	private const string LayoutPrefabPath = "UI/Title/StartMenu/Prefabs/HistoryRoot";
	private GameObject m_LayoutPrefab; // 0x10
	private MainMenuSequence.HistoryInfo.Window[] m_Window; // 0x18
	private Animator m_MenuAnimator; // 0x20

	// Methods

	// RVA: 0x2233A10 Offset: 0x2233B11 VA: 0x2233A10
	public static void LoadLayoutPrefabAsync() { }

	// RVA: 0x2233AB0 Offset: 0x2233BB1 VA: 0x2233AB0
	public static void UnloadLayoutPrefab() { }

	// RVA: 0x2233B30 Offset: 0x2233C31 VA: 0x2233B30
	public static bool IsLoadingLayoutPrefab() { }

	// RVA: 0x2233BB0 Offset: 0x2233CB1 VA: 0x2233BB0
	public void Setup() { }

	// RVA: 0x2233F30 Offset: 0x2234031 VA: 0x2233F30
	private MainMenuSequence.HistoryInfo.Window GetWindow(MainMenuSequence.HistoryInfo.InfoKind infoKind) { }

	// RVA: 0x2233F70 Offset: 0x2234071 VA: 0x2233F70
	public void FadeIn() { }

	// RVA: 0x2234020 Offset: 0x2234121 VA: 0x2234020
	public void FadeOut() { }

	// RVA: 0x22340D0 Offset: 0x22341D1 VA: 0x22340D0
	public void ShowWindow(MainMenuSequence.HistoryInfo.InfoKind infoKind) { }

	// RVA: 0x2234120 Offset: 0x2234221 VA: 0x2234120
	public void HideWindow(MainMenuSequence.HistoryInfo.InfoKind infoKind) { }

	// RVA: 0x2234170 Offset: 0x2234271 VA: 0x2234170
	public void SetHistoryText(MainMenuSequence.HistoryInfo.InfoKind infoKind, string text) { }

	// RVA: 0x22341C0 Offset: 0x22342C1 VA: 0x22341C0
	public void ClearHistoryText(MainMenuSequence.HistoryInfo.InfoKind infoKind) { }

	// RVA: 0x2234210 Offset: 0x2234311 VA: 0x2234210
	public void .ctor() { }
}

// Namespace: 
public abstract class MainMenuSequence.DifficultySelectMenuSequence.Menu.MenuItem : BasicMenuItem // TypeDefIndex: 13055
{
	// Fields
	private Difficulty m_Difficulty; // 0x64

	// Methods

	// RVA: 0x2D75D80 Offset: 0x2D75E81 VA: 0x2D75D80
	public void .ctor(Difficulty difficulty) { }

	// RVA: 0x2D76030 Offset: 0x2D76131 VA: 0x2D76030 Slot: 27
	public virtual string GetHelp() { }

	// RVA: 0x2D76080 Offset: 0x2D76181 VA: 0x2D76080 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D76190 Offset: 0x2D76291 VA: 0x2D76190 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
private class MainMenuSequence.DifficultySelectMenuSequence.Menu.NormalMenuItem : MainMenuSequence.DifficultySelectMenuSequence.Menu.MenuItem // TypeDefIndex: 13056
{
	// Methods

	// RVA: 0x2D76600 Offset: 0x2D76701 VA: 0x2D76600
	public void .ctor() { }

	// RVA: 0x2D76630 Offset: 0x2D76731 VA: 0x2D76630 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D76690 Offset: 0x2D76791 VA: 0x2D76690 Slot: 27
	public override string GetHelp() { }
}

// Namespace: 
private class MainMenuSequence.DifficultySelectMenuSequence.Menu.HardMenuItem : MainMenuSequence.DifficultySelectMenuSequence.Menu.MenuItem // TypeDefIndex: 13057
{
	// Methods

	// RVA: 0x2D75D50 Offset: 0x2D75E51 VA: 0x2D75D50
	public void .ctor() { }

	// RVA: 0x2D75DB0 Offset: 0x2D75EB1 VA: 0x2D75DB0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D75E10 Offset: 0x2D75F11 VA: 0x2D75E10 Slot: 27
	public override string GetHelp() { }
}

// Namespace: 
private class MainMenuSequence.DifficultySelectMenuSequence.Menu.LunaticMenuItem : MainMenuSequence.DifficultySelectMenuSequence.Menu.MenuItem // TypeDefIndex: 13058
{
	// Methods

	// RVA: 0x2D75E90 Offset: 0x2D75F91 VA: 0x2D75E90
	public void .ctor() { }

	// RVA: 0x2D75EC0 Offset: 0x2D75FC1 VA: 0x2D75EC0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D75F20 Offset: 0x2D76021 VA: 0x2D75F20 Slot: 27
	public override string GetHelp() { }
}

// Namespace: 
public class MainMenuSequence.DifficultySelectMenuSequence.Menu.MenuContent : BasicMenuContent // TypeDefIndex: 13059
{
	// Methods

	// RVA: 0x2D75FA0 Offset: 0x2D760A1 VA: 0x2D75FA0 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2D75FC0 Offset: 0x2D760C1 VA: 0x2D75FC0
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.DifficultySelectMenuSequence.Menu.MenuItemContent : BasicMenuItemContent // TypeDefIndex: 13060
{
	// Fields
	private TextMeshProUGUI m_NameText; // 0x48
	private TextMeshProUGUI m_HelpText; // 0x50

	// Methods

	// RVA: 0x2D76240 Offset: 0x2D76341 VA: 0x2D76240 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x2D76420 Offset: 0x2D76521 VA: 0x2D76420 Slot: 10
	public override void BuildText() { }

	// RVA: 0x2D76370 Offset: 0x2D76471 VA: 0x2D76370
	public void SetupByMenuItem(MainMenuSequence.DifficultySelectMenuSequence.Menu.MenuItem menuItem) { }

	// RVA: 0x2D76560 Offset: 0x2D76661 VA: 0x2D76560 Slot: 7
	protected override void UpdateTextColor() { }

	// RVA: 0x2D765F0 Offset: 0x2D766F1 VA: 0x2D765F0
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.DifficultySelectMenuSequence.Menu : BasicMenu // TypeDefIndex: 13061
{
	// Methods

	// RVA: 0x1DD2370 Offset: 0x1DD2471 VA: 0x1DD2370 Slot: 32
	public override int GetShowRowMax() { }

	// RVA: 0x1DD2380 Offset: 0x1DD2481 VA: 0x1DD2380 Slot: 26
	public override void OnClose() { }

	// RVA: 0x1DD2390 Offset: 0x1DD2491 VA: 0x1DD2390
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent) { }

	// RVA: 0x1DD23A0 Offset: 0x1DD24A1 VA: 0x1DD23A0
	public static void CreateMenuBind(ProcInst super, MainMenuSequence.DifficultySelectMenuSequence.Menu.MenuContent menuContent) { }
}

// Namespace: 
public class MainMenuSequence.DifficultySelectMenuSequence : MainMenuSequence.MenuSequenceBase // TypeDefIndex: 13062
{
	// Methods

	// RVA: 0x2233000 Offset: 0x2233101 VA: 0x2233000 Slot: 18
	protected override string GetLayoutPrefabPath() { }

	// RVA: 0x2233050 Offset: 0x2233151 VA: 0x2233050 Slot: 20
	protected override string GetTitleBarName() { }

	// RVA: 0x22330D0 Offset: 0x22331D1 VA: 0x22330D0 Slot: 21
	protected override string GetTitleBarHelp() { }

	// RVA: 0x2233120 Offset: 0x2233221 VA: 0x2233120 Slot: 22
	protected override string GetTitleBarKeyHelpId() { }

	// RVA: 0x2233170 Offset: 0x2233271 VA: 0x2233170 Slot: 23
	protected override void CreateMenuBind(ProcInst super) { }

	// RVA: 0x2233210 Offset: 0x2233311 VA: 0x2233210
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x22332A0 Offset: 0x22333A1 VA: 0x22332A0
	public void .ctor() { }
}

// Namespace: 
public abstract class MainMenuSequence.GameModeSelectMenuSequence.Menu.MenuItem : BasicMenuItem // TypeDefIndex: 13063
{
	// Fields
	private GameMode m_GameMode; // 0x64

	// Methods

	// RVA: 0x2D76740 Offset: 0x2D76841 VA: 0x2D76740
	public void .ctor(GameMode gameMode) { }

	// RVA: 0x2D769F0 Offset: 0x2D76AF1 VA: 0x2D769F0 Slot: 27
	public virtual string GetHelp() { }

	// RVA: 0x2D76A40 Offset: 0x2D76B41 VA: 0x2D76A40 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D76BB0 Offset: 0x2D76CB1 VA: 0x2D76BB0 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
private class MainMenuSequence.GameModeSelectMenuSequence.Menu.CasualMenuItem : MainMenuSequence.GameModeSelectMenuSequence.Menu.MenuItem // TypeDefIndex: 13064
{
	// Methods

	// RVA: 0x2D76710 Offset: 0x2D76811 VA: 0x2D76710
	public void .ctor() { }

	// RVA: 0x2D76770 Offset: 0x2D76871 VA: 0x2D76770 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D767D0 Offset: 0x2D768D1 VA: 0x2D767D0 Slot: 27
	public override string GetHelp() { }
}

// Namespace: 
private class MainMenuSequence.GameModeSelectMenuSequence.Menu.ClassicMenuItem : MainMenuSequence.GameModeSelectMenuSequence.Menu.MenuItem // TypeDefIndex: 13065
{
	// Methods

	// RVA: 0x2D76850 Offset: 0x2D76951 VA: 0x2D76850
	public void .ctor() { }

	// RVA: 0x2D76880 Offset: 0x2D76981 VA: 0x2D76880 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D768E0 Offset: 0x2D769E1 VA: 0x2D768E0 Slot: 27
	public override string GetHelp() { }
}

// Namespace: 
public class MainMenuSequence.GameModeSelectMenuSequence.Menu.MenuContent : BasicMenuContent // TypeDefIndex: 13066
{
	// Methods

	// RVA: 0x2D76960 Offset: 0x2D76A61 VA: 0x2D76960 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2D76980 Offset: 0x2D76A81 VA: 0x2D76980
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.GameModeSelectMenuSequence.Menu.MenuItemContent : BasicMenuItemContent // TypeDefIndex: 13067
{
	// Fields
	private TextMeshProUGUI m_NameText; // 0x48
	private TextMeshProUGUI m_HelpText; // 0x50

	// Methods

	// RVA: 0x2D76C60 Offset: 0x2D76D61 VA: 0x2D76C60 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x2D76E40 Offset: 0x2D76F41 VA: 0x2D76E40 Slot: 10
	public override void BuildText() { }

	// RVA: 0x2D76D90 Offset: 0x2D76E91 VA: 0x2D76D90
	public void SetupByMenuItem(MainMenuSequence.GameModeSelectMenuSequence.Menu.MenuItem menuItem) { }

	// RVA: 0x2D76F80 Offset: 0x2D77081 VA: 0x2D76F80 Slot: 7
	protected override void UpdateTextColor() { }

	// RVA: 0x2D77010 Offset: 0x2D77111 VA: 0x2D77010
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.GameModeSelectMenuSequence.Menu : BasicMenu // TypeDefIndex: 13068
{
	// Methods

	// RVA: 0x1DD29A0 Offset: 0x1DD2AA1 VA: 0x1DD29A0 Slot: 32
	public override int GetShowRowMax() { }

	// RVA: 0x1DD29B0 Offset: 0x1DD2AB1 VA: 0x1DD29B0 Slot: 26
	public override void OnClose() { }

	// RVA: 0x1DD29C0 Offset: 0x1DD2AC1 VA: 0x1DD29C0
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent) { }

	// RVA: 0x1DD29D0 Offset: 0x1DD2AD1 VA: 0x1DD29D0
	public static void CreateMenuBind(ProcInst super, MainMenuSequence.GameModeSelectMenuSequence.Menu.MenuContent menuContent) { }
}

// Namespace: 
public class MainMenuSequence.GameModeSelectMenuSequence : MainMenuSequence.MenuSequenceBase // TypeDefIndex: 13069
{
	// Methods

	// RVA: 0x22334B0 Offset: 0x22335B1 VA: 0x22334B0 Slot: 18
	protected override string GetLayoutPrefabPath() { }

	// RVA: 0x2233500 Offset: 0x2233601 VA: 0x2233500 Slot: 20
	protected override string GetTitleBarName() { }

	// RVA: 0x2233580 Offset: 0x2233681 VA: 0x2233580 Slot: 21
	protected override string GetTitleBarHelp() { }

	// RVA: 0x22335D0 Offset: 0x22336D1 VA: 0x22335D0 Slot: 22
	protected override string GetTitleBarKeyHelpId() { }

	// RVA: 0x2233620 Offset: 0x2233721 VA: 0x2233620 Slot: 23
	protected override void CreateMenuBind(ProcInst super) { }

	// RVA: 0x22336C0 Offset: 0x22337C1 VA: 0x22336C0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2233750 Offset: 0x2233851 VA: 0x2233750
	public void .ctor() { }
}

// Namespace: 
public abstract class MainMenuSequence.GrowModeSelectMenuSequence.Menu.MenuItem : BasicMenuItem // TypeDefIndex: 13070
{
	// Fields
	private GrowMode m_GrowMode; // 0x64

	// Methods

	// RVA: 0x2D77050 Offset: 0x2D77151 VA: 0x2D77050
	public void .ctor(GrowMode growMode) { }

	// RVA: 0x2D77170 Offset: 0x2D77271 VA: 0x2D77170 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D77240 Offset: 0x2D77341 VA: 0x2D77240 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D773D0 Offset: 0x2D774D1 VA: 0x2D773D0 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
private class MainMenuSequence.GrowModeSelectMenuSequence.Menu.RandomMenuItem : MainMenuSequence.GrowModeSelectMenuSequence.Menu.MenuItem // TypeDefIndex: 13071
{
	// Methods

	// RVA: 0x2D777E0 Offset: 0x2D778E1 VA: 0x2D777E0
	public void .ctor() { }

	// RVA: 0x2D77810 Offset: 0x2D77911 VA: 0x2D77810 Slot: 4
	public override string GetName() { }
}

// Namespace: 
private class MainMenuSequence.GrowModeSelectMenuSequence.Menu.FixedMenuItem : MainMenuSequence.GrowModeSelectMenuSequence.Menu.MenuItem // TypeDefIndex: 13072
{
	// Methods

	// RVA: 0x2D77020 Offset: 0x2D77121 VA: 0x2D77020
	public void .ctor() { }

	// RVA: 0x2D77080 Offset: 0x2D77181 VA: 0x2D77080 Slot: 4
	public override string GetName() { }
}

// Namespace: 
public class MainMenuSequence.GrowModeSelectMenuSequence.Menu.MenuContent : BasicMenuContent // TypeDefIndex: 13073
{
	// Methods

	// RVA: 0x2D770E0 Offset: 0x2D771E1 VA: 0x2D770E0 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2D77100 Offset: 0x2D77201 VA: 0x2D77100
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.GrowModeSelectMenuSequence.Menu.MenuItemContent : BasicMenuItemContent // TypeDefIndex: 13074
{
	// Fields
	private TextMeshProUGUI m_NameText; // 0x48
	private TextMeshProUGUI m_HelpText; // 0x50

	// Methods

	// RVA: 0x2D77490 Offset: 0x2D77591 VA: 0x2D77490 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x2D77600 Offset: 0x2D77701 VA: 0x2D77600 Slot: 10
	public override void BuildText() { }

	// RVA: 0x2D77590 Offset: 0x2D77691 VA: 0x2D77590
	public void SetupByMenuItem(MainMenuSequence.GrowModeSelectMenuSequence.Menu.MenuItem menuItem) { }

	// RVA: 0x2D77740 Offset: 0x2D77841 VA: 0x2D77740 Slot: 7
	protected override void UpdateTextColor() { }

	// RVA: 0x2D777D0 Offset: 0x2D778D1 VA: 0x2D777D0
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.GrowModeSelectMenuSequence.Menu : BasicMenu // TypeDefIndex: 13075
{
	// Methods

	// RVA: 0x1DD2C10 Offset: 0x1DD2D11 VA: 0x1DD2C10 Slot: 32
	public override int GetShowRowMax() { }

	// RVA: 0x1DD2C20 Offset: 0x1DD2D21 VA: 0x1DD2C20 Slot: 26
	public override void OnClose() { }

	// RVA: 0x1DD2C30 Offset: 0x1DD2D31 VA: 0x1DD2C30
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent) { }

	// RVA: 0x1DD2C40 Offset: 0x1DD2D41 VA: 0x1DD2C40
	public static void CreateMenuBind(ProcInst super, MainMenuSequence.GrowModeSelectMenuSequence.Menu.MenuContent menuContent) { }
}

// Namespace: 
public class MainMenuSequence.GrowModeSelectMenuSequence : MainMenuSequence.MenuSequenceBase // TypeDefIndex: 13076
{
	// Methods

	// RVA: 0x2233760 Offset: 0x2233861 VA: 0x2233760 Slot: 18
	protected override string GetLayoutPrefabPath() { }

	// RVA: 0x22337B0 Offset: 0x22338B1 VA: 0x22337B0 Slot: 20
	protected override string GetTitleBarName() { }

	// RVA: 0x2233830 Offset: 0x2233931 VA: 0x2233830 Slot: 21
	protected override string GetTitleBarHelp() { }

	// RVA: 0x2233880 Offset: 0x2233981 VA: 0x2233880 Slot: 22
	protected override string GetTitleBarKeyHelpId() { }

	// RVA: 0x22338D0 Offset: 0x22339D1 VA: 0x22338D0 Slot: 23
	protected override void CreateMenuBind(ProcInst super) { }

	// RVA: 0x2233970 Offset: 0x2233A71 VA: 0x2233970
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2233A00 Offset: 0x2233B01 VA: 0x2233A00
	public void .ctor() { }
}

// Namespace: 
public abstract class MainMenuSequence.NetworkServiceSelectMenuSequence.Menu.MenuItem : BasicMenuItem // TypeDefIndex: 13077
{
	// Methods

	// RVA: 0x2D799E0 Offset: 0x2D79AE1 VA: 0x2D799E0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2D79A00 Offset: 0x2D79B01 VA: 0x2D79A00
	protected void .ctor() { }
}

// Namespace: 
private class MainMenuSequence.NetworkServiceSelectMenuSequence.Menu.YesMenuItem : MainMenuSequence.NetworkServiceSelectMenuSequence.Menu.MenuItem // TypeDefIndex: 13078
{
	// Methods

	// RVA: 0x2D79E30 Offset: 0x2D79F31 VA: 0x2D79E30 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D79EB0 Offset: 0x2D79FB1 VA: 0x2D79EB0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D79F30 Offset: 0x2D7A031 VA: 0x2D79F30
	public void .ctor() { }
}

// Namespace: 
private class MainMenuSequence.NetworkServiceSelectMenuSequence.Menu.NoMenuItem : MainMenuSequence.NetworkServiceSelectMenuSequence.Menu.MenuItem // TypeDefIndex: 13079
{
	// Methods

	// RVA: 0x2D79CC0 Offset: 0x2D79DC1 VA: 0x2D79CC0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D79D40 Offset: 0x2D79E41 VA: 0x2D79D40 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D79E20 Offset: 0x2D79F21 VA: 0x2D79E20
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.NetworkServiceSelectMenuSequence.Menu.MenuContent : BasicMenuContent // TypeDefIndex: 13080
{
	// Methods

	// RVA: 0x2D79950 Offset: 0x2D79A51 VA: 0x2D79950 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2D79970 Offset: 0x2D79A71 VA: 0x2D79970
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.NetworkServiceSelectMenuSequence.Menu.MenuItemContent : BasicMenuItemContent // TypeDefIndex: 13081
{
	// Fields
	private TextMeshProUGUI m_NameText; // 0x48

	// Methods

	// RVA: 0x2D79A10 Offset: 0x2D79B11 VA: 0x2D79A10 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x2D79B80 Offset: 0x2D79C81 VA: 0x2D79B80 Slot: 10
	public override void BuildText() { }

	// RVA: 0x2D79B10 Offset: 0x2D79C11 VA: 0x2D79B10
	public void SetupByMenuItem(MainMenuSequence.NetworkServiceSelectMenuSequence.Menu.MenuItem menuItem) { }

	// RVA: 0x2D79C60 Offset: 0x2D79D61 VA: 0x2D79C60 Slot: 7
	protected override void UpdateTextColor() { }

	// RVA: 0x2D79CB0 Offset: 0x2D79DB1 VA: 0x2D79CB0
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.NetworkServiceSelectMenuSequence.Menu : BasicMenu // TypeDefIndex: 13082
{
	// Methods

	// RVA: 0x1DD3880 Offset: 0x1DD3981 VA: 0x1DD3880 Slot: 32
	public override int GetShowRowMax() { }

	// RVA: 0x1DD3890 Offset: 0x1DD3991 VA: 0x1DD3890 Slot: 26
	public override void OnClose() { }

	// RVA: 0x1DD38A0 Offset: 0x1DD39A1 VA: 0x1DD38A0
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent) { }

	// RVA: 0x1DD38B0 Offset: 0x1DD39B1 VA: 0x1DD38B0
	private static void ReturnSequence() { }

	// RVA: 0x1DD39B0 Offset: 0x1DD3AB1 VA: 0x1DD39B0
	public static void CreateMenuBind(ProcInst super, MainMenuSequence.NetworkServiceSelectMenuSequence.Menu.MenuContent menuContent) { }
}

// Namespace: 
public class MainMenuSequence.NetworkServiceSelectMenuSequence : MainMenuSequence.MenuSequenceBase // TypeDefIndex: 13083
{
	// Methods

	// RVA: 0x2235400 Offset: 0x2235501 VA: 0x2235400 Slot: 18
	protected override string GetLayoutPrefabPath() { }

	// RVA: 0x2235450 Offset: 0x2235551 VA: 0x2235450 Slot: 20
	protected override string GetTitleBarName() { }

	// RVA: 0x22354D0 Offset: 0x22355D1 VA: 0x22354D0 Slot: 21
	protected override string GetTitleBarHelp() { }

	// RVA: 0x2235520 Offset: 0x2235621 VA: 0x2235520 Slot: 22
	protected override string GetTitleBarKeyHelpId() { }

	// RVA: 0x2235570 Offset: 0x2235671 VA: 0x2235570 Slot: 23
	protected override void CreateMenuBind(ProcInst super) { }

	// RVA: 0x2235610 Offset: 0x2235711 VA: 0x2235610
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x22356A0 Offset: 0x22357A1 VA: 0x22356A0
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.PlayerGenderSelectMenuSequence : MainMenuSequence.MenuSequenceBase // TypeDefIndex: 13084
{
	// Fields
	private Gender m_Gender; // 0x78
	private Animator m_MenuAnimator; // 0x80

	// Methods

	// RVA: 0x2235D90 Offset: 0x2235E91 VA: 0x2235D90 Slot: 18
	protected override string GetLayoutPrefabPath() { }

	// RVA: 0x2235DE0 Offset: 0x2235EE1 VA: 0x2235DE0 Slot: 20
	protected override string GetTitleBarName() { }

	// RVA: 0x2235E60 Offset: 0x2235F61 VA: 0x2235E60 Slot: 21
	protected override string GetTitleBarHelp() { }

	// RVA: 0x2235EB0 Offset: 0x2235FB1 VA: 0x2235EB0 Slot: 22
	protected override string GetTitleBarKeyHelpId() { }

	// RVA: 0x2235F30 Offset: 0x2236031 VA: 0x2235F30
	private void Init() { }

	// RVA: 0x2235FC0 Offset: 0x22360C1 VA: 0x2235FC0
	private void Tick() { }

	// RVA: 0x2237410 Offset: 0x2237511 VA: 0x2237410
	private void InitLayoutObjectReference() { }

	// RVA: 0x22374D0 Offset: 0x22375D1 VA: 0x22374D0
	private void CloseWindow() { }

	// RVA: 0x2237530 Offset: 0x2237631 VA: 0x2237530
	private bool WaitCloseWindow() { }

	// RVA: 0x22372F0 Offset: 0x22373F1 VA: 0x22372F0
	private void SetGender(Gender gender) { }

	// RVA: 0x22375E0 Offset: 0x22376E1 VA: 0x22375E0 Slot: 24
	protected override ProcDesc[] GetProcDesc() { }

	// RVA: 0x2237C60 Offset: 0x2237D61 VA: 0x2237C60
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2237CF0 Offset: 0x2237DF1 VA: 0x2237CF0
	public void .ctor() { }
}

// Namespace: 
private class MainMenuSequence.NameCheckDialogItemYes : BasicDialogItemYes // TypeDefIndex: 13085
{
	// Methods

	// RVA: 0x22351E0 Offset: 0x22352E1 VA: 0x22351E0
	public void .ctor() { }

	// RVA: 0x22350D0 Offset: 0x22351D1 VA: 0x22350D0
	public void .ctor(string text) { }

	// RVA: 0x2235160 Offset: 0x2235261 VA: 0x2235160
	protected void ToRename() { }

	// RVA: 0x2235270 Offset: 0x2235371 VA: 0x2235270 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2235300 Offset: 0x2235401 VA: 0x2235300 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class MainMenuSequence.NameCheckDialogItemNo : MainMenuSequence.NameCheckDialogItemYes // TypeDefIndex: 13086
{
	// Methods

	// RVA: 0x2235040 Offset: 0x2235141 VA: 0x2235040
	public void .ctor() { }

	// RVA: 0x22350E0 Offset: 0x22351E1 VA: 0x22350E0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
public abstract class MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.MenuItem : BasicMenuItem // TypeDefIndex: 13087
{
	// Methods

	// RVA: 0x2D7B260 Offset: 0x2D7B361 VA: 0x2D7B260 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D7B3A0 Offset: 0x2D7B4A1 VA: 0x2D7B3A0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2D7AC90 Offset: 0x2D7AD91 VA: 0x2D7AC90
	protected void .ctor() { }
}

// Namespace: 
private class MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.MonthMenuItem : MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.MenuItem // TypeDefIndex: 13088
{
	// Fields
	private MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.DayMenuItem m_DayMenuItem; // 0x68

	// Methods

	// RVA: 0x2D7B6A0 Offset: 0x2D7B7A1 VA: 0x2D7B6A0
	public void .ctor(MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.DayMenuItem dayMenuItem) { }

	// RVA: 0x2D7B6E0 Offset: 0x2D7B7E1 VA: 0x2D7B6E0 Slot: 17
	public override BasicMenu.Result KeyCall() { }
}

// Namespace: 
private class MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.DayMenuItem : MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.MenuItem // TypeDefIndex: 13089
{
	// Methods

	// RVA: 0x2D7A3D0 Offset: 0x2D7A4D1 VA: 0x2D7A3D0 Slot: 17
	public override BasicMenu.Result KeyCall() { }

	// RVA: 0x2D7AC80 Offset: 0x2D7AD81 VA: 0x2D7AC80
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.MenuContent : BasicMenuContent // TypeDefIndex: 13090
{
	// Fields
	protected TextMeshProUGUI m_MonthUnitText; // 0xE8
	protected TextMeshProUGUI m_DayUnitText; // 0xF0

	// Methods

	// RVA: 0x2D7ADD0 Offset: 0x2D7AED1 VA: 0x2D7ADD0 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2D7ADF0 Offset: 0x2D7AEF1 VA: 0x2D7ADF0 Slot: 13
	protected override void InitObjReference() { }

	// RVA: 0x2D7AFE0 Offset: 0x2D7B0E1 VA: 0x2D7AFE0 Slot: 9
	protected override float CalcCursorMovedPosX(int menuItemIndex) { }

	// RVA: 0x2D7B0E0 Offset: 0x2D7B1E1 VA: 0x2D7B0E0 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x2D7B1F0 Offset: 0x2D7B2F1 VA: 0x2D7B1F0
	public void .ctor() { }
}

// Namespace: 
public abstract class MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.MenuItemContent : BasicMenuItemContent // TypeDefIndex: 13091
{
	// Fields
	protected GameObject m_ValueFrameObject; // 0x48
	protected TextMeshProUGUI m_ValueText; // 0x50

	// Methods

	// RVA: 0x2D7B4C0 Offset: 0x2D7B5C1 VA: 0x2D7B4C0
	public GameObject GetValueFrameObject() { }

	// RVA: 0x2D7B4D0 Offset: 0x2D7B5D1 VA: 0x2D7B4D0 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x2D7B580 Offset: 0x2D7B681 VA: 0x2D7B580 Slot: 10
	public override void BuildText() { }

	// RVA: 0x2D7B690 Offset: 0x2D7B791 VA: 0x2D7B690 Slot: 16
	public virtual void SetupByMenuItem(MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.MenuItem menuItem) { }

	// RVA: 0x2D7ADC0 Offset: 0x2D7AEC1 VA: 0x2D7ADC0
	protected void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.MonthMenuItemContent : MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.MenuItemContent // TypeDefIndex: 13092
{
	// Methods

	// RVA: 0x2D7C030 Offset: 0x2D7C131 VA: 0x2D7C030 Slot: 16
	public override void SetupByMenuItem(MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.MenuItem menuItem) { }

	// RVA: 0x2D7C140 Offset: 0x2D7C241 VA: 0x2D7C140
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.DayMenuItemContent : MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.MenuItemContent // TypeDefIndex: 13093
{
	// Methods

	// RVA: 0x2D7ACA0 Offset: 0x2D7ADA1 VA: 0x2D7ACA0 Slot: 16
	public override void SetupByMenuItem(MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.MenuItem menuItem) { }

	// RVA: 0x2D7ADB0 Offset: 0x2D7AEB1 VA: 0x2D7ADB0
	public void .ctor() { }
}

// Namespace: 
public class MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu : BasicMenu // TypeDefIndex: 13094
{
	// Fields
	private static readonly int MonthMin; // 0x0
	private static readonly int MonthMax; // 0x4
	private static readonly int DayMin; // 0x8
	private static readonly int[] DayMax; // 0x10
	private int m_Month; // 0xC4
	private int m_Day; // 0xC8

	// Methods

	// RVA: 0x1DD3E20 Offset: 0x1DD3F21 VA: 0x1DD3E20 Slot: 32
	public override int GetShowRowMax() { }

	// RVA: 0x1DD3E30 Offset: 0x1DD3F31 VA: 0x1DD3E30 Slot: 26
	public override void OnClose() { }

	// RVA: 0x1DD3E40 Offset: 0x1DD3F41 VA: 0x1DD3E40 Slot: 40
	protected override void KeyUp(bool isTrigger) { }

	// RVA: 0x1DD3E50 Offset: 0x1DD3F51 VA: 0x1DD3E50 Slot: 41
	protected override void KeyDown(bool isTrigger) { }

	// RVA: 0x1DD3E60 Offset: 0x1DD3F61 VA: 0x1DD3E60 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x1DD3E80 Offset: 0x1DD3F81 VA: 0x1DD3E80 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x1DD3EA0 Offset: 0x1DD3FA1 VA: 0x1DD3EA0
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent) { }

	// RVA: 0x1DD3F60 Offset: 0x1DD4061 VA: 0x1DD3F60
	public static void CreateMenuBind(ProcInst super, MainMenuSequence.PlayerBirthdayInputMenuSequence.Menu.MenuContent menuContent) { }

	// RVA: 0x1DD4100 Offset: 0x1DD4201 VA: 0x1DD4100
	private static void .cctor() { }
}

// Namespace: 
private enum MainMenuSequence.PlayerBirthdayInputMenuSequence.LayoutType // TypeDefIndex: 13095
{
	// Fields
	public int value__; // 0x0
	public const MainMenuSequence.PlayerBirthdayInputMenuSequence.LayoutType JpChKorea = 0;
	public const MainMenuSequence.PlayerBirthdayInputMenuSequence.LayoutType UsEuEtc = 1;
}

// Namespace: 
public class MainMenuSequence.PlayerBirthdayInputMenuSequence : MainMenuSequence.MenuSequenceBase // TypeDefIndex: 13096
{
	// Methods

	// RVA: 0x22359A0 Offset: 0x2235AA1 VA: 0x22359A0
	private MainMenuSequence.PlayerBirthdayInputMenuSequence.LayoutType GetLayoutType() { }

	// RVA: 0x2235A90 Offset: 0x2235B91 VA: 0x2235A90 Slot: 18
	protected override string GetLayoutPrefabPath() { }

	// RVA: 0x2235B00 Offset: 0x2235C01 VA: 0x2235B00 Slot: 20
	protected override string GetTitleBarName() { }

	// RVA: 0x2235B80 Offset: 0x2235C81 VA: 0x2235B80 Slot: 21
	protected override string GetTitleBarHelp() { }

	// RVA: 0x2235BD0 Offset: 0x2235CD1 VA: 0x2235BD0 Slot: 22
	protected override string GetTitleBarKeyHelpId() { }

	// RVA: 0x2235C20 Offset: 0x2235D21 VA: 0x2235C20 Slot: 23
	protected override void CreateMenuBind(ProcInst super) { }

	// RVA: 0x2235CF0 Offset: 0x2235DF1 VA: 0x2235CF0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2235D80 Offset: 0x2235E81 VA: 0x2235D80
	public void .ctor() { }
}

// Namespace: 
private class MainMenuSequence.FinalConfirmDialog.YesDialogItem : BasicDialogItemYes // TypeDefIndex: 13097
{
	// Methods

	// RVA: 0x1DD27E0 Offset: 0x1DD28E1 VA: 0x1DD27E0
	public void .ctor() { }

	// RVA: 0x1DD2870 Offset: 0x1DD2971 VA: 0x1DD2870 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1DD28F0 Offset: 0x1DD29F1 VA: 0x1DD28F0 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
private class MainMenuSequence.FinalConfirmDialog.NoDialogItem : BasicDialogItemNo // TypeDefIndex: 13098
{
	// Methods

	// RVA: 0x1DD25F0 Offset: 0x1DD26F1 VA: 0x1DD25F0
	public void .ctor() { }

	// RVA: 0x1DD2680 Offset: 0x1DD2781 VA: 0x1DD2680 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1DD2730 Offset: 0x1DD2831 VA: 0x1DD2730 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
private class MainMenuSequence.FinalConfirmDialog : YesNoDialog // TypeDefIndex: 13099
{
	// Methods

	// RVA: 0x22332C0 Offset: 0x22333C1 VA: 0x22332C0
	private void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent dialogContent) { }

	// RVA: 0x22332D0 Offset: 0x22333D1 VA: 0x22332D0
	public static void CreateBind(ProcInst super) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278A30 Offset: 0x278B31 VA: 0x278A30
private sealed class MainMenuSequence.<>c__DisplayClass67_0 // TypeDefIndex: 13100
{
	// Fields
	public MainMenuSequence.CharacterWork characterWork; // 0x10
	public Character character; // 0x18

	// Methods

	// RVA: 0x2231EB0 Offset: 0x2231FB1 VA: 0x2231EB0
	public void .ctor() { }

	// RVA: 0x2231EC0 Offset: 0x2231FC1 VA: 0x2231EC0
	internal void <CreateCharacter>b__0() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278A40 Offset: 0x278B41 VA: 0x278A40
[Serializable]
private sealed class MainMenuSequence.<>c // TypeDefIndex: 13101
{
	// Fields
	public static readonly MainMenuSequence.<>c <>9; // 0x0
	public static Action <>9__73_0; // 0x8
	public static Action <>9__73_1; // 0x10

	// Methods

	// RVA: 0x2231CF0 Offset: 0x2231DF1 VA: 0x2231CF0
	private static void .cctor() { }

	// RVA: 0x2231D60 Offset: 0x2231E61 VA: 0x2231D60
	public void .ctor() { }

	// RVA: 0x2231D70 Offset: 0x2231E71 VA: 0x2231D70
	internal void <InitCameraZoomInToPlayer>b__73_0() { }

	// RVA: 0x2231E20 Offset: 0x2231F21 VA: 0x2231E20
	internal void <InitCameraZoomInToPlayer>b__73_1() { }
}

