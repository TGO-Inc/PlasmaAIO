namespace PlasmaAPI.Packs.Model
{
    /// <summary>
    /// Interface for classes that select the shader to use based on the material data.
    /// </summary>
    internal interface IShaderSelector
    {
        string Select(MaterialData md, bool useUnlit, ModelUtil.MtlBlendMode blendMode);
    }
}