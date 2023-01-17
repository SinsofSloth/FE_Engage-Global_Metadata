// Namespace: System.Collections.Generic
internal sealed class TreeWalkPredicate<T> : MulticastDelegate // TypeDefIndex: 2441
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3571AF0 Offset: 0x3571BF1 VA: 0x3571AF0
	|-TreeWalkPredicate<KeyValuePair<int, bool>>..ctor
	|
	|-RVA: 0x3571ED0 Offset: 0x3571FD1 VA: 0x3571ED0
	|-TreeWalkPredicate<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x35722B0 Offset: 0x35723B1 VA: 0x35722B0
	|-TreeWalkPredicate<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x3572690 Offset: 0x3572791 VA: 0x3572690
	|-TreeWalkPredicate<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool Invoke(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3571B10 Offset: 0x3571C11 VA: 0x3571B10
	|-TreeWalkPredicate<KeyValuePair<int, bool>>.Invoke
	|
	|-RVA: 0x3571EF0 Offset: 0x3571FF1 VA: 0x3571EF0
	|-TreeWalkPredicate<KeyValuePair<int, int>>.Invoke
	|
	|-RVA: 0x35722D0 Offset: 0x35723D1 VA: 0x35722D0
	|-TreeWalkPredicate<KeyValuePair<object, object>>.Invoke
	|
	|-RVA: 0x35726B0 Offset: 0x35727B1 VA: 0x35726B0
	|-TreeWalkPredicate<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(SortedSet.Node<T> node, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3571E70 Offset: 0x3571F71 VA: 0x3571E70
	|-TreeWalkPredicate<KeyValuePair<int, bool>>.BeginInvoke
	|
	|-RVA: 0x3572250 Offset: 0x3572351 VA: 0x3572250
	|-TreeWalkPredicate<KeyValuePair<int, int>>.BeginInvoke
	|
	|-RVA: 0x3572630 Offset: 0x3572731 VA: 0x3572630
	|-TreeWalkPredicate<KeyValuePair<object, object>>.BeginInvoke
	|
	|-RVA: 0x3572A10 Offset: 0x3572B11 VA: 0x3572A10
	|-TreeWalkPredicate<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3571EA0 Offset: 0x3571FA1 VA: 0x3571EA0
	|-TreeWalkPredicate<KeyValuePair<int, bool>>.EndInvoke
	|
	|-RVA: 0x3572280 Offset: 0x3572381 VA: 0x3572280
	|-TreeWalkPredicate<KeyValuePair<int, int>>.EndInvoke
	|
	|-RVA: 0x3572660 Offset: 0x3572761 VA: 0x3572660
	|-TreeWalkPredicate<KeyValuePair<object, object>>.EndInvoke
	|
	|-RVA: 0x3572A40 Offset: 0x3572B41 VA: 0x3572A40
	|-TreeWalkPredicate<object>.EndInvoke
	*/
}

