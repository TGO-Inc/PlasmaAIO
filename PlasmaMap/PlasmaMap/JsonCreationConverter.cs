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
// Token: 0x020000EA RID: 234
public abstract class JsonCreationConverter<T> : JsonConverter
{
	// Token: 0x060009EE RID: 2542
	protected abstract T Create(Type objectType, JObject jObject);

	// Token: 0x060009EF RID: 2543 RVA: 0x00034B6B File Offset: 0x00032D6B
	public override bool CanConvert(Type objectType)
	{

        return default;
    }

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00034B7D File Offset: 0x00032D7D
	public override bool CanWrite
	{
		get
		{
			return false;
		}
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x00034B80 File Offset: 0x00032D80
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{

        return default;
    }
}
}