// Namespace: Mono.Math.Prime.Generator
internal abstract class PrimeGeneratorBase // TypeDefIndex: 83
{
	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x3822D40 Offset: 0x3822E41 VA: 0x3822D40 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x3822D50 Offset: 0x3822E51 VA: 0x3822D50 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x3822DE0 Offset: 0x3822EE1 VA: 0x3822DE0 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x3822DF0 Offset: 0x3822EF1 VA: 0x3822DF0
	protected void .ctor() { }
}

// Namespace: Mono.Math.Prime.Generator
public abstract class PrimeGeneratorBase // TypeDefIndex: 1586
{
	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x1BD6A80 Offset: 0x1BD6B81 VA: 0x1BD6A80 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x1BD6A90 Offset: 0x1BD6B91 VA: 0x1BD6A90 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x1BD6B20 Offset: 0x1BD6C21 VA: 0x1BD6B20 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x1BD6B30 Offset: 0x1BD6C31 VA: 0x1BD6B30
	protected void .ctor() { }
}

