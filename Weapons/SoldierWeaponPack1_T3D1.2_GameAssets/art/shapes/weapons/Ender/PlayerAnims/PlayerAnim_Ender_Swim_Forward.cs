singleton TSShapeConstructor(PlayerAnim_Ender_Swim_ForwardDAE)
{
   baseShape = "./PlayerAnim_Ender_Swim_Forward.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_Swim_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Forward", "1360", "1419");
}
