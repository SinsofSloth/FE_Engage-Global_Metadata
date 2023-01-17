// Namespace: Combat
internal sealed class ActionWaitFunc : ActionBase // TypeDefIndex: 8428
{
	// Fields
	private Func<Character, bool> m_Func; // 0x28

	// Properties
	public override string Name { get; }

	// Methods

	// RVA: 0x2EC9D00 Offset: 0x2EC9E01 VA: 0x2EC9D00 Slot: 5
	public override string get_Name() { }

	// RVA: 0x2EC9D50 Offset: 0x2EC9E51 VA: 0x2EC9D50
	public void .ctor(Character chr, Func<Character, bool> waitFunc_whileTrue) { }

	// RVA: 0x2EC9DB0 Offset: 0x2EC9EB1 VA: 0x2EC9DB0 Slot: 6
	public override void OnEnter() { }

	// RVA: 0x2EC9E20 Offset: 0x2EC9F21 VA: 0x2EC9E20 Slot: 7
	public override void OnUpdate() { }
}

