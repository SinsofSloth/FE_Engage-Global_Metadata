// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x4742A0 Offset: 0x4743A1 VA: 0x4742A0
public class SignatureDescription // TypeDefIndex: 955
{
	// Fields
	private string _strKey; // 0x10
	private string _strDigest; // 0x18
	private string _strFormatter; // 0x20
	private string _strDeformatter; // 0x28

	// Properties
	public string KeyAlgorithm { set; }
	public string DigestAlgorithm { set; }
	public string FormatterAlgorithm { set; }
	public string DeformatterAlgorithm { set; }

	// Methods

	// RVA: 0x361CA70 Offset: 0x361CB71 VA: 0x361CA70
	public void .ctor() { }

	// RVA: 0x361CA80 Offset: 0x361CB81 VA: 0x361CA80
	public void set_KeyAlgorithm(string value) { }

	// RVA: 0x361CA90 Offset: 0x361CB91 VA: 0x361CA90
	public void set_DigestAlgorithm(string value) { }

	// RVA: 0x361CAA0 Offset: 0x361CBA1 VA: 0x361CAA0
	public void set_FormatterAlgorithm(string value) { }

	// RVA: 0x361CAB0 Offset: 0x361CBB1 VA: 0x361CAB0
	public void set_DeformatterAlgorithm(string value) { }
}

