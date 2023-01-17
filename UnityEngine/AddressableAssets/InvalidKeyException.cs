// Namespace: UnityEngine.AddressableAssets
public class InvalidKeyException : Exception // TypeDefIndex: 7252
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x655A0 Offset: 0x656A1 VA: 0x655A0
	private object <Key>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x655B0 Offset: 0x656B1 VA: 0x655B0
	private Type <Type>k__BackingField; // 0x90

	// Properties
	public object Key { get; set; }
	public Type Type { get; set; }
	public override string Message { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x65E90 Offset: 0x65F91 VA: 0x65E90
	// RVA: 0x309DAD0 Offset: 0x309DBD1 VA: 0x309DAD0
	public object get_Key() { }

	[CompilerGeneratedAttribute] // RVA: 0x65EA0 Offset: 0x65FA1 VA: 0x65EA0
	// RVA: 0x309DAE0 Offset: 0x309DBE1 VA: 0x309DAE0
	private void set_Key(object value) { }

	[CompilerGeneratedAttribute] // RVA: 0x65EB0 Offset: 0x65FB1 VA: 0x65EB0
	// RVA: 0x309DAF0 Offset: 0x309DBF1 VA: 0x309DAF0
	public Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x65EC0 Offset: 0x65FC1 VA: 0x65EC0
	// RVA: 0x309DB00 Offset: 0x309DC01 VA: 0x309DB00
	private void set_Type(Type value) { }

	// RVA: 0x309DB10 Offset: 0x309DC11 VA: 0x309DB10
	public void .ctor(object key) { }

	// RVA: 0x3090B10 Offset: 0x3090C11 VA: 0x3090B10
	public void .ctor(object key, Type type) { }

	// RVA: 0x309DC10 Offset: 0x309DD11 VA: 0x309DC10
	public void .ctor() { }

	// RVA: 0x309DC80 Offset: 0x309DD81 VA: 0x309DC80
	public void .ctor(string message) { }

	// RVA: 0x309DD00 Offset: 0x309DE01 VA: 0x309DD00
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x309DD90 Offset: 0x309DE91 VA: 0x309DD90
	protected void .ctor(SerializationInfo message, StreamingContext context) { }

	// RVA: 0x309DE20 Offset: 0x309DF21 VA: 0x309DE20 Slot: 5
	public override string get_Message() { }
}

