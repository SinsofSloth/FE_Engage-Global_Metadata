// Namespace: App
[ExtensionAttribute] // RVA: 0x2766F0 Offset: 0x2767F1 VA: 0x2766F0
public static class DataTypesExtension // TypeDefIndex: 10117
{
	// Fields
	private static readonly string[] DifficultyMidTable; // 0x0
	private static readonly string[] GameModeMidTable; // 0x8
	private static readonly string[] GrowModeMidTable; // 0x10
	private static readonly string[] DifficultyLabelTable; // 0x18
	private static readonly string[] GameModeLabelTable; // 0x20

	// Methods

	[ExtensionAttribute] // RVA: 0x2BD250 Offset: 0x2BD351 VA: 0x2BD250
	// RVA: 0x2E96E90 Offset: 0x2E96F91 VA: 0x2E96E90
	public static string GetName(Difficulty difficulty) { }

	[ExtensionAttribute] // RVA: 0x2BD260 Offset: 0x2BD361 VA: 0x2BD260
	// RVA: 0x2E96F60 Offset: 0x2E97061 VA: 0x2E96F60
	public static string GetName(GameMode gameMode) { }

	[ExtensionAttribute] // RVA: 0x2BD270 Offset: 0x2BD371 VA: 0x2BD270
	// RVA: 0x2E97030 Offset: 0x2E97131 VA: 0x2E97030
	public static string GetName(GrowMode growMode) { }

	[ExtensionAttribute] // RVA: 0x2BD280 Offset: 0x2BD381 VA: 0x2BD280
	// RVA: 0x2E97100 Offset: 0x2E97201 VA: 0x2E97100
	public static string GetName(Gender gender) { }

	[ExtensionAttribute] // RVA: 0x2BD290 Offset: 0x2BD391 VA: 0x2BD290
	// RVA: 0x2E97180 Offset: 0x2E97281 VA: 0x2E97180
	public static string GetLabel(Difficulty difficulty) { }

	[ExtensionAttribute] // RVA: 0x2BD2A0 Offset: 0x2BD3A1 VA: 0x2BD2A0
	// RVA: 0x2E97210 Offset: 0x2E97311 VA: 0x2E97210
	public static string GetLabel(GameMode gameMode) { }

	[ExtensionAttribute] // RVA: 0x2BD2B0 Offset: 0x2BD3B1 VA: 0x2BD2B0
	// RVA: 0x2E972A0 Offset: 0x2E973A1 VA: 0x2E972A0
	public static bool IsNullOrEmpty(Unit unit) { }

	[ExtensionAttribute] // RVA: 0x2BD2C0 Offset: 0x2BD3C1 VA: 0x2BD2C0
	// RVA: 0x2E972C0 Offset: 0x2E973C1 VA: 0x2E972C0
	public static bool IsNullOrEmpty(string str) { }

	[ExtensionAttribute] // RVA: 0x2BD2D0 Offset: 0x2BD3D1 VA: 0x2BD2D0
	// RVA: -1 Offset: -1
	public static T TryGetComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229E0B0 Offset: 0x229E1B1 VA: 0x229E0B0
	|-DataTypesExtension.TryGetComponent<Animator>
	|-DataTypesExtension.TryGetComponent<BasicMenuItemContent>
	|-DataTypesExtension.TryGetComponent<HubAccess>
	|-DataTypesExtension.TryGetComponent<HubAccessHelp>
	|-DataTypesExtension.TryGetComponent<HubCullingPlayerCollider>
	|-DataTypesExtension.TryGetComponent<HubPlayerCollider>
	|-DataTypesExtension.TryGetComponent<Image>
	|-DataTypesExtension.TryGetComponent<object>
	|-DataTypesExtension.TryGetComponent<RectTransform>
	|-DataTypesExtension.TryGetComponent<ShopTopMenuContent>
	|-DataTypesExtension.TryGetComponent<SphereCollider>
	|-DataTypesExtension.TryGetComponent<Text>
	|-DataTypesExtension.TryGetComponent<TextMeshProUGUI>
	|-DataTypesExtension.TryGetComponent<UnitIcon>
	|-DataTypesExtension.TryGetComponent<VerticalLayoutGroup>
	*/

	[ExtensionAttribute] // RVA: 0x2BD2E0 Offset: 0x2BD3E1 VA: 0x2BD2E0
	// RVA: -1 Offset: -1
	public static T TryGetComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229DFF0 Offset: 0x229E0F1 VA: 0x229DFF0
	|-DataTypesExtension.TryGetComponent<BasicMenuItemContent>
	|-DataTypesExtension.TryGetComponent<HubAccess>
	|-DataTypesExtension.TryGetComponent<object>
	|-DataTypesExtension.TryGetComponent<RectTransform>
	|-DataTypesExtension.TryGetComponent<Text>
	|-DataTypesExtension.TryGetComponent<TextMeshProUGUI>
	*/

	// RVA: 0x2E972D0 Offset: 0x2E973D1 VA: 0x2E972D0
	private static void .cctor() { }
}

