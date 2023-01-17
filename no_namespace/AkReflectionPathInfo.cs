// Namespace: 
public class AkReflectionPathInfo : IDisposable // TypeDefIndex: 7893
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public Vector3 imageSource { get; set; }
	public uint numPathPoints { get; set; }
	public uint numReflections { get; set; }
	public float level { get; set; }
	public bool isOccluded { get; set; }

	// Methods

	// RVA: 0x3188820 Offset: 0x3188921 VA: 0x3188820
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x3188860 Offset: 0x3188961 VA: 0x3188860
	internal static IntPtr getCPtr(AkReflectionPathInfo obj) { }

	// RVA: 0x31888C0 Offset: 0x31889C1 VA: 0x31888C0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x31888F0 Offset: 0x31889F1 VA: 0x31888F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3188960 Offset: 0x3188A61 VA: 0x3188960 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x3188AF0 Offset: 0x3188BF1 VA: 0x3188AF0
	public void set_imageSource(Vector3 value) { }

	// RVA: 0x3188B90 Offset: 0x3188C91 VA: 0x3188B90
	public Vector3 get_imageSource() { }

	// RVA: 0x3188C00 Offset: 0x3188D01 VA: 0x3188C00
	public void set_numPathPoints(uint value) { }

	// RVA: 0x3188C80 Offset: 0x3188D81 VA: 0x3188C80
	public uint get_numPathPoints() { }

	// RVA: 0x3188CF0 Offset: 0x3188DF1 VA: 0x3188CF0
	public void set_numReflections(uint value) { }

	// RVA: 0x3188D70 Offset: 0x3188E71 VA: 0x3188D70
	public uint get_numReflections() { }

	// RVA: 0x3188DE0 Offset: 0x3188EE1 VA: 0x3188DE0
	public void set_level(float value) { }

	// RVA: 0x3188E60 Offset: 0x3188F61 VA: 0x3188E60
	public float get_level() { }

	// RVA: 0x3188ED0 Offset: 0x3188FD1 VA: 0x3188ED0
	public void set_isOccluded(bool value) { }

	// RVA: 0x3188F50 Offset: 0x3189051 VA: 0x3188F50
	public bool get_isOccluded() { }

	// RVA: 0x3188FC0 Offset: 0x31890C1 VA: 0x3188FC0
	public static int GetSizeOf() { }

	// RVA: 0x3189030 Offset: 0x3189131 VA: 0x3189030
	public Vector3 GetPathPoint(uint idx) { }

	// RVA: 0x31890B0 Offset: 0x31891B1 VA: 0x31890B0
	public AkAcousticSurface GetAcousticSurface(uint idx) { }

	// RVA: 0x3189170 Offset: 0x3189271 VA: 0x3189170
	public float GetDiffraction(uint idx) { }

	// RVA: 0x31891F0 Offset: 0x31892F1 VA: 0x31891F0
	public void Clone(AkReflectionPathInfo other) { }

	// RVA: 0x31892B0 Offset: 0x31893B1 VA: 0x31892B0
	public void .ctor() { }
}

