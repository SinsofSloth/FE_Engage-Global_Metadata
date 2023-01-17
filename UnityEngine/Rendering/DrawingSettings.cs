// Namespace: UnityEngine.Rendering
public struct DrawingSettings : IEquatable<DrawingSettings> // TypeDefIndex: 3942
{
	// Fields
	public static readonly int maxShaderPasses; // 0x0
	private SortingSettings m_SortingSettings; // 0x0
	[FixedBufferAttribute] // RVA: 0x444D50 Offset: 0x444E51 VA: 0x444D50
	internal DrawingSettings.<shaderPassNames>e__FixedBuffer shaderPassNames; // 0xE0
	private PerObjectData m_PerObjectData; // 0x120
	private DrawRendererFlags m_Flags; // 0x124
	private int m_OverrideMaterialInstanceId; // 0x128
	private int m_OverrideMaterialPassIndex; // 0x12C
	private int m_MainLightIndex; // 0x130
	private int m_UseSrpBatcher; // 0x134

	// Properties
	public SortingSettings sortingSettings { get; set; }
	public PerObjectData perObjectData { set; }
	public bool enableDynamicBatching { set; }
	public bool enableInstancing { set; }
	public Material overrideMaterial { set; }
	public int overrideMaterialPassIndex { set; }
	public int mainLightIndex { set; }

	// Methods

	// RVA: 0x2F21250 Offset: 0x2F21351 VA: 0x2F21250
	public void .ctor(ShaderTagId shaderPassName, SortingSettings sortingSettings) { }

	// RVA: 0x2F21340 Offset: 0x2F21441 VA: 0x2F21340
	public SortingSettings get_sortingSettings() { }

	// RVA: 0x2F21360 Offset: 0x2F21461 VA: 0x2F21360
	public void set_sortingSettings(SortingSettings value) { }

	// RVA: 0x2F21380 Offset: 0x2F21481 VA: 0x2F21380
	public void set_perObjectData(PerObjectData value) { }

	// RVA: 0x2F21390 Offset: 0x2F21491 VA: 0x2F21390
	public void set_enableDynamicBatching(bool value) { }

	// RVA: 0x2F213B0 Offset: 0x2F214B1 VA: 0x2F213B0
	public void set_enableInstancing(bool value) { }

	// RVA: 0x2F213D0 Offset: 0x2F214D1 VA: 0x2F213D0
	public void set_overrideMaterial(Material value) { }

	// RVA: 0x2F21420 Offset: 0x2F21521 VA: 0x2F21420
	public void set_overrideMaterialPassIndex(int value) { }

	// RVA: 0x2F21430 Offset: 0x2F21531 VA: 0x2F21430
	public void set_mainLightIndex(int value) { }

	// RVA: 0x2F21440 Offset: 0x2F21541 VA: 0x2F21440
	public ShaderTagId GetShaderPassName(int index) { }

	// RVA: 0x2F215E0 Offset: 0x2F216E1 VA: 0x2F215E0
	public void SetShaderPassName(int index, ShaderTagId shaderPassName) { }

	// RVA: 0x2F21770 Offset: 0x2F21871 VA: 0x2F21770 Slot: 4
	public bool Equals(DrawingSettings other) { }

	// RVA: 0x2F218C0 Offset: 0x2F219C1 VA: 0x2F218C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F21960 Offset: 0x2F21A61 VA: 0x2F21960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F219D0 Offset: 0x2F21AD1 VA: 0x2F219D0
	private static void .cctor() { }
}

