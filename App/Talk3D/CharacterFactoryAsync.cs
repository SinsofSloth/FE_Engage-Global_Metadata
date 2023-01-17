// Namespace: App.Talk3D
internal class CharacterFactoryAsync // TypeDefIndex: 14118
{
	// Methods

	// RVA: 0x2B73180 Offset: 0x2B73281 VA: 0x2B73180
	public static Character CreateForTalk(string pid, string pidForCreate, GameObject locator, bool useTalkController = False) { }

	// RVA: 0x2B73650 Offset: 0x2B73751 VA: 0x2B73650
	public static Character CreateForTalk(Unit unit, GameObject locator, bool useTalkController = False) { }

	// RVA: 0x2B73780 Offset: 0x2B73881 VA: 0x2B73780
	public static Character CreateForTalk(GodUnit godUnit, GameObject locator, bool useTalkController = False) { }

	// RVA: 0x2B73850 Offset: 0x2B73951 VA: 0x2B73850
	public static Character CreateForUnitInfo(Unit unit, GameObject locator) { }

	// RVA: 0x2B738B0 Offset: 0x2B739B1 VA: 0x2B738B0
	public static Character CreateForUnitInfo(GodUnit god, GameObject locator) { }

	// RVA: 0x2B739E0 Offset: 0x2B73AE1 VA: 0x2B739E0
	public static Character CreateForUnitHub(Unit unit, GameObject locator) { }

	// RVA: 0x2B73A40 Offset: 0x2B73B41 VA: 0x2B73A40
	public static Character CreateForUnitRelay(GameObject locator, PersonData person, JobData job, UnitEdit edit) { }

	// RVA: 0x2B73A90 Offset: 0x2B73B91 VA: 0x2B73A90
	public static Character CreateForRingCleaning(Unit unit, GameObject locator) { }

	// RVA: 0x2B73AF0 Offset: 0x2B73BF1 VA: 0x2B73AF0
	public static Character CreateForRingCleaning(GodUnit godUnit, GameObject locator) { }

	// RVA: 0x2B732E0 Offset: 0x2B733E1 VA: 0x2B732E0
	private static Character CreateCommon(AssetTable.Result result, string pid, GameObject locator, bool useTalkController, bool invisible, bool isEngage) { }

	// RVA: 0x2B73C80 Offset: 0x2B73D81 VA: 0x2B73C80
	public static void SetupLookAt(Character chara, GameObject locator) { }

	// RVA: 0x2B74070 Offset: 0x2B74171 VA: 0x2B74070
	public static void Delete(GameObject locator) { }

	// RVA: 0x2B74210 Offset: 0x2B74311 VA: 0x2B74210
	public void .ctor() { }
}

