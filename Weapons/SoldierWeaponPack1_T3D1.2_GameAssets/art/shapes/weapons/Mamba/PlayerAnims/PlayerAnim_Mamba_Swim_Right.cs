singleton TSShapeConstructor(PlayerAnim_Mamba_Swim_RightDAE)
{
   baseShape = "./PlayerAnim_Mamba_Swim_Right.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_Swim_RightDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Right", "1760", "1820");
}
