//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- fireHydrant.dae MATERIALS BEGIN ---

singleton Material(firehydrant_material)
{
	mapTo = "firehydrant";

	diffuseMap[0] = "hydrant_d.dds";
	normalMap[0] = "hydrant_n.dds";
	specularMap[0] = "hydrant_s.dds";

	specular[0] = "0 0 0 0";
	specularPower[0] = 1;
	pixelSpecular[0] = 0;
   constantCubemapGloss = "0.2";
   materialTag0 = "RoadAndPath";

	//doubleSided = false;
	//translucent = false;
	//translucentBlendOp = "None";
};


singleton Material(hydrant_ColorEffectR228G153B184_material)
{
   mapTo = "ColorEffectR228G153B184-material";
   diffuseColor[0] = "0.894118 0.6 0.721569 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
