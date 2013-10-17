singleton TSShapeConstructor(PlayerAnim_Ender_HeadDAE)
{
   baseShape = "./PlayerAnim_Ender_Head.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Ender_HeadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Head", "860", "870");
}
