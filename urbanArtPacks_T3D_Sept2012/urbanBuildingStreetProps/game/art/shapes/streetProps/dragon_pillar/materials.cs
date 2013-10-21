//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------


singleton Material(dragonpillar_material)
{
   mapTo = "dragonpillar";
   diffuseColor[0] = "1 1 1 0";
   diffuseMap[0] = "dragonpillar_d.dds";
   normalMap[0] = "dragonpillar_n.dds";
   specular[0] = "0.470588 0.564706 0.619608 1";
   specularPower[0] = "31";
   pixelSpecular[0] = "0";
   translucentBlendOp = "None";
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
   specularMap[0] = "dragonpillar_s.dds";
   translucent = "1";
   alphaTest = "1";
   alphaRef = "20";
};


singleton Material(dragon_pillar_ColorEffectR8G110B135_material)
{
   mapTo = "ColorEffectR8G110B135-material";
   diffuseColor[0] = "0.0313726 0.431373 0.529412 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
