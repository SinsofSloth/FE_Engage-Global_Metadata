// Namespace: System
[ComVisibleAttribute] // RVA: 0x46FDC0 Offset: 0x46FEC1 VA: 0x46FDC0
[AttributeUsageAttribute] // RVA: 0x46FDC0 Offset: 0x46FEC1 VA: 0x46FDC0
[Serializable]
public sealed class AttributeUsageAttribute : Attribute // TypeDefIndex: 175
{
	// Fields
	internal AttributeTargets m_attributeTarget; // 0x10
	internal bool m_allowMultiple; // 0x14
	internal bool m_inherited; // 0x15
	internal static AttributeUsageAttribute Default; // 0x0

	// Properties
	public bool AllowMultiple { get; set; }
	public bool Inherited { get; set; }

	// Methods

	// RVA: 0x356C7B0 Offset: 0x356C8B1 VA: 0x356C7B0
	public void .ctor(AttributeTargets validOn) { }

	// RVA: 0x356C7F0 Offset: 0x356C8F1 VA: 0x356C7F0
	public bool get_AllowMultiple() { }

	// RVA: 0x356C800 Offset: 0x356C901 VA: 0x356C800
	public void set_AllowMultiple(bool value) { }

	// RVA: 0x356C810 Offset: 0x356C911 VA: 0x356C810
	public bool get_Inherited() { }

	// RVA: 0x356C820 Offset: 0x356C921 VA: 0x356C820
	public void set_Inherited(bool value) { }

	// RVA: 0x356C830 Offset: 0x356C931 VA: 0x356C830
	private static void .cctor() { }
}

