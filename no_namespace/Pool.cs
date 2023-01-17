// Namespace: 
public abstract class Pool.Node // TypeDefIndex: 9203
{
	// Properties
	public virtual int SortKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnEnter();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnExit();

	// RVA: 0x1F203F0 Offset: 0x1F204F1 VA: 0x1F203F0 Slot: 6
	public virtual int get_SortKey() { }

	// RVA: 0x1F20400 Offset: 0x1F20501 VA: 0x1F20400
	protected void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275270 Offset: 0x275371 VA: 0x275270
[Serializable]
private sealed class Pool.List.<>c<T> // TypeDefIndex: 9204
{
	// Fields
	public static readonly Pool.List.<>c<T> <>9; // 0x0
	public static Comparison<T> <>9__10_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B33D00 Offset: 0x2B33E01 VA: 0x2B33D00
	|-Pool.List.<>c<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B33DE0 Offset: 0x2B33EE1 VA: 0x2B33DE0
	|-Pool.List.<>c<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int <Sort>b__10_0(T a, T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B33DF0 Offset: 0x2B33EF1 VA: 0x2B33DF0
	|-Pool.List.<>c<object>.<Sort>b__10_0
	*/
}

// Namespace: 
[DefaultMemberAttribute] // RVA: 0x275230 Offset: 0x275331 VA: 0x275230
public class Pool.List<T> // TypeDefIndex: 9205
{
	// Fields
	private List<T> m_List; // 0x0
	private Stack<T> m_Pool; // 0x0

	// Properties
	public int Count { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09B70 Offset: 0x3B09C71 VA: 0x3B09B70
	|-Pool.List<BattleScene>..ctor
	|-Pool.List<GodBond>..ctor
	|-Pool.List<object>..ctor
	|-Pool.List<BattleCalculator.HitSkill>..ctor
	|-Pool.List<BattleCalculator.Order>..ctor
	|-Pool.List<MapEffect.LocationNode>..ctor
	|-Pool.List<MapHistory.Rewind.OverlapData>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09C90 Offset: 0x3B09D91 VA: 0x3B09C90
	|-Pool.List<BattleScene>.get_Count
	|-Pool.List<object>.get_Count
	|-Pool.List<BattleCalculator.HitSkill>.get_Count
	|-Pool.List<BattleCalculator.Order>.get_Count
	|-Pool.List<MapEffect.LocationNode>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09CB0 Offset: 0x3B09DB1 VA: 0x3B09CB0
	|-Pool.List<BattleScene>.get_Item
	|-Pool.List<object>.get_Item
	|-Pool.List<BattleCalculator.HitSkill>.get_Item
	|-Pool.List<BattleCalculator.Order>.get_Item
	|-Pool.List<MapEffect.LocationNode>.get_Item
	*/

	// RVA: -1 Offset: -1
	public T Get(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09CD0 Offset: 0x3B09DD1 VA: 0x3B09CD0
	|-Pool.List<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Swap(int indexA, int indexB) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09CF0 Offset: 0x3B09DF1 VA: 0x3B09CF0
	|-Pool.List<object>.Swap
	|-Pool.List<BattleCalculator.Order>.Swap
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public virtual T Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09E00 Offset: 0x3B09F01 VA: 0x3B09E00
	|-Pool.List<BattleScene>.Create
	|-Pool.List<object>.Create
	|-Pool.List<BattleCalculator.HitSkill>.Create
	|-Pool.List<BattleCalculator.Order>.Create
	|-Pool.List<MapEffect.LocationNode>.Create
	|-Pool.List<MapHistory.Rewind.OverlapData>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual void Delete(T p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09EA0 Offset: 0x3B09FA1 VA: 0x3B09EA0
	|-Pool.List<BattleScene>.Delete
	|-Pool.List<object>.Delete
	|-Pool.List<BattleCalculator.HitSkill>.Delete
	|-Pool.List<BattleCalculator.Order>.Delete
	|-Pool.List<MapEffect.LocationNode>.Delete
	|-Pool.List<MapHistory.Rewind.OverlapData>.Delete
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B09F40 Offset: 0x3B0A041 VA: 0x3B09F40
	|-Pool.List<BattleScene>.Clear
	|-Pool.List<object>.Clear
	|-Pool.List<BattleCalculator.HitSkill>.Clear
	|-Pool.List<BattleCalculator.Order>.Clear
	|-Pool.List<MapEffect.LocationNode>.Clear
	|-Pool.List<MapHistory.Rewind.OverlapData>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public virtual void Sort() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0A010 Offset: 0x3B0A111 VA: 0x3B0A010
	|-Pool.List<BattleScene>.Sort
	|-Pool.List<object>.Sort
	|-Pool.List<BattleCalculator.HitSkill>.Sort
	|-Pool.List<BattleCalculator.Order>.Sort
	|-Pool.List<MapEffect.LocationNode>.Sort
	|-Pool.List<MapHistory.Rewind.OverlapData>.Sort
	*/

	// RVA: -1 Offset: -1
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B0A1F0 Offset: 0x3B0A2F1 VA: 0x3B0A1F0
	|-Pool.List<BattleScene>.GetEnumerator
	|-Pool.List<object>.GetEnumerator
	*/
}

// Namespace: 
public class Pool.Stack<T> // TypeDefIndex: 9206
{
	// Fields
	private Stack<T> m_Pool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BB470 Offset: 0x36BB571 VA: 0x36BB470
	|-Pool.Stack<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public virtual T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BB540 Offset: 0x36BB641 VA: 0x36BB540
	|-Pool.Stack<object>.Pop
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual void Push(T p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BB590 Offset: 0x36BB691 VA: 0x36BB590
	|-Pool.Stack<object>.Push
	*/
}

// Namespace: 
public class Pool.LockStack<T> : Pool.Stack<T> // TypeDefIndex: 9207
{
	// Fields
	private object lockObject; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306AD10 Offset: 0x306AE11 VA: 0x306AD10
	|-Pool.LockStack<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306ADB0 Offset: 0x306AEB1 VA: 0x306ADB0
	|-Pool.LockStack<object>.Pop
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void Push(T p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x306AEA0 Offset: 0x306AFA1 VA: 0x306AEA0
	|-Pool.LockStack<object>.Push
	*/
}

// Namespace: 
public class Pool.Hierarchy<T> // TypeDefIndex: 9208
{
	// Fields
	private Stack<T> m_Pool; // 0x0
	private Stack<T> m_Used; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAEAD0 Offset: 0x1EAEBD1 VA: 0x1EAEAD0
	|-Pool.Hierarchy<BattleDetail>..ctor
	|-Pool.Hierarchy<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public virtual T Push() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAEC00 Offset: 0x1EAED01 VA: 0x1EAEC00
	|-Pool.Hierarchy<object>.Push
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAEC80 Offset: 0x1EAED81 VA: 0x1EAEC80
	|-Pool.Hierarchy<object>.Pop
	*/
}

