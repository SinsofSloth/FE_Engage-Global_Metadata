// Namespace: System.Reflection
internal abstract class RuntimePropertyInfo : PropertyInfo, ISerializable // TypeDefIndex: 589
{
	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x322E1B0 Offset: 0x322E2B1 VA: 0x322E1B0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x322E1C0 Offset: 0x322E2C1 VA: 0x322E1C0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x322E2E0 Offset: 0x322E3E1 VA: 0x322E2E0
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x322E370 Offset: 0x322E471 VA: 0x322E370
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x322E250 Offset: 0x322E351 VA: 0x322E250
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x322E400 Offset: 0x322E501 VA: 0x322E400 Slot: 3
	public override string ToString() { }

	// RVA: 0x322E410 Offset: 0x322E511 VA: 0x322E410
	private string FormatNameAndSig(bool serialization) { }

	// RVA: 0x322E580 Offset: 0x322E681 VA: 0x322E580 Slot: 34
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x322E6C0 Offset: 0x322E7C1 VA: 0x322E6C0
	internal string SerializationToString() { }

	// RVA: 0x322E6D0 Offset: 0x322E7D1 VA: 0x322E6D0
	protected void .ctor() { }
}

