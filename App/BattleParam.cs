// Namespace: App
public class BattleParam // TypeDefIndex: 9516
{
	// Fields
	public static float INVALID; // 0x0
	private static float[] Mins; // 0x8
	private static float[] Maxs; // 0x10
	private static float[] Clamps; // 0x18
	public float Add; // 0x10
	public float Scale; // 0x14
	public float Value; // 0x18

	// Properties
	protected virtual BattleParam.Kinds Kind { get; }
	protected virtual string Name { get; }

	// Methods

	// RVA: 0x225B7D0 Offset: 0x225B8D1 VA: 0x225B7D0 Slot: 4
	protected virtual BattleParam.Kinds get_Kind() { }

	// RVA: 0x225B7E0 Offset: 0x225B8E1 VA: 0x225B7E0 Slot: 5
	protected virtual string get_Name() { }

	// RVA: 0x225B830 Offset: 0x225B931 VA: 0x225B830
	public float GetResult(BattleInfoSide side) { }

	// RVA: 0x225B960 Offset: 0x225BA61 VA: 0x225B960 Slot: 6
	public virtual float Calculate(BattleInfoSide side) { }

	// RVA: 0x225B970 Offset: 0x225BA71 VA: 0x225B970
	public void .ctor() { }

	// RVA: 0x225BA10 Offset: 0x225BB11 VA: 0x225BA10
	public void .ctor(BattleParam src) { }

	// RVA: 0x225BAC0 Offset: 0x225BBC1 VA: 0x225BAC0
	public void Clear() { }

	// RVA: 0x225BB40 Offset: 0x225BC41 VA: 0x225BB40
	public void Copy(BattleParam src) { }

	// RVA: 0x225BB60 Offset: 0x225BC61 VA: 0x225BB60
	private static void .cctor() { }
}

