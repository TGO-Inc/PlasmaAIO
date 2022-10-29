using UnityEngine;

namespace PlasmaAPI.Packs.ImportModel
{
    /// <summary>
    /// Implementation of IMaterialFactory that creates a material based on the shader name.
    /// </summary>
    internal class MaterialFactory : IMaterialFactory
    {
        /// <inheritdoc/>
        public Material Create(string shaderName)
        {
            return new Material(Shader.Find(shaderName));
        }
    }
}