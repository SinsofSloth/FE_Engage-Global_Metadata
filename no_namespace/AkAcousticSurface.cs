// Namespace: 
public class AkAcousticSurface : IDisposable // TypeDefIndex: 7823
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint textureID { get; set; }
	public float occlusion { get; set; }
	public string strName { get; set; }

	// Methods

	// RVA: 0x2ECB9E0 Offset: 0x2ECBAE1 VA: 0x2ECB9E0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x2ECBA20 Offset: 0x2ECBB21 VA: 0x2ECBA20
	internal static IntPtr getCPtr(AkAcousticSurface obj) { }

	// RVA: 0x2ECBA80 Offset: 0x2ECBB81 VA: 0x2ECBA80 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x2ECBAB0 Offset: 0x2ECBBB1 VA: 0x2ECBAB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2ECBB20 Offset: 0x2ECBC21 VA: 0x2ECBB20 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x2ECBCB0 Offset: 0x2ECBDB1 VA: 0x2ECBCB0
	public void .ctor() { }

	// RVA: 0x2ECBD40 Offset: 0x2ECBE41 VA: 0x2ECBD40
	public void set_textureID(uint value) { }

	// RVA: 0x2ECBDC0 Offset: 0x2ECBEC1 VA: 0x2ECBDC0
	public uint get_textureID() { }

	// RVA: 0x2ECBE30 Offset: 0x2ECBF31 VA: 0x2ECBE30
	public void set_occlusion(float value) { }

	// RVA: 0x2ECBEB0 Offset: 0x2ECBFB1 VA: 0x2ECBEB0
	public float get_occlusion() { }

	// RVA: 0x2ECBF20 Offset: 0x2ECC021 VA: 0x2ECBF20
	public void set_strName(string value) { }

	// RVA: 0x2ECBFA0 Offset: 0x2ECC0A1 VA: 0x2ECBFA0
	public string get_strName() { }

	// RVA: 0x2ECC050 Offset: 0x2ECC151 VA: 0x2ECC050
	public void Clear() { }

	// RVA: 0x2ECC0C0 Offset: 0x2ECC1C1 VA: 0x2ECC0C0
	public void DeleteName() { }

	// RVA: 0x2ECC130 Offset: 0x2ECC231 VA: 0x2ECC130
	public static int GetSizeOf() { }

	// RVA: 0x2ECC1A0 Offset: 0x2ECC2A1 VA: 0x2ECC1A0
	public void Clone(AkAcousticSurface other) { }
}

