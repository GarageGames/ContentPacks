singleton TSShapeConstructor(PlayerAnim_Mamba_LookDAE)
{
   baseShape = "./PlayerAnim_Mamba_Look.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_LookDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Look", "950", "960");
}
