// Namespace: Nintendo.MessageStudio.Lib
public abstract class BinLibmsFileBase : IDisposable // TypeDefIndex: 15025
{
	// Fields
	private IntPtr m_ResourceFilePtr; // 0x10
	private IntPtr m_FileObjectPtr; // 0x18

	// Properties
	protected IntPtr FileObjectPtr { get; }
	public bool IsFileLoaded { get; }

	// Methods

	// RVA: 0x2264010 Offset: 0x2264111 VA: 0x2264010
	protected IntPtr get_FileObjectPtr() { }

	// RVA: 0x2264020 Offset: 0x2264121 VA: 0x2264020
	public bool get_IsFileLoaded() { }

	// RVA: 0x2264070 Offset: 0x2264171 VA: 0x2264070
	public void Load(byte[] bytes) { }

	// RVA: 0x2264150 Offset: 0x2264251 VA: 0x2264150
	public void Free() { }

	// RVA: 0x2264210 Offset: 0x2264311 VA: 0x2264210 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2264280 Offset: 0x2264381 VA: 0x2264280 Slot: 4
	public void Dispose() { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract IntPtr InitObject(IntPtr resourcePtr);

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void CloseObject(IntPtr objectPtr);

	// RVA: 0x2263FC0 Offset: 0x22640C1 VA: 0x2263FC0
	protected void .ctor() { }
}

