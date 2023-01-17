// Namespace: App
public class FileHandle<T> : FileCommon, IDisposable // TypeDefIndex: 9134
{
	// Fields
	private FileData m_Data; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public bool Load(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D35F0 Offset: 0x33D36F1 VA: 0x33D35F0
	|-FileHandle<FileData>.Load
	|-FileHandle<object>.Load
	*/

	// RVA: -1 Offset: -1
	public void LoadAsync(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D3890 Offset: 0x33D3991 VA: 0x33D3890
	|-FileHandle<FileData>.LoadAsync
	|-FileHandle<object>.LoadAsync
	*/

	// RVA: -1 Offset: -1
	public void Unload() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D3B30 Offset: 0x33D3C31 VA: 0x33D3B30
	|-FileHandle<object>.Unload
	*/

	// RVA: -1 Offset: -1
	public void Dump() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D3CD0 Offset: 0x33D3DD1 VA: 0x33D3CD0
	|-FileHandle<object>.Dump
	*/

	// RVA: -1 Offset: -1
	public bool IsLoading() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D3E00 Offset: 0x33D3F01 VA: 0x33D3E00
	|-FileHandle<FileData>.IsLoading
	|-FileHandle<object>.IsLoading
	*/

	// RVA: -1 Offset: -1
	public bool IsValid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D3F40 Offset: 0x33D4041 VA: 0x33D3F40
	|-FileHandle<FileData>.IsValid
	|-FileHandle<object>.IsValid
	*/

	// RVA: -1 Offset: -1
	public byte[] GetData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D4070 Offset: 0x33D4171 VA: 0x33D4070
	|-FileHandle<FileData>.GetData
	|-FileHandle<object>.GetData
	*/

	// RVA: -1 Offset: -1
	public int GetSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D41A0 Offset: 0x33D42A1 VA: 0x33D41A0
	|-FileHandle<FileData>.GetSize
	|-FileHandle<object>.GetSize
	*/

	// RVA: -1 Offset: -1
	public string GetPath() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D42E0 Offset: 0x33D43E1 VA: 0x33D42E0
	|-FileHandle<object>.GetPath
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D4410 Offset: 0x33D4511 VA: 0x33D4410
	|-FileHandle<FileData>.Dispose
	|-FileHandle<object>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D4430 Offset: 0x33D4531 VA: 0x33D4430
	|-FileHandle<FileData>..ctor
	|-FileHandle<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D44A0 Offset: 0x33D45A1 VA: 0x33D44A0
	|-FileHandle<FileData>.Finalize
	|-FileHandle<object>.Finalize
	*/
}

