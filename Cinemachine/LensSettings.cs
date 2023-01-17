// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1B950 Offset: 0x1BA51 VA: 0x1B950
[Serializable]
public struct LensSettings // TypeDefIndex: 5853
{
	// Fields
	public static LensSettings Default; // 0x0
	[TooltipAttribute] // RVA: 0x21E10 Offset: 0x21F11 VA: 0x21E10
	[RangeAttribute] // RVA: 0x21E10 Offset: 0x21F11 VA: 0x21E10
	public float FieldOfView; // 0x0
	[TooltipAttribute] // RVA: 0x21E70 Offset: 0x21F71 VA: 0x21E70
	public float OrthographicSize; // 0x4
	[TooltipAttribute] // RVA: 0x21EB0 Offset: 0x21FB1 VA: 0x21EB0
	public float NearClipPlane; // 0x8
	[TooltipAttribute] // RVA: 0x21EF0 Offset: 0x21FF1 VA: 0x21EF0
	public float FarClipPlane; // 0xC
	[RangeAttribute] // RVA: 0x21F30 Offset: 0x22031 VA: 0x21F30
	[TooltipAttribute] // RVA: 0x21F30 Offset: 0x22031 VA: 0x21F30
	public float Dutch; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x21F90 Offset: 0x22091 VA: 0x21F90
	private bool <Orthographic>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x21FA0 Offset: 0x220A1 VA: 0x21FA0
	private Vector2 <SensorSize>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x21FB0 Offset: 0x220B1 VA: 0x21FB0
	private bool <IsPhysicalCamera>k__BackingField; // 0x20
	public Vector2 LensShift; // 0x24

	// Properties
	public bool Orthographic { get; set; }
	public Vector2 SensorSize { get; set; }
	public float Aspect { get; }
	public bool IsPhysicalCamera { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x23EF0 Offset: 0x23FF1 VA: 0x23EF0
	[CompilerGeneratedAttribute] // RVA: 0x23EF0 Offset: 0x23FF1 VA: 0x23EF0
	// RVA: 0x1A82610 Offset: 0x1A82711 VA: 0x1A82610
	public bool get_Orthographic() { }

	[CompilerGeneratedAttribute] // RVA: 0x23F30 Offset: 0x24031 VA: 0x23F30
	// RVA: 0x1A82620 Offset: 0x1A82721 VA: 0x1A82620
	public void set_Orthographic(bool value) { }

	[IsReadOnlyAttribute] // RVA: 0x23F40 Offset: 0x24041 VA: 0x23F40
	[CompilerGeneratedAttribute] // RVA: 0x23F40 Offset: 0x24041 VA: 0x23F40
	// RVA: 0x1A82630 Offset: 0x1A82731 VA: 0x1A82630
	public Vector2 get_SensorSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x23F80 Offset: 0x24081 VA: 0x23F80
	// RVA: 0x1A82640 Offset: 0x1A82741 VA: 0x1A82640
	public void set_SensorSize(Vector2 value) { }

	// RVA: 0x1A82650 Offset: 0x1A82751 VA: 0x1A82650
	public float get_Aspect() { }

	[IsReadOnlyAttribute] // RVA: 0x23F90 Offset: 0x24091 VA: 0x23F90
	[CompilerGeneratedAttribute] // RVA: 0x23F90 Offset: 0x24091 VA: 0x23F90
	// RVA: 0x1A82670 Offset: 0x1A82771 VA: 0x1A82670
	public bool get_IsPhysicalCamera() { }

	[CompilerGeneratedAttribute] // RVA: 0x23FD0 Offset: 0x240D1 VA: 0x23FD0
	// RVA: 0x1A82680 Offset: 0x1A82781 VA: 0x1A82680
	public void set_IsPhysicalCamera(bool value) { }

	// RVA: 0x1A82690 Offset: 0x1A82791 VA: 0x1A82690
	public static LensSettings FromCamera(Camera fromCamera) { }

	// RVA: 0x1A80080 Offset: 0x1A80181 VA: 0x1A80080
	public void SnapshotCameraReadOnlyProperties(Camera camera) { }

	// RVA: 0x1A82800 Offset: 0x1A82901 VA: 0x1A82800
	public void SnapshotCameraReadOnlyProperties(ref LensSettings lens) { }

	// RVA: 0x1A82860 Offset: 0x1A82961 VA: 0x1A82860
	public void .ctor(float fov, float orthographicSize, float nearClip, float farClip, float dutch) { }

	// RVA: 0x1A82890 Offset: 0x1A82991 VA: 0x1A82890
	public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t) { }

	// RVA: 0x1A7D080 Offset: 0x1A7D181 VA: 0x1A7D080
	public void Validate() { }

	// RVA: 0x1A82A20 Offset: 0x1A82B21 VA: 0x1A82A20
	private static void .cctor() { }
}

