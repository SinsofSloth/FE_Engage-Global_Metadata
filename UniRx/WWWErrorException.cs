// Namespace: UniRx
public class WWWErrorException : Exception // TypeDefIndex: 6729
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x13BE0 Offset: 0x13CE1 VA: 0x13BE0
	private string <RawErrorMessage>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x13BF0 Offset: 0x13CF1 VA: 0x13BF0
	private bool <HasResponse>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x13C00 Offset: 0x13D01 VA: 0x13C00
	private string <Text>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x13C10 Offset: 0x13D11 VA: 0x13C10
	private HttpStatusCode <StatusCode>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x13C20 Offset: 0x13D21 VA: 0x13C20
	private Dictionary<string, string> <ResponseHeaders>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x13C30 Offset: 0x13D31 VA: 0x13C30
	private WWW <WWW>k__BackingField; // 0xB0

	// Properties
	public string RawErrorMessage { get; set; }
	public bool HasResponse { get; set; }
	public string Text { get; set; }
	public HttpStatusCode StatusCode { get; set; }
	public Dictionary<string, string> ResponseHeaders { get; set; }
	public WWW WWW { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x16B90 Offset: 0x16C91 VA: 0x16B90
	// RVA: 0x1AFBF20 Offset: 0x1AFC021 VA: 0x1AFBF20
	public string get_RawErrorMessage() { }

	[CompilerGeneratedAttribute] // RVA: 0x16BA0 Offset: 0x16CA1 VA: 0x16BA0
	// RVA: 0x1AFBF30 Offset: 0x1AFC031 VA: 0x1AFBF30
	private void set_RawErrorMessage(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x16BB0 Offset: 0x16CB1 VA: 0x16BB0
	// RVA: 0x1AFBF40 Offset: 0x1AFC041 VA: 0x1AFBF40
	public bool get_HasResponse() { }

	[CompilerGeneratedAttribute] // RVA: 0x16BC0 Offset: 0x16CC1 VA: 0x16BC0
	// RVA: 0x1AFBF50 Offset: 0x1AFC051 VA: 0x1AFBF50
	private void set_HasResponse(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x16BD0 Offset: 0x16CD1 VA: 0x16BD0
	// RVA: 0x1AFBF60 Offset: 0x1AFC061 VA: 0x1AFBF60
	public string get_Text() { }

	[CompilerGeneratedAttribute] // RVA: 0x16BE0 Offset: 0x16CE1 VA: 0x16BE0
	// RVA: 0x1AFBF70 Offset: 0x1AFC071 VA: 0x1AFBF70
	private void set_Text(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x16BF0 Offset: 0x16CF1 VA: 0x16BF0
	// RVA: 0x1AFBF80 Offset: 0x1AFC081 VA: 0x1AFBF80
	public HttpStatusCode get_StatusCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x16C00 Offset: 0x16D01 VA: 0x16C00
	// RVA: 0x1AFBF90 Offset: 0x1AFC091 VA: 0x1AFBF90
	private void set_StatusCode(HttpStatusCode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x16C10 Offset: 0x16D11 VA: 0x16C10
	// RVA: 0x1AFBFA0 Offset: 0x1AFC0A1 VA: 0x1AFBFA0
	public Dictionary<string, string> get_ResponseHeaders() { }

	[CompilerGeneratedAttribute] // RVA: 0x16C20 Offset: 0x16D21 VA: 0x16C20
	// RVA: 0x1AFBFB0 Offset: 0x1AFC0B1 VA: 0x1AFBFB0
	private void set_ResponseHeaders(Dictionary<string, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x16C30 Offset: 0x16D31 VA: 0x16C30
	// RVA: 0x1AFBFC0 Offset: 0x1AFC0C1 VA: 0x1AFBFC0
	public WWW get_WWW() { }

	[CompilerGeneratedAttribute] // RVA: 0x16C40 Offset: 0x16D41 VA: 0x16C40
	// RVA: 0x1AFBFD0 Offset: 0x1AFC0D1 VA: 0x1AFBFD0
	private void set_WWW(WWW value) { }

	// RVA: 0x1AFBFE0 Offset: 0x1AFC0E1 VA: 0x1AFBFE0
	public void .ctor(WWW www, string text) { }

	// RVA: 0x1AFC160 Offset: 0x1AFC261 VA: 0x1AFC160 Slot: 3
	public override string ToString() { }
}

