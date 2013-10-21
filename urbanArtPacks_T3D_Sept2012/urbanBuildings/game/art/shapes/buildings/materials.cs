//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

//--- ChinaTownBuildings MATERIALS BEGIN ---

singleton Material(allborders_mat)
{
   mapTo = "allborders";
   diffuseMap[0] = "./textures/allBorders_D.dds";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   normalMap[0] = "./textures/allBorders_N.dds";
   specularMap[0] = "./textures/allBorders_S.dds";
   materialTag0 = "BuildingStructures";
   constantCubemapGloss = "0.2";
};

singleton Material(props_allprops_mat)
{
   mapTo = "props_allprops";
   diffuseMap[0] = "./textures/allProps_D.dds";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   normalMap[0] = "./textures/allProps_N.dds";
   specularMap[0] = "./textures/allPropss_S.dds";
   materialTag0 = "BuildingStructures";
   constantCubemapGloss = "0.2";
   alphaTest = "1";
   alphaRef = "50";
};

singleton Material(walls_concrete_001_mat)
{
   mapTo = "walls_concrete_001";
   diffuseMap[0] = "./textures/concrete_001_D.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./textures/concrete_001_N.dds";
   specularMap[0] = "./textures/concrete_001_S.dds";
   materialTag0 = "BuildingStructures";
   constantCubemapGloss = "0.2";
};

singleton Material(walls_brick_001_mat)
{
   mapTo = "walls_brick_001";
   diffuseMap[0] = "./textures/brick_001_D.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./textures/brick_001_N.dds";
   specularMap[0] = "./textures/brick_001_S.dds";
   materialTag0 = "BuildingStructures";
   constantCubemapGloss = "0.2";
};

singleton Material(walls_brick_002_mat)
{
   mapTo = "walls_brick_002";
   diffuseMap[0] = "./textures/brick_002_D.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./textures/brick_002_N.dds";
   specularMap[0] = "./textures/brick_002_S.dds";
   materialTag0 = "BuildingStructures";
   constantCubemapGloss = "0.2";
};

singleton Material(walls_brick_003_mat)
{
   mapTo = "walls_brick_003";
   diffuseMap[0] = "./textures/brick_003_D";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./textures/brick_003_N.dds";
   specularMap[0] = "./textures/brick_003_S.dds";
   materialTag0 = "BuildingStructures";
};

singleton Material(walls_brick_004_mat)
{
   mapTo = "walls_brick_004";
   diffuseMap[0] = "./textures/brick_004_D.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./textures/brick_004_N.dds";
   specularMap[0] = "./textures/brick_004_S.dds";
   materialTag0 = "BuildingStructures";
   constantCubemapGloss = "0.2";
};

singleton Material(walls_brick_005_mat)
{
   mapTo = "walls_brick_005";
   diffuseMap[0] = "./textures/brick_005_D.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./textures/brick_005_N.dds";
   specularMap[0] = "./textures/brick_005_S.dds";
   materialTag0 = "BuildingStructures";
   constantCubemapGloss = "0.2";
};

singleton Material(walls_plaster_001_mat)
{
   mapTo = "walls_plaster_001";
   diffuseMap[0] = "./textures/plaster_001_D.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";
   normalMap[0] = "./textures/plaster_all_N.dds";
   specularMap[0] = "./textures/plaster_all_S.dds";
   constantCubemapGloss = "0.2";
};

singleton Material(windows_doors_mat)
{
   mapTo = "windows_doors";
   diffuseMap[0] = "./textures/windowsDoors_D.dds";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   normalMap[0] = "./textures/windowsDoors_N.dds";
   specularMap[0] = "./textures/windowsDoors_S.dds";
   materialTag0 = "BuildingStructures";
   constantCubemapGloss = "0.2";
};

singleton Material(building_001_LOD_mat)
{
   mapTo = "building_001_LOD";
   diffuseMap[0] = "./textures/building_005_LOD_D.dds";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";   
   constantCubemapGloss = "0.2";
};

singleton Material(walls_plaster_002_mat)
{
   mapTo = "walls_plaster_002";
   diffuseMap[0] = "./textures/plaster_002_D.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./textures/plaster_all_N.dds";
   specularMap[0] = "./textures/plaster_all_S.dds";
   materialTag0 = "BuildingStructures";
   constantCubemapGloss = "0.2";
};

singleton Material(walls_plaster_003_mat)
{
   mapTo = "walls_plaster_003";
   diffuseMap[0] = "./textures/plaster_003_D.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./textures/plaster_all_N.dds";
   specularMap[0] = "./textures/plaster_all_S.dds";
   materialTag0 = "BuildingStructures";
   constantCubemapGloss = "0.2";
};

singleton Material(windows_GlassPanes_mat)
{
   mapTo = "windows_GlassPanes";
   diffuseMap[0] = "./textures/glass_D.dds";
   specularPower[0] = "50";
   translucentBlendOp = "LerpAlpha";
   materialTag0 = "BuildingStructures";   
   constantCubemapGloss = "0.2";
   translucent = "1";
   translucentZWrite = "1";
};

singleton Material(interiors_intWall_001_mat)
{
   mapTo = "interiors_intWall_001";
   diffuseMap[0] = "./textures/intWall01_D.dds";
   specularPower[0] = "1";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";   
   constantCubemapGloss = "0.2";
   normalMap[0] = "./textures/intWall01_N.dds";
   specular[0] = "0 0 0 0";
   specularMap[0] = "./textures/intWall01_S.dds";
};

singleton Material(interiors_intWall_002_mat)
{
   mapTo = "interiors_intWall_002";
   diffuseMap[0] = "./textures/intWall02_D.dds";
   normalMap[0] = "./textures/intWall02_N.dds";
   specular[0] = "0 0 0 0";
   specularPower[0] = "1";
   specularMap[0] = "./textures/intWall02_S.dds";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";   
   constantCubemapGloss = "0.2";
};

singleton Material(interiors_intWall_003_mat)
{
   mapTo = "interiors_intWall_003";
   diffuseMap[0] = "./textures/intWall03_D.dds";
   normalMap[0] = "./textures/intWall03_N.dds";
   specular[0] = "0 0 0 0";
   specularPower[0] = "1";
   specularMap[0] = "./textures/intWall03_S.dds";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";   
   constantCubemapGloss = "0.2";
};

singleton Material(interiors_intWall_004_mat)
{
   mapTo = "interiors_intWall_004";
   diffuseMap[0] = "./textures/intWall04_D.dds";
   normalMap[0] = "./textures/intWall04_N.dds";
   specular[0] = "0 0 0 0";
   specularPower[0] = "1";
   specularMap[0] = "./textures/intWall04_S.dds";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";
};

singleton Material(interiors_intWall_005_mat)
{
   mapTo = "interiors_intWall_005";
   diffuseMap[0] = "./textures/intWall05_D.dds";
   normalMap[0] = "./textures/intWall05_N.dds";
   specular[0] = "0 0 0 0";
   specularPower[0] = "1";
   specularMap[0] = "./textures/intWall05_S.dds";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";   
   constantCubemapGloss = "0.2";
};

singleton Material(interiors_intWall_006_mat)
{
   mapTo = "interiors_intWall_006";
   diffuseMap[0] = "./textures/intWall06_D.dds";
   normalMap[0] = "./textures/intWall06_N.dds";
   specular[0] = "0 0 0 0";
   specularPower[0] = "1";
   specularMap[0] = "./textures/intWall06_S.dds";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";   
   diffuseColor[0] = "0.7 0.7 0.7 0";
   constantCubemapGloss = "0.2";
};

singleton Material(interiors_stairs_mat)
{
   mapTo = "interiors_stairs";
   diffuseMap[0] = "./textures/stairs_D.dds";
   normalMap[0] = "./textures/stairs_N.dds";
   specular[0] = "1 1 1 1";
   specularPower[0] = "8";
   translucentBlendOp = "LerpAlpha";
   materialTag0 = "BuildingStructures";   
   diffuseColor[0] = "1 1 1 1";
   constantCubemapGloss = "0.2";
};

singleton Material(interiors_floor_001_mat)
{
   mapTo = "interiors_floor_001";
   diffuseMap[0] = "./textures/tiles_001_D.dds";
   constantCubemapGloss = "0.2";
   normalMap[0] = "./textures/tiles_001_N.dds";
   materialTag0 = "BuildingStructures";   
   specularMap[0] = "./textures/tiles_001_S.dds";
};

singleton Material(interiors_floor_002_mat)
{
   mapTo = "interiors_floor_002";
   diffuseMap[0] = "./textures/tiles_002_D.dds";
   constantCubemapGloss = "0.2";
   normalMap[0] = "./textures/tiles_002_N.dds";
   specularMap[0] = "./textures/tiles_002_S.dds";
   materialTag0 = "BuildingStructures";   
};

singleton Material(interiors_floor_003_mat)
{
   mapTo = "interiors_floor_003";
   diffuseMap[0] = "./textures/WoodenFloor_D";
   normalMap[0] = "./textures/WoodenFloor_N.dds";
   specularMap[0] = "./textures/WoodenFloor_S.dds";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";
};

singleton Material(interiors_confloor_001_mat)
{
   mapTo = "interiors_confloor_001";
   diffuseMap[0] = "./textures/conFloor_001_D.dds";
   constantCubemapGloss = "0.2";
   normalMap[0] = "./textures/conFloor_001_N.dds";
   materialTag0 = "BuildingStructures";   
};

singleton Material(interiors_ceiling_001_mat)
{
   mapTo = "interiors_ceiling_001";
   diffuseMap[0] = "./textures/ceiling_001_D.dds";
   constantCubemapGloss = "0.2";
   specularMap[0] = "";
   materialTag0 = "BuildingStructures";   
};

singleton Material(interiors_ceiling_002_mat)
{
   mapTo = "interiors_ceiling_002";
   diffuseMap[0] = "./textures/ceiling_002_D.dds";
   constantCubemapGloss = "0.2";
   normalMap[0] = "";
   specularMap[0] = "";
   materialTag0 = "BuildingStructures";   
};

singleton Material(interior_light_fixture_mat)
{
   mapTo = "interior_light_fixture";
   diffuseMap[0] = "./textures/lights_D.dds";
   constantCubemapGloss = "0.2";
   normalMap[0] = "./textures/lights_N.dds";
   specularMap[0] = "./textures/lights_S.dds";
   materialTag0 = "BuildingStructures";   
};

singleton Material(interior_light_fixture_mat)
{
   mapTo = "interior_light_fixture";
   diffuseMap[0] = "./textures/lights_D.dds";
   constantCubemapGloss = "0.2";
   normalMap[0] = "./textures/lights_N.dds";
   specularMap[0] = "./textures/lights_S.dds";
   materialTag0 = "BuildingStructures";   
};

singleton Material(interior_light_fixture_mat)
{
   mapTo = "interior_light_fixture";
   diffuseMap[0] = "textures/lights_D.dds";
   constantCubemapGloss = "0.2";
   normalMap[0] = "textures/lights_N.dds";
   specularMap[0] = "textures/lights_S.dds";
   materialTag0 = "BuildingStructures";   
};

singleton Material(concreteBorders_mat)
{
   mapTo = "concreteBorders";
   diffuseMap[0] = "./textures/concreteborders_D.dds";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   normalMap[0] = "./textures/concreteborders_N.dds";
   specularMap[0] = "./textures/concreteborders_S.dds";
   materialTag0 = "BuildingStructures";
   constantCubemapGloss = "0.2";
};






























singleton Material(building_002_LOD_mat)
{
   mapTo = "building_002_LOD";
   diffuseMap[0] = "./textures/building_006_LOD_D.dds";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";
};

singleton Material(building_003_LOD_mat)
{
   mapTo = "building_003_LOD";
   diffuseMap[0] = "./textures/building_003_LOD_D";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";
};

singleton Material(building_004_LOD_mat)
{
   mapTo = "building_004_LOD";
   diffuseMap[0] = "./textures/_015_buildingLOD3_albedo";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";
};

singleton Material(building_005_LOD_mat)
{
   mapTo = "building_005_LOD";
   diffuseMap[0] = "./textures/_023_buildingLOD3_albedo";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";
};

singleton Material(building_006_LOD_mat)
{
   mapTo = "building_006_LOD";
   diffuseMap[0] = "./textures/_027_buildingLOD3_albedo";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";
};

singleton Material(building_007_LOD_mat)
{
   mapTo = "building_007_LOD";
   diffuseMap[0] = "./textures/_028_buildingLOD3_albedo";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";
};

singleton Material(interiors_intWall_004_mat)
{
   mapTo = "interiors_intWall_004";
   diffuseMap[0] = "./textures/brick_004_D";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";
};

singleton Material(building_008_LOD_mat)
{
   mapTo = "building_008_LOD";
   diffuseMap[0] = "./textures/_032_buildingLOD3_albedo";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";
};

singleton Material(building_009_LOD_mat)
{
   mapTo = "building_009_LOD";
   diffuseMap[0] = "./textures/_034_buildingLOD3_albedo";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";
};

singleton Material(building_010_LOD_mat)
{
   mapTo = "building_010_LOD";
   diffuseMap[0] = "./textures/_034_buildingLOD3_albedo";
   specularPower[0] = "50";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";
};

singleton Material(Sidewalk_10meters_ground_pavement)
{
   mapTo = "ground_pavement";
   diffuseMap[0] = "./textures/pavement_D.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "33.2193";
   translucentBlendOp = "None";
   normalMap[0] = "./textures/pavement_N.dds";
   specularMap[0] = "./textures/pavement_S.dds";
   materialTag0 = "BuildingStructures";
};

singleton Material(Sidewalk_10meters_ground_pavement_edge)
{
   mapTo = "ground_pavement_edge";
   diffuseMap[0] = "./textures/pavement_edge_D.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "33.2193";
   translucentBlendOp = "None";
   materialTag0 = "BuildingStructures";
   normalMap[0] = "./textures/pavement_edge_N.dds";
   specularMap[0] = "./textures/pavement_edge_S.DDS";
};
