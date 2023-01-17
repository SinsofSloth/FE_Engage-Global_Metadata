// Namespace: NexPlugin
public class SubscriberContent // TypeDefIndex: 15012
{
	// Fields
	internal ulong contentId; // 0x10
	internal ulong pid; // 0x18
	internal NpDateTime postTime; // 0x20
	internal List<uint> topics; // 0x28
	internal List<byte> binary; // 0x30
	internal string message; // 0x38

	// Methods

	// RVA: 0x2927440 Offset: 0x2927541 VA: 0x2927440
	public void .ctor() { }

	// RVA: 0x2927550 Offset: 0x2927651 VA: 0x2927550
	public ulong GetContentId() { }

	// RVA: 0x2927560 Offset: 0x2927661 VA: 0x2927560
	public string GetMessage() { }

	// RVA: 0x2927570 Offset: 0x2927671 VA: 0x2927570
	public List<byte> GetBinary() { }

	// RVA: 0x2927580 Offset: 0x2927681 VA: 0x2927580
	public ulong GetPosterPrincipalId() { }

	// RVA: 0x2927590 Offset: 0x2927691 VA: 0x2927590
	public List<uint> GetTopic() { }

	// RVA: 0x29275A0 Offset: 0x29276A1 VA: 0x29275A0
	public uint GetTopicSingle() { }

	// RVA: 0x2927610 Offset: 0x2927711 VA: 0x2927610
	public NpDateTime GetPostDateTime() { }

	// RVA: 0x2927620 Offset: 0x2927721 VA: 0x2927620
	public void Trace() { }

	// RVA: 0x2927630 Offset: 0x2927731 VA: 0x2927630 Slot: 3
	public override string ToString() { }
}

