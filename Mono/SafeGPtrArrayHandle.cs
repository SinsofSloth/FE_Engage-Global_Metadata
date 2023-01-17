// Namespace: Mono
[DefaultMemberAttribute] // RVA: 0x46F640 Offset: 0x46F741 VA: 0x46F640
internal struct SafeGPtrArrayHandle : IDisposable // TypeDefIndex: 20
{
	// Fields
	private RuntimeGPtrArrayHandle handle; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x360FE70 Offset: 0x360FF71 VA: 0x360FE70
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x360FEB0 Offset: 0x360FFB1 VA: 0x360FEB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x360FEC0 Offset: 0x360FFC1 VA: 0x360FEC0
	internal int get_Length() { }

	// RVA: 0x360FED0 Offset: 0x360FFD1 VA: 0x360FED0
	internal IntPtr get_Item(int i) { }
}

