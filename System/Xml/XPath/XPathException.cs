// Namespace: System.Xml.XPath
[Serializable]
public class XPathException : SystemException // TypeDefIndex: 1772
{
	// Fields
	private string res; // 0x88
	private string[] args; // 0x90
	private string message; // 0x98

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x19BD8D0 Offset: 0x19BD9D1 VA: 0x19BD8D0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19BDC80 Offset: 0x19BDD81 VA: 0x19BDC80 Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19BDD80 Offset: 0x19BDE81 VA: 0x19BDD80
	public void .ctor() { }

	// RVA: 0x19BDDE0 Offset: 0x19BDEE1 VA: 0x19BDDE0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x19BDF80 Offset: 0x19BE081 VA: 0x19BDF80
	internal static XPathException Create(string res) { }

	// RVA: 0x19BE0B0 Offset: 0x19BE1B1 VA: 0x19BE0B0
	internal static XPathException Create(string res, string arg) { }

	// RVA: 0x19BE1D0 Offset: 0x19BE2D1 VA: 0x19BE1D0
	internal static XPathException Create(string res, string arg, string arg2) { }

	// RVA: 0x19BE030 Offset: 0x19BE131 VA: 0x19BE030
	private void .ctor(string res, string[] args) { }

	// RVA: 0x19BDF00 Offset: 0x19BE001 VA: 0x19BDF00
	private void .ctor(string res, string[] args, Exception inner) { }

	// RVA: 0x19BDB40 Offset: 0x19BDC41 VA: 0x19BDB40
	private static string CreateMessage(string res, string[] args) { }

	// RVA: 0x19BE330 Offset: 0x19BE431 VA: 0x19BE330 Slot: 5
	public override string get_Message() { }
}

