using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Behavior;
using Sirenix.OdinInspector;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000056 RID: 86
[CreateAssetMenu(menuName = "Plasma/Agent Gestalt")]
public class AgentGestalt : SerializedScriptableObject
{
	// Token: 0x0600057B RID: 1403 RVA: 0x00020FDA File Offset: 0x0001F1DA
	private void SetStaticInstance()
	{

	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00020FE2 File Offset: 0x0001F1E2
	private void SetAsInvalid()
	{

	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00020FEB File Offset: 0x0001F1EB
	private bool ShouldShowRepresentingNode()
	{

        return default;
    }

	// Token: 0x0600057E RID: 1406 RVA: 0x00021003 File Offset: 0x0001F203
	private bool IsInteractable()
	{

        return default;
    }

	// Token: 0x0600057F RID: 1407 RVA: 0x0002100B File Offset: 0x0001F20B
	private bool CanHaveFocus()
	{

        return default;
    }

	// Token: 0x06000580 RID: 1408 RVA: 0x00021013 File Offset: 0x0001F213
	private bool HasDeviceModifier()
	{

        return default;
    }

	// Token: 0x06000581 RID: 1409 RVA: 0x00021021 File Offset: 0x0001F221
	private bool SupportsNUS()
	{

        return default;
    }

	// Token: 0x06000582 RID: 1410 RVA: 0x0002102C File Offset: 0x0001F22C
	private IList<ValueDropdownItem<Type>> AgentList()
	{

        return default;
    }

	// Token: 0x06000583 RID: 1411 RVA: 0x00021074 File Offset: 0x0001F274
	private IList<ValueDropdownItem<Type>> DeviceComponentModifierList()
	{

        return default;
    }

	// Token: 0x06000584 RID: 1412 RVA: 0x000210BC File Offset: 0x0001F2BC
	public Dictionary<int, AgentGestalt.Property> GetConfigurableProperties()
	{

        return default;
    }

	// Token: 0x06000585 RID: 1413 RVA: 0x00021134 File Offset: 0x0001F334
	public void ConsolidatePropertyPorts()
	{

	}

	// Token: 0x06000586 RID: 1414 RVA: 0x000212EC File Offset: 0x0001F4EC
	public List<KeyValuePair<int, AgentGestalt.Port>> GetPortsOfType(AgentGestalt.Port.Types type)
	{

        return default;
    }

	// Token: 0x0400049C RID: 1180
	public const int propertyPortsStart = 64;

	// Token: 0x0400049D RID: 1181
	public const int moduleInterfaceCommandPortsStart = 128;

	// Token: 0x0400049E RID: 1182
	public const int moduleInterfacePropertyPortsStart = 192;

	// Token: 0x0400049F RID: 1183
	public const int moduleInterfaceOutputPortsStart = 256;

	// Token: 0x040004A0 RID: 1184
	public const int remotePortId = 512;

	// Token: 0x040004A1 RID: 1185
	public const int moduleInterfacePropertiesStart = 256;

	// Token: 0x040004A2 RID: 1186
	public const int moduleInterfaceOperationId = 64;

	// Token: 0x040004A3 RID: 1187
	public const int moduleInterfacePropertyHandlerId = 64;

	// Token: 0x040004A4 RID: 1188
	public AgentGestalt.Types type;

	// Token: 0x040004A5 RID: 1189
	public Type agent;

	// Token: 0x040004A6 RID: 1190
	public string displayName;

	// Token: 0x040004A7 RID: 1191
	public bool needsResources;

	// Token: 0x040004A8 RID: 1192
	public string description;

	// Token: 0x040004A9 RID: 1193
	public string keywords;

	// Token: 0x040004AA RID: 1194
	public bool developersOnly;

	// Token: 0x040004AB RID: 1195
	public bool hideDuringStage;

	// Token: 0x040004AC RID: 1196
	public bool canBeModule;

	// Token: 0x040004AD RID: 1197
	public bool processesModuleInterfaces;

	// Token: 0x040004AE RID: 1198
	public bool handlesModuleProperties;

	// Token: 0x040004AF RID: 1199
	public Dictionary<int, AgentGestalt.Property> properties;

	// Token: 0x040004B0 RID: 1200
	public Dictionary<int, AgentGestalt.Port> ports;

	// Token: 0x040004B1 RID: 1201
	public AgentGestalt.ComponentCategories componentCategory;

	// Token: 0x040004B2 RID: 1202
	public float componentMass;

	// Token: 0x040004B3 RID: 1203
	public bool defaultsToKinematic;

	// Token: 0x040004B4 RID: 1204
	public AgentGestalt.MassCategories defaultMassCategory;

	// Token: 0x040004B5 RID: 1205
	public float componentPlasmaConsumption;

	// Token: 0x040004B6 RID: 1206
	public Type deviceComponentModifier;

	// Token: 0x040004B7 RID: 1207
	public bool modifierAffectsAllBodies;

	// Token: 0x040004B8 RID: 1208
	public bool componentInteractive;

	// Token: 0x040004B9 RID: 1209
	public bool componentInteractionLocksCamera;

	// Token: 0x040004BA RID: 1210
	public bool componentPlasmaInteraction;

	// Token: 0x040004BB RID: 1211
	public bool componentCanHaveFocus;

	// Token: 0x040004BC RID: 1212
	public bool componentFocusLocksCamera;

	// Token: 0x040004BD RID: 1213
	public bool componentReactsToRaycast;

	// Token: 0x040004BE RID: 1214
	public bool componentHidesHintsUnderRaycast;

	// Token: 0x040004BF RID: 1215
	public bool componentAllowsDocking;

	// Token: 0x040004C0 RID: 1216
	public bool componentAllowsMounting;

	// Token: 0x040004C1 RID: 1217
	public bool simulatedPhysicsWhenMounted;

	// Token: 0x040004C2 RID: 1218
	public bool componentSupportSecondarySnappingPointChild;

	// Token: 0x040004C3 RID: 1219
	public bool componentAllowNonUniformScale;

	// Token: 0x040004C4 RID: 1220
	public List<AgentGestalt.NUSDefinition> nusDefinitions;

	// Token: 0x040004C5 RID: 1221
	public Vector3 spawnScale;

	// Token: 0x040004C6 RID: 1222
	public FloatRange componentScaleXLimits;

	// Token: 0x040004C7 RID: 1223
	public FloatRange componentScaleYLimits;

	// Token: 0x040004C8 RID: 1224
	public FloatRange componentScaleZLimits;

	// Token: 0x040004C9 RID: 1225
	public bool componentReactsToScaling;

	// Token: 0x040004CA RID: 1226
	public bool componentDisableScaling;

	// Token: 0x040004CB RID: 1227
	public bool componentVolumeControl;

	// Token: 0x040004CC RID: 1228
	public GameObject componentPrefab;

	// Token: 0x040004CD RID: 1229
	public Dictionary<int, string> componentIds;

	// Token: 0x040004CE RID: 1230
	public Sprite componentIcon;

	// Token: 0x040004CF RID: 1231
	public Sprite componentPreview;

	// Token: 0x040004D0 RID: 1232
	public bool componentHidden;

	// Token: 0x040004D1 RID: 1233
	public bool affectedByProjectileExplosion;

	// Token: 0x040004D2 RID: 1234
	public AgentCategoryEnum nodeCategory;

	// Token: 0x040004D3 RID: 1235
	public bool nodeAlwaysRun;

	// Token: 0x040004D4 RID: 1236
	public bool nodeRepeatable;

	// Token: 0x040004D5 RID: 1237
	public bool advanced;

	// Token: 0x040004D6 RID: 1238
	public bool hideNode;

	// Token: 0x040004D7 RID: 1239
	public AgentGestaltEnum id;

	// Token: 0x040004D8 RID: 1240
	public static AgentGestalt instance;

	// Token: 0x02000340 RID: 832
	public class Property
	{
		// Token: 0x06002002 RID: 8194 RVA: 0x0009F3B8 File Offset: 0x0009D5B8
		private void SetValidData()
		{

		}

		// Token: 0x06002003 RID: 8195 RVA: 0x0009F3DC File Offset: 0x0009D5DC
		private void SetLimitPercentage()
		{

		}

		// Token: 0x06002004 RID: 8196 RVA: 0x0009F430 File Offset: 0x0009D630
		private bool ShouldMapCommand()
		{

            return default;
        }

		// Token: 0x06002005 RID: 8197 RVA: 0x0009F4CD File Offset: 0x0009D6CD
		private bool ShouldShowAlwaysTrigger()
		{

            return default;
        }

		// Token: 0x06002006 RID: 8198 RVA: 0x0009F4D8 File Offset: 0x0009D6D8
		private bool ShouldShowSendEventOnSet()
		{

            return default;
        }

		// Token: 0x06002007 RID: 8199 RVA: 0x0009F4EA File Offset: 0x0009D6EA
		private bool ShouldShowValidateNodeOnSet()
		{

            return default;
        }

		// Token: 0x06002008 RID: 8200 RVA: 0x0009F51D File Offset: 0x0009D71D
		private bool ShouldShowPowerBoolean()
		{

            return default;
        }

		// Token: 0x06002009 RID: 8201 RVA: 0x0009F53F File Offset: 0x0009D73F
		private bool ShouldShowScript()
		{

            return default;
        }

		// Token: 0x0600200A RID: 8202 RVA: 0x0009F561 File Offset: 0x0009D761
		private bool ShouldShowVariable()
		{

            return default;
        }

		// Token: 0x0600200B RID: 8203 RVA: 0x0009F583 File Offset: 0x0009D783
		private bool ShouldShowUseLimits()
		{

            return default;
        }

		// Token: 0x0600200C RID: 8204 RVA: 0x0009F5A5 File Offset: 0x0009D7A5
		private bool ShouldShowDynamicLimits()
		{

            return default;
        }

		// Token: 0x0600200D RID: 8205 RVA: 0x0009F5CD File Offset: 0x0009D7CD
		private bool ShouldShowLimits()
		{

            return default;
        }

		// Token: 0x0600200E RID: 8206 RVA: 0x0009F600 File Offset: 0x0009D800
		private IList<ValueDropdownItem<int>> CommandList()
		{

            return default;
        }

		// Token: 0x0600200F RID: 8207 RVA: 0x0009F74C File Offset: 0x0009D94C
		private IList<ValueDropdownItem<int>> HandlerList()
		{

            return default;
        }

		// Token: 0x04001B49 RID: 6985
		public string name;

		// Token: 0x04001B4A RID: 6986
		public bool injectable;

		// Token: 0x04001B4B RID: 6987
		public bool allowsAnyData;

		// Token: 0x04001B4C RID: 6988
		public Data defaultData = new Data();

		// Token: 0x04001B4D RID: 6989
		public bool useLimits;

		// Token: 0x04001B4E RID: 6990
		public bool dynamicLimits;

		// Token: 0x04001B4F RID: 6991
		public FloatRange limits;

		// Token: 0x04001B50 RID: 6992
		public bool isVariable;

		// Token: 0x04001B51 RID: 6993
		public bool isScript;

		// Token: 0x04001B52 RID: 6994
		public bool isPowerBoolean;

		// Token: 0x04001B53 RID: 6995
		public bool configurable;

		// Token: 0x04001B54 RID: 6996
		public bool accessible;

		// Token: 0x04001B55 RID: 6997
		public int position;

		// Token: 0x04001B56 RID: 6998
		public string description;

		// Token: 0x04001B57 RID: 6999
		public int handler;

		// Token: 0x04001B58 RID: 7000
		public int driverCommand;

		// Token: 0x04001B59 RID: 7001
		public bool alwaysTrigger;

		// Token: 0x04001B5A RID: 7002
		public bool validateNodeOnSet;

		// Token: 0x04001B5B RID: 7003
		public bool assetOwnership;

		// Token: 0x04001B5C RID: 7004
		public bool hidePort;
	}

	// Token: 0x02000341 RID: 833
	public class Port
	{
		// Token: 0x06002011 RID: 8209 RVA: 0x0009F8C0 File Offset: 0x0009DAC0
		private void CreateInjectablePropertyAndAssignIt()
		{

		}

		// Token: 0x06002012 RID: 8210 RVA: 0x0009F96C File Offset: 0x0009DB6C
		private bool ValidatePropertyValue(Data newPropertyValue)
		{

            return default;
        }

		// Token: 0x06002013 RID: 8211 RVA: 0x0009F98A File Offset: 0x0009DB8A
		private bool ShouldShowButton()
		{

            return default;
        }

		// Token: 0x06002014 RID: 8212 RVA: 0x0009F99F File Offset: 0x0009DB9F
		private bool ShouldShowOnlyAppliesData()
		{

            return default;
        }

		// Token: 0x06002015 RID: 8213 RVA: 0x0009F9B4 File Offset: 0x0009DBB4
		private bool ShouldShowExpectsData()
		{

            return default;
        }

		// Token: 0x06002016 RID: 8214 RVA: 0x0009F9D1 File Offset: 0x0009DBD1
		private bool ShouldShowAnyType()
		{

            return default;
        }

		// Token: 0x06002017 RID: 8215 RVA: 0x0009F9FE File Offset: 0x0009DBFE
		private bool ShouldShowDataType()
		{

            return default;
        }

		// Token: 0x06002018 RID: 8216 RVA: 0x0009FA10 File Offset: 0x0009DC10
		private bool ShouldShowMappedProperty()
		{

            return default;
        }

		// Token: 0x06002019 RID: 8217 RVA: 0x0009FA3A File Offset: 0x0009DC3A
		private bool ShouldShowInjectedProperty()
		{

            return default;
        }

		// Token: 0x0600201A RID: 8218 RVA: 0x0009FA68 File Offset: 0x0009DC68
		private void UpdateDataType()
		{

		}

		// Token: 0x0600201B RID: 8219 RVA: 0x0009FAC9 File Offset: 0x0009DCC9
		private void UpdateExpectsData()
		{

		}

		// Token: 0x0600201C RID: 8220 RVA: 0x0009FADA File Offset: 0x0009DCDA
		private IList<ValueDropdownItem<Data.Types>> ValidTypes()
		{

            return default;
        }

		// Token: 0x0600201D RID: 8221 RVA: 0x0009FB19 File Offset: 0x0009DD19
		private IList<ValueDropdownItem<int>> InjectablePropertyList()
		{

            return default;
        }

		// Token: 0x0600201E RID: 8222 RVA: 0x0009FB22 File Offset: 0x0009DD22
		private IList<ValueDropdownItem<int>> MappablePropertyList()
		{

            return default;
        }

		// Token: 0x0600201F RID: 8223 RVA: 0x0009FB2C File Offset: 0x0009DD2C
		private IList<ValueDropdownItem<int>> PropertyList(bool injectable)
		{

            return default;
        }

		// Token: 0x06002020 RID: 8224 RVA: 0x0009FD14 File Offset: 0x0009DF14
		private bool ShouldShowPropertyValue()
		{

            return default;
        }

		// Token: 0x06002021 RID: 8225 RVA: 0x0009FD3C File Offset: 0x0009DF3C
		private bool ShouldMapCommand()
		{

            return default;
        }

		// Token: 0x06002022 RID: 8226 RVA: 0x0009FDE4 File Offset: 0x0009DFE4
		private IList<ValueDropdownItem<int>> CommandList()
		{

            return default;
        }

		// Token: 0x06002023 RID: 8227 RVA: 0x0009FF30 File Offset: 0x0009E130
		private bool ShouldMapOperation()
		{

            return default;
        }

		// Token: 0x06002024 RID: 8228 RVA: 0x0009FF54 File Offset: 0x0009E154
		private IList<ValueDropdownItem<int>> OperationList()
		{

            return default;
        }

		// Token: 0x06002025 RID: 8229 RVA: 0x000A00B2 File Offset: 0x0009E2B2
		private bool ShouldShowWillRetrigger()
		{

            return default;
        }

		// Token: 0x04001B5D RID: 7005
		public AgentGestalt.Port.Types type;

		// Token: 0x04001B5E RID: 7006
		public string name;

		// Token: 0x04001B5F RID: 7007
		public int position;

		// Token: 0x04001B60 RID: 7008
		public string description;

		// Token: 0x04001B61 RID: 7009
		public int mappedProperty;

		// Token: 0x04001B62 RID: 7010
		public bool onlyAppliesData;

		// Token: 0x04001B63 RID: 7011
		public bool expectsData;

		// Token: 0x04001B64 RID: 7012
		public int injectedProperty;

		// Token: 0x04001B65 RID: 7013
		public bool allowsAnyData;

		// Token: 0x04001B66 RID: 7014
		public Data.Types dataType;

		// Token: 0x04001B67 RID: 7015
		public Data propertyValue;

		// Token: 0x04001B68 RID: 7016
		public int operation;

		// Token: 0x04001B69 RID: 7017
		public bool willRetrigger;

		// Token: 0x04001B6A RID: 7018
		public bool hidePort;

		// Token: 0x04001B6B RID: 7019
		[HideInInspector]
		public bool fromModuleInterface;

		// Token: 0x020004BE RID: 1214
		public enum Types
		{
			// Token: 0x040020F4 RID: 8436
			Command,
			// Token: 0x040020F5 RID: 8437
			Property,
			// Token: 0x040020F6 RID: 8438
			Output
		}
	}

	// Token: 0x02000342 RID: 834
	public enum Types
	{
		// Token: 0x04001B6D RID: 7021
		Component,
		// Token: 0x04001B6E RID: 7022
		Logic
	}

	// Token: 0x02000343 RID: 835
	public enum ComponentCategories
	{
		// Token: 0x04001B70 RID: 7024
		Behavior,
		// Token: 0x04001B71 RID: 7025
		Mechanic,
		// Token: 0x04001B72 RID: 7026
		Basic,
		// Token: 0x04001B73 RID: 7027
		Structure,
		// Token: 0x04001B74 RID: 7028
		Decorative,
		// Token: 0x04001B75 RID: 7029
		All = 100
	}

	// Token: 0x02000344 RID: 836
	public enum MassCategories
	{
		// Token: 0x04001B77 RID: 7031
		Light,
		// Token: 0x04001B78 RID: 7032
		Medium,
		// Token: 0x04001B79 RID: 7033
		Heavy,
		// Token: 0x04001B7A RID: 7034
		Zero
	}

	// Token: 0x02000345 RID: 837
	public enum NUSLabel
	{
		// Token: 0x04001B7C RID: 7036
		None,
		// Token: 0x04001B7D RID: 7037
		Height,
		// Token: 0x04001B7E RID: 7038
		Width,
		// Token: 0x04001B7F RID: 7039
		Depth,
		// Token: 0x04001B80 RID: 7040
		Diameter
	}

	// Token: 0x02000346 RID: 838
	public enum NUSAxis
	{
		// Token: 0x04001B82 RID: 7042
		X,
		// Token: 0x04001B83 RID: 7043
		Y,
		// Token: 0x04001B84 RID: 7044
		Z
	}

	// Token: 0x02000347 RID: 839
	public class NUSDefinition
	{
		// Token: 0x04001B85 RID: 7045
		public AgentGestalt.NUSLabel label;

		// Token: 0x04001B86 RID: 7046
		public List<AgentGestalt.NUSAxis> axis;

		// Token: 0x04001B87 RID: 7047
		public float unitSize;

		// Token: 0x04001B88 RID: 7048
		public bool overrideCellSize;

		// Token: 0x04001B89 RID: 7049
		public float cellSize;
	}
}
}