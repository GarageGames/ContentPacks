//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------


//--- ReatPlanters.dae MATERIALS BEGIN ---
singleton Material(ceramic_planter_material)
{
	mapTo = "ceramic_planter";

	diffuseMap[0] = "ceramic_planter_d.dds";
	normalMap[0] = "ceramic_planter_n.dds";
	specularMap[0] = "ceramic_planter_s.dds";

	diffuseColor[0] = "0.443137 0.443137 0.443137 1";
	specular[0] = "1 1 1 0";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "5";
};

singleton Material(ceramic_planter_lod_material)
{
	mapTo = "ceramic_planter_lod";

	diffuseMap[0] = "ceramic_planter_d.dds";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.537255 0.537255 0.537255 1";
	specular[0] = "1 1 1 0";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
	   alphaTest = "1";
   alphaRef = "5";
   materialTag0 = "RoadAndPath";
};

//--- ReatPlanters.dae MATERIALS END ---
