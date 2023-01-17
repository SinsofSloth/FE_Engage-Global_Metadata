// Namespace: App
public abstract class IRawAssetBundle<T> : IDisposable // TypeDefIndex: 9137
{
	// Fields
	private AsyncOperationHandle<T> m_Handle; // 0x0
	private T m_Asset; // 0x0

	// Properties
	public T Asset { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAF310 Offset: 0x1EAF411 VA: 0x1EAF310
	|-IRawAssetBundle<object>..ctor
	|-IRawAssetBundle<TextAsset>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAF360 Offset: 0x1EAF461 VA: 0x1EAF360
	|-IRawAssetBundle<object>.Dispose
	|-IRawAssetBundle<TextAsset>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void OnLoad() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAF380 Offset: 0x1EAF481 VA: 0x1EAF380
	|-IRawAssetBundle<object>.OnLoad
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected virtual void OnUnload() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAF390 Offset: 0x1EAF491 VA: 0x1EAF390
	|-IRawAssetBundle<object>.OnUnload
	*/

	// RVA: -1 Offset: -1
	protected bool Load(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAF3A0 Offset: 0x1EAF4A1 VA: 0x1EAF3A0
	|-IRawAssetBundle<object>.Load
	*/

	// RVA: -1 Offset: -1
	protected void Unload() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAF560 Offset: 0x1EAF661 VA: 0x1EAF560
	|-IRawAssetBundle<object>.Unload
	*/

	// RVA: -1 Offset: -1
	public T get_Asset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAF690 Offset: 0x1EAF791 VA: 0x1EAF690
	|-IRawAssetBundle<object>.get_Asset
	|-IRawAssetBundle<TextAsset>.get_Asset
	*/
}

