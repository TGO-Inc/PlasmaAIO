using System;
using System.Collections.Generic;
using System.Reflection;

namespace Behavior
{
	// Token: 0x0200021E RID: 542
	public static class DataSelectionProvider
	{
		// Token: 0x060012A7 RID: 4775 RVA: 0x0005F494 File Offset: 0x0005D694
		static DataSelectionProvider()
		{
			Dictionary<int, string> value = new Dictionary<int, string>
			{
				{
					0,
					"Equal"
				},
				{
					1,
					"Not Equal"
				},
				{
					2,
					"Less"
				},
				{
					3,
					"Less or Equal"
				},
				{
					4,
					"Greater"
				},
				{
					5,
					"Greater or Equal"
				}
			};
			DataSelectionProvider._providers.Add(typeof(NumberComparatorAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Once"
				},
				{
					1,
					"Repeat"
				},
				{
					2,
					"Yoyo"
				}
			};
			Dictionary<int, string> value2 = DataSelectionProvider.EaseOptions();
			DataSelectionProvider._providers.Add(typeof(ColorTweenerAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				},
				{
					1,
					value2
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Once"
				},
				{
					1,
					"Repeat"
				},
				{
					2,
					"Yoyo"
				}
			};
			value2 = DataSelectionProvider.EaseOptions();
			DataSelectionProvider._providers.Add(typeof(NumberTweenerAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				},
				{
					1,
					value2
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Analog"
				},
				{
					1,
					"Stepped"
				}
			};
			DataSelectionProvider._providers.Add(typeof(KnobAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Autoscroll"
				},
				{
					1,
					"Manual Scroll"
				},
				{
					2,
					"Cursor"
				}
			};
			DataSelectionProvider._providers.Add(typeof(LCDAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Generic"
				},
				{
					1,
					"Percentage"
				},
				{
					2,
					"Time"
				},
				{
					3,
					"Integer"
				}
			};
			DataSelectionProvider._providers.Add(typeof(NumberDecoratorAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Generic"
				},
				{
					1,
					"Percentage"
				},
				{
					2,
					"Time"
				},
				{
					3,
					"Integer"
				}
			};
			DataSelectionProvider._providers.Add(typeof(MathExpressionAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Player"
				},
				{
					1,
					"Devices"
				},
				{
					2,
					"Props"
				},
				{
					3,
					"Environment"
				},
				{
					4,
					"All"
				}
			};
			DataSelectionProvider._providers.Add(typeof(DistanceSensorAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Player"
				},
				{
					1,
					"Devices"
				},
				{
					2,
					"Props"
				},
				{
					3,
					"Projectiles"
				},
				{
					4,
					"All"
				}
			};
			value2 = new Dictionary<int, string>
			{
				{
					0,
					"Sphere"
				},
				{
					1,
					"Box"
				}
			};
			DataSelectionProvider._providers.Add(typeof(ProximitySensorAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				},
				{
					1,
					value2
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Left"
				},
				{
					1,
					"Center"
				},
				{
					2,
					"Right"
				}
			};
			value2 = new Dictionary<int, string>
			{
				{
					0,
					"Top"
				},
				{
					1,
					"Center"
				},
				{
					2,
					"Bottom"
				}
			};
			DataSelectionProvider._providers.Add(typeof(ScreenAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				},
				{
					1,
					value2
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Left"
				},
				{
					1,
					"Center"
				},
				{
					2,
					"Right"
				}
			};
			value2 = new Dictionary<int, string>
			{
				{
					0,
					"Top"
				},
				{
					1,
					"Center"
				},
				{
					2,
					"Bottom"
				}
			};
			DataSelectionProvider._providers.Add(typeof(TabletAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				},
				{
					1,
					value2
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Horizontal"
				},
				{
					1,
					"Vertical"
				}
			};
			DataSelectionProvider._providers.Add(typeof(SliderAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Generic"
				},
				{
					1,
					"Percentage"
				},
				{
					2,
					"Time"
				},
				{
					3,
					"Integer"
				}
			};
			DataSelectionProvider._providers.Add(typeof(ParserAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Log"
				},
				{
					2,
					"Warning"
				}
			};
			DataSelectionProvider._providers.Add(typeof(LoggerAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
			value = DataSelectionProvider.EaseOptions();
			value2 = new Dictionary<int, string>
			{
				{
					0,
					"Generic"
				},
				{
					1,
					"Percentage"
				},
				{
					2,
					"Time"
				},
				{
					3,
					"Integer"
				}
			};
			DataSelectionProvider._providers.Add(typeof(PercentageMapperAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				},
				{
					1,
					value2
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Player"
				},
				{
					1,
					"Devices"
				},
				{
					2,
					"Props"
				},
				{
					3,
					"Environment"
				},
				{
					4,
					"Projectiles"
				},
				{
					5,
					"All"
				}
			};
			DataSelectionProvider._providers.Add(typeof(ImpactSensorAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Player"
				},
				{
					1,
					"Devices"
				},
				{
					2,
					"Props"
				},
				{
					3,
					"Environment"
				},
				{
					4,
					"Projectiles"
				},
				{
					5,
					"All"
				}
			};
			DataSelectionProvider._providers.Add(typeof(CollisionDetectorAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Left"
				},
				{
					1,
					"Center"
				},
				{
					2,
					"Right"
				}
			};
			DataSelectionProvider._providers.Add(typeof(LabelAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"AND"
				},
				{
					1,
					"OR"
				}
			};
			DataSelectionProvider._providers.Add(typeof(LogicOperatorAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"AND"
				},
				{
					1,
					"OR"
				},
				{
					2,
					"XOR"
				},
				{
					3,
					"NOR"
				},
				{
					4,
					"NAND"
				},
				{
					5,
					"NOT"
				}
			};
			DataSelectionProvider._providers.Add(typeof(BooleanOperatorAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Left"
				},
				{
					1,
					"Center"
				},
				{
					2,
					"Right"
				}
			};
			DataSelectionProvider._providers.Add(typeof(UITextAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"Log"
				},
				{
					1,
					"Normal"
				},
				{
					2,
					"Warning"
				},
				{
					3,
					"Error"
				},
				{
					-1,
					"All"
				}
			};
			DataSelectionProvider._providers.Add(typeof(LogMonitorAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
			value = new Dictionary<int, string>
			{
				{
					0,
					"System"
				},
				{
					1,
					"Steam"
				}
			};
			DataSelectionProvider._providers.Add(typeof(BrowserAgent), new Dictionary<int, Dictionary<int, string>>
			{
				{
					0,
					value
				}
			});
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x0005FCE8 File Offset: 0x0005DEE8
		public static string GetOption(Data.Selection selection)
		{

            return default;
        }

		// Token: 0x060012A9 RID: 4777 RVA: 0x0005FDD8 File Offset: 0x0005DFD8
		public static Dictionary<int, string> GetOptions(Data.Selection selection)
		{

            return default;
        }

		// Token: 0x060012AA RID: 4778 RVA: 0x0005FEAC File Offset: 0x0005E0AC
		private static Dictionary<int, string> EaseOptions()
		{

            return default;
        }

		// Token: 0x04000F8A RID: 3978
		private static Dictionary<Type, Dictionary<int, Dictionary<int, string>>> _providers = new Dictionary<Type, Dictionary<int, Dictionary<int, string>>>();
	}
}
