// Namespace: System.Xml.Schema
[DefaultMemberAttribute] // RVA: 0x47280 Offset: 0x47381 VA: 0x47280
public class XmlSchemaObjectCollection : CollectionBase // TypeDefIndex: 2018
{
	// Fields
	private XmlSchemaObject parent; // 0x18

	// Properties
	public virtual XmlSchemaObject Item { get; set; }

	// Methods

	// RVA: 0x195DF30 Offset: 0x195E031 VA: 0x195DF30
	public void .ctor() { }

	// RVA: 0x1967950 Offset: 0x1967A51 VA: 0x1967950 Slot: 28
	public virtual XmlSchemaObject get_Item(int index) { }

	// RVA: 0x1967A60 Offset: 0x1967B61 VA: 0x1967A60 Slot: 29
	public virtual void set_Item(int index, XmlSchemaObject value) { }

	// RVA: 0x1961C30 Offset: 0x1961D31 VA: 0x1961C30
	public int Add(XmlSchemaObject item) { }

	// RVA: 0x1967B30 Offset: 0x1967C31 VA: 0x1967B30
	public void Remove(XmlSchemaObject item) { }

	// RVA: 0x1967BF0 Offset: 0x1967CF1 VA: 0x1967BF0 Slot: 20
	protected override void OnInsert(int index, object item) { }

	// RVA: 0x1967C10 Offset: 0x1967D11 VA: 0x1967C10 Slot: 19
	protected override void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x1967C70 Offset: 0x1967D71 VA: 0x1967C70 Slot: 21
	protected override void OnClear() { }

	// RVA: 0x1967C90 Offset: 0x1967D91 VA: 0x1967C90 Slot: 22
	protected override void OnRemove(int index, object item) { }

	// RVA: 0x1963690 Offset: 0x1963791 VA: 0x1963690
	internal XmlSchemaObjectCollection Clone() { }

	// RVA: 0x1967CB0 Offset: 0x1967DB1 VA: 0x1967CB0
	private void Add(XmlSchemaObjectCollection collToAdd) { }
}

