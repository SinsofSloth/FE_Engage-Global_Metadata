// Namespace: Combat
public sealed class CharacterIllusion : MonoBehaviour // TypeDefIndex: 8614
{
	// Fields
	[TooltipAttribute] // RVA: 0x2826B0 Offset: 0x2827B1 VA: 0x2826B0
	public int NumIllusions; // 0x18
	[TooltipAttribute] // RVA: 0x2826F0 Offset: 0x2827F1 VA: 0x2826F0
	public float Interval; // 0x1C
	private Character _cp; // 0x20
	private BakedMesh[][] illusionHistory; // 0x28
	private int index; // 0x30
	private float freqency; // 0x34
	private GameObject[] illusionGOs; // 0x38
	private SkinnedMeshRenderer[] srcSkinnedMeshRenderers; // 0x40
	private MeshFilter[] srcMeshFilters; // 0x48
	private MeshRenderer[] srcMeshRenderers; // 0x50
	private bool initialized; // 0x58
	private IDisposable updateDisposable; // 0x60

	// Properties
	private Character CP { get; }

	// Methods

	// RVA: 0x2B7C9F0 Offset: 0x2B7CAF1 VA: 0x2B7C9F0
	private Character get_CP() { }

	// RVA: 0x2B7CAB0 Offset: 0x2B7CBB1 VA: 0x2B7CAB0
	public void On() { }

	// RVA: 0x2B7D110 Offset: 0x2B7D211 VA: 0x2B7D110
	public void Off() { }

	// RVA: 0x2B7D220 Offset: 0x2B7D321 VA: 0x2B7D220
	public void Stop() { }

	// RVA: 0x2B7D230 Offset: 0x2B7D331 VA: 0x2B7D230
	private void OnDisable() { }

	// RVA: 0x2B7D340 Offset: 0x2B7D441 VA: 0x2B7D340
	private void MyUpdate() { }

	// RVA: 0x2B7D3E0 Offset: 0x2B7D4E1 VA: 0x2B7D3E0
	private void Capture(BakedMesh[] dstMeshes) { }

	// RVA: 0x2B7D510 Offset: 0x2B7D611 VA: 0x2B7D510
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAC80 Offset: 0x2AAD81 VA: 0x2AAC80
	// RVA: 0x2B7D530 Offset: 0x2B7D631 VA: 0x2B7D530
	private void <On>b__14_0(Unit _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AAC90 Offset: 0x2AAD91 VA: 0x2AAC90
	// RVA: 0x2B7D540 Offset: 0x2B7D641 VA: 0x2B7D540
	private void <Off>b__15_0() { }
}

