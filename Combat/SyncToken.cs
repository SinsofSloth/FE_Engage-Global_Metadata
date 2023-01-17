// Namespace: Combat
internal sealed class SyncToken // TypeDefIndex: 8439
{
	// Fields
	private SyncToken.State[] state; // 0x10

	// Methods

	// RVA: 0x292BB10 Offset: 0x292BC11 VA: 0x292BB10
	public void Join(Character chara) { }

	// RVA: 0x292BBE0 Offset: 0x292BCE1 VA: 0x292BBE0
	public void Join(int index) { }

	// RVA: 0x292BC20 Offset: 0x292BD21 VA: 0x292BC20
	public void Reach(Character chara) { }

	// RVA: 0x292BCA0 Offset: 0x292BDA1 VA: 0x292BCA0
	public bool IsArrivedEveryone() { }

	// RVA: 0x292BB90 Offset: 0x292BC91 VA: 0x292BB90
	private static int ChrToIndex(Character chara) { }

	// RVA: 0x292BDF0 Offset: 0x292BEF1 VA: 0x292BDF0
	private static Character IndexToChr(CombatWorld world, int i) { }

	// RVA: 0x292BF10 Offset: 0x292C011 VA: 0x292BF10
	public void .ctor() { }
}

