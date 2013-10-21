//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------




singleton Material(trolley_lod_material)
{
   mapTo = "trolley_lod";
   diffuseMap[0] = "trolley_diff.dds";
   translucentBlendOp = "None";
   cubemap = "refDaySkyCubemap";
   normalMap[0] = "trolley_norm.dds";
   pixelSpecular[0] = "0";
   specularMap[0] = "trolley_spec.dds";
   constantCubemapGloss = "0.2";
   materialTag0 = "RoadAndPath";
};

singleton Material(trolley_material)
{
   mapTo = "trolley";
   diffuseMap[0] = "trolley_diff.dds";
   normalMap[0] = "trolley_norm.dds";
   specularMap[0] = "trolley_spec.dds";
   pixelSpecular[0] = "0";
   cubemap = "refDaySkyCubemap";
   specular[0] = "1 1 1 0";
   specularPower[0] = "39";
   constantCubemapGloss = "0.2";
   materialTag0 = "RoadAndPath";
};
