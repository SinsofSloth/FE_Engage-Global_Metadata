// Namespace: System.Security.Claims
[ComVisibleAttribute] // RVA: 0x473BD0 Offset: 0x473CD1 VA: 0x473BD0
[Serializable]
public class ClaimsIdentity : IIdentity // TypeDefIndex: 899
{
	// Fields
	private byte[] m_userSerializationData; // 0x10
	private List<Claim> m_instanceClaims; // 0x18
	private Collection<IEnumerable<Claim>> m_externalClaims; // 0x20
	private string m_nameType; // 0x28
	private string m_roleType; // 0x30
	[OptionalFieldAttribute] // RVA: 0x479150 Offset: 0x479251 VA: 0x479150
	private string m_version; // 0x38
	[OptionalFieldAttribute] // RVA: 0x479190 Offset: 0x479291 VA: 0x479190
	private ClaimsIdentity m_actor; // 0x40
	[OptionalFieldAttribute] // RVA: 0x4791D0 Offset: 0x4792D1 VA: 0x4791D0
	private string m_authenticationType; // 0x48
	[OptionalFieldAttribute] // RVA: 0x479210 Offset: 0x479311 VA: 0x479210
	private object m_bootstrapContext; // 0x50
	[OptionalFieldAttribute] // RVA: 0x479250 Offset: 0x479351 VA: 0x479250
	private string m_label; // 0x58
	[OptionalFieldAttribute] // RVA: 0x479290 Offset: 0x479391 VA: 0x479290
	private string m_serializedNameType; // 0x60
	[OptionalFieldAttribute] // RVA: 0x4792D0 Offset: 0x4793D1 VA: 0x4792D0
	private string m_serializedRoleType; // 0x68
	[OptionalFieldAttribute] // RVA: 0x479310 Offset: 0x479411 VA: 0x479310
	private string m_serializedClaims; // 0x70

	// Properties
	public virtual string AuthenticationType { get; }
	public ClaimsIdentity Actor { get; set; }
	public virtual IEnumerable<Claim> Claims { get; }
	public virtual string Name { get; }

	// Methods

	// RVA: 0x33A2C90 Offset: 0x33A2D91 VA: 0x33A2C90
	public void .ctor() { }

	// RVA: 0x33A2CB0 Offset: 0x33A2DB1 VA: 0x33A2CB0
	public void .ctor(IEnumerable<Claim> claims) { }

	// RVA: 0x33A2CD0 Offset: 0x33A2DD1 VA: 0x33A2CD0
	public void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) { }

	// RVA: 0x33A2CE0 Offset: 0x33A2DE1 VA: 0x33A2CE0
	internal void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType) { }

	// RVA: 0x33A3820 Offset: 0x33A3921 VA: 0x33A3820
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x33A41A0 Offset: 0x33A42A1 VA: 0x33A41A0 Slot: 6
	public virtual string get_AuthenticationType() { }

	// RVA: 0x33A41B0 Offset: 0x33A42B1 VA: 0x33A41B0
	public ClaimsIdentity get_Actor() { }

	// RVA: 0x33A41C0 Offset: 0x33A42C1 VA: 0x33A41C0
	public void set_Actor(ClaimsIdentity value) { }

	[IteratorStateMachineAttribute] // RVA: 0x47CE70 Offset: 0x47CF71 VA: 0x47CE70
	// RVA: 0x33A4250 Offset: 0x33A4351 VA: 0x33A4250 Slot: 7
	public virtual IEnumerable<Claim> get_Claims() { }

	// RVA: 0x33A42D0 Offset: 0x33A43D1 VA: 0x33A42D0 Slot: 8
	public virtual string get_Name() { }

	// RVA: 0x33A4300 Offset: 0x33A4401 VA: 0x33A4300 Slot: 9
	public virtual ClaimsIdentity Clone() { }

	// RVA: 0x33A34B0 Offset: 0x33A35B1 VA: 0x33A34B0
	private void SafeAddClaims(IEnumerable<Claim> claims) { }

	// RVA: 0x33A3790 Offset: 0x33A3891 VA: 0x33A3790
	private void SafeAddClaim(Claim claim) { }

	// RVA: 0x33A4490 Offset: 0x33A4591 VA: 0x33A4490 Slot: 10
	public virtual Claim FindFirst(string type) { }

	[OnSerializingAttribute] // RVA: 0x47CEE0 Offset: 0x47CFE1 VA: 0x47CEE0
	// RVA: 0x33A47D0 Offset: 0x33A48D1 VA: 0x33A47D0
	private void OnSerializingMethod(StreamingContext context) { }

	[OnDeserializedAttribute] // RVA: 0x47CEF0 Offset: 0x47CFF1 VA: 0x47CEF0
	// RVA: 0x33A4AB0 Offset: 0x33A4BB1 VA: 0x33A4AB0
	private void OnDeserializedMethod(StreamingContext context) { }

	[OnDeserializingAttribute] // RVA: 0x47CF00 Offset: 0x47D001 VA: 0x47CF00
	// RVA: 0x33A4EB0 Offset: 0x33A4FB1 VA: 0x33A4EB0
	private void OnDeserializingMethod(StreamingContext context) { }

	// RVA: 0x33A4FB0 Offset: 0x33A50B1 VA: 0x33A4FB0 Slot: 11
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x33A4BC0 Offset: 0x33A4CC1 VA: 0x33A4BC0
	private void DeserializeClaims(string serializedClaims) { }

	// RVA: 0x33A4870 Offset: 0x33A4971 VA: 0x33A4870
	private string SerializeClaims() { }

	// RVA: 0x33A3480 Offset: 0x33A3581 VA: 0x33A3480
	private bool IsCircular(ClaimsIdentity subject) { }

	// RVA: 0x33A39F0 Offset: 0x33A3AF1 VA: 0x33A39F0
	private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext) { }
}

