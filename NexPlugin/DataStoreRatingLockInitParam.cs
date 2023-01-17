// Namespace: NexPlugin
public class DataStoreRatingLockInitParam // TypeDefIndex: 14878
{
	// Fields
	internal DataStore.RatingLockType lockType; // 0x10
	internal short periodDuration; // 0x14
	internal sbyte periodHour; // 0x16

	// Methods

	// RVA: 0x2E95150 Offset: 0x2E95251 VA: 0x2E95150
	public void .ctor() { }

	// RVA: 0x2E955A0 Offset: 0x2E956A1 VA: 0x2E955A0
	private void Reset() { }

	// RVA: 0x2E955B0 Offset: 0x2E956B1 VA: 0x2E955B0
	public void SetIntervalLock(short intervalSec) { }

	// RVA: 0x2E955D0 Offset: 0x2E956D1 VA: 0x2E955D0
	public void SetPeriodicLock(DataStore.RatingLockPeriod period, sbyte hour) { }

	// RVA: 0x2E95600 Offset: 0x2E95701 VA: 0x2E95600
	public void SetDaysAfterLock(short days, sbyte hour) { }

	// RVA: 0x2E95630 Offset: 0x2E95731 VA: 0x2E95630
	public void SetPermanentLock() { }

	// RVA: 0x2E95650 Offset: 0x2E95751 VA: 0x2E95650
	public void Trace() { }

	// RVA: 0x2E95660 Offset: 0x2E95761 VA: 0x2E95660 Slot: 3
	public override string ToString() { }
}

