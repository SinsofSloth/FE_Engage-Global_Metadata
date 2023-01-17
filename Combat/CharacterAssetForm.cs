// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273CC0 Offset: 0x273DC1 VA: 0x273CC0
[DefaultMemberAttribute] // RVA: 0x273CC0 Offset: 0x273DC1 VA: 0x273CC0
public abstract class CharacterAssetForm : MonoBehaviour // TypeDefIndex: 8589
{
	// Fields
	[HideInInspector] // RVA: 0x282240 Offset: 0x282341 VA: 0x282240
	public CharacterAppearance Appearance; // 0x18
	private bool m_bSelfAppearance; // 0x20
	[HideInInspector] // RVA: 0x282250 Offset: 0x282351 VA: 0x282250
	public int ViewerPresetIndex; // 0x24
	[HideInInspector] // RVA: 0x282260 Offset: 0x282361 VA: 0x282260
	public int ViewerPersonIndex; // 0x28
	[HideInInspector] // RVA: 0x282270 Offset: 0x282371 VA: 0x282270
	public int ViewerJobIndex; // 0x2C
	[HideInInspector] // RVA: 0x282280 Offset: 0x282381 VA: 0x282280
	public int ViewerWeaponIndex; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x282290 Offset: 0x282391 VA: 0x282290
	private bool <InitialInvisibility>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x2822A0 Offset: 0x2823A1 VA: 0x2822A0
	private bool <IsDone>k__BackingField; // 0x35
	protected bool isBuilding_WatchFromCharacterAssetForm; // 0x36

	// Properties
	public CharacterAsset Item { get; }
	public CharacterAsset Item { get; }
	public bool InitialInvisibility { get; set; }
	public bool IsDone { get; set; }

	// Methods

	// RVA: 0x2B69570 Offset: 0x2B69671 VA: 0x2B69570
	public CharacterAsset get_Item(int index) { }

	// RVA: 0x2B69580 Offset: 0x2B69681 VA: 0x2B69580
	public CharacterAsset get_Item(AssetType type) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA370 Offset: 0x2AA471 VA: 0x2AA370
	// RVA: 0x2B69590 Offset: 0x2B69691 VA: 0x2B69590
	public bool get_InitialInvisibility() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA380 Offset: 0x2AA481 VA: 0x2AA380
	// RVA: 0x2B695A0 Offset: 0x2B696A1 VA: 0x2B695A0
	private void set_InitialInvisibility(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA390 Offset: 0x2AA491 VA: 0x2AA390
	// RVA: 0x2B695B0 Offset: 0x2B696B1 VA: 0x2B695B0
	public bool get_IsDone() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA3A0 Offset: 0x2AA4A1 VA: 0x2AA3A0
	// RVA: 0x2B695C0 Offset: 0x2B696C1 VA: 0x2B695C0
	private void set_IsDone(bool value) { }

	// RVA: 0x2B695D0 Offset: 0x2B696D1 VA: 0x2B695D0
	public void Build(CharacterAppearance appearance, bool invisible = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x2AA3B0 Offset: 0x2AA4B1 VA: 0x2AA3B0
	// RVA: 0x2B69720 Offset: 0x2B69821 VA: 0x2B69720
	public IEnumerator BuildForTest() { }

	[IteratorStateMachineAttribute] // RVA: 0x2AA420 Offset: 0x2AA521 VA: 0x2AA420
	// RVA: 0x2B697A0 Offset: 0x2B698A1 VA: 0x2B697A0
	private IEnumerator BuildCoroutine() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void BuildHierarchy();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract IEnumerator CoBuildHierarchy();

	// RVA: 0x2B69820 Offset: 0x2B69921 VA: 0x2B69820
	public void BeginContentsChange() { }

	// RVA: 0x2B69830 Offset: 0x2B69931 VA: 0x2B69830
	public void EndContentsChange() { }

	// RVA: 0x2B69840 Offset: 0x2B69941 VA: 0x2B69840 Slot: 6
	public virtual void SetViaTableResult(AssetTable.Result r) { }

	// RVA: 0x2B698E0 Offset: 0x2B699E1 VA: 0x2B698E0 Slot: 7
	public virtual void UnloadD(Transform chr) { }

	// RVA: 0x2B69A60 Offset: 0x2B69B61 VA: 0x2B69A60
	protected static void Attach(GameObject me, Transform parent) { }

	// RVA: 0x2B69B50 Offset: 0x2B69C51 VA: 0x2B69B50
	public void Attach(GameObject me, string parent) { }

	// RVA: 0x2B69CC0 Offset: 0x2B69DC1 VA: 0x2B69CC0
	public Transform FindInChildren(string parent) { }

	[IteratorStateMachineAttribute] // RVA: 0x2AA490 Offset: 0x2AA591 VA: 0x2AA490
	// RVA: 0x2B69D50 Offset: 0x2B69E51 VA: 0x2B69D50
	public IEnumerable<CharacterAsset> GetAccessories() { }

	// RVA: 0x2B69DD0 Offset: 0x2B69ED1 VA: 0x2B69DD0
	private void OnDestroy() { }

	// RVA: 0x2B698D0 Offset: 0x2B699D1 VA: 0x2B698D0
	public static void LoadDatabase() { }

	// RVA: 0x2B69DF0 Offset: 0x2B69EF1 VA: 0x2B69DF0
	protected void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AA500 Offset: 0x2AA601 VA: 0x2AA500
	// RVA: 0x2B69E70 Offset: 0x2B69F71 VA: 0x2B69E70
	private IEnumerator <Build>b__18_0() { }
}

