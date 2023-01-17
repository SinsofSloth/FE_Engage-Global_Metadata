// Namespace: NexPlugin
public class RankingCachedResult : RankingResult // TypeDefIndex: 14988
{
	// Fields
	internal uint maxLength; // 0x28
	internal NpDateTime createdTime; // 0x2C
	internal NpDateTime expiredTime; // 0x34

	// Methods

	// RVA: 0x276DFD0 Offset: 0x276E0D1 VA: 0x276DFD0
	public void .ctor() { }

	// RVA: 0x276E140 Offset: 0x276E241 VA: 0x276E140
	public uint GetMaxLength() { }

	// RVA: 0x276E150 Offset: 0x276E251 VA: 0x276E150
	public NpDateTime GetCreatedTime() { }

	// RVA: 0x276E160 Offset: 0x276E261 VA: 0x276E160
	public NpDateTime GetExpiredTime() { }

	// RVA: 0x276E170 Offset: 0x276E271 VA: 0x276E170
	public RankingCachedResult.LocalUpdateState LocalUpdate(RankingOrderParam orderParam, RankingScoreData scoreData, ulong pid, ulong nexUniqueId = 0, NpDateTime utcCurrentTime, List<byte> pCommonData) { }

	// RVA: 0x276E280 Offset: 0x276E381 VA: 0x276E280
	public void Trace() { }

	// RVA: 0x276E290 Offset: 0x276E391 VA: 0x276E290 Slot: 3
	public override string ToString() { }
}

