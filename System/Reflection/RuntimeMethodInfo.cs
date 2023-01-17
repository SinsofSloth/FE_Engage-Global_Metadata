// Namespace: System.Reflection
internal abstract class RuntimeMethodInfo : MethodInfo, ISerializable // TypeDefIndex: 579
{
	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x322D930 Offset: 0x322DA31 VA: 0x322D930
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x322D940 Offset: 0x322DA41 VA: 0x322D940 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x322DA60 Offset: 0x322DB61 VA: 0x322DA60
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x322DAF0 Offset: 0x322DBF1 VA: 0x322DAF0 Slot: 40
	internal override string FormatNameAndSig(bool serialization) { }

	// RVA: 0x322DC40 Offset: 0x322DD41 VA: 0x322DC40 Slot: 47
	public override Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x322DC60 Offset: 0x322DD61 VA: 0x322DC60 Slot: 48
	public override Delegate CreateDelegate(Type delegateType, object target) { }

	// RVA: 0x322DC80 Offset: 0x322DD81 VA: 0x322DC80 Slot: 3
	public override string ToString() { }

	// RVA: 0x322D9D0 Offset: 0x322DAD1 VA: 0x322D9D0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x322DD20 Offset: 0x322DE21 VA: 0x322DD20 Slot: 50
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x322DF30 Offset: 0x322E031 VA: 0x322DF30
	internal string SerializationToString() { }

	// RVA: 0x322DFD0 Offset: 0x322E0D1 VA: 0x322DFD0
	protected void .ctor() { }
}

