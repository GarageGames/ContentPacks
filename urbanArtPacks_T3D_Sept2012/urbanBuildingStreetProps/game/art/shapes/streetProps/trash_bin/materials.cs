//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- trash_bin.dae MATERIALS BEGIN ---
singleton Material(trash_bin_lod_material)
{
	mapTo = "trash_bin_lod";

	diffuseMap[0] = "trash_bin_d.dds";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 0";
	specular[0] = "1 1 1 0";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

//--- trash_bin.dae MATERIALS END ---


singleton Material(trash_bin_material)
{
   mapTo = "trash_bin";
   diffuseColor[0] = "1 1 1 0";
   diffuseMap[0] = "trash_bin_d.dds";
   normalMap[0] = "trash_bin_n.dds";
   specularPower[0] = "21";
   specularMap[0] = "trash_bin_s.dds";
   translucentBlendOp = "None";
};
