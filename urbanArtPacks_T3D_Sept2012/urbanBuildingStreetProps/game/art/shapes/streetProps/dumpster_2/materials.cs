//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- Dumpster_2.dae MATERIALS BEGIN ---
singleton Material(dumpster_2_material)
{
	mapTo = "dumpster_2";

	diffuseMap[0] = "dumpster_2_d.dds";
	normalMap[0] = "dumpster_2_n.dds";
	specularMap[0] = "dumpster_2_s.dds";

	specular[0] = "1 1 1 0";
	specularPower[0] = 50;
	pixelSpecular[0] = 0;
   constantCubemapGloss = "0.2";
   materialTag0 = "RoadAndPath";

	//doubleSided = false;
	//translucent = false;
	//translucentBlendOp = "None";
};

