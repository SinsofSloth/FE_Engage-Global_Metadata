// Namespace: System.Reflection
internal abstract class RuntimeConstructorInfo : ConstructorInfo, ISerializable // TypeDefIndex: 581
{
	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x322B9D0 Offset: 0x322BAD1 VA: 0x322B9D0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x322BA60 Offset: 0x322BB61 VA: 0x322BA60
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x322BAF0 Offset: 0x322BBF1 VA: 0x322BAF0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x322BB00 Offset: 0x322BC01 VA: 0x322BB00
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x322BB90 Offset: 0x322BC91 VA: 0x322BB90 Slot: 45
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x322BCE0 Offset: 0x322BDE1 VA: 0x322BCE0
	internal string SerializationToString() { }

	// RVA: 0x322BD00 Offset: 0x322BE01 VA: 0x322BD00
	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x322BE40 Offset: 0x322BF41 VA: 0x322BE40
	protected void .ctor() { }
}

