// Namespace: FUtility
public sealed class Task<T> // TypeDefIndex: 6341
{
	// Fields
	public T item; // 0x0
	public Task<T> prev; // 0x0
	public Task<T> next; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Attach(Task<T> prev, Task<T> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3987BB0 Offset: 0x3987CB1 VA: 0x3987BB0
	|-Task<NativeBlock>.Attach
	|
	|-RVA: 0x3987CB0 Offset: 0x3987DB1 VA: 0x3987CB0
	|-Task<object>.Attach
	*/

	// RVA: -1 Offset: -1
	public void Detach() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3987C30 Offset: 0x3987D31 VA: 0x3987C30
	|-Task<NativeBlock>.Detach
	|
	|-RVA: 0x3987D30 Offset: 0x3987E31 VA: 0x3987D30
	|-Task<object>.Detach
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3987CA0 Offset: 0x3987DA1 VA: 0x3987CA0
	|-Task<NativeBlock>..ctor
	|
	|-RVA: 0x3987DA0 Offset: 0x3987EA1 VA: 0x3987DA0
	|-Task<object>..ctor
	*/
}

