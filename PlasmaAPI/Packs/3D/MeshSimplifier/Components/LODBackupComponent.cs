using UnityEngine;

namespace   Plasma.Packs.MeshUtil
{
    internal class LODBackupComponent : MonoBehaviour
    {
        private Renderer[] originalRenderers = null;

        public Renderer[] OriginalRenderers
        {
            get { return originalRenderers; }
            set { originalRenderers = value; }
        }
    }
}
