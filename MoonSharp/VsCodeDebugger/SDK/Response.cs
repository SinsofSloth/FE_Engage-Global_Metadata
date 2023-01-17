// Namespace: MoonSharp.VsCodeDebugger.SDK
public class Response : ProtocolMessage // TypeDefIndex: 6300
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xF060 Offset: 0xF161 VA: 0xF060
	private bool <success>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xF070 Offset: 0xF171 VA: 0xF070
	private string <message>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xF080 Offset: 0xF181 VA: 0xF080
	private int <request_seq>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0xF090 Offset: 0xF191 VA: 0xF090
	private string <command>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xF0A0 Offset: 0xF1A1 VA: 0xF0A0
	private ResponseBody <body>k__BackingField; // 0x40

	// Properties
	public bool success { get; set; }
	public string message { get; set; }
	public int request_seq { get; set; }
	public string command { get; set; }
	public ResponseBody body { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x123C0 Offset: 0x124C1 VA: 0x123C0
	// RVA: 0x30156A0 Offset: 0x30157A1 VA: 0x30156A0
	public bool get_success() { }

	[CompilerGeneratedAttribute] // RVA: 0x123D0 Offset: 0x124D1 VA: 0x123D0
	// RVA: 0x30156B0 Offset: 0x30157B1 VA: 0x30156B0
	private void set_success(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x123E0 Offset: 0x124E1 VA: 0x123E0
	// RVA: 0x30156C0 Offset: 0x30157C1 VA: 0x30156C0
	public string get_message() { }

	[CompilerGeneratedAttribute] // RVA: 0x123F0 Offset: 0x124F1 VA: 0x123F0
	// RVA: 0x30156D0 Offset: 0x30157D1 VA: 0x30156D0
	private void set_message(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x12400 Offset: 0x12501 VA: 0x12400
	// RVA: 0x30156E0 Offset: 0x30157E1 VA: 0x30156E0
	public int get_request_seq() { }

	[CompilerGeneratedAttribute] // RVA: 0x12410 Offset: 0x12511 VA: 0x12410
	// RVA: 0x30156F0 Offset: 0x30157F1 VA: 0x30156F0
	private void set_request_seq(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x12420 Offset: 0x12521 VA: 0x12420
	// RVA: 0x3015700 Offset: 0x3015801 VA: 0x3015700
	public string get_command() { }

	[CompilerGeneratedAttribute] // RVA: 0x12430 Offset: 0x12531 VA: 0x12430
	// RVA: 0x3015710 Offset: 0x3015811 VA: 0x3015710
	private void set_command(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x12440 Offset: 0x12541 VA: 0x12440
	// RVA: 0x3015720 Offset: 0x3015821 VA: 0x3015720
	public ResponseBody get_body() { }

	[CompilerGeneratedAttribute] // RVA: 0x12450 Offset: 0x12551 VA: 0x12450
	// RVA: 0x3015730 Offset: 0x3015831 VA: 0x3015730
	private void set_body(ResponseBody value) { }

	// RVA: 0x30122E0 Offset: 0x30123E1 VA: 0x30122E0
	public void .ctor(Table req) { }

	// RVA: 0x3015740 Offset: 0x3015841 VA: 0x3015740
	public void SetBody(ResponseBody bdy) { }

	// RVA: 0x3015750 Offset: 0x3015851 VA: 0x3015750
	public void SetErrorBody(string msg, ResponseBody bdy) { }
}

