//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- Car_White MATERIALS BEGIN ---
singleton Material(car_white_material)
{
	mapTo = "car_white";

	diffuseMap[0] = "car_white_diff.dds";
	normalMap[0] = "";
	specularMap[0] = "car_spec.dds";

	diffuseColor[0] = "1 1 1 0";
	specular[0] = "0.2 0.2 0.2 1";
	specularPower[0] = 50;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";	
   cubemap = "refnightSkyCubemap";
   constantCubemapGloss = "0.2";
   materialTag0 = "RoadAndPath";
};
singleton Material(car_white_lod_material)
{
	mapTo = "car_white_lod";

	diffuseMap[0] = "car_white_diff.dds";
	diffuseColor[0] = "1 1 1 0";
	castShadows = "0";
   constantCubemapGloss = "0.2";
   materialTag0 = "RoadAndPath";
   doubleSided = "1";
   customFootstepSound = "playerFootstepPlaylist";
};


//--- Car_White.dae MATERIALS END ---


//--- Car_Black MATERIALS BEGIN ---
singleton Material(car_black_material)
{
	mapTo = "car_black";

	diffuseMap[0] = "car_black_diff.dds";
	normalMap[0] = "";
	specularMap[0] = "car_spec.dds";

	diffuseColor[0] = "0.396078 0.396078 0.396078 1";
	specular[0] = "0.25098 0.25098 0.25098 1";
	specularPower[0] = 1;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";	
   cubemap = "refnightSkyCubemap";
   pixelSpecular[0] = "1";
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
};
singleton Material(car_black_lod_material)
{
	mapTo = "car_black_lod";

	diffuseMap[0] = "car_black_diff.dds";
	diffuseColor[0] = "0.27451 0.27451 0.27451 1";
	castShadows = "0";
   materialTag0 = "RoadAndPath";
   specularMap[0] = "car_spec.dds";
   constantCubemapGloss = "0.2";
};

//--- Car_Black MATERIALS END ---



//--- Car_Blue MATERIALS BEGIN ---
singleton Material(car_blue_material)
{
	mapTo = "car_blue";

	diffuseMap[0] = "car_blue_diff.dds";
	normalMap[0] = "";
	specularMap[0] = "car_spec.dds";

	diffuseColor[0] = "0.717647 0.717647 0.717647 1";
	specular[0] = "0.2 0.2 0.2 1";
	specularPower[0] = 16;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";	
   pixelSpecular[0] = "1";
   cubemap = "refnightSkyCubemap";
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
};
singleton Material(car_blue_lod_material)
{
	mapTo = "car_blue_lod";

	diffuseMap[0] = "car_blue_diff.dds";
	diffuseColor[0] = "0.71 0.71 0.71 1";
	castShadows = "0";
   specularPower[0] = "1";
   cubemap = "";
   pixelSpecular[0] = "0";
   specularMap[0] = "";
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
   doubleSided = "1";
   customFootstepSound = "playerFootstepPlaylist";
};
//--- Car_Blue MATERIALS END ---



//--- Car_Green MATERIALS BEGIN ---


singleton Material(car_green_material)
{
	mapTo = "car_green";

	diffuseMap[0] = "car_green_diff.dds";
	normalMap[0] = "";
	specularMap[0] = "car_spec.dds";

	diffuseColor[0] = "1 1 1 0";
	specular[0] = "0.2 0.2 0.2 1";
	specularPower[0] = 41;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";	
   constantCubemapGloss = "0.2";
   materialTag0 = "RoadAndPath";
};
singleton Material(car_green_lod_material)
{
	mapTo = "car_green_lod";

	diffuseMap[0] = "car_green_diff.dds";
	diffuseColor[0] = "1 1 1 0";
	castShadows = "0";
   constantCubemapGloss = "0.2";
   materialTag0 = "RoadAndPath";
   doubleSided = "1";
   customFootstepSound = "playerFootstepPlaylist";
};
//--- Car_Green MATERIALS END ---



//--- Car_Police MATERIALS BEGIN ---
singleton Material(car_police_material)
{
	mapTo = "car_police";

	diffuseMap[0] = "car_police_diff.dds";
	normalMap[0] = "";
	specularMap[0] = "car_spec.dds";

	diffuseColor[0] = "0.992157 0.992157 0.992157 0";
	specular[0] = "0.992157 0.992157 0.992157 1";
	specularPower[0] = 44;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";	
   cubemap = "refnightSkyCubemap";
   pixelSpecular[0] = "1";
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
};
singleton Material(car_police_lod_material)
{
	mapTo = "car_police_lod";

	diffuseMap[0] = "car_police_diff.dds";
	diffuseColor[0] = "1 1 1 0";
	castShadows = "0";
   specularPower[0] = "1";
   pixelSpecular[0] = "0";
   specularMap[0] = "";
   materialTag0 = "RoadAndPath";
};

//--- Car_Police MATERIALS END ---



//--- Car_Red MATERIALS BEGIN ---
singleton Material(car_red_material)
{
	mapTo = "car_red";

	diffuseMap[0] = "car_red_diff.dds";
	normalMap[0] = "";
	specularMap[0] = "car_spec.dds";

	diffuseColor[0] = "0.992157 0.992157 0.992157 0";
	specular[0] = "0.992157 0.992157 0.992157 1";
	specularPower[0] = 44;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";	
   cubemap = "refnightSkyCubemap";
   pixelSpecular[0] = "1";
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
};
singleton Material(car_red_lod_material)
{
	mapTo = "car_red_lod";

	diffuseMap[0] = "car_red_diff.dds";
	diffuseColor[0] = "1 1 1 0";
	castShadows = "0";
   specularPower[0] = "1";
   pixelSpecular[0] = "0";
   specularMap[0] = "";
   materialTag0 = "RoadAndPath";
};

//--- Car_Red MATERIALS END ---




//--- Car_Yellow MATERIALS BEGIN ---
singleton Material(car_yellow_material)
{
	mapTo = "car_yellow";

	diffuseMap[0] = "car_yellow_diff.dds";
	normalMap[0] = "";
	specularMap[0] = "car_spec.dds";

	diffuseColor[0] = "1 1 1 0";
	specular[0] = "0.2 0.2 0.2 1";
	specularPower[0] = 14;
	useAnisotropic[0] = true;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";	
   cubemap = "refnightSkyCubemap";
   pixelSpecular[0] = "1";
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
};
singleton Material(car_yellow_lod_material)
{
	mapTo = "car_yellow_lod";

	diffuseMap[0] = "car_yellow_diff.dds";
	diffuseColor[0] = "1 1 1 0";
	castShadows = "0";
   materialTag0 = "RoadAndPath";
   doubleSided = "1";
   customFootstepSound = "playerFootstepPlaylist";
   constantCubemapGloss = "0.2";
};
//--- Car_Yellow MATERIALS END ---




singleton Material(car_windows_material)
{
   mapTo = "car_windows";
   diffuseColor[0] = "0.8 0.8 0.8 0";
   diffuseMap[0] = "car_black_diff.dds";
   specular[0] = "0.25098 0.25098 0.254902 0.444";
   specularPower[0] = "56";
   specularMap[0] = "";
   translucent = "1";
   translucentBlendOp = "LerpAlpha";
   translucentZWrite = "0";
   cubemap = "refDaySkyCubemap";
   alphaRef = "0";
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
   pixelSpecular[0] = "0";
   doubleSided = "1";
   customFootstepSound = "playerFootstepPlaylist";
};
singleton Material(car_windows_lod_material)
{
	mapTo = "car_GlassLOD";

   diffuseMap[0] = "car_black_diff.dds";
	diffuseColor[0] = "1 1 1 0";
	castShadows = "1";
   translucent = "1";
   translucentZWrite = "0";
   materialTag0 = "RoadAndPath";
   constantCubemapGloss = "0.2";
   cubemap = "refDaySkyCubemap";
};


singleton Material(car_black_ColorEffectR27G177B148_material)
{
   mapTo = "ColorEffectR27G177B148-material";
   diffuseColor[0] = "0.105882 0.694118 0.580392 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
