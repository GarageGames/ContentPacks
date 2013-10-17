singleton TSShapeConstructor(PlayerAnim_Mamba_Swim_LeftDAE)
{
   baseShape = "./PlayerAnim_Mamba_Swim_Left.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_Swim_LeftDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Left", "1670", "1729");
}
