// Namespace: App
public class SingletonPool<P, T> : SingletonClass<P> // TypeDefIndex: 9224
{
	// Fields
	private const int OnlineInstanceID = 1000000;
	private List<T> m_List; // 0x0
	private List<T> m_Sort; // 0x0
	private LinkedList<T> m_Pool; // 0x0
	private LinkedList<T> m_Used; // 0x0
	private IComparer<T> m_Compare; // 0x0
	private Dictionary<int, T> m_Dictionary; // 0x0
	private Queue<int> m_InstanceIDs; // 0x0
	private bool m_IsOnline; // 0x0

	// Properties
	public static int Count { get; }
	protected static List<T> List { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343C340 Offset: 0x343C441 VA: 0x343C340
	|-SingletonPool<GodBondHolderPool, GodBondHolder>..ctor
	|-SingletonPool<GodPool, GodUnit>..ctor
	|-SingletonPool<object, object>..ctor
	|-SingletonPool<UnitRingPool, UnitRing>..ctor
	*/

	// RVA: -1 Offset: -1
	private T CreateImpl(int instanceID = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343C6A0 Offset: 0x343C7A1 VA: 0x343C6A0
	|-SingletonPool<object, object>.CreateImpl
	*/

	// RVA: -1 Offset: -1
	private void DeleteImpl(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343C810 Offset: 0x343C911 VA: 0x343C810
	|-SingletonPool<object, object>.DeleteImpl
	*/

	// RVA: -1 Offset: -1
	private void ClearImpl() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343C940 Offset: 0x343CA41 VA: 0x343C940
	|-SingletonPool<object, object>.ClearImpl
	*/

	// RVA: -1 Offset: -1
	public void ReassignInstanceIDForOnline() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343CAF0 Offset: 0x343CBF1 VA: 0x343CAF0
	|-SingletonPool<GodBondHolderPool, GodBondHolder>.ReassignInstanceIDForOnline
	|-SingletonPool<GodPool, GodUnit>.ReassignInstanceIDForOnline
	|-SingletonPool<object, object>.ReassignInstanceIDForOnline
	|-SingletonPool<UnitRingPool, UnitRing>.ReassignInstanceIDForOnline
	*/

	// RVA: -1 Offset: -1
	public void ResetInstanceID() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343CC90 Offset: 0x343CD91 VA: 0x343CC90
	|-SingletonPool<GodBondHolderPool, GodBondHolder>.ResetInstanceID
	|-SingletonPool<GodPool, GodUnit>.ResetInstanceID
	|-SingletonPool<object, object>.ResetInstanceID
	|-SingletonPool<UnitRingPool, UnitRing>.ResetInstanceID
	*/

	// RVA: -1 Offset: -1
	public static T Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343CDC0 Offset: 0x343CEC1 VA: 0x343CDC0
	|-SingletonPool<GodBondHolderPool, GodBondHolder>.Create
	|-SingletonPool<GodPool, GodUnit>.Create
	|-SingletonPool<object, object>.Create
	|-SingletonPool<UnitRingPool, UnitRing>.Create
	*/

	// RVA: -1 Offset: -1
	public static void Delete(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343D0C0 Offset: 0x343D1C1 VA: 0x343D0C0
	|-SingletonPool<GodBondHolderPool, GodBondHolder>.Delete
	|-SingletonPool<GodPool, GodUnit>.Delete
	|-SingletonPool<object, object>.Delete
	|-SingletonPool<UnitRingPool, UnitRing>.Delete
	*/

	// RVA: -1 Offset: -1
	public static void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343D3C0 Offset: 0x343D4C1 VA: 0x343D3C0
	|-SingletonPool<GodBondHolderPool, GodBondHolder>.Clear
	|-SingletonPool<GodPool, GodUnit>.Clear
	|-SingletonPool<object, object>.Clear
	|-SingletonPool<UnitRingPool, UnitRing>.Clear
	*/

	// RVA: -1 Offset: -1
	public static void SerializeForOnline(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343D6C0 Offset: 0x343D7C1 VA: 0x343D6C0
	|-SingletonPool<GodBondHolderPool, GodBondHolder>.SerializeForOnline
	|-SingletonPool<GodPool, GodUnit>.SerializeForOnline
	|-SingletonPool<object, object>.SerializeForOnline
	|-SingletonPool<UnitRingPool, UnitRing>.SerializeForOnline
	*/

	// RVA: -1 Offset: -1
	public static void DeserializeForOnline(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343DA10 Offset: 0x343DB11 VA: 0x343DA10
	|-SingletonPool<GodBondHolderPool, GodBondHolder>.DeserializeForOnline
	|-SingletonPool<GodPool, GodUnit>.DeserializeForOnline
	|-SingletonPool<object, object>.DeserializeForOnline
	|-SingletonPool<UnitRingPool, UnitRing>.DeserializeForOnline
	*/

	// RVA: -1 Offset: -1
	public static void SerializeSingle(Stream stream, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343DE50 Offset: 0x343DF51 VA: 0x343DE50
	|-SingletonPool<GodBondHolderPool, GodBondHolder>.SerializeSingle
	|-SingletonPool<GodPool, GodUnit>.SerializeSingle
	|-SingletonPool<object, object>.SerializeSingle
	|-SingletonPool<UnitRingPool, UnitRing>.SerializeSingle
	*/

	// RVA: -1 Offset: -1
	public static T DeserializeSingle(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343E190 Offset: 0x343E291 VA: 0x343E190
	|-SingletonPool<GodBondHolderPool, GodBondHolder>.DeserializeSingle
	|-SingletonPool<GodPool, GodUnit>.DeserializeSingle
	|-SingletonPool<object, object>.DeserializeSingle
	|-SingletonPool<UnitRingPool, UnitRing>.DeserializeSingle
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void OnSerialize(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343E630 Offset: 0x343E731 VA: 0x343E630
	|-SingletonPool<GodBondHolderPool, GodBondHolder>.OnSerialize
	|-SingletonPool<GodPool, GodUnit>.OnSerialize
	|-SingletonPool<object, object>.OnSerialize
	|-SingletonPool<UnitRingPool, UnitRing>.OnSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343E730 Offset: 0x343E831 VA: 0x343E730
	|-SingletonPool<GodBondHolderPool, GodBondHolder>.OnDeserialize
	|-SingletonPool<GodPool, GodUnit>.OnDeserialize
	|-SingletonPool<object, object>.OnDeserialize
	|-SingletonPool<UnitRingPool, UnitRing>.OnDeserialize
	*/

	// RVA: -1 Offset: -1
	private void SortImpl() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343EA00 Offset: 0x343EB01 VA: 0x343EA00
	|-SingletonPool<object, object>.SortImpl
	*/

	// RVA: -1 Offset: -1
	public List.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343EC30 Offset: 0x343ED31 VA: 0x343EC30
	|-SingletonPool<GodBondHolderPool, GodBondHolder>.GetEnumerator
	|-SingletonPool<GodPool, GodUnit>.GetEnumerator
	|-SingletonPool<object, object>.GetEnumerator
	|-SingletonPool<UnitRingPool, UnitRing>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public static int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343EC80 Offset: 0x343ED81 VA: 0x343EC80
	|-SingletonPool<GodPool, GodUnit>.get_Count
	|-SingletonPool<object, object>.get_Count
	|-SingletonPool<UnitRingPool, UnitRing>.get_Count
	*/

	// RVA: -1 Offset: -1
	protected static List<T> get_List() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343EF80 Offset: 0x343F081 VA: 0x343EF80
	|-SingletonPool<object, object>.get_List
	*/

	// RVA: -1 Offset: -1
	public static T Find(int instanceID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343F220 Offset: 0x343F321 VA: 0x343F220
	|-SingletonPool<GodBondHolderPool, GodBondHolder>.Find
	|-SingletonPool<GodPool, GodUnit>.Find
	|-SingletonPool<object, object>.Find
	|-SingletonPool<UnitRingPool, UnitRing>.Find
	*/

	// RVA: -1 Offset: -1
	public static bool IsFromOnline(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343F520 Offset: 0x343F621 VA: 0x343F520
	|-SingletonPool<GodBondHolderPool, GodBondHolder>.IsFromOnline
	|-SingletonPool<GodPool, GodUnit>.IsFromOnline
	|-SingletonPool<object, object>.IsFromOnline
	|-SingletonPool<UnitRingPool, UnitRing>.IsFromOnline
	*/

	// RVA: -1 Offset: -1
	public static void Sort() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x343F700 Offset: 0x343F801 VA: 0x343F700
	|-SingletonPool<GodBondHolderPool, GodBondHolder>.Sort
	|-SingletonPool<GodPool, GodUnit>.Sort
	|-SingletonPool<object, object>.Sort
	|-SingletonPool<UnitRingPool, UnitRing>.Sort
	*/
}

