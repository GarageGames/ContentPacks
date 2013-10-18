//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- Kitchen Props MATERIALS BEGIN ---

singleton Material(kitchen_props)
{   
   mapTo = "kitchen_props";
   diffuseMap[0] = "kitchen_props_D.dds";
   normalMap[0] = "kitchen_props_N.dds";
   specular[0] = "1 1 1 0";
   specularPower[0] = "50";
   specularMap[0] = "kitchen_props_S.dds";
   castShadows = "0";
   translucentBlendOp = "None";
   materialTag0 = "InteriorProps";
   constantCubemapGloss = "0.2";
};
