singleton TSShapeConstructor(PlayerAnim_Mamba_BackDAE)
{
   baseShape = "./PlayerAnim_Mamba_Back.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Back", "250", "269");
}
