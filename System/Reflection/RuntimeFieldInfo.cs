// Namespace: System.Reflection
internal abstract class RuntimeFieldInfo : FieldInfo, ISerializable // TypeDefIndex: 575
{
	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x322C870 Offset: 0x322C971 VA: 0x322C870
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x322C880 Offset: 0x322C981 VA: 0x322C880 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x322C9A0 Offset: 0x322CAA1 VA: 0x322C9A0
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x322CA30 Offset: 0x322CB31 VA: 0x322CA30
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x322C910 Offset: 0x322CA11 VA: 0x322C910
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x322CAC0 Offset: 0x322CBC1 VA: 0x322CAC0 Slot: 36
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x322B510 Offset: 0x322B611 VA: 0x322B510
	protected void .ctor() { }
}

