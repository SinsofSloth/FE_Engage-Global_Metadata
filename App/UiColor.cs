// Namespace: App
public class UiColor : SingletonScriptableObject<UiColor> // TypeDefIndex: 8908
{
	// Fields
	[HeaderAttribute] // RVA: 0x284FA0 Offset: 0x2850A1 VA: 0x284FA0
	public Color 紋章士アイコン_出撃; // 0x18
	public Color 紋章士アイコン_非出撃; // 0x28
	public Color ユニット選択_ユニット顔絵_出撃; // 0x38
	public Color ユニット選択_ユニット顔絵_非出撃; // 0x48

	// Methods

	// RVA: 0x257E3F0 Offset: 0x257E4F1 VA: 0x257E3F0
	public Color GetFaceColor(bool bOn) { }

	// RVA: 0x257E440 Offset: 0x257E541 VA: 0x257E440
	public Color GetSymbolColor(bool bOn) { }

	// RVA: 0x257E490 Offset: 0x257E591 VA: 0x257E490
	public void .ctor() { }
}

