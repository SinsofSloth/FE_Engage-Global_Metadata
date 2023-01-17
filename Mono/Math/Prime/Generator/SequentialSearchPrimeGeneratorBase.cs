// Namespace: Mono.Math.Prime.Generator
public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 1587
{
	// Methods

	// RVA: 0x1BD7DD0 Offset: 0x1BD7ED1 VA: 0x1BD7DD0 Slot: 8
	protected virtual BigInteger GenerateSearchBase(int bits, object context) { }

	// RVA: 0x1BD7EC0 Offset: 0x1BD7FC1 VA: 0x1BD7EC0 Slot: 7
	public override BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0x1BD7ED0 Offset: 0x1BD7FD1 VA: 0x1BD7ED0 Slot: 9
	public virtual BigInteger GenerateNewPrime(int bits, object context) { }

	// RVA: 0x1BD8250 Offset: 0x1BD8351 VA: 0x1BD8250 Slot: 10
	protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) { }

	// RVA: 0x1BC7180 Offset: 0x1BC7281 VA: 0x1BC7180
	public void .ctor() { }
}

