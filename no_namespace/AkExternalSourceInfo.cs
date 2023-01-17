// Namespace: 
public class AkExternalSourceInfo : IDisposable // TypeDefIndex: 7851
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint iExternalSrcCookie { get; set; }
	public uint idCodec { get; set; }
	public string szFile { get; set; }
	public IntPtr pInMemory { get; set; }
	public uint uiMemorySize { get; set; }
	public uint idFile { get; set; }

	// Methods

	// RVA: 0x3174850 Offset: 0x3174951 VA: 0x3174850
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x3174890 Offset: 0x3174991 VA: 0x3174890
	internal static IntPtr getCPtr(AkExternalSourceInfo obj) { }

	// RVA: 0x31748F0 Offset: 0x31749F1 VA: 0x31748F0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x3174920 Offset: 0x3174A21 VA: 0x3174920 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3174990 Offset: 0x3174A91 VA: 0x3174990 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x3174B20 Offset: 0x3174C21 VA: 0x3174B20
	public void .ctor() { }

	// RVA: 0x3174BB0 Offset: 0x3174CB1 VA: 0x3174BB0
	public void .ctor(IntPtr in_pInMemory, uint in_uiMemorySize, uint in_iExternalSrcCookie, uint in_idCodec) { }

	// RVA: 0x3174C70 Offset: 0x3174D71 VA: 0x3174C70
	public void .ctor(string in_pszFileName, uint in_iExternalSrcCookie, uint in_idCodec) { }

	// RVA: 0x3174D20 Offset: 0x3174E21 VA: 0x3174D20
	public void .ctor(uint in_idFile, uint in_iExternalSrcCookie, uint in_idCodec) { }

	// RVA: 0x3174DD0 Offset: 0x3174ED1 VA: 0x3174DD0
	public void Clear() { }

	// RVA: 0x3174E40 Offset: 0x3174F41 VA: 0x3174E40
	public void Clone(AkExternalSourceInfo other) { }

	// RVA: 0x3174F00 Offset: 0x3175001 VA: 0x3174F00
	public static int GetSizeOf() { }

	// RVA: 0x3174F70 Offset: 0x3175071 VA: 0x3174F70
	public void set_iExternalSrcCookie(uint value) { }

	// RVA: 0x3174FF0 Offset: 0x31750F1 VA: 0x3174FF0
	public uint get_iExternalSrcCookie() { }

	// RVA: 0x3175060 Offset: 0x3175161 VA: 0x3175060
	public void set_idCodec(uint value) { }

	// RVA: 0x31750E0 Offset: 0x31751E1 VA: 0x31750E0
	public uint get_idCodec() { }

	// RVA: 0x3175150 Offset: 0x3175251 VA: 0x3175150
	public void set_szFile(string value) { }

	// RVA: 0x31751D0 Offset: 0x31752D1 VA: 0x31751D0
	public string get_szFile() { }

	// RVA: 0x3175280 Offset: 0x3175381 VA: 0x3175280
	public void set_pInMemory(IntPtr value) { }

	// RVA: 0x3175300 Offset: 0x3175401 VA: 0x3175300
	public IntPtr get_pInMemory() { }

	// RVA: 0x3175370 Offset: 0x3175471 VA: 0x3175370
	public void set_uiMemorySize(uint value) { }

	// RVA: 0x31753F0 Offset: 0x31754F1 VA: 0x31753F0
	public uint get_uiMemorySize() { }

	// RVA: 0x3175460 Offset: 0x3175561 VA: 0x3175460
	public void set_idFile(uint value) { }

	// RVA: 0x31754E0 Offset: 0x31755E1 VA: 0x31754E0
	public uint get_idFile() { }
}

