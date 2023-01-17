// Namespace: 
internal struct RuntimeStructs.RemoteClass // TypeDefIndex: 11
{
	// Fields
	internal IntPtr default_vtable; // 0x0
	internal IntPtr xdomain_vtable; // 0x8
	internal RuntimeStructs.MonoClass* proxy_class; // 0x10
	internal IntPtr proxy_class_name; // 0x18
	internal uint interface_count; // 0x20
}

// Namespace: 
internal struct RuntimeStructs.MonoClass // TypeDefIndex: 12
{}

// Namespace: 
internal struct RuntimeStructs.GenericParamInfo // TypeDefIndex: 13
{
	// Fields
	internal RuntimeStructs.MonoClass* pklass; // 0x0
	internal IntPtr name; // 0x8
	internal ushort flags; // 0x10
	internal uint token; // 0x14
	internal RuntimeStructs.MonoClass** constraints; // 0x18
}

// Namespace: 
internal struct RuntimeStructs.GPtrArray // TypeDefIndex: 14
{
	// Fields
	internal IntPtr* data; // 0x0
	internal int len; // 0x8
}

// Namespace: 
private struct RuntimeStructs.HandleStackMark // TypeDefIndex: 15
{
	// Fields
	private int size; // 0x0
	private int interior_size; // 0x4
	private IntPtr chunk; // 0x8
}

// Namespace: 
private struct RuntimeStructs.MonoError // TypeDefIndex: 16
{
	// Fields
	private ushort error_code; // 0x0
	private ushort hidden_0; // 0x2
	private IntPtr hidden_1; // 0x8
	private IntPtr hidden_2; // 0x10
	private IntPtr hidden_3; // 0x18
	private IntPtr hidden_4; // 0x20
	private IntPtr hidden_5; // 0x28
	private IntPtr hidden_6; // 0x30
	private IntPtr hidden_7; // 0x38
	private IntPtr hidden_8; // 0x40
	private IntPtr hidden_11; // 0x48
	private IntPtr hidden_12; // 0x50
	private IntPtr hidden_13; // 0x58
	private IntPtr hidden_14; // 0x60
	private IntPtr hidden_15; // 0x68
	private IntPtr hidden_16; // 0x70
	private IntPtr hidden_17; // 0x78
	private IntPtr hidden_18; // 0x80
}

