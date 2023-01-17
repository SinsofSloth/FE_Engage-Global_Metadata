// Namespace: CustomRP
public class MaterialUtils // TypeDefIndex: 8893
{
	// Fields
	private static MaterialUtils s_Instance; // 0x0
	private readonly string DitherAlphaKeyword; // 0x10
	private readonly string DitherAlphaKeyProp; // 0x18
	private readonly string DitherAlphaValueProp; // 0x20
	private int m_DitherAlphaKeyProp; // 0x28
	private int m_DitherAlphaValueProp; // 0x2C

	// Properties
	public static MaterialUtils Instance { get; }

	// Methods

	// RVA: 0x285EBD0 Offset: 0x285ECD1 VA: 0x285EBD0
	public static MaterialUtils get_Instance() { }

	// RVA: 0x285ECB0 Offset: 0x285EDB1 VA: 0x285ECB0
	private void .ctor() { }

	// RVA: 0x285ED90 Offset: 0x285EE91 VA: 0x285ED90
	public void EnableDitherAlpha(Material mat) { }

	// RVA: 0x285EE60 Offset: 0x285EF61 VA: 0x285EE60
	public void EnableDitherAlphaWithAutoQueue(Material mat) { }

	// RVA: 0x285EF10 Offset: 0x285F011 VA: 0x285EF10
	public void EnableDitherAlphaWithQueue(Material mat, int customQueue) { }

	// RVA: 0x285EDF0 Offset: 0x285EEF1 VA: 0x285EDF0
	private bool InternalEnableDitherAlpha(Material mat) { }

	// RVA: 0x285EF90 Offset: 0x285F091 VA: 0x285EF90
	public void DisableDitherAlpha(Material mat) { }

	// RVA: 0x285F060 Offset: 0x285F161 VA: 0x285F060
	public void DisableDitherAlphaWithAutoQueue(Material mat) { }

	// RVA: 0x285F0D0 Offset: 0x285F1D1 VA: 0x285F0D0
	public void DisableDitherAlphaWithQueue(Material mat, int customQueue) { }

	// RVA: 0x285EFF0 Offset: 0x285F0F1 VA: 0x285EFF0
	private bool InternalDisableDitherAlpha(Material mat) { }

	// RVA: 0x285F150 Offset: 0x285F251 VA: 0x285F150
	public bool IsDitherAlphaEnabled(Material mat) { }

	// RVA: 0x285F1A0 Offset: 0x285F2A1 VA: 0x285F1A0
	public void SetDitherAlphaValue(Material mat, float alpha) { }

	// RVA: 0x285F1C0 Offset: 0x285F2C1 VA: 0x285F1C0
	public void EnableDitherAlpha(Material[] mats) { }

	// RVA: 0x285F360 Offset: 0x285F461 VA: 0x285F360
	public void EnableDitherAlpha(List<Material> mats) { }

	// RVA: 0x285F520 Offset: 0x285F621 VA: 0x285F520
	public void DisableDitherAlpha(Material[] mats) { }

	// RVA: 0x285F6C0 Offset: 0x285F7C1 VA: 0x285F6C0
	public void DisableDitherAlpha(List<Material> mats) { }

	// RVA: 0x285F880 Offset: 0x285F981 VA: 0x285F880
	public void EnableDitherAlphaWithAutoQueue(Material[] mats) { }

	// RVA: 0x285F9D0 Offset: 0x285FAD1 VA: 0x285F9D0
	public void DisableDitherAlphaWithAutoQueue(List<Material> mats) { }

	// RVA: 0x285FBA0 Offset: 0x285FCA1 VA: 0x285FBA0
	public void SetDitherAlphaValue(Material[] mats, float alpha) { }

	// RVA: 0x285FD10 Offset: 0x285FE11 VA: 0x285FD10
	public void SetDitherAlphaValue(List<Material> mats, float alpha) { }

	// RVA: 0x285FEB0 Offset: 0x285FFB1 VA: 0x285FEB0
	public bool HasDitherProperty(Material mat) { }

	// RVA: 0x285FED0 Offset: 0x285FFD1 VA: 0x285FED0
	public bool HasDitherProperty(Material[] mats) { }

	// RVA: 0x2860040 Offset: 0x2860141 VA: 0x2860040
	public bool HasDitherProperty(List<Material> mats) { }

	// RVA: 0x28601E0 Offset: 0x28602E1 VA: 0x28601E0
	public void SetParticleAlpha(Material[] materials, float alpha) { }

	// RVA: 0x2860350 Offset: 0x2860451 VA: 0x2860350
	public void SetParticleAlpha(List<Material> materials, float alpha) { }

	// RVA: 0x2860260 Offset: 0x2860361 VA: 0x2860260
	public void SetParticleAlpha(Material material, float alpha) { }

	// RVA: 0x2860460 Offset: 0x2860561 VA: 0x2860460
	private static void .cctor() { }
}

