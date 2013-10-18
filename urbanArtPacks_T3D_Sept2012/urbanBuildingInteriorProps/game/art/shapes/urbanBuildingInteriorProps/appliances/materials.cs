//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- Appliances MATERIALS BEGIN ---


singleton Material(appliances)
{
   mapTo = "appliances";
   diffuseMap[0] = "appliances_D.dds";
   normalMap[0] = "appliances_N.dds";
   specular[0] = "1 1 1 0";
   specularPower[0] = "50";
   specularMap[0] = "appliances_S.dds";
   castShadows = "0";
   translucentBlendOp = "None";
   materialTag0 = "InteriorProps";
   constantCubemapGloss = "0.2";
};
