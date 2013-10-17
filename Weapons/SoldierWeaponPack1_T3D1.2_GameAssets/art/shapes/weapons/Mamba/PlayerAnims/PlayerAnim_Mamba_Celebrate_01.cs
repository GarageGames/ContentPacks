singleton TSShapeConstructor(PlayerAnim_Mamba_Celebrate_01DAE)
{
   baseShape = "./PlayerAnim_Mamba_Celebrate_01.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_Celebrate_01DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Celebrate_01", "2020", "2090");
}
