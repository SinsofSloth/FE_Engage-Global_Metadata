// Namespace: System.Runtime.Serialization
internal sealed class ObjectHolder // TypeDefIndex: 1000
{
	// Fields
	private object m_object; // 0x10
	internal long m_id; // 0x18
	private int m_missingElementsRemaining; // 0x20
	private int m_missingDecendents; // 0x24
	internal SerializationInfo m_serInfo; // 0x28
	internal ISerializationSurrogate m_surrogate; // 0x30
	internal FixupHolderList m_missingElements; // 0x38
	internal LongList m_dependentObjects; // 0x40
	internal ObjectHolder m_next; // 0x48
	internal int m_flags; // 0x50
	private bool m_markForFixupWhenAvailable; // 0x54
	private ValueTypeFixupInfo m_valueFixup; // 0x58
	private TypeLoadExceptionHolder m_typeLoad; // 0x60
	private bool m_reachable; // 0x68

	// Properties
	internal bool IsIncompleteObjectReference { get; set; }
	internal bool RequiresDelayedFixup { get; }
	internal bool RequiresValueTypeFixup { get; }
	internal bool ValueTypeFixupPerformed { get; set; }
	internal bool HasISerializable { get; }
	internal bool HasSurrogate { get; }
	internal bool CanSurrogatedObjectValueChange { get; }
	internal bool CanObjectValueChange { get; }
	internal int DirectlyDependentObjects { get; }
	internal int TotalDependentObjects { get; }
	internal bool Reachable { get; set; }
	internal bool TypeLoadExceptionReachable { get; }
	internal TypeLoadExceptionHolder TypeLoadException { get; set; }
	internal object ObjectValue { get; }
	internal SerializationInfo SerializationInfo { get; set; }
	internal ISerializationSurrogate Surrogate { get; }
	internal LongList DependentObjects { get; set; }
	internal bool RequiresSerInfoFixup { get; set; }
	internal ValueTypeFixupInfo ValueFixup { get; }
	internal bool CompletelyFixed { get; }
	internal long ContainerID { get; }

	// Methods

	// RVA: 0x3863870 Offset: 0x3863971 VA: 0x3863870
	internal void .ctor(long objID) { }

	// RVA: 0x38639E0 Offset: 0x3863AE1 VA: 0x38639E0
	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x38638B0 Offset: 0x38639B1 VA: 0x38638B0
	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x3863CC0 Offset: 0x3863DC1 VA: 0x3863CC0
	private void IncrementDescendentFixups(int amount) { }

	// RVA: 0x3863CD0 Offset: 0x3863DD1 VA: 0x3863CD0
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	// RVA: 0x3863DB0 Offset: 0x3863EB1 VA: 0x3863DB0
	internal void RemoveDependency(long id) { }

	// RVA: 0x3863DC0 Offset: 0x3863EC1 VA: 0x3863DC0
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	// RVA: 0x3863D50 Offset: 0x3863E51 VA: 0x3863D50
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	// RVA: 0x3863FB0 Offset: 0x38640B1 VA: 0x3863FB0
	internal void AddDependency(long dependentObject) { }

	// RVA: 0x3864040 Offset: 0x3864141 VA: 0x3864040
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	// RVA: 0x3864390 Offset: 0x3864491 VA: 0x3864390
	internal void MarkForCompletionWhenAvailable() { }

	// RVA: 0x3863BF0 Offset: 0x3863CF1 VA: 0x3863BF0
	internal void SetFlags() { }

	// RVA: 0x38643A0 Offset: 0x38644A1 VA: 0x38643A0
	internal bool get_IsIncompleteObjectReference() { }

	// RVA: 0x38643B0 Offset: 0x38644B1 VA: 0x38643B0
	internal void set_IsIncompleteObjectReference(bool value) { }

	// RVA: 0x38643D0 Offset: 0x38644D1 VA: 0x38643D0
	internal bool get_RequiresDelayedFixup() { }

	// RVA: 0x3863D40 Offset: 0x3863E41 VA: 0x3863D40
	internal bool get_RequiresValueTypeFixup() { }

	// RVA: 0x38643E0 Offset: 0x38644E1 VA: 0x38643E0
	internal bool get_ValueTypeFixupPerformed() { }

	// RVA: 0x3864420 Offset: 0x3864521 VA: 0x3864420
	internal void set_ValueTypeFixupPerformed(bool value) { }

	// RVA: 0x3864440 Offset: 0x3864541 VA: 0x3864440
	internal bool get_HasISerializable() { }

	// RVA: 0x3864450 Offset: 0x3864551 VA: 0x3864450
	internal bool get_HasSurrogate() { }

	// RVA: 0x3864460 Offset: 0x3864561 VA: 0x3864460
	internal bool get_CanSurrogatedObjectValueChange() { }

	// RVA: 0x3864520 Offset: 0x3864621 VA: 0x3864520
	internal bool get_CanObjectValueChange() { }

	// RVA: 0x3864540 Offset: 0x3864641 VA: 0x3864540
	internal int get_DirectlyDependentObjects() { }

	// RVA: 0x3864550 Offset: 0x3864651 VA: 0x3864550
	internal int get_TotalDependentObjects() { }

	// RVA: 0x3864560 Offset: 0x3864661 VA: 0x3864560
	internal bool get_Reachable() { }

	// RVA: 0x3864570 Offset: 0x3864671 VA: 0x3864570
	internal void set_Reachable(bool value) { }

	// RVA: 0x3864580 Offset: 0x3864681 VA: 0x3864580
	internal bool get_TypeLoadExceptionReachable() { }

	// RVA: 0x3864590 Offset: 0x3864691 VA: 0x3864590
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	// RVA: 0x38645A0 Offset: 0x38646A1 VA: 0x38645A0
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	// RVA: 0x38645B0 Offset: 0x38646B1 VA: 0x38645B0
	internal object get_ObjectValue() { }

	// RVA: 0x38642A0 Offset: 0x38643A1 VA: 0x38642A0
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	// RVA: 0x3864D00 Offset: 0x3864E01 VA: 0x3864D00
	internal SerializationInfo get_SerializationInfo() { }

	// RVA: 0x3864D10 Offset: 0x3864E11 VA: 0x3864D10
	internal void set_SerializationInfo(SerializationInfo value) { }

	// RVA: 0x3864D20 Offset: 0x3864E21 VA: 0x3864D20
	internal ISerializationSurrogate get_Surrogate() { }

	// RVA: 0x3864D30 Offset: 0x3864E31 VA: 0x3864D30
	internal LongList get_DependentObjects() { }

	// RVA: 0x3864D40 Offset: 0x3864E41 VA: 0x3864D40
	internal void set_DependentObjects(LongList value) { }

	// RVA: 0x3864D50 Offset: 0x3864E51 VA: 0x3864D50
	internal bool get_RequiresSerInfoFixup() { }

	// RVA: 0x3864D70 Offset: 0x3864E71 VA: 0x3864D70
	internal void set_RequiresSerInfoFixup(bool value) { }

	// RVA: 0x3864D90 Offset: 0x3864E91 VA: 0x3864D90
	internal ValueTypeFixupInfo get_ValueFixup() { }

	// RVA: 0x3864DA0 Offset: 0x3864EA1 VA: 0x3864DA0
	internal bool get_CompletelyFixed() { }

	// RVA: 0x3863EB0 Offset: 0x3863FB1 VA: 0x3863EB0
	internal long get_ContainerID() { }
}

