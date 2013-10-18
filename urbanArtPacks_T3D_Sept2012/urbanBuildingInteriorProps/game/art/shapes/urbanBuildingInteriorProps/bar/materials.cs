//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- Bar MATERIALS BEGIN ---

singleton Material(Interior_props_bar)
{   
   mapTo = "bar";
   diffuseMap[0] = "bar_D.dds";
   normalMap[0] = "bar_N.dds";
   specular[0] = "1 1 1 0";
   specularPower[0] = "50";
   specularMap[0] = "bar_S.dds";
   castShadows = "0";
   translucentBlendOp = "None";
   materialTag0 = "InteriorProps";
   constantCubemapGloss = "0.2";
};
