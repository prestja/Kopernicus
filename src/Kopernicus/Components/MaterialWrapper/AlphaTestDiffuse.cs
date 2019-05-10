// Material wrapper generated by shader translator tool

using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace Kopernicus.Components.MaterialWrapper
{
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    [SuppressMessage("ReSharper", "MemberCanBeProtected.Global")]
    public class AlphaTestDiffuse : Material
    {
        // Internal property ID tracking object
        protected class Properties
        {
            // Return the shader for this wrapper
            private const String SHADER_NAME = "Legacy Shaders/Transparent/Cutout/Diffuse";

            public static Shader Shader
            {
                get { return Shader.Find(SHADER_NAME); }
            }

            // Main Color, default = (1,1,1,1)
            public const String COLOR_KEY = "_Color";
            public Int32 ColorId { get; private set; }

            // Base (RGB) Trans (A), default = "white" { }
            public const String MAIN_TEX_KEY = "_MainTex";
            public Int32 MainTexId { get; private set; }

            // Alpha cutoff, default = 0.5
            public const String CUTOFF_KEY = "_Cutoff";
            public Int32 CutoffId { get; private set; }

            // Singleton instance
            private static Properties _singleton;

            public static Properties Instance
            {
                get
                {
                    // Construct the singleton if it does not exist
                    return _singleton ?? (_singleton = new Properties());
                }
            }

            private Properties()
            {
                ColorId = Shader.PropertyToID(COLOR_KEY);
                MainTexId = Shader.PropertyToID(MAIN_TEX_KEY);
                CutoffId = Shader.PropertyToID(CUTOFF_KEY);
            }
        }

        // Is some random material this material 
        public static Boolean UsesSameShader(Material m)
        {
            return m.shader.name == Properties.Shader.name;
        }

        // Main Color, default = (1,1,1,1)
        public Color Color
        {
            get { return GetColor(Properties.Instance.ColorId); }
            set { SetColor(Properties.Instance.ColorId, value); }
        }

        // Base (RGB) Trans (A), default = "white" { }
        public Texture2D MainTex
        {
            get { return GetTexture(Properties.Instance.MainTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.MainTexId, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 MainTexScale
        {
            get { return GetTextureScale(Properties.MAIN_TEX_KEY); }
            set { SetTextureScale(Properties.MAIN_TEX_KEY, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 MainTexOffset
        {
            get { return GetTextureOffset(Properties.MAIN_TEX_KEY); }
            set { SetTextureOffset(Properties.MAIN_TEX_KEY, value); }
        }

        // Alpha cutoff, default = 0.5
        public Single Cutoff
        {
            get { return GetFloat(Properties.Instance.CutoffId); }
            set { SetFloat(Properties.Instance.CutoffId, Mathf.Clamp(value, 0f, 1f)); }
        }

        public AlphaTestDiffuse() : base(Properties.Shader)
        {
        }

        [Obsolete("Creating materials from shader source String is no longer supported. Use Shader assets instead.")]
        public AlphaTestDiffuse(String contents) : base(contents)
        {
            shader = Properties.Shader;
        }

        public AlphaTestDiffuse(Material material) : base(material)
        {
            // Throw exception if this material was not the proper material
            if (material.shader.name != Properties.Shader.name)
            {
                throw new InvalidOperationException(
                    "Type Mismatch: Legacy Shaders/Transparent/Cutout/Diffuse shader required");
            }
        }

    }
}
