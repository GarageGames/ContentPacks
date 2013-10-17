//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton CubemapData( refnightSkyCubemap )
{
   cubeFace[0] = "./ref_night_skybox_1";
   cubeFace[1] = "./ref_night_skybox_2";
   cubeFace[2] = "./ref_night_skybox_3";
   cubeFace[3] = "./ref_night_skybox_4";
   cubeFace[4] = "./ref_night_skybox_5";
   cubeFace[5] = "./ref_night_skybox_6";
};

singleton Material( refnightSkyMat )
{
   cubemap = refnightSkyCubemap;
};
