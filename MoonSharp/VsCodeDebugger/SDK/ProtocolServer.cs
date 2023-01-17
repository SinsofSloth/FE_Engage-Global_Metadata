// Namespace: MoonSharp.VsCodeDebugger.SDK
public abstract class ProtocolServer // TypeDefIndex: 6302
{
	// Fields
	public bool TRACE; // 0x10
	public bool TRACE_RESPONSE; // 0x11
	protected const int BUFFER_SIZE = 4096;
	protected const string TWO_CRLF = "\r\n\r\n";
	protected static readonly Regex CONTENT_LENGTH_MATCHER; // 0x0
	protected static readonly Encoding Encoding; // 0x8
	private int _sequenceNumber; // 0x14
	private Stream _outputStream; // 0x18
	private ByteBuffer _rawData; // 0x20
	private int _bodyLength; // 0x28
	private bool _stopRequested; // 0x2C

	// Methods

	// RVA: 0x30118A0 Offset: 0x30119A1 VA: 0x30118A0
	public void .ctor() { }

	// RVA: 0x3011930 Offset: 0x3011A31 VA: 0x3011930
	public void ProcessLoop(Stream inputStream, Stream outputStream) { }

	// RVA: 0x3011C50 Offset: 0x3011D51 VA: 0x3011C50
	public void Stop() { }

	// RVA: 0x3011C60 Offset: 0x3011D61 VA: 0x3011C60
	public void SendEvent(Event e) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void DispatchRequest(string command, Table args, Response response);

	// RVA: 0x3011A10 Offset: 0x3011B11 VA: 0x3011A10
	private void ProcessData() { }

	// RVA: 0x3011FC0 Offset: 0x30120C1 VA: 0x3011FC0
	private void Dispatch(string req) { }

	// RVA: 0x3011C70 Offset: 0x3011D71 VA: 0x3011C70
	protected void SendMessage(ProtocolMessage message) { }

	// RVA: 0x3012540 Offset: 0x3012641 VA: 0x3012540
	private static byte[] ConvertToBytes(ProtocolMessage request) { }

	// RVA: 0x30126E0 Offset: 0x30127E1 VA: 0x30126E0
	private static void .cctor() { }
}

