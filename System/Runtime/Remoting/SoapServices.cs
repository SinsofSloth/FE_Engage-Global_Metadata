// Namespace: System.Runtime.Remoting
[ComVisibleAttribute] // RVA: 0x474A90 Offset: 0x474B91 VA: 0x474A90
public class SoapServices // TypeDefIndex: 1113
{
	// Fields
	private static Hashtable _xmlTypes; // 0x0
	private static Hashtable _xmlElements; // 0x8
	private static Hashtable _soapActions; // 0x10
	private static Hashtable _soapActionsMethods; // 0x18
	private static Hashtable _typeInfos; // 0x20

	// Properties
	public static string XmlNsForClrTypeWithAssembly { get; }
	public static string XmlNsForClrTypeWithNs { get; }
	public static string XmlNsForClrTypeWithNsAndAssembly { get; }

	// Methods

	// RVA: 0x3829980 Offset: 0x3829A81 VA: 0x3829980
	public static string get_XmlNsForClrTypeWithAssembly() { }

	// RVA: 0x38299D0 Offset: 0x3829AD1 VA: 0x38299D0
	public static string get_XmlNsForClrTypeWithNs() { }

	// RVA: 0x3829A20 Offset: 0x3829B21 VA: 0x3829A20
	public static string get_XmlNsForClrTypeWithNsAndAssembly() { }

	// RVA: 0x3829A70 Offset: 0x3829B71 VA: 0x3829A70
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { }

	// RVA: 0x3829FD0 Offset: 0x382A0D1 VA: 0x3829FD0
	private static string GetNameKey(string name, string namspace) { }

	// RVA: 0x382A050 Offset: 0x382A151 VA: 0x382A050
	private static string GetAssemblyName(MethodBase mb) { }

	// RVA: 0x382A180 Offset: 0x382A281 VA: 0x382A180
	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace) { }

	// RVA: 0x3829740 Offset: 0x3829841 VA: 0x3829740
	public static string GetXmlNamespaceForMethodCall(MethodBase mb) { }

	// RVA: 0x38296A0 Offset: 0x38297A1 VA: 0x38296A0
	public static string GetXmlNamespaceForMethodResponse(MethodBase mb) { }

	// RVA: 0x382A2A0 Offset: 0x382A3A1 VA: 0x382A2A0
	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace) { }

	// RVA: 0x382A3B0 Offset: 0x382A4B1 VA: 0x382A3B0
	public static void PreLoad(Assembly assembly) { }

	// RVA: 0x382A490 Offset: 0x382A591 VA: 0x382A490
	public static void PreLoad(Type type) { }

	// RVA: 0x382ABA0 Offset: 0x382ACA1 VA: 0x382ABA0
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) { }

	// RVA: 0x382AA00 Offset: 0x382AB01 VA: 0x382AA00
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) { }

	// RVA: 0x3829CA0 Offset: 0x3829DA1 VA: 0x3829CA0
	private static string EncodeNs(string ns) { }

	// RVA: 0x382ADA0 Offset: 0x382AEA1 VA: 0x382ADA0
	private static void .cctor() { }
}

