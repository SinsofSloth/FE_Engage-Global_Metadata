// Namespace: App
public class ClassChange // TypeDefIndex: 9846
{
	// Methods

	// RVA: 0x22C0890 Offset: 0x22C0991 VA: 0x22C0890
	public static List<ClassChange.ChangeJobData> GetSelectJobList(JobData jobData) { }

	// RVA: 0x22C0D00 Offset: 0x22C0E01 VA: 0x22C0D00
	public static List<ClassChange.ChangeJobData> GetJobListAll() { }

	// RVA: 0x22C0FC0 Offset: 0x22C10C1 VA: 0x22C0FC0
	public static List<JobData> GetJobList(Unit unit, ItemData item) { }

	// RVA: 0x22C1150 Offset: 0x22C1251 VA: 0x22C1150
	public static List<JobData> GetJobListByMaster(Unit unit) { }

	// RVA: 0x22C11F0 Offset: 0x22C12F1 VA: 0x22C11F0
	public static List<JobData> GetJobListByChange(Unit unit) { }

	// RVA: 0x22C1290 Offset: 0x22C1391 VA: 0x22C1290
	private static void AddToListForMaster(List<JobData> jobList, Unit unit, List<JobData> highJobs) { }

	// RVA: 0x22C13C0 Offset: 0x22C14C1 VA: 0x22C13C0
	private static void AddToListForChange(List<JobData> jobList, Unit unit) { }

	// RVA: 0x22C1920 Offset: 0x22C1A21 VA: 0x22C1920
	private static void AddToList(List<JobData> jobList, Unit unit, JobData job, bool includeCurrentJob = False, bool ignoreAptitudeCheck = False) { }

	// RVA: 0x22C1BC0 Offset: 0x22C1CC1 VA: 0x22C1BC0
	private static List<JobData> GetRelationalJobs(JobData job) { }

	// RVA: 0x22C1CE0 Offset: 0x22C1DE1 VA: 0x22C1CE0
	private static bool IsExists(List<JobData> jobList, JobData targetJob) { }

	// RVA: 0x22C1DA0 Offset: 0x22C1EA1 VA: 0x22C1DA0
	public void .ctor() { }
}

