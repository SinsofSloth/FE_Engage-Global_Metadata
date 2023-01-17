// Namespace: System.Reflection
internal abstract class RuntimeEventInfo : EventInfo, ISerializable // TypeDefIndex: 573
{
	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x322C000 Offset: 0x322C101 VA: 0x322C000
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x322C010 Offset: 0x322C111 VA: 0x322C010 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x322C130 Offset: 0x322C231 VA: 0x322C130
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x322C1C0 Offset: 0x322C2C1 VA: 0x322C1C0
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x322C0A0 Offset: 0x322C1A1 VA: 0x322C0A0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x322C260 Offset: 0x322C361 VA: 0x322C260 Slot: 22
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x322C370 Offset: 0x322C471 VA: 0x322C370
	protected void .ctor() { }
}

