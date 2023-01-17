// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x473F40 Offset: 0x474041 VA: 0x473F40
public class HMACSHA1 : HMAC // TypeDefIndex: 926
{
	// Methods

	// RVA: 0x38BDFA0 Offset: 0x38BE0A1 VA: 0x38BDFA0
	public void .ctor() { }

	// RVA: 0x38BE9E0 Offset: 0x38BEAE1 VA: 0x38BE9E0
	public void .ctor(byte[] key) { }

	// RVA: 0x38BE9F0 Offset: 0x38BEAF1 VA: 0x38BE9F0
	public void .ctor(byte[] key, bool useManagedSha1) { }
}

// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x473F60 Offset: 0x474061 VA: 0x473F60
public class HMACSHA256 : HMAC // TypeDefIndex: 927
{
	// Methods

	// RVA: 0x38BEAE0 Offset: 0x38BEBE1 VA: 0x38BEAE0
	public void .ctor() { }

	// RVA: 0x38BEB10 Offset: 0x38BEC11 VA: 0x38BEB10
	public void .ctor(byte[] key) { }
}

// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x473F80 Offset: 0x474081 VA: 0x473F80
public class HMACSHA384 : HMAC // TypeDefIndex: 928
{
	// Fields
	private bool m_useLegacyBlockSize; // 0x61

	// Properties
	private int BlockSize { get; }

	// Methods

	// RVA: 0x38BEC00 Offset: 0x38BED01 VA: 0x38BEC00
	public void .ctor() { }

	// RVA: 0x38BEC30 Offset: 0x38BED31 VA: 0x38BEC30
	public void .ctor(byte[] key) { }

	// RVA: 0x38BED40 Offset: 0x38BEE41 VA: 0x38BED40
	private int get_BlockSize() { }
}

// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x473FA0 Offset: 0x4740A1 VA: 0x473FA0
public class HMACSHA512 : HMAC // TypeDefIndex: 929
{
	// Fields
	private bool m_useLegacyBlockSize; // 0x61

	// Properties
	private int BlockSize { get; }

	// Methods

	// RVA: 0x38BED60 Offset: 0x38BEE61 VA: 0x38BED60
	public void .ctor() { }

	// RVA: 0x38BED90 Offset: 0x38BEE91 VA: 0x38BED90
	public void .ctor(byte[] key) { }

	// RVA: 0x38BEEA0 Offset: 0x38BEFA1 VA: 0x38BEEA0
	private int get_BlockSize() { }
}

