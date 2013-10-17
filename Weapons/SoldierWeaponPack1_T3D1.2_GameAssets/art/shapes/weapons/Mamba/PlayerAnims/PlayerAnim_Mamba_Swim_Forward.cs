singleton TSShapeConstructor(PlayerAnim_Mamba_Swim_ForwardDAE)
{
   baseShape = "./PlayerAnim_Mamba_Swim_Forward.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_Swim_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Forward", "1490", "1549");
}
