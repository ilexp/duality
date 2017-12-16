﻿<root dataType="Struct" type="Duality.Resources.VertexShader" id="129723834">
  <assetInfo dataType="Struct" type="Duality.Editor.AssetManagement.AssetInfo" id="427169525">
    <customData />
    <importerId dataType="String">BasicShaderAssetImporter</importerId>
    <sourceFileHint dataType="Array" type="System.String[]" id="1100841590">
      <item dataType="String">{Name}.vert</item>
    </sourceFileHint>
  </assetInfo>
  <source dataType="String">attribute float VertexDepthOffset;
attribute float VertexAnimBlend;
varying float animBlendVar;

void main()
{
	gl_Position = TransformVertexDefault(gl_Vertex.xyz, VertexDepthOffset);
	gl_TexCoord[0] = gl_MultiTexCoord0;
	gl_FrontColor = gl_Color;
	animBlendVar = VertexAnimBlend;
}</source>
</root>
<!-- XmlFormatterBase Document Separator -->
