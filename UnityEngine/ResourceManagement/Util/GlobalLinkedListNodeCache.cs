// Namespace: UnityEngine.ResourceManagement.Util
internal static class GlobalLinkedListNodeCache<T> // TypeDefIndex: 5569
{
	// Fields
	private static LinkedListNodeCache<T> m_globalCache; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static LinkedListNode<T> Acquire(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A12420 Offset: 0x3A12521 VA: 0x3A12420
	|-GlobalLinkedListNodeCache<object>.Acquire
	*/

	// RVA: -1 Offset: -1
	public static void Release(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A12610 Offset: 0x3A12711 VA: 0x3A12610
	|-GlobalLinkedListNodeCache<object>.Release
	*/
}

