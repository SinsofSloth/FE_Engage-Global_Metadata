// Namespace: NexPlugin
public class SubscriberPostContentParam // TypeDefIndex: 15013
{
	// Fields
	internal List<uint> topics; // 0x10
	internal List<byte> binary; // 0x18
	internal string message; // 0x20

	// Methods

	// RVA: 0x2927BE0 Offset: 0x2927CE1 VA: 0x2927BE0
	public void .ctor() { }

	// RVA: 0x2927DC0 Offset: 0x2927EC1 VA: 0x2927DC0
	public void SetTopic(List<uint> topics_) { }

	// RVA: 0x2927E50 Offset: 0x2927F51 VA: 0x2927E50
	public void SetTopic(uint topic_) { }

	// RVA: 0x2927F20 Offset: 0x2928021 VA: 0x2927F20
	public List<uint> GetTopic() { }

	// RVA: 0x2927F30 Offset: 0x2928031 VA: 0x2927F30
	public uint GetTopicSingle() { }

	// RVA: 0x2927FA0 Offset: 0x29280A1 VA: 0x2927FA0
	public void SetMessage(string message_) { }

	// RVA: 0x2928010 Offset: 0x2928111 VA: 0x2928010
	public string GetMessage() { }

	// RVA: 0x2928020 Offset: 0x2928121 VA: 0x2928020
	public void SetBinary(List<byte> binary_) { }

	// RVA: 0x29280B0 Offset: 0x29281B1 VA: 0x29280B0
	public List<byte> GetBinary() { }

	// RVA: 0x2927C10 Offset: 0x2927D11 VA: 0x2927C10
	public void Reset() { }

	// RVA: 0x29280C0 Offset: 0x29281C1 VA: 0x29280C0
	public void Trace() { }

	// RVA: 0x29280D0 Offset: 0x29281D1 VA: 0x29280D0 Slot: 3
	public override string ToString() { }
}

