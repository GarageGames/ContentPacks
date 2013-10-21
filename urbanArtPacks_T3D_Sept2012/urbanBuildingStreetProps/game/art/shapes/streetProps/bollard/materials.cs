//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- bollard.dae MATERIALS BEGIN ---
singleton Material(bollard_material)
{
	mapTo = "bollard";

	diffuseMap[0] = "bollard_diffuse.dds";
	normalMap[0] = "bollard_norm.dds";
	specularMap[0] = "bollard_spec.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "1 1 1 0";
	specularPower[0] = 4;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "0";
   constantCubemapGloss = "0.2";
   materialTag0 = "RoadAndPath";
};

//--- bollard.dae MATERIALS END ---

