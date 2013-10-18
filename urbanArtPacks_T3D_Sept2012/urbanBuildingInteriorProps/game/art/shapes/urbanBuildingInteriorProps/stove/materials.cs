//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- Stove MATERIALS BEGIN ---

singleton Material(stove)
{   
   mapTo = "stove";
   diffuseMap[0] = "stove_D.dds";
   normalMap[0] = "stove_N.dds";
   specular[0] = "1 1 1 0";
   specularPower[0] = "50";
   specularMap[0] = "stove_S.dds";
   castShadows = "0";
   translucentBlendOp = "None";
   materialTag0 = "InteriorProps";
   constantCubemapGloss = "0.2";
};
