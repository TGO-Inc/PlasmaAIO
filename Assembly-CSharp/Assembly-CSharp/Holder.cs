using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Behavior;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;
using UnityEngine.Video;

// Token: 0x0200003C RID: 60
public class Holder : SerializedMonoBehaviour
{
	// Token: 0x060001C6 RID: 454 RVA: 0x0000AF8C File Offset: 0x0000918C
	private void Awake()
	{

	}

	// Token: 0x060001C7 RID: 455 RVA: 0x0000B868 File Offset: 0x00009A68
	public static int GetQuickbarSlotIndexForComponentId(AgentGestaltEnum componentGestaltId)
	{

        return default;
    }

	// Token: 0x060001C8 RID: 456 RVA: 0x0000B8D0 File Offset: 0x00009AD0
	public static void AssignComponentIdToQuickbarSlot(AgentGestaltEnum componentGestaltId, int slotIndex)
	{

	}

	// Token: 0x060001C9 RID: 457 RVA: 0x0000B99C File Offset: 0x00009B9C
	public static void ToggleFavoriteNode(AgentGestaltEnum nodeGestaltId)
	{

	}

	// Token: 0x060001CA RID: 458 RVA: 0x0000B9FC File Offset: 0x00009BFC
	public static bool IsTimeAfterLastPlayed(DateTime dateTime)
	{

        return default;
    }

	// Token: 0x060001CB RID: 459 RVA: 0x0000BA32 File Offset: 0x00009C32
	private void DeleteAllPlayerPrefs()
	{

	}

	// Token: 0x060001CC RID: 460 RVA: 0x0000BA39 File Offset: 0x00009C39
	private void DeleteVideoSettings()
	{

	}

	// Token: 0x060001CD RID: 461 RVA: 0x0000BA77 File Offset: 0x00009C77
	private void DeleteMiscSettings()
	{

	}

	// Token: 0x060001CE RID: 462 RVA: 0x0000BA83 File Offset: 0x00009C83
	private void DeleteWelcomeSettings()
	{

	}

	// Token: 0x060001CF RID: 463 RVA: 0x0000BA8F File Offset: 0x00009C8F
	private void DeleteLastSavedWorld()
	{

	}

	// Token: 0x060001D0 RID: 464 RVA: 0x0000BA9C File Offset: 0x00009C9C
	private void DeleteTutorialImpressions()
	{

	}

	// Token: 0x060001D1 RID: 465 RVA: 0x0000BB28 File Offset: 0x00009D28
	private void CheckForUnusedUIColors()
	{

	}

	// Token: 0x060001D2 RID: 466 RVA: 0x0000BB80 File Offset: 0x00009D80
	private void ListAllUsedLogicNodesInTheCurrentWorld()
	{

	}

	// Token: 0x060001D3 RID: 467 RVA: 0x0000BCB4 File Offset: 0x00009EB4
	private void ListAllUsedComponentsInTheCurrentWorld()
	{

	}

	// Token: 0x060001D4 RID: 468 RVA: 0x0000BE0C File Offset: 0x0000A00C
	private void OnApplicationQuit()
	{

	}

	// Token: 0x040001D2 RID: 466
	public Dictionary<int, UIColorEntity> UIColorPalette;

	// Token: 0x040001D3 RID: 467
	public Dictionary<AgentGestalt.ComponentCategories, Holder.SketchColorTheme> sketchColorThemes;

	// Token: 0x040001D4 RID: 468
	public Holder.SketchColorTheme sketchLogicColorTheme;

	// Token: 0x040001D5 RID: 469
	public Dictionary<string, GameObject> keyboardIcons;

	// Token: 0x040001D6 RID: 470
	public Dictionary<AgentCategoryEnum, string> agentCategories;

	// Token: 0x040001D7 RID: 471
	public float UITransitionDuration;

	// Token: 0x040001D8 RID: 472
	public Dictionary<Holder.TransitionDurations, float> transitionDurations;

	// Token: 0x040001D9 RID: 473
	public Texture2D normalCursor;

	// Token: 0x040001DA RID: 474
	public Texture2D panCursor;

	// Token: 0x040001DB RID: 475
	public Texture2D pinCursor;

	// Token: 0x040001DC RID: 476
	public int sketchViewWidth;

	// Token: 0x040001DD RID: 477
	public int sketchViewHeight;

	// Token: 0x040001DE RID: 478
	public Dictionary<Data.Types, Holder.DataTypeDescriptor> dataTypeDescriptors;

	// Token: 0x040001DF RID: 479
	public Holder.DataTypeDescriptor anyDataDescriptor;

	// Token: 0x040001E0 RID: 480
	public Sprite variableIcon;

	// Token: 0x040001E1 RID: 481
	public Sprite variableSketchIcon;

	// Token: 0x040001E2 RID: 482
	public Sprite moduleInterfaceIcon;

	// Token: 0x040001E3 RID: 483
	public float buttonAnimationInDuration;

	// Token: 0x040001E4 RID: 484
	public float buttonAnimationOutDuration;

	// Token: 0x040001E5 RID: 485
	public BiomeGestaltEnum DemoDefaultBiome;

	// Token: 0x040001E6 RID: 486
	public Dictionary<int, TextAsset> demoImageAssets;

	// Token: 0x040001E7 RID: 487
	public List<VideoClip> tutorialVideos;

	// Token: 0x040001E8 RID: 488
	[ColorUsage(true, true)]
	public Color LEDPowerColor;

	// Token: 0x040001E9 RID: 489
	[ColorUsage(true, true)]
	public Color LEDBusyColor;

	// Token: 0x040001EA RID: 490
	[ColorUsage(true, true)]
	public Color LEDWarningColor;

	// Token: 0x040001EB RID: 491
	[ColorUsage(true, true)]
	public Color LEDErrorColor;

	// Token: 0x040001EC RID: 492
	[ColorUsage(true, true)]
	public Color LEDConfirmColor;

	// Token: 0x040001ED RID: 493
	[ColorUsage(true, true)]
	public Color overlayNormalColor;

	// Token: 0x040001EE RID: 494
	[ColorUsage(true, true)]
	public Color overlaySelectedColor;

	// Token: 0x040001EF RID: 495
	[ColorUsage(true, true)]
	public Color propsInteractiveColor;

	// Token: 0x040001F0 RID: 496
	[ColorUsage(false, false)]
	public Color structureColor;

	// Token: 0x040001F1 RID: 497
	public List<Color> componentPalette;

	// Token: 0x040001F2 RID: 498
	public List<Color> componentPaletteUI;

	// Token: 0x040001F3 RID: 499
	public static Holder instance;

	// Token: 0x040001F4 RID: 500
	public static Dictionary<string, List<AgentGestalt>> sortedComponentGestaltsByKeyword;

	// Token: 0x040001F5 RID: 501
	public static Dictionary<AgentGestaltEnum, AgentGestalt> agentGestalts;

	// Token: 0x040001F6 RID: 502
	public static Dictionary<AgentGestaltEnum, AgentGestalt> componentGestalts;

	// Token: 0x040001F7 RID: 503
	public static Dictionary<AgentGestaltEnum, AgentId> logicNodesByEnum;

	// Token: 0x040001F8 RID: 504
	public static Dictionary<AgentCategoryEnum, List<AgentId>> logicNodesByCategory;

	// Token: 0x040001F9 RID: 505
	public static Dictionary<string, List<AgentId>> sortedlogicNodesByKeyword;

	// Token: 0x040001FA RID: 506
	public static Dictionary<HintGestaltEnum, HintGestalt> hintGestalts;

	// Token: 0x040001FB RID: 507
	public static Dictionary<TutorialGestaltEnum, TutorialGestalt> tutorialGestalts;

	// Token: 0x040001FC RID: 508
	public static Dictionary<BlockingTutorialGestaltEnum, BlockingTutorialGestalt> blockingTutorialGestalts;

	// Token: 0x040001FD RID: 509
	public static Dictionary<BiomeGestaltEnum, BiomeGestalt> biomeGestalts;

	// Token: 0x040001FE RID: 510
	public static List<Color> colorSwatches;

	// Token: 0x040001FF RID: 511
	public static Dictionary<int, AgentGestaltEnum> quickbarAssignments;

	// Token: 0x04000200 RID: 512
	public static List<AgentGestaltEnum> favoriteNodesAssignments;

	// Token: 0x04000201 RID: 513
	public static readonly Dictionary<Data.Types, List<int>> sketchViewNodePreviewWidths = new Dictionary<Data.Types, List<int>>
	{
		{
			Data.Types.Boolean,
			new List<int>
			{
				2,
				1
			}
		},
		{
			Data.Types.Color,
			new List<int>
			{
				3,
				2
			}
		},
		{
			Data.Types.Image,
			new List<int>
			{
				5,
				4
			}
		},
		{
			Data.Types.None,
			new List<int>
			{
				5,
				3
			}
		},
		{
			Data.Types.Number,
			new List<int>
			{
				5,
				4
			}
		},
		{
			Data.Types.Sound,
			new List<int>
			{
				5,
				4
			}
		},
		{
			Data.Types.String,
			new List<int>
			{
				5,
				4
			}
		},
		{
			Data.Types.Selection,
			new List<int>
			{
				5,
				4
			}
		},
		{
			Data.Types.ModuleInterface,
			new List<int>
			{
				5,
				4
			}
		},
		{
			Data.Types.ComponentProperty,
			new List<int>
			{
				5,
				4
			}
		}
	};

	// Token: 0x04000202 RID: 514
	public const int sketchViewVariableWidth = 4;

	// Token: 0x04000203 RID: 515
	public const int sketchViewNodeMaxTypeWidth = 5;

	// Token: 0x04000204 RID: 516
	public static char decimalSeparator;

	// Token: 0x04000205 RID: 517
	public static string importPath;

	// Token: 0x04000206 RID: 518
	public static string devicesPath;

	// Token: 0x04000207 RID: 519
	public static string worldsPath;

	// Token: 0x04000208 RID: 520
	public static string progressPath;

	// Token: 0x04000209 RID: 521
	public static string screenshotsPath;

	// Token: 0x0400020A RID: 522
	private static string _colorSwatchesPath;

	// Token: 0x0400020B RID: 523
	private static string _quickbarAssignmentsPath;

	// Token: 0x0400020C RID: 524
	private static string _favoriteNodesAssignmentsPath;

	// Token: 0x020002E2 RID: 738
	public enum TransitionDurations
	{
		// Token: 0x04001983 RID: 6531
		Short,
		// Token: 0x04001984 RID: 6532
		Normal,
		// Token: 0x04001985 RID: 6533
		Long,
		// Token: 0x04001986 RID: 6534
		Shorter,
		// Token: 0x04001987 RID: 6535
		Shortest,
		// Token: 0x04001988 RID: 6536
		Longer,
		// Token: 0x04001989 RID: 6537
		Longest,
		// Token: 0x0400198A RID: 6538
		Shortish,
		// Token: 0x0400198B RID: 6539
		Longish
	}

	// Token: 0x020002E3 RID: 739
	public class DataTypeDescriptor
	{
		// Token: 0x0400198C RID: 6540
		public string name;

		// Token: 0x0400198D RID: 6541
		public string description;

		// Token: 0x0400198E RID: 6542
		public Sprite icon;

		// Token: 0x0400198F RID: 6543
		public Sprite sketchIcon;
	}

	// Token: 0x020002E4 RID: 740
	public class SketchColorTheme
	{
		// Token: 0x06001E7A RID: 7802 RVA: 0x0009657C File Offset: 0x0009477C
		private IList<ValueDropdownItem<int>> ColorList()
		{

            return default;
        }

		// Token: 0x04001990 RID: 6544
		[ColorEntity]
		public int normal;

		// Token: 0x04001991 RID: 6545
		[ColorEntity]
		public int alternate;

		// Token: 0x04001992 RID: 6546
		[ColorEntity]
		public int highlighted;

		// Token: 0x04001993 RID: 6547
		[ColorEntity]
		public int disabled;

		// Token: 0x04001994 RID: 6548
		[ColorEntity]
		public int lighterShade;

		// Token: 0x04001995 RID: 6549
		[ColorEntity]
		public int typeStatic;

		// Token: 0x04001996 RID: 6550
		[ColorEntity]
		public int typeDynamic;

		// Token: 0x04001997 RID: 6551
		[ColorEntity]
		public int safetyBufferWarning;

		// Token: 0x04001998 RID: 6552
		[ColorEntity]
		public int moduleInterface;
	}
}
