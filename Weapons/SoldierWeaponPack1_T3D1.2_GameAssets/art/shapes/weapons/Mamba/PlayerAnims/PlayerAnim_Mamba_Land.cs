singleton TSShapeConstructor(PlayerAnim_Mamba_LandDAE)
{
   baseShape = "./PlayerAnim_Mamba_Land.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_LandDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Land", "1100", "1110");
}
