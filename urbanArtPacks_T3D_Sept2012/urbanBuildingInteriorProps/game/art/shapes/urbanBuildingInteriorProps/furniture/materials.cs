//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- Furniture MATERIALS BEGIN ---

singleton Material(furniture)
{   
   mapTo = "furniture";
   diffuseMap[0] = "furniture_D.dds";
   normalMap[0] = "furniture_N.dds";
   specular[0] = "1 1 1 0";
   specularPower[0] = "50";
   specularMap[0] = "furniture_S.dds";
   castShadows = "0";
   translucentBlendOp = "None";
   materialTag0 = "InteriorProps";
   constantCubemapGloss = "0.2";
};
