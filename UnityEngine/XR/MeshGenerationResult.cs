// Namespace: UnityEngine.XR
[RequiredByNativeCodeAttribute] // RVA: 0x590F0 Offset: 0x591F1 VA: 0x590F0
[NativeHeaderAttribute] // RVA: 0x590F0 Offset: 0x591F1 VA: 0x590F0
public struct MeshGenerationResult : IEquatable<MeshGenerationResult> // TypeDefIndex: 4883
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x59580 Offset: 0x59681 VA: 0x59580
	[CompilerGeneratedAttribute] // RVA: 0x59580 Offset: 0x59681 VA: 0x59580
	private readonly MeshId <MeshId>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x595C0 Offset: 0x596C1 VA: 0x595C0
	[CompilerGeneratedAttribute] // RVA: 0x595C0 Offset: 0x596C1 VA: 0x595C0
	private readonly Mesh <Mesh>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x59600 Offset: 0x59701 VA: 0x59600
	[DebuggerBrowsableAttribute] // RVA: 0x59600 Offset: 0x59701 VA: 0x59600
	private readonly MeshCollider <MeshCollider>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x59640 Offset: 0x59741 VA: 0x59640
	[DebuggerBrowsableAttribute] // RVA: 0x59640 Offset: 0x59741 VA: 0x59640
	private readonly MeshGenerationStatus <Status>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x59680 Offset: 0x59781 VA: 0x59680
	[DebuggerBrowsableAttribute] // RVA: 0x59680 Offset: 0x59781 VA: 0x59680
	private readonly MeshVertexAttributes <Attributes>k__BackingField; // 0x24

	// Properties
	public MeshId MeshId { get; }
	public Mesh Mesh { get; }
	public MeshCollider MeshCollider { get; }
	public MeshGenerationStatus Status { get; }
	public MeshVertexAttributes Attributes { get; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x59B20 Offset: 0x59C21 VA: 0x59B20
	[CompilerGeneratedAttribute] // RVA: 0x59B20 Offset: 0x59C21 VA: 0x59B20
	// RVA: 0x1C4F010 Offset: 0x1C4F111 VA: 0x1C4F010
	public MeshId get_MeshId() { }

	[IsReadOnlyAttribute] // RVA: 0x59B60 Offset: 0x59C61 VA: 0x59B60
	[CompilerGeneratedAttribute] // RVA: 0x59B60 Offset: 0x59C61 VA: 0x59B60
	// RVA: 0x1C4F020 Offset: 0x1C4F121 VA: 0x1C4F020
	public Mesh get_Mesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x59BA0 Offset: 0x59CA1 VA: 0x59BA0
	[IsReadOnlyAttribute] // RVA: 0x59BA0 Offset: 0x59CA1 VA: 0x59BA0
	// RVA: 0x1C4F030 Offset: 0x1C4F131 VA: 0x1C4F030
	public MeshCollider get_MeshCollider() { }

	[IsReadOnlyAttribute] // RVA: 0x59BE0 Offset: 0x59CE1 VA: 0x59BE0
	[CompilerGeneratedAttribute] // RVA: 0x59BE0 Offset: 0x59CE1 VA: 0x59BE0
	// RVA: 0x1C4F040 Offset: 0x1C4F141 VA: 0x1C4F040
	public MeshGenerationStatus get_Status() { }

	[IsReadOnlyAttribute] // RVA: 0x59C20 Offset: 0x59D21 VA: 0x59C20
	[CompilerGeneratedAttribute] // RVA: 0x59C20 Offset: 0x59D21 VA: 0x59C20
	// RVA: 0x1C4F050 Offset: 0x1C4F151 VA: 0x1C4F050
	public MeshVertexAttributes get_Attributes() { }

	// RVA: 0x1C4F060 Offset: 0x1C4F161 VA: 0x1C4F060 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C4F110 Offset: 0x1C4F211 VA: 0x1C4F110 Slot: 4
	public bool Equals(MeshGenerationResult other) { }

	// RVA: 0x1C4F2D0 Offset: 0x1C4F3D1 VA: 0x1C4F2D0 Slot: 2
	public override int GetHashCode() { }
}

