// Namespace: System.Runtime.ConstrainedExecution
[Serializable]
public enum Consistency // TypeDefIndex: 1229
{
	// Fields
	public int value__; // 0x0
	public const Consistency MayCorruptProcess = 0;
	public const Consistency MayCorruptAppDomain = 1;
	public const Consistency MayCorruptInstance = 2;
	public const Consistency WillNotCorruptState = 3;
}

