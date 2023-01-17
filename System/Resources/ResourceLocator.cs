// Namespace: System.Resources
internal struct ResourceLocator // TypeDefIndex: 493
{
	// Fields
	internal object _value; // 0x0
	internal int _dataPos; // 0x8

	// Properties
	internal int DataPosition { get; }
	internal object Value { get; set; }

	// Methods

	// RVA: 0x3222730 Offset: 0x3222831 VA: 0x3222730
	internal void .ctor(int dataPos, object value) { }

	// RVA: 0x3222740 Offset: 0x3222841 VA: 0x3222740
	internal int get_DataPosition() { }

	// RVA: 0x3222750 Offset: 0x3222851 VA: 0x3222750
	internal object get_Value() { }

	// RVA: 0x3222760 Offset: 0x3222861 VA: 0x3222760
	internal void set_Value(object value) { }

	// RVA: 0x3222770 Offset: 0x3222871 VA: 0x3222770
	internal static bool CanCache(ResourceTypeCode value) { }
}

