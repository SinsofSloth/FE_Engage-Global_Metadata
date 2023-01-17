// Namespace: Mono.Math.Prime.Generator
internal class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 84
{
	// Methods

	// RVA: 0x3617790 Offset: 0x3617891 VA: 0x3617790 Slot: 8
	protected virtual BigInteger GenerateSearchBase(int bits, object context) { }

	// RVA: 0x3617820 Offset: 0x3617921 VA: 0x3617820 Slot: 7
	public override BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0x3617830 Offset: 0x3617931 VA: 0x3617830 Slot: 9
	public virtual BigInteger GenerateNewPrime(int bits, object context) { }

	// RVA: 0x3617B30 Offset: 0x3617C31 VA: 0x3617B30 Slot: 10
	protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) { }

	// RVA: 0x3617B40 Offset: 0x3617C41 VA: 0x3617B40
	public void .ctor() { }
}

