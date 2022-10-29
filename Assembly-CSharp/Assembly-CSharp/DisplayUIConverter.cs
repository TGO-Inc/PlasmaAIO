using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PlasmaAPI.GameClass {
// Token: 0x020000E9 RID: 233
public class DisplayUIConverter : JsonCreationConverter<DisplayUIElement>
{
	// Token: 0x060009EA RID: 2538 RVA: 0x00034AEC File Offset: 0x00032CEC
	protected override DisplayUIElement Create(Type objectType, JObject jObject)
	{

        return default;
    }

	// Token: 0x060009EB RID: 2539 RVA: 0x00034B50 File Offset: 0x00032D50
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{

	}

	// Token: 0x060009EC RID: 2540 RVA: 0x00034B57 File Offset: 0x00032D57
	private static bool FieldExists(string fieldName, JObject jObject)
	{

        return default;
    }
}
}