// Namespace: System.Runtime.Remoting.Metadata
[ComVisibleAttribute] // RVA: 0x474F80 Offset: 0x475081 VA: 0x474F80
public class SoapAttribute : Attribute // TypeDefIndex: 1172
{
	// Fields
	private bool _useAttribute; // 0x10
	protected string ProtXmlNamespace; // 0x18
	protected object ReflectInfo; // 0x20

	// Properties
	public virtual bool UseAttribute { get; }
	public virtual string XmlNamespace { get; }

	// Methods

	// RVA: 0x38291B0 Offset: 0x38292B1 VA: 0x38291B0
	public void .ctor() { }

	// RVA: 0x38291C0 Offset: 0x38292C1 VA: 0x38291C0 Slot: 4
	public virtual bool get_UseAttribute() { }

	// RVA: 0x38291D0 Offset: 0x38292D1 VA: 0x38291D0 Slot: 5
	public virtual string get_XmlNamespace() { }

	// RVA: 0x38291E0 Offset: 0x38292E1 VA: 0x38291E0 Slot: 6
	internal virtual void SetReflectionObject(object reflectionObject) { }
}

