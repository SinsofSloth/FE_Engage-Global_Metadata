// Namespace: 
public enum Dish.Liking // TypeDefIndex: 13516
{
	// Fields
	public int value__; // 0x0
	public const Dish.Liking None = -1;
	public const Dish.Liking OK = 0;
	public const Dish.Liking Like = 1;
	public const Dish.Liking Dislike = 2;
}

// Namespace: 
public enum Dish.RelianceResult.TryResult // TypeDefIndex: 13517
{
	// Fields
	public int value__; // 0x0
	public const Dish.RelianceResult.TryResult None = -1;
	public const Dish.RelianceResult.TryResult Success = 0;
	public const Dish.RelianceResult.TryResult Faileur = 1;
	public const Dish.RelianceResult.TryResult NotExists = 2;
}

// Namespace: 
public struct Dish.RelianceResult // TypeDefIndex: 13518
{
	// Fields
	public int Hero_UnitA; // 0x0
	public int Hero_UnitB; // 0x4
	public int UnitA_UnitB; // 0x8
	public Dish.RelianceResult.TryResult Hero_UnitA_Result; // 0xC
	public Dish.RelianceResult.TryResult Hero_UnitB_Result; // 0x10
	public Dish.RelianceResult.TryResult UnitA_UnitB_Result; // 0x14
	public Unit Hero; // 0x18
	public Unit UnitA; // 0x20
	public Unit UnitB; // 0x28
}

