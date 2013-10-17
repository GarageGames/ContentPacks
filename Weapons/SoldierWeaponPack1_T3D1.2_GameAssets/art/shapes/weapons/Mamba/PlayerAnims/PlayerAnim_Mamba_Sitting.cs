singleton TSShapeConstructor(PlayerAnim_Mamba_SittingDAE)
{
   baseShape = "./PlayerAnim_Mamba_Sitting.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_SittingDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Sitting", "1360", "1365");
}
