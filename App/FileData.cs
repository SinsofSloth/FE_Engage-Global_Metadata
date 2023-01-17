// Namespace: App
public class FileData : FileCommon, IDisposable // TypeDefIndex: 9133
{
	// Fields
	public FileCommon.State m_State; // 0x10
	public string m_Path; // 0x18
	public byte[] m_Data; // 0x20
	public BindHolder m_Refer; // 0x28

	// Methods

	// RVA: 0x2A20180 Offset: 0x2A20281 VA: 0x2A20180
	public string GetPath() { }

	// RVA: 0x2A20190 Offset: 0x2A20291 VA: 0x2A20190
	public byte[] GetData() { }

	// RVA: 0x2A201A0 Offset: 0x2A202A1 VA: 0x2A201A0
	public int GetSize() { }

	// RVA: 0x2A201C0 Offset: 0x2A202C1 VA: 0x2A201C0
	public void Dump(int index = -1) { }

	// RVA: 0x2A204F0 Offset: 0x2A205F1 VA: 0x2A204F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2A20550 Offset: 0x2A20651 VA: 0x2A20550
	public void .ctor() { }

	// RVA: 0x2A20600 Offset: 0x2A20701 VA: 0x2A20600 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2A206A0 Offset: 0x2A207A1 VA: 0x2A206A0 Slot: 5
	public virtual void OnBuild() { }

	// RVA: 0x2A206B0 Offset: 0x2A207B1 VA: 0x2A206B0 Slot: 6
	public virtual void OnDispose() { }

	// RVA: 0x2A20480 Offset: 0x2A20581 VA: 0x2A20480
	public uint GetCrc32() { }

	// RVA: 0x2A207B0 Offset: 0x2A208B1 VA: 0x2A207B0
	public bool IsValid() { }
}

