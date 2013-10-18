//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- Coffee MATERIALS BEGIN ---

singleton Material(Interior_props_coffee)
{   
   mapTo = "interior_props_coffee";
   diffuseMap[0] = "coffee_machine_D.dds";
   normalMap[0] = "coffee_machine_N.dds";
   specular[0] = "1 1 1 0";
   specularPower[0] = "50";
   specularMap[0] = "coffee_machine_S.dds";
   castShadows = "0";
   translucentBlendOp = "None";
   materialTag0 = "InteriorProps";
   constantCubemapGloss = "0.2";
   alphaTest = "1";
   alphaRef = "73";
};
