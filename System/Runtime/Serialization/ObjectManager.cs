// Namespace: System.Runtime.Serialization
[ComVisibleAttribute] // RVA: 0x474590 Offset: 0x474691 VA: 0x474590
public class ObjectManager // TypeDefIndex: 999
{
	// Fields
	private DeserializationEventHandler m_onDeserializationHandler; // 0x10
	private SerializationEventHandler m_onDeserializedHandler; // 0x18
	internal ObjectHolder[] m_objects; // 0x20
	internal object m_topObject; // 0x28
	internal ObjectHolderList m_specialFixupObjects; // 0x30
	internal long m_fixupCount; // 0x38
	internal ISurrogateSelector m_selector; // 0x40
	internal StreamingContext m_context; // 0x48

	// Properties
	internal object TopObject { get; set; }
	internal ObjectHolderList SpecialFixupObjects { get; }

	// Methods

	// RVA: 0x3865DA0 Offset: 0x3865EA1 VA: 0x3865DA0
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain) { }

	// RVA: 0x3865E40 Offset: 0x3865F41 VA: 0x3865E40
	private bool CanCallGetType(object obj) { }

	// RVA: 0x3865E50 Offset: 0x3865F51 VA: 0x3865E50
	internal void set_TopObject(object value) { }

	// RVA: 0x3865E60 Offset: 0x3865F61 VA: 0x3865E60
	internal object get_TopObject() { }

	// RVA: 0x3865E70 Offset: 0x3865F71 VA: 0x3865E70
	internal ObjectHolderList get_SpecialFixupObjects() { }

	// RVA: 0x3865F50 Offset: 0x3866051 VA: 0x3865F50
	internal ObjectHolder FindObjectHolder(long objectID) { }

	// RVA: 0x3863ED0 Offset: 0x3863FD1 VA: 0x3863ED0
	internal ObjectHolder FindOrCreateObjectHolder(long objectID) { }

	// RVA: 0x3865FB0 Offset: 0x38660B1 VA: 0x3865FB0
	private void AddObjectHolder(ObjectHolder holder) { }

	// RVA: 0x3866100 Offset: 0x3866201 VA: 0x3866100
	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing) { }

	// RVA: 0x38663F0 Offset: 0x38664F1 VA: 0x38663F0
	private void FixupSpecialObject(ObjectHolder holder) { }

	// RVA: 0x38670A0 Offset: 0x38671A1 VA: 0x38670A0
	private bool ResolveObjectReference(ObjectHolder holder) { }

	// RVA: 0x3866970 Offset: 0x3866A71 VA: 0x3866970
	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value) { }

	// RVA: 0x38645C0 Offset: 0x38646C1 VA: 0x38645C0
	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete) { }

	// RVA: 0x3866F50 Offset: 0x3867051 VA: 0x3866F50
	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder) { }

	// RVA: 0x3867450 Offset: 0x3867551 VA: 0x3867450 Slot: 4
	public virtual object GetObject(long objectID) { }

	// RVA: 0x3867550 Offset: 0x3867651 VA: 0x3867550
	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member) { }

	// RVA: 0x3867650 Offset: 0x3867751 VA: 0x3867650
	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex) { }

	// RVA: 0x38666F0 Offset: 0x38667F1 VA: 0x38666F0
	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3867C50 Offset: 0x3867D51 VA: 0x3867C50
	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t) { }

	// RVA: 0x3867D80 Offset: 0x3867E81 VA: 0x3867D80 Slot: 5
	public virtual void DoFixups() { }

	// RVA: 0x3868180 Offset: 0x3868281 VA: 0x3868180
	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired) { }

	// RVA: 0x38682B0 Offset: 0x38683B1 VA: 0x38682B0 Slot: 6
	public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired) { }

	// RVA: 0x3868530 Offset: 0x3868631 VA: 0x3868530 Slot: 7
	public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) { }

	// RVA: 0x3868690 Offset: 0x3868791 VA: 0x3868690 Slot: 8
	public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired) { }

	// RVA: 0x38687F0 Offset: 0x38688F1 VA: 0x38687F0 Slot: 9
	public virtual void RaiseDeserializationEvent() { }

	// RVA: 0x3868840 Offset: 0x3868941 VA: 0x3868840 Slot: 10
	internal virtual void AddOnDeserialization(DeserializationEventHandler handler) { }

	// RVA: 0x38688D0 Offset: 0x38689D1 VA: 0x38688D0 Slot: 11
	internal virtual void AddOnDeserialized(object obj) { }

	// RVA: 0x3868970 Offset: 0x3868A71 VA: 0x3868970 Slot: 12
	internal virtual void RaiseOnDeserializedEvent(object obj) { }

	// RVA: 0x3868A00 Offset: 0x3868B01 VA: 0x3868A00
	public void RaiseOnDeserializingEvent(object obj) { }
}

