// Namespace: NexPlugin
public class DataStoreRatingInitParam // TypeDefIndex: 14879
{
	// Fields
	internal long initialValue; // 0x10
	internal int rangeMin; // 0x18
	internal int rangeMax; // 0x1C
	internal DataStore.RatingFlag flag; // 0x20
	internal DataStore.RatingInternalFlag internalFlag; // 0x24
	internal DataStore.RatingLockType lockType; // 0x28
	internal short periodDuration; // 0x2C
	internal sbyte periodHour; // 0x2E
	internal sbyte slot; // 0x2F

	// Methods

	// RVA: 0x2E95030 Offset: 0x2E95131 VA: 0x2E95030
	public void .ctor() { }

	// RVA: 0x2E95070 Offset: 0x2E95171 VA: 0x2E95070
	public void SetInitialValue(long initialValue_) { }

	// RVA: 0x2E95080 Offset: 0x2E95181 VA: 0x2E95080
	public void SetRangeMin(int min_) { }

	// RVA: 0x2E950A0 Offset: 0x2E951A1 VA: 0x2E950A0
	public void SetRangeMax(int max) { }

	// RVA: 0x2E950C0 Offset: 0x2E951C1 VA: 0x2E950C0
	public void SetLock(DataStoreRatingLockInitParam ratingLockInitParam) { }

	// RVA: 0x2E95180 Offset: 0x2E95281 VA: 0x2E95180
	public void SetFlag(DataStore.RatingFlag flag_) { }

	// RVA: 0x2E95060 Offset: 0x2E95161 VA: 0x2E95060
	public void Reset() { }

	// RVA: 0x2E95190 Offset: 0x2E95291 VA: 0x2E95190
	public void Trace() { }

	// RVA: 0x2E951A0 Offset: 0x2E952A1 VA: 0x2E951A0 Slot: 3
	public override string ToString() { }
}

