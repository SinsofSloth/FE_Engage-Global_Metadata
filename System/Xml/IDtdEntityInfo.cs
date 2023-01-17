// Namespace: System.Xml
internal interface IDtdEntityInfo // TypeDefIndex: 1637
{
	// Properties
	public abstract string Name { get; }
	public abstract bool IsExternal { get; }
	public abstract bool IsDeclaredInExternal { get; }
	public abstract bool IsUnparsedEntity { get; }
	public abstract bool IsParameterEntity { get; }
	public abstract string BaseUriString { get; }
	public abstract string DeclaredUriString { get; }
	public abstract string SystemId { get; }
	public abstract string PublicId { get; }
	public abstract string Text { get; }
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsExternal();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsDeclaredInExternal();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsUnparsedEntity();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsParameterEntity();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_BaseUriString();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_DeclaredUriString();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_SystemId();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_PublicId();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_Text();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_LinePosition();
}

