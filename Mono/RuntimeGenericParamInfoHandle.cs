// Namespace: Mono
internal struct RuntimeGenericParamInfoHandle // TypeDefIndex: 6
{
	// Fields
	private RuntimeStructs.GenericParamInfo* value; // 0x0

	// Properties
	internal Type[] Constraints { get; }
	internal GenericParameterAttributes Attributes { get; }

	// Methods

	// RVA: 0x322CD40 Offset: 0x322CE41 VA: 0x322CD40
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x322CD70 Offset: 0x322CE71 VA: 0x322CD70
	internal Type[] get_Constraints() { }

	// RVA: 0x322CF00 Offset: 0x322D001 VA: 0x322CF00
	internal GenericParameterAttributes get_Attributes() { }

	// RVA: 0x322CD80 Offset: 0x322CE81 VA: 0x322CD80
	private Type[] GetConstraints() { }

	// RVA: 0x322CF10 Offset: 0x322D011 VA: 0x322CF10
	private int GetConstraintsCount() { }
}

