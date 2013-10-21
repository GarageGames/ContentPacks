//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------




singleton Material(baracades_material)
{
   mapTo = "baracades";
   specular[0] = "1 1 1 0";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   diffuseMap[0] = "baracades_diff.dds";
   normalMap[0] = "baracades_normals.dds";
   pixelSpecular[0] = "0";
   specularMap[0] = "baracades_spec.dds";
   constantCubemapGloss = "0.2";
   materialTag0 = "RoadAndPath";
};

singleton Material(baracades_lod_material)
{
   mapTo = "baracades_lod";
   translucentBlendOp = "None";
   diffuseMap[0] = "baracades_diff.dds";
};

singleton Material(baracade_police_ColorEffectR135G110B8_material)
{
   mapTo = "ColorEffectR135G110B8-material";
   diffuseColor[0] = "0.529412 0.431373 0.0313726 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
