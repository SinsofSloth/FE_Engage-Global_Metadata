// Namespace: nn.fs
public static class AddOnContent // TypeDefIndex: 14730
{
	// Methods

	// RVA: 0x2EC9FC0 Offset: 0x2ECA0C1 VA: 0x2EC9FC0
	public static extern Result QueryMountCacheSize(ref long pOutValue, int targetIndex) { }

	// RVA: 0x2EC9FE0 Offset: 0x2ECA0E1 VA: 0x2EC9FE0
	public static extern Result Mount(string name, int targetIndex, byte[] pFileSystemCacheBuffer, long fileSystemCacheBufferSize) { }
}

