// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class WriteObjectInfo // TypeDefIndex: 1069
{
	// Fields
	internal int objectInfoId; // 0x10
	internal object obj; // 0x18
	internal Type objectType; // 0x20
	internal bool isSi; // 0x28
	internal bool isNamed; // 0x29
	internal bool isTyped; // 0x2A
	internal bool isArray; // 0x2B
	internal SerializationInfo si; // 0x30
	internal SerObjectInfoCache cache; // 0x38
	internal object[] memberData; // 0x40
	internal ISerializationSurrogate serializationSurrogate; // 0x48
	internal StreamingContext context; // 0x50
	internal SerObjectInfoInit serObjectInfoInit; // 0x60
	internal long objectId; // 0x68
	internal long assemId; // 0x70
	private string binderTypeName; // 0x78
	private string binderAssemblyString; // 0x80

	// Methods

	// RVA: 0x34D4070 Offset: 0x34D4171 VA: 0x34D4070
	internal void .ctor() { }

	// RVA: 0x34D4080 Offset: 0x34D4181 VA: 0x34D4080
	internal void ObjectEnd() { }

	// RVA: 0x34D40B0 Offset: 0x34D41B1 VA: 0x34D40B0
	private void InternalInit() { }

	// RVA: 0x34D4140 Offset: 0x34D4241 VA: 0x34D4140
	internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x34D4310 Offset: 0x34D4411 VA: 0x34D4310
	internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x34D50F0 Offset: 0x34D51F1 VA: 0x34D50F0
	internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x34D5180 Offset: 0x34D5281 VA: 0x34D5180
	internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x34D4930 Offset: 0x34D4A31 VA: 0x34D4930
	private void InitSiWrite() { }

	// RVA: 0x34D4C80 Offset: 0x34D4D81 VA: 0x34D4C80
	private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString) { }

	// RVA: 0x34D4800 Offset: 0x34D4901 VA: 0x34D4800
	private void InitNoMembers() { }

	// RVA: 0x34D4DE0 Offset: 0x34D4EE1 VA: 0x34D4DE0
	private void InitMemberInfo() { }

	// RVA: 0x34D5650 Offset: 0x34D5751 VA: 0x34D5650
	internal string GetTypeFullName() { }

	// RVA: 0x34D5670 Offset: 0x34D5771 VA: 0x34D5670
	internal string GetAssemblyString() { }

	// RVA: 0x34D4900 Offset: 0x34D4A01 VA: 0x34D4900
	private void InvokeSerializationBinder(SerializationBinder binder) { }

	// RVA: 0x34D54E0 Offset: 0x34D55E1 VA: 0x34D54E0
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x34D5690 Offset: 0x34D5791 VA: 0x34D5690
	internal void GetMemberInfo(out string[] outMemberNames, out Type[] outMemberTypes, out object[] outMemberData) { }

	// RVA: 0x34D41E0 Offset: 0x34D42E1 VA: 0x34D41E0
	private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

	// RVA: 0x34D40A0 Offset: 0x34D41A1 VA: 0x34D40A0
	private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo) { }
}

