singleton TSShapeConstructor(PlayerAnim_Mamba_Death3DAE)
{
   baseShape = "./PlayerAnim_Mamba_Death3.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_Death3DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Death3", "1280", "1320");
}
