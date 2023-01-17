// Namespace: System.Security.Claims
[Serializable]
public class Claim // TypeDefIndex: 897
{
	// Fields
	private string m_issuer; // 0x10
	private string m_originalIssuer; // 0x18
	private string m_type; // 0x20
	private string m_value; // 0x28
	private string m_valueType; // 0x30
	private byte[] m_userSerializationData; // 0x38
	private Dictionary<string, string> m_properties; // 0x40
	private object m_propertyLock; // 0x48
	private ClaimsIdentity m_subject; // 0x50

	// Properties
	public IDictionary<string, string> Properties { get; }
	public ClaimsIdentity Subject { get; set; }
	public string Type { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x33A23B0 Offset: 0x33A24B1 VA: 0x33A23B0
	public void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject) { }

	// RVA: 0x33A23E0 Offset: 0x33A24E1 VA: 0x33A23E0
	internal void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue) { }

	// RVA: 0x33A27D0 Offset: 0x33A28D1 VA: 0x33A27D0
	protected void .ctor(Claim other, ClaimsIdentity subject) { }

	[OnDeserializedAttribute] // RVA: 0x47CE60 Offset: 0x47CF61 VA: 0x47CE60
	// RVA: 0x33A2AE0 Offset: 0x33A2BE1 VA: 0x33A2AE0
	private void OnDeserializedMethod(StreamingContext context) { }

	// RVA: 0x33A2680 Offset: 0x33A2781 VA: 0x33A2680
	public IDictionary<string, string> get_Properties() { }

	// RVA: 0x33A2B50 Offset: 0x33A2C51 VA: 0x33A2B50
	public ClaimsIdentity get_Subject() { }

	// RVA: 0x33A2B60 Offset: 0x33A2C61 VA: 0x33A2B60
	internal void set_Subject(ClaimsIdentity value) { }

	// RVA: 0x33A2B70 Offset: 0x33A2C71 VA: 0x33A2B70
	public string get_Type() { }

	// RVA: 0x33A2B80 Offset: 0x33A2C81 VA: 0x33A2B80
	public string get_Value() { }

	// RVA: 0x33A2B90 Offset: 0x33A2C91 VA: 0x33A2B90 Slot: 4
	public virtual Claim Clone(ClaimsIdentity identity) { }

	// RVA: 0x33A2C00 Offset: 0x33A2D01 VA: 0x33A2C00 Slot: 3
	public override string ToString() { }
}

