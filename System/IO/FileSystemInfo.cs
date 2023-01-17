// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472AA0 Offset: 0x472BA1 VA: 0x472AA0
[Serializable]
public abstract class FileSystemInfo : MarshalByRefObject, ISerializable // TypeDefIndex: 631
{
	// Fields
	internal MonoIOStat _data; // 0x18
	internal int _dataInitialised; // 0x40
	protected string FullPath; // 0x48
	protected string OriginalPath; // 0x50
	private string _displayPath; // 0x58

	// Properties
	public virtual string FullName { get; }
	public abstract string Name { get; }
	public abstract bool Exists { get; }
	internal string DisplayPath { get; set; }

	// Methods

	// RVA: 0x38ADBE0 Offset: 0x38ADCE1 VA: 0x38ADBE0
	protected void .ctor() { }

	// RVA: 0x38ADDC0 Offset: 0x38ADEC1 VA: 0x38ADDC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x38B36B0 Offset: 0x38B37B1 VA: 0x38B36B0 Slot: 7
	public virtual string get_FullName() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_Exists();

	// RVA: 0x38AE210 Offset: 0x38AE311 VA: 0x38AE210
	public void Refresh() { }

	[ComVisibleAttribute] // RVA: 0x47C220 Offset: 0x47C321 VA: 0x47C220
	// RVA: 0x38B36C0 Offset: 0x38B37C1 VA: 0x38B36C0 Slot: 10
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x38B37D0 Offset: 0x38B38D1 VA: 0x38B37D0
	internal string get_DisplayPath() { }

	// RVA: 0x38B37E0 Offset: 0x38B38E1 VA: 0x38B37E0
	internal void set_DisplayPath(string value) { }
}

