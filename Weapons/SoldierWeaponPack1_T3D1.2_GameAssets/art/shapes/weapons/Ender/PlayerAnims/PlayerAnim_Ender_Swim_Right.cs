singleton TSShapeConstructor(PlayerAnim_Ender_Swim_RightDAE)
{
   baseShape = "./PlayerAnim_Ender_Swim_Right.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_Swim_RightDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Right", "1630", "1689");
}
