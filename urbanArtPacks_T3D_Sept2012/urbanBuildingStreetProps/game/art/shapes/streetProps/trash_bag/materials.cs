//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- rub_bag.dae MATERIALS BEGIN ---
singleton Material(trash_bag_material)
{
	mapTo = "trash_bag";

	diffuseMap[0] = "trash_bag_d.dds";
	normalMap[0] = "trash_bag_n.dds";
	specularMap[0] = "trash_bag_s.dds";

	diffuseColor[0] = "0.8 0.8 0.8 0";
	specularPower[0] = 31;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

//--- rub_bag.dae MATERIALS END ---

