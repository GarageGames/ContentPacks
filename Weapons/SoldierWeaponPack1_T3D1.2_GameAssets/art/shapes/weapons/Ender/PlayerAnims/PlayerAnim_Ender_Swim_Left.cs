singleton TSShapeConstructor(PlayerAnim_Ender_Swim_LeftDAE)
{
   baseShape = "./PlayerAnim_Ender_Swim_Left.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_Swim_LeftDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Left", "1540", "1599");
}
