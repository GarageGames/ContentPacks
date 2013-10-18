//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- Bar props MATERIALS BEGIN ---

singleton Material(Interior_bar_props)
{
   mapTo = "Interior_bar_props";
   diffuseMap[0] = "bar_props_D.dds";
   normalMap[0] = "bar_props_N.dds";
   specular[0] = "1 1 1 0";
   specularPower[0] = "50";
   specularMap[0] = "bar_props_S.dds";
   castShadows = "0";
   translucentBlendOp = "None";
   materialTag0 = "InteriorProps";
   constantCubemapGloss = "0.2";
};
