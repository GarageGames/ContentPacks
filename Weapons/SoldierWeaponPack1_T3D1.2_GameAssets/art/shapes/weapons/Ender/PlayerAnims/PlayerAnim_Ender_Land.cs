singleton TSShapeConstructor(PlayerAnim_Ender_LandDAE)
{
   baseShape = "./PlayerAnim_Ender_Land.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_LandDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Land", "1005", "1020");
}
