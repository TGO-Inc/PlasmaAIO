using Newtonsoft.Json.Linq;
using PrefabUtil.Extensions;
using System.Collections.Generic;

namespace PrefabUtil.Internal.Temp
{
    internal class PrefabHolder
    {
        public long id;
        public long pid;
        public string type;
        public string name;
        public string tag;
        public JObject data;
        public JObject child;
        public List<long> children;
        public PrefabHolder(long id, string type, JObject data, JObject child, List<long> children, long pid, string name, string tag)
        {
            this.id = id;
            this.type = type;
            this.data = data;
            this.child = child;
            this.children = children;
            this.pid = pid;
            this.name = name;
            this.tag = tag;
        }
        public void LoadChildren(Prefab parent, Dictionary<long, PrefabHolder> holder, Dictionary<long, long> map)
        {
            foreach (var cid in children)
            {
                var child_holder = holder[cid];

                Prefab child = new Prefab()
                {
                    Parent = parent,
                    Id = child_holder.id,
                    ParentId = parent.Id,
                    Type = child_holder.type,
                    Children = new List<Prefab>(),
                    Components = new List<Prefab>(),
                    Name = child_holder.child.GetValueString("m_Name"),
                    Tag = child_holder.child.GetValueString("m_TagString"),
                    Root = child_holder.child.StripGameObject()
                };

                if (!parent.Type.Equals("GameObject"))
                {
                    var pnt = holder[child_holder.pid];
                    var np = new Prefab()
                    {
                        ParentId = parent.ParentId,
                        Children = new List<Prefab>(),
                        Components = new List<Prefab>(),
                        Name = pnt.child.GetValueString("m_Name"),
                        Tag = pnt.child.GetValueString("m_TagString"),
                        Root = pnt.child.StripGameObject(),
                        Id = pnt.id,
                        Type = pnt.type
                    };
                    parent.Parent.Children.Add(np);
                    pnt.LoadChildren(np, holder, map);
                }
                else
                {
                    if (child_holder.type.Equals("GameObject"))
                        parent.Children.Add(child);
                    else
                        parent.Components.Add(child);
                    child_holder.LoadChildren(child, holder, map);
                }
            }
        }
    }
}
