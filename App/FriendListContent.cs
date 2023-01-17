// Namespace: App
public class FriendListContent : MonoBehaviour // TypeDefIndex: 13422
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29BEF0 Offset: 0x29BFF1 VA: 0x29BEF0
	private bool <IsInitialized>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x29BF00 Offset: 0x29C001 VA: 0x29BF00
	private bool <IsPageChanging>k__BackingField; // 0x19
	private FriendListContent.FriendContent[] m_FriendContentArray; // 0x20
	private int m_ActiveFriendContentIndex; // 0x28
	private Animator[] m_IndexAnimatorArray; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x29BF10 Offset: 0x29C011 VA: 0x29BF10
	private bool <IsShowArrow>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x29BF20 Offset: 0x29C021 VA: 0x29BF20
	private bool <IsCharaChange>k__BackingField; // 0x39
	[CompilerGeneratedAttribute] // RVA: 0x29BF30 Offset: 0x29C031 VA: 0x29BF30
	private bool <IsCountryChange>k__BackingField; // 0x3A

	// Properties
	public bool IsInitialized { get; set; }
	public bool IsPageChanging { get; set; }
	private bool IsShowArrow { get; set; }
	public bool IsCharaChange { get; set; }
	public bool IsCountryChange { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB8A0 Offset: 0x2CB9A1 VA: 0x2CB8A0
	// RVA: 0x2A093E0 Offset: 0x2A094E1 VA: 0x2A093E0
	private void set_IsInitialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB8B0 Offset: 0x2CB9B1 VA: 0x2CB8B0
	// RVA: 0x2A093F0 Offset: 0x2A094F1 VA: 0x2A093F0
	public bool get_IsInitialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB8C0 Offset: 0x2CB9C1 VA: 0x2CB8C0
	// RVA: 0x2A09400 Offset: 0x2A09501 VA: 0x2A09400
	private void set_IsPageChanging(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB8D0 Offset: 0x2CB9D1 VA: 0x2CB8D0
	// RVA: 0x2A09410 Offset: 0x2A09511 VA: 0x2A09410
	public bool get_IsPageChanging() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB8E0 Offset: 0x2CB9E1 VA: 0x2CB8E0
	// RVA: 0x2A09420 Offset: 0x2A09521 VA: 0x2A09420
	private void set_IsShowArrow(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB8F0 Offset: 0x2CB9F1 VA: 0x2CB8F0
	// RVA: 0x2A09430 Offset: 0x2A09531 VA: 0x2A09430
	private bool get_IsShowArrow() { }

	// RVA: 0x2A09440 Offset: 0x2A09541 VA: 0x2A09440
	private void Start() { }

	// RVA: 0x2A09960 Offset: 0x2A09A61 VA: 0x2A09960
	private void Update() { }

	// RVA: 0x2A099C0 Offset: 0x2A09AC1 VA: 0x2A099C0
	private void SetFriendDataCore(FriendListData friendData, Sprite charaImageSprite, Sprite stampSprite) { }

	// RVA: 0x2A09D10 Offset: 0x2A09E11 VA: 0x2A09D10
	public void InitCountryTag(List<FriendListData> dataArray) { }

	// RVA: 0x2A09FF0 Offset: 0x2A0A0F1 VA: 0x2A09FF0
	public void SetFriendDataAtFirst(FriendListData friendData, Sprite charaImageSprite, Sprite stampSprite) { }

	// RVA: 0x2A0A100 Offset: 0x2A0A201 VA: 0x2A0A100
	public void SetFriendData(FriendListData friendData, Sprite charaImageSprite, Sprite stampSprite) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB900 Offset: 0x2CBA01 VA: 0x2CB900
	// RVA: 0x2A0A280 Offset: 0x2A0A381 VA: 0x2A0A280
	public bool get_IsCharaChange() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB910 Offset: 0x2CBA11 VA: 0x2CB910
	// RVA: 0x2A0A290 Offset: 0x2A0A391 VA: 0x2A0A290
	public void set_IsCharaChange(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB920 Offset: 0x2CBA21 VA: 0x2CB920
	// RVA: 0x2A0A2A0 Offset: 0x2A0A3A1 VA: 0x2A0A2A0
	public bool get_IsCountryChange() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB930 Offset: 0x2CBA31 VA: 0x2CB930
	// RVA: 0x2A0A2B0 Offset: 0x2A0A3B1 VA: 0x2A0A2B0
	public void set_IsCountryChange(bool value) { }

	// RVA: 0x2A09F10 Offset: 0x2A0A011 VA: 0x2A09F10
	public void HideArrow() { }

	// RVA: 0x2A0A2C0 Offset: 0x2A0A3C1 VA: 0x2A0A2C0
	public void ShowArrow() { }

	// RVA: 0x2A0A3B0 Offset: 0x2A0A4B1 VA: 0x2A0A3B0
	public void .ctor() { }
}

