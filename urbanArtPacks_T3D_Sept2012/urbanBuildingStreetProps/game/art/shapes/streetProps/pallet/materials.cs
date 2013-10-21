//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------



singleton Material(pallet_material)
{
	mapTo = "pallet";

	diffuseMap[0] = "pallet_d.dds";
	normalMap[0] = "pallet_n.dds";
	specularMap[0] = "pallet_s.dds";

	diffuseColor[0] = "1 1 1 0";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   detailMap[0] = "pallet_detail.dds";
   detailScale[0] = "10 10";
};



