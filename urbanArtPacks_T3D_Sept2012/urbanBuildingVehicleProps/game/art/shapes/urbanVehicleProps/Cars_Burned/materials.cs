//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------


//--- CS_cars.dae MATERIALS BEGIN ---
singleton Material(burned_truck_material)
{
	mapTo = "burned_truck";

	diffuseMap[0] = "burned_truck_diffuse.dds";
	normalMap[0] = "burned_truck_normal.dds";
	specularMap[0] = "";

	diffuseColor[0] = "0.7 0.7 0.7 0";
	specular[0] = "1 1 1 0";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "0";
};

singleton Material(burned_cars_material)
{
	mapTo = "burned_cars";

	diffuseMap[0] = "burned_car_diffuse.dds";
	normalMap[0] = "burned_car_normal.dds";
	specularMap[0] = "burned_car_spec.dds";

	diffuseColor[0] = "0.7 0.7 0.7 0";
	specular[0] = "1 1 1 0";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "1";
};

//--- CS_cars.dae MATERIALS END ---

