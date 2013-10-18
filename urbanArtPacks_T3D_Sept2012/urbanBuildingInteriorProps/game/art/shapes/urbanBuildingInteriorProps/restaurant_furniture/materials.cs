//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- Restaurant Furniture MATERIALS BEGIN ---

singleton Material(restaurant_furniture)
{   
   mapTo = "restaurant_furniture";
   diffuseMap[0] = "restaurant_furniture_D.dds";
   normalMap[0] = "restaurant_furniture_N.dds";
   specular[0] = "1 1 1 0";
   specularPower[0] = "50";
   specularMap[0] = "restaurant_furniture_S.dds";
   castShadows = "0";
   translucentBlendOp = "None";
   materialTag0 = "InteriorProps";
   constantCubemapGloss = "0.2";
};
