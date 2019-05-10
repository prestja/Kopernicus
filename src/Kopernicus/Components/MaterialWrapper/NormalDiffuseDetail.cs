// Material wrapper generated by shader translator tool

using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace Kopernicus.Components.MaterialWrapper
{
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    [SuppressMessage("ReSharper", "MemberCanBeProtected.Global")]
    public class NormalDiffuseDetail : Material
    {
        // Internal property ID tracking object
        protected class Properties
        {
            // Return the shader for this wrapper
            private const String SHADER_NAME = "Legacy Shaders/Diffuse Detail";

            public static Shader Shader
            {
                get { return Shader.Find(SHADER_NAME); }
            }

            // Main Color, default = (1,1,1,1)
            public const String COLOR_KEY = "_Color";
            public Int32 ColorId { get; private set; }

            // Base (RGB), default = "white" { }
            public const String MAIN_TEX_KEY = "_MainTex";
            public Int32 MainTexId { get; private set; }

            // Detail (RGB), default = "gray" { }
            public const String DETAIL_KEY = "_Detail";
            public Int32 DetailId { get; private set; }

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
                DetailId = Shader.PropertyToID(DETAIL_KEY);
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

        // Base (RGB), default = "white" { }
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

        // Detail (RGB), default = "gray" { }
        public Texture2D Detail
        {
            get { return GetTexture(Properties.Instance.DetailId) as Texture2D; }
            set { SetTexture(Properties.Instance.DetailId, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 DetailScale
        {
            get { return GetTextureScale(Properties.DETAIL_KEY); }
            set { SetTextureScale(Properties.DETAIL_KEY, value); }
        }

        [SuppressMessage("ReSharper", "Unity.PreferAddressByIdToGraphicsParams")]
        public Vector2 DetailOffset
        {
            get { return GetTextureOffset(Properties.DETAIL_KEY); }
            set { SetTextureOffset(Properties.DETAIL_KEY, value); }
        }

        public NormalDiffuseDetail() : base(Properties.Shader)
        {
        }

        [Obsolete("Creating materials from shader source String is no longer supported. Use Shader assets instead.")]
        public NormalDiffuseDetail(String contents) : base(contents)
        {
            shader = Properties.Shader;
        }

        public NormalDiffuseDetail(Material material) : base(material)
        {
            // Throw exception if this material was not the proper material
            if (material.shader.name != Properties.Shader.name)
            {
                throw new InvalidOperationException("Type Mismatch: Legacy Shaders/Diffuse Detail shader required");
            }
        }

    }
}
