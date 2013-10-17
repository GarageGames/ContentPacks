singleton TSShapeConstructor(PlayerAnim_Mamba_Swim_BackDAE)
{
   baseShape = "./PlayerAnim_Mamba_Swim_Back.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_Swim_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Back", "1580", "1639");
}
