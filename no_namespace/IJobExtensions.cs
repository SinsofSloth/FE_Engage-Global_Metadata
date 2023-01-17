// Namespace: 
public sealed class IJobExtensions.JobStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 3336
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CE770 Offset: 0x33CE871 VA: 0x33CE770
	|-IJobExtensions.JobStruct.ExecuteJobFunction<DeferredLights.CullLightsJob>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CE790 Offset: 0x33CE891 VA: 0x33CE790
	|-IJobExtensions.JobStruct.ExecuteJobFunction<DeferredLights.CullLightsJob>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CEA30 Offset: 0x33CEB31 VA: 0x33CEA30
	|-IJobExtensions.JobStruct.ExecuteJobFunction<DeferredLights.CullLightsJob>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33CEB60 Offset: 0x33CEC61 VA: 0x33CEB60
	|-IJobExtensions.JobStruct.ExecuteJobFunction<DeferredLights.CullLightsJob>.EndInvoke
	*/
}

