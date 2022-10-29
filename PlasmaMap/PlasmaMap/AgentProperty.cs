using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Reflection;
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000055 RID: 85
public class AgentProperty
{
	// Token: 0x14000016 RID: 22
	// (add) Token: 0x0600053B RID: 1339 RVA: 0x0001F908 File Offset: 0x0001DB08
	// (remove) Token: 0x0600053C RID: 1340 RVA: 0x0001F940 File Offset: 0x0001DB40
	public event AgentProperty.AgentPropertyEvent OnPropertyStateChanged;

	// Token: 0x14000017 RID: 23
	// (add) Token: 0x0600053D RID: 1341 RVA: 0x0001F978 File Offset: 0x0001DB78
	// (remove) Token: 0x0600053E RID: 1342 RVA: 0x0001F9B0 File Offset: 0x0001DBB0
	public event AgentProperty.AgentPropertyEvent OnPropertyValueChanged;

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x0600053F RID: 1343 RVA: 0x0001F9E5 File Offset: 0x0001DBE5
	public AgentGestalt.Property definition
	{
		get
		{
			return this._definition;
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x06000540 RID: 1344 RVA: 0x0001F9ED File Offset: 0x0001DBED
	// (set) Token: 0x06000541 RID: 1345 RVA: 0x0001F9F5 File Offset: 0x0001DBF5
	public bool enabled
	{
		get
		{
			return this._enabled;
		}
		set
		{
			this._enabled = value;
			if (this.OnPropertyStateChanged != null)
			{
				this.OnPropertyStateChanged(this);
			}
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x06000542 RID: 1346 RVA: 0x0001FA12 File Offset: 0x0001DC12
	public int id
	{
		get
		{
			return this._id;
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x06000543 RID: 1347 RVA: 0x0001FA1A File Offset: 0x0001DC1A
	// (set) Token: 0x06000544 RID: 1348 RVA: 0x0001FA22 File Offset: 0x0001DC22
	public int ownedAssetIndex { get; set; }

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06000545 RID: 1349 RVA: 0x0001FA2B File Offset: 0x0001DC2B
	// (set) Token: 0x06000546 RID: 1350 RVA: 0x0001FA33 File Offset: 0x0001DC33
	public bool dontCopyAsset { get; set; }

	// Token: 0x06000547 RID: 1351 RVA: 0x0001FA3C File Offset: 0x0001DC3C
	public AgentProperty(AgentGestalt.Property definition, Agent agent, int id, bool isRuntime, bool isVariable = false)
	{

	}

	// Token: 0x06000548 RID: 1352 RVA: 0x0001FB08 File Offset: 0x0001DD08
	public void CleanUp()
	{

	}

	// Token: 0x06000549 RID: 1353 RVA: 0x0001FB5C File Offset: 0x0001DD5C
	private void RunPostUpdateSteps()
	{

	}

	// Token: 0x0600054A RID: 1354 RVA: 0x0001FBE9 File Offset: 0x0001DDE9
	public FloatRange GetLimits()
	{

        return default;
    }

	// Token: 0x0600054B RID: 1355 RVA: 0x0001FC18 File Offset: 0x0001DE18
	public float ApplyLimits(float value)
	{

        return default;
    }

	// Token: 0x0600054C RID: 1356 RVA: 0x0001FC43 File Offset: 0x0001DE43
	public Data.Types GetDataType()
	{

        return default;
    }

	// Token: 0x0600054D RID: 1357 RVA: 0x0001FC50 File Offset: 0x0001DE50
	public void SetDataType(Data.Types type)
	{

	}

	// Token: 0x0600054E RID: 1358 RVA: 0x0001FD4E File Offset: 0x0001DF4E
	public Data GetValue()
	{

        return default;
    }

	// Token: 0x0600054F RID: 1359 RVA: 0x0001FD56 File Offset: 0x0001DF56
	public bool GetValueBoolean()
	{

        return default;
    }

	// Token: 0x06000550 RID: 1360 RVA: 0x0001FD63 File Offset: 0x0001DF63
	public Color GetValueColor()
	{

        return default;
    }

	// Token: 0x06000551 RID: 1361 RVA: 0x0001FD70 File Offset: 0x0001DF70
	public Data.ComponentProperty GetValueComponentProperty()
	{

        return default;
    }

	// Token: 0x06000552 RID: 1362 RVA: 0x0001FD7D File Offset: 0x0001DF7D
	public Data.Image GetValueImage()
	{

        return default;
    }

	// Token: 0x06000553 RID: 1363 RVA: 0x0001FD8A File Offset: 0x0001DF8A
	public Data.ModuleInterface GetValueModuleInterface()
	{

        return default;
    }

	// Token: 0x06000554 RID: 1364 RVA: 0x0001FD97 File Offset: 0x0001DF97
	public float GetValueNumberAsFloat()
	{

        return default;
    }

	// Token: 0x06000555 RID: 1365 RVA: 0x0001FDA4 File Offset: 0x0001DFA4
	public float GetValueNumberAsAngle()
	{

        return default;
    }

	// Token: 0x06000556 RID: 1366 RVA: 0x0001FDC0 File Offset: 0x0001DFC0
	public int GetValueNumberAsInteger()
	{

        return default;
    }

	// Token: 0x06000557 RID: 1367 RVA: 0x0001FDD2 File Offset: 0x0001DFD2
	public float GetValueNumberFromPercentage()
	{

        return default;
    }

	// Token: 0x06000558 RID: 1368 RVA: 0x0001FDE5 File Offset: 0x0001DFE5
	public Data.NumberDecorators GetValueNumberDecorator()
	{

        return default;
    }

	// Token: 0x06000559 RID: 1369 RVA: 0x0001FE0C File Offset: 0x0001E00C
	public Data.Selection GetValueSelection()
	{

        return default;
    }

	// Token: 0x0600055A RID: 1370 RVA: 0x0001FE19 File Offset: 0x0001E019
	public Data.Sound GetValueSound()
	{

        return default;
    }

	// Token: 0x0600055B RID: 1371 RVA: 0x0001FE26 File Offset: 0x0001E026
	public string GetValueString()
	{

        return default;
    }

	// Token: 0x0600055C RID: 1372 RVA: 0x0001FE34 File Offset: 0x0001E034
	private bool IsLegal(Data value)
	{

        return default;
    }

	// Token: 0x0600055D RID: 1373 RVA: 0x0001FE90 File Offset: 0x0001E090
	public bool SetValue(Data value, bool forcePostUpdateSteps = false, bool copyDecorator = true)
	{

        return default;
    }

	// Token: 0x0600055E RID: 1374 RVA: 0x0001FFF4 File Offset: 0x0001E1F4
	private void HandleRuntimeImageOwnership(Data value)
	{

	}

	// Token: 0x0600055F RID: 1375 RVA: 0x000202A8 File Offset: 0x0001E4A8
	private void HandleConfiguredImageOwnership(Data value)
	{

	}

	// Token: 0x06000560 RID: 1376 RVA: 0x000203E0 File Offset: 0x0001E5E0
	public bool SetValueBoolean(bool value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x06000561 RID: 1377 RVA: 0x00020492 File Offset: 0x0001E692
	public bool SetValueBoolean(Data value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x06000562 RID: 1378 RVA: 0x000204A4 File Offset: 0x0001E6A4
	public bool SetValueColor(Color value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x06000563 RID: 1379 RVA: 0x00020564 File Offset: 0x0001E764
	public bool SetValueColor(Data value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x06000564 RID: 1380 RVA: 0x00020574 File Offset: 0x0001E774
	public bool SetValueComponentProperty(Data.ComponentProperty value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x06000565 RID: 1381 RVA: 0x0002063D File Offset: 0x0001E83D
	public bool SetValueComponentProperty(Data value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x06000566 RID: 1382 RVA: 0x0002064C File Offset: 0x0001E84C
	public bool SetValueNumber(float value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x06000567 RID: 1383 RVA: 0x000207C4 File Offset: 0x0001E9C4
	public bool SetValueNumber(int value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x06000568 RID: 1384 RVA: 0x0002093B File Offset: 0x0001EB3B
	public bool SetValueNumberAsPercentage(float value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x06000569 RID: 1385 RVA: 0x0002094B File Offset: 0x0001EB4B
	public bool SetValueNumber(Data value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x0600056A RID: 1386 RVA: 0x00020978 File Offset: 0x0001EB78
	public bool SetValueNumberDecorator(Data.NumberDecorators decorator, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x0600056B RID: 1387 RVA: 0x00020A34 File Offset: 0x0001EC34
	public bool SetValueImage(Data.Image value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x0600056C RID: 1388 RVA: 0x00020AF2 File Offset: 0x0001ECF2
	public bool SetValueModuleInterface(Data value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x0600056D RID: 1389 RVA: 0x00020B04 File Offset: 0x0001ED04
	public bool SetValueModuleInterface(Data.ModuleInterface value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x0600056E RID: 1390 RVA: 0x00020BC3 File Offset: 0x0001EDC3
	public bool SetValueImage(Data value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x0600056F RID: 1391 RVA: 0x00020BD4 File Offset: 0x0001EDD4
	public bool SetValueSelection(Data.Selection value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x06000570 RID: 1392 RVA: 0x00020C9D File Offset: 0x0001EE9D
	public bool SetValueSelection(Data value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x06000571 RID: 1393 RVA: 0x00020CAC File Offset: 0x0001EEAC
	public bool SetValueSound(Data.Sound value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x06000572 RID: 1394 RVA: 0x00020D6A File Offset: 0x0001EF6A
	public bool SetValueSound(Data value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x06000573 RID: 1395 RVA: 0x00020D7C File Offset: 0x0001EF7C
	public bool SetValueString(string value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x06000574 RID: 1396 RVA: 0x00020E2E File Offset: 0x0001F02E
	public bool SetValueString(Data value, bool forcePostUpdateSteps = false)
	{

        return default;
    }

	// Token: 0x06000575 RID: 1397 RVA: 0x00020E3D File Offset: 0x0001F03D
	public object ComposeStorage()
	{

        return default;
    }

	// Token: 0x06000576 RID: 1398 RVA: 0x00020E74 File Offset: 0x0001F074
	public void ApplyStorage(object data)
	{

	}

	// Token: 0x06000577 RID: 1399 RVA: 0x00020EF8 File Offset: 0x0001F0F8
	public static AgentProperty CreateDynamicProperty(string name, Agent agent, int id, bool isRuntime)
	{

        return default;
    }

	// Token: 0x06000578 RID: 1400 RVA: 0x00020F5D File Offset: 0x0001F15D
	private void Log(string message)
	{

	}

	// Token: 0x06000579 RID: 1401 RVA: 0x00020F87 File Offset: 0x0001F187
	private void LogWarning(string message)
	{

	}

	// Token: 0x0600057A RID: 1402 RVA: 0x00020FB1 File Offset: 0x0001F1B1
	private void LogError(string message)
	{

	}

	// Token: 0x04000490 RID: 1168
	private AgentGestalt.Property _definition;

	// Token: 0x04000491 RID: 1169
	private Agent _agent;

	// Token: 0x04000492 RID: 1170
	private int _id;

	// Token: 0x04000493 RID: 1171
	private MethodInfo _processor;

	// Token: 0x04000494 RID: 1172
	private Data _data;

	// Token: 0x04000495 RID: 1173
	private Data _oldData;

	// Token: 0x04000496 RID: 1174
	private bool _isRuntime;

	// Token: 0x04000497 RID: 1175
	private bool _enabled;

	// Token: 0x04000498 RID: 1176
	private bool _semaphore;

	// Token: 0x04000499 RID: 1177
	private bool _isVariable;

	// Token: 0x0200033E RID: 830
	public class Storage
	{
		// Token: 0x04001B47 RID: 6983
		public string name;

		// Token: 0x04001B48 RID: 6984
		public Data data;
	}

	// Token: 0x0200033F RID: 831
	// (Invoke) Token: 0x06001FFF RID: 8191
	public delegate void AgentPropertyEvent(AgentProperty property);
}
}