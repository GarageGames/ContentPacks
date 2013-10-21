//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- food_cart.dae MATERIALS BEGIN ---
singleton Material(gas_cylinder_material)
{
	mapTo = "gas_cylinder";

	diffuseMap[0] = "gas_cylinder_diff.dds";
	specularMap[0] = "gas_cylinder_spec.dds";

	specular[0] = "1 1 1 0";
	specularPower[0] = 50;

	//doubleSided = false;
	//translucent = false;
	//translucentBlendOp = "None";
};

singleton Material(gas_cylinder_lod_material)
{
	mapTo = "gas_cylinder_lod";

	diffuseMap[0] = "gas_cylinder_diff.dds";
	castShadows = "0";
};







singleton Material(food_cart)
{
   mapTo = "food_cart";
   
   diffuseMap[0] = "food_cart_diff.dds";
   normalMap[0] = "food_cart_norm.dds";
   specularMap[0] = "food_cart_spec.dds";
	
   specular[0] = "1 1 1 1";
   specularPower[0] = "24";
   pixelSpecular[0] = "0";
   constantCubemapGloss = "0.2";
   materialTag0 = "SkySNight";
   	useAnisotropic[0] = true;
  
   //translucentBlendOp = "LerpAlpha"; 
};

singleton Material(food_cart_lod_material)
{
	mapTo = "food_cart_lod";

	diffuseMap[0] = "food_cart_diff.dds";
	castShadows = "0";
   specularMap[0] = "food_cart_spec.dds";
};





singleton Material(posters_material)
{
	mapTo = "posters";

	diffuseMap[0] = "posters_diff.dds";
	
	specular[0] = "1 1 1 0";
	specularPower[0] = 50;

	//doubleSided = false;
	//translucent = true;
	translucentBlendOp = "LerpAlpha";
	useAnisotropic[0] = true;
};

singleton Material(postersLOD_material)
{
	mapTo = "postersLOD";

	diffuseMap[0] = "posters_diff.dds";
	castShadows = "0";
};

singleton Material(food_cart_posters_lod)
{
   mapTo = "posters_lod";
   diffuseMap[0] = "posters_diff";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
