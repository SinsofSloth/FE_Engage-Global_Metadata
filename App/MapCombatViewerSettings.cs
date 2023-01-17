// Namespace: App
[Serializable]
public class MapCombatViewerSettings : ScriptableObject // TypeDefIndex: 11914
{
	// Fields
	public string FieldName; // 0x18
	public CharacterIdSet[] Characters; // 0x20
	public bool RandomPosition; // 0x28
	public bool RandomCharacter; // 0x29
	public bool PlayerAttack; // 0x2A
	public bool EternalCombat; // 0x2B
	public bool RepeatCombat; // 0x2C
	public bool CharaSelectRandomly; // 0x2D
	public int SortiePreset; // 0x30
	public int BattlePreset; // 0x34
	public uint CombatSeed; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x299A10 Offset: 0x299B11 VA: 0x299A10
	private bool <NeedRefresh>k__BackingField; // 0x3C
	public static readonly int ChainAttackCount; // 0x0
	public static readonly int ChainGuardCount; // 0x4
	public static readonly string[] Id2Name; // 0x8
	public static readonly string[] SortiePresets; // 0x10
	public static readonly string[] BattlePresets; // 0x18

	// Properties
	public bool NeedRefresh { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C7120 Offset: 0x2C7221 VA: 0x2C7120
	// RVA: 0x2C95CB0 Offset: 0x2C95DB1 VA: 0x2C95CB0
	public bool get_NeedRefresh() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7130 Offset: 0x2C7231 VA: 0x2C7130
	// RVA: 0x2C95CC0 Offset: 0x2C95DC1 VA: 0x2C95CC0
	public void set_NeedRefresh(bool value) { }

	// RVA: 0x2C95CD0 Offset: 0x2C95DD1 VA: 0x2C95CD0
	public void Initialize() { }

	// RVA: 0x2C974B0 Offset: 0x2C975B1 VA: 0x2C974B0
	public int GetHash() { }

	// RVA: 0x2C975B0 Offset: 0x2C976B1 VA: 0x2C975B0
	public void Validate() { }

	// RVA: 0x2C95EA0 Offset: 0x2C95FA1 VA: 0x2C95EA0
	public void LoadSortiePreset(int presetId) { }

	// RVA: 0x2C974A0 Offset: 0x2C975A1 VA: 0x2C974A0
	public void LoadBattlePreset(int presetId) { }

	// RVA: 0x2C977A0 Offset: 0x2C978A1 VA: 0x2C977A0
	public void LoadBattlePreset(CombatRecord record) { }

	// RVA: 0x2C97C10 Offset: 0x2C97D11 VA: 0x2C97C10
	public void SetCharacterRandom() { }

	// RVA: 0x2C97DD0 Offset: 0x2C97ED1 VA: 0x2C97DD0
	private void SettingRandamCharacter(int side) { }

	// RVA: 0x2C98210 Offset: 0x2C98311 VA: 0x2C98210
	public void SetCharacterParamRandom() { }

	// RVA: 0x2C98380 Offset: 0x2C98481 VA: 0x2C98380
	public void .ctor() { }

	// RVA: 0x2C98390 Offset: 0x2C98491 VA: 0x2C98390
	private static void .cctor() { }
}

