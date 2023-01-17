// Namespace: System.Xml
public abstract class XmlResolver // TypeDefIndex: 1767
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);

	// RVA: 0x33035C0 Offset: 0x33036C1 VA: 0x33035C0 Slot: 5
	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0x33037A0 Offset: 0x33038A1 VA: 0x33037A0 Slot: 6
	public virtual bool SupportsType(Uri absoluteUri, Type type) { }

	// RVA: 0x3303900 Offset: 0x3303A01 VA: 0x3303900 Slot: 7
	public virtual Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x3303940 Offset: 0x3303A41 VA: 0x3303940
	protected void .ctor() { }
}

