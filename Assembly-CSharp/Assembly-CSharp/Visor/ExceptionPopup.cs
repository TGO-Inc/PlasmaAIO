using System;
using System.Collections;
using System.IO;
using EasyFeedback;
using EasyFeedback.APIs;
using Tayx.Graphy;
using Tayx.Graphy.Utils;
using TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Visor
{
	// Token: 0x02000250 RID: 592
	public class ExceptionPopup : MonoBehaviour
	{
		// Token: 0x060015EE RID: 5614 RVA: 0x0006E9F8 File Offset: 0x0006CBF8
		public void Setup(string screenshotPath)
		{

		}

		// Token: 0x060015EF RID: 5615 RVA: 0x0006EAED File Offset: 0x0006CCED
		public void OnEnable()
		{

		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x0006EB10 File Offset: 0x0006CD10
		public void Submit()
		{

		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x0006EEF9 File Offset: 0x0006D0F9
		private IEnumerator SubmitBugReport()
		{

            return default;
        }

		// Token: 0x040011C2 RID: 4546
		public TMP_InputField contentField;

		// Token: 0x040011C3 RID: 4547
		public BetterButton submitButton;

		// Token: 0x040011C4 RID: 4548
		public GameObject loadingCircle;

		// Token: 0x040011C5 RID: 4549
		public EFConfig config;

		// Token: 0x040011C6 RID: 4550
		private Report _report;

		// Token: 0x040011C7 RID: 4551
		private Trello _trello;

		// Token: 0x040011C8 RID: 4552
		private const string _contentSection = "Content";

		// Token: 0x040011C9 RID: 4553
		private const string _timeSection = "Time and Date";

		// Token: 0x040011CA RID: 4554
		private const string _versionSection = "Version";

		// Token: 0x040011CB RID: 4555
		private const string _additionalInfoSection = "Additional Info";

		// Token: 0x040011CC RID: 4556
		private const string _performanceSection = "Performance Data";

		// Token: 0x040011CD RID: 4557
		private const string _systemInfoSection = "System Info";

		// Token: 0x040011CE RID: 4558
		private const string _exceptionInfoSection = "Exception Info";

		// Token: 0x040011CF RID: 4559
		private const string _exceptionStackTraceSection = "Exception Stack Trace";
	}
}
