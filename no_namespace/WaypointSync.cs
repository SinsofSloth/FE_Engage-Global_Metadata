// Namespace: 
[Serializable]
public class WaypointSync.Relative // TypeDefIndex: 10562
{
	// Fields
	public int m_targetID; // 0x10
	public int m_recieverID; // 0x14
	public Vector3 m_offset; // 0x18
	public bool m_Enable; // 0x24
	private int _pastTargetID; // 0x28
	private int _pastRecieverID; // 0x2C
	private Vector3 _pastRecieverPos; // 0x30
	private bool _pastEnable; // 0x3C
	private Vector3 _targetPos; // 0x40

	// Methods

	// RVA: 0x1DBA630 Offset: 0x1DBA731 VA: 0x1DBA630
	private void .ctor() { }

	// RVA: 0x1DBA640 Offset: 0x1DBA741 VA: 0x1DBA640
	public void PostUpdate(CinemachineSmoothPath target, ref CinemachineSmoothPath reciever) { }

	// RVA: 0x1DBA810 Offset: 0x1DBA911 VA: 0x1DBA810
	public void UpdateValidate(CinemachineSmoothPath target, ref CinemachineSmoothPath reciever) { }
}

