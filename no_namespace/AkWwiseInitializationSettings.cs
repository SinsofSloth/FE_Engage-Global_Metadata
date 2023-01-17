// Namespace: 
public abstract class AkWwiseInitializationSettings.PlatformSettings : AkCommonPlatformSettings // TypeDefIndex: 7958
{
	// Fields
	[HideInInspector] // RVA: 0x27E460 Offset: 0x27E561 VA: 0x27E460
	[SerializeField] // RVA: 0x27E460 Offset: 0x27E561 VA: 0x27E460
	private List<string> IgnorePropertyNameList; // 0x18
	[HideInInspector] // RVA: 0x27E4A0 Offset: 0x27E5A1 VA: 0x27E4A0
	[SerializeField] // RVA: 0x27E4A0 Offset: 0x27E5A1 VA: 0x27E4A0
	private List<string> GlobalPropertyNameList; // 0x20
	private HashSet<string> _GlobalPropertyHashSet; // 0x28

	// Properties
	public HashSet<string> GlobalPropertyHashSet { get; set; }

	// Methods

	// RVA: 0x1F5BFE0 Offset: 0x1F5C0E1 VA: 0x1F5BFE0
	public void IgnorePropertyValue(string propertyPath) { }

	// RVA: 0x1F5C110 Offset: 0x1F5C211 VA: 0x1F5C110
	public bool IsPropertyIgnored(string propertyPath) { }

	// RVA: 0x1F5BEE0 Offset: 0x1F5BFE1 VA: 0x1F5BEE0
	protected void .ctor() { }

	// RVA: 0x1F5C170 Offset: 0x1F5C271 VA: 0x1F5C170
	public void SetUseGlobalPropertyValue(string propertyPath, bool use) { }

	// RVA: 0x1F5C270 Offset: 0x1F5C371 VA: 0x1F5C270
	public void SetGlobalPropertyValues(IEnumerable enumerable) { }

	// RVA: 0x1F5C5A0 Offset: 0x1F5C6A1 VA: 0x1F5C5A0
	private bool IsUsingGlobalPropertyValue(string propertyPath) { }

	// RVA: 0x1F5C600 Offset: 0x1F5C701 VA: 0x1F5C600
	public HashSet<string> get_GlobalPropertyHashSet() { }

	// RVA: 0x1F5C6C0 Offset: 0x1F5C7C1 VA: 0x1F5C6C0
	public void set_GlobalPropertyHashSet(HashSet<string> value) { }
}

// Namespace: 
public class AkWwiseInitializationSettings.CommonPlatformSettings : AkWwiseInitializationSettings.PlatformSettings // TypeDefIndex: 7959
{
	// Fields
	[HideInInspector] // RVA: 0x27E4E0 Offset: 0x27E5E1 VA: 0x27E4E0
	public AkCommonUserSettings UserSettings; // 0x30
	[HideInInspector] // RVA: 0x27E4F0 Offset: 0x27E5F1 VA: 0x27E4F0
	public AkCommonAdvancedSettings AdvancedSettings; // 0x38
	[HideInInspector] // RVA: 0x27E500 Offset: 0x27E601 VA: 0x27E500
	public AkCommonCommSettings CommsSettings; // 0x40

	// Methods

	// RVA: 0x1F5BEA0 Offset: 0x1F5BFA1 VA: 0x1F5BEA0 Slot: 13
	protected override AkCommonUserSettings GetUserSettings() { }

	// RVA: 0x1F5BEB0 Offset: 0x1F5BFB1 VA: 0x1F5BEB0 Slot: 14
	protected override AkCommonAdvancedSettings GetAdvancedSettings() { }

	// RVA: 0x1F5BEC0 Offset: 0x1F5BFC1 VA: 0x1F5BEC0 Slot: 15
	protected override AkCommonCommSettings GetCommsSettings() { }

	// RVA: 0x1F5BED0 Offset: 0x1F5BFD1 VA: 0x1F5BED0
	public void .ctor() { }
}

// Namespace: 
public class AkWwiseInitializationSettings : AkCommonPlatformSettings // TypeDefIndex: 7960
{
	// Fields
	[HideInInspector] // RVA: 0x27E400 Offset: 0x27E501 VA: 0x27E400
	public List<string> PlatformSettingsNameList; // 0x18
	[HideInInspector] // RVA: 0x27E410 Offset: 0x27E511 VA: 0x27E410
	public List<AkWwiseInitializationSettings.PlatformSettings> PlatformSettingsList; // 0x20
	[HideInInspector] // RVA: 0x27E420 Offset: 0x27E521 VA: 0x27E420
	public List<string> InvalidReferencePlatforms; // 0x28
	[HideInInspector] // RVA: 0x27E430 Offset: 0x27E531 VA: 0x27E430
	public AkCommonUserSettings UserSettings; // 0x30
	[HideInInspector] // RVA: 0x27E440 Offset: 0x27E541 VA: 0x27E440
	public AkCommonAdvancedSettings AdvancedSettings; // 0x38
	[HideInInspector] // RVA: 0x27E450 Offset: 0x27E551 VA: 0x27E450
	public AkCommonCommSettings CommsSettings; // 0x40
	private static readonly string[] AllGlobalValues; // 0x0
	private static AkWwiseInitializationSettings m_Instance; // 0x8
	private static AkBasePlatformSettings m_ActivePlatformSettings; // 0x10

	// Properties
	public bool IsValid { get; }
	public int Count { get; }
	public static AkWwiseInitializationSettings Instance { get; }
	public static AkBasePlatformSettings ActivePlatformSettings { get; }

	// Methods

	// RVA: 0x20E04D0 Offset: 0x20E05D1 VA: 0x20E04D0
	public bool get_IsValid() { }

	// RVA: 0x20E0530 Offset: 0x20E0631 VA: 0x20E0530
	public int get_Count() { }

	// RVA: 0x20E0580 Offset: 0x20E0681 VA: 0x20E0580 Slot: 13
	protected override AkCommonUserSettings GetUserSettings() { }

	// RVA: 0x20E0590 Offset: 0x20E0691 VA: 0x20E0590 Slot: 14
	protected override AkCommonAdvancedSettings GetAdvancedSettings() { }

	// RVA: 0x20E05A0 Offset: 0x20E06A1 VA: 0x20E05A0 Slot: 15
	protected override AkCommonCommSettings GetCommsSettings() { }

	// RVA: 0x20E05B0 Offset: 0x20E06B1 VA: 0x20E05B0
	public static AkWwiseInitializationSettings get_Instance() { }

	// RVA: 0x20E0720 Offset: 0x20E0821 VA: 0x20E0720
	private static AkBasePlatformSettings GetPlatformSettings(string platformName) { }

	// RVA: 0x20D20E0 Offset: 0x20D21E1 VA: 0x20D20E0
	public static AkBasePlatformSettings get_ActivePlatformSettings() { }

	// RVA: 0x20E0970 Offset: 0x20E0A71 VA: 0x20E0970
	private void OnEnable() { }

	// RVA: 0x20D1060 Offset: 0x20D1161 VA: 0x20D1060
	public static bool InitializeSoundEngine() { }

	// RVA: 0x20E0B00 Offset: 0x20E0C01 VA: 0x20E0B00
	public static bool ResetSoundEngine(bool isPlaying) { }

	// RVA: 0x20D1AE0 Offset: 0x20D1BE1 VA: 0x20D1AE0
	public static void TerminateSoundEngine() { }

	// RVA: 0x20E0C60 Offset: 0x20E0D61 VA: 0x20E0C60
	private static void SleepForMilliseconds(double milliseconds) { }

	// RVA: 0x20E0E00 Offset: 0x20E0F01 VA: 0x20E0E00
	public void .ctor() { }

	// RVA: 0x20E0F10 Offset: 0x20E1011 VA: 0x20E0F10
	private static void .cctor() { }
}

