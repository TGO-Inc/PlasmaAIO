using System;
using System.Collections.ObjectModel;
using System.Linq;
using UnityEngine;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001DD RID: 477
	[Serializable]
	public class Transitions
	{
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x0005A255 File Offset: 0x00058455
		public Transitions.TransitionMode Mode
		{
			get
			{
				return this.mode;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x0005A25D File Offset: 0x0005845D
		public ReadOnlyCollection<string> StateNames
		{
			get
			{
				return this.stateNames.ToList<string>().AsReadOnly();
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x0005A270 File Offset: 0x00058470
		public TransitionStateCollection TransitionStates
		{
			get
			{
				switch (this.mode)
				{
				case Transitions.TransitionMode.ColorTint:
					return this.colorTransitions;
				case Transitions.TransitionMode.SpriteSwap:
					return this.spriteSwapTransitions;
				case Transitions.TransitionMode.Animation:
					return this.animationTransitions;
				case Transitions.TransitionMode.ObjectActiveness:
					return this.activenessTransitions;
				case Transitions.TransitionMode.Alpha:
					return this.alphaTransitions;
				case Transitions.TransitionMode.MaterialProperty:
					return this.materialPropertyTransitions;
				case Transitions.TransitionMode.Color32Tint:
					return this.color32Transitions;
				default:
					return null;
				}
			}
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0005A2DC File Offset: 0x000584DC
		public Transitions(params string[] stateNames)
		{

		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0005A2EB File Offset: 0x000584EB
		public void SetState(string stateName, bool instant)
		{

		}

		// Token: 0x060010EA RID: 4330 RVA: 0x0005A314 File Offset: 0x00058514
		public void SetMode(Transitions.TransitionMode mode)
		{

		}

		// Token: 0x04000EAE RID: 3758
		public static readonly string[] OnOffStateNames = new string[]
		{
			"On",
			"Off"
		};

		// Token: 0x04000EAF RID: 3759
		public static readonly string[] ShowHideStateNames = new string[]
		{
			"Show",
			"Hide"
		};

		// Token: 0x04000EB0 RID: 3760
		public static readonly string[] SelectionStateNames = new string[]
		{
			"Normal",
			"Highlighted",
			"Pressed",
			"Disabled"
		};

		// Token: 0x04000EB1 RID: 3761
		[SerializeField]
		private Transitions.TransitionMode mode;

		// Token: 0x04000EB2 RID: 3762
		[SerializeField]
		private string[] stateNames;

		// Token: 0x04000EB3 RID: 3763
		[SerializeField]
		private ColorTransitions colorTransitions;

		// Token: 0x04000EB4 RID: 3764
		[SerializeField]
		private Color32Transitions color32Transitions;

		// Token: 0x04000EB5 RID: 3765
		[SerializeField]
		private SpriteSwapTransitions spriteSwapTransitions;

		// Token: 0x04000EB6 RID: 3766
		[SerializeField]
		private AnimationTransitions animationTransitions;

		// Token: 0x04000EB7 RID: 3767
		[SerializeField]
		private ObjectActivenessTransitions activenessTransitions;

		// Token: 0x04000EB8 RID: 3768
		[SerializeField]
		private AlphaTransitions alphaTransitions;

		// Token: 0x04000EB9 RID: 3769
		[SerializeField]
		private MaterialPropertyTransition materialPropertyTransitions;

		// Token: 0x020003ED RID: 1005
		public enum TransitionMode
		{
			// Token: 0x04001DCE RID: 7630
			None,
			// Token: 0x04001DCF RID: 7631
			ColorTint,
			// Token: 0x04001DD0 RID: 7632
			SpriteSwap,
			// Token: 0x04001DD1 RID: 7633
			Animation,
			// Token: 0x04001DD2 RID: 7634
			ObjectActiveness,
			// Token: 0x04001DD3 RID: 7635
			Alpha,
			// Token: 0x04001DD4 RID: 7636
			MaterialProperty,
			// Token: 0x04001DD5 RID: 7637
			Color32Tint
		}
	}
}
