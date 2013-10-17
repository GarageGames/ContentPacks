singleton TSShapeConstructor(PlayerAnim_Mamba_RootDAE)
{
   baseShape = "./PlayerAnim_Mamba_Root.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Root", "50", "109");
}
