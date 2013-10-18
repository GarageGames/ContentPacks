//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- Residential Props MATERIALS BEGIN ---

singleton Material(residential_props)
{   
   mapTo = "residential_props";
   diffuseMap[0] = "art/shapes/chinatown_interior_props/residential_props/residential_props_D.dds";
   normalMap[0] = "art/shapes/chinatown_interior_props/residential_props/residential_props_N.dds";
   specular[0] = "1 1 1 0";
   specularPower[0] = "50";
   specularMap[0] = "art/shapes/chinatown_interior_props/residential_props/residential_props_S.dds";
   castShadows = "0";
   translucentBlendOp = "None";
   materialTag0 = "InteriorProps";
   constantCubemapGloss = "0.2";
   alphaTest = "1";
   alphaRef = "175";
};
